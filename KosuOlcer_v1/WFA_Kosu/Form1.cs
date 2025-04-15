using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WFA_Kosu
{
    public partial class Form1 : Form
    {
        decimal ortAdim = 0;
        decimal kacAdim = 0;
        decimal saat = 0;
        decimal dakika;

        private List<decimal> KosuData = new List<decimal>();
        private List<decimal> KosuHizlari = new List<decimal>();
        private List<decimal> KosuMesafeleri = new List<decimal>();



        public Form1()
        {
            InitializeComponent();
            HosgeldinMesaji();// Bu metot, Form1_Load içindeki karişikligi onlemek amaciyla olusturuldu.
        }



        ////Metodun amaci,kullaniciya karsilama mesaji ve uygulamanın amacını vermek.
        private void HosgeldinMesaji()
        {
            MessageBox.Show("KosuOlcer Uygulamasına Hosgeldiniz");
            MessageBox.Show("Uygulamamızın amacı manuel girilen bilgiler ile kosu mesafemizi ölçmek.");
        }





        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (TryGetInput(out decimal ortAdim, out decimal kacAdim, out decimal saat, out decimal dakika))
                {
                    decimal kosuHiziKmPerHour = HesaplaKosuHizi(ortAdim, kacAdim, saat, dakika) * 60 / 1000;
                    KosuHizlari.Add(kosuHiziKmPerHour);


                    decimal toplamMesafe = HesaplaToplamMesafe(ortAdim, kacAdim);
                    KosuMesafeleri.Add(toplamMesafe);

                    UpdateListBox();
                    UpdateTotalDistanceListBox();

                    MessageBox.Show($"Hız (km/saat): {kosuHiziKmPerHour} km/h\nToplam Mesafe: {toplamMesafe} km", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Format hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Aşım hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Bu metod ile ListBox'ı günceller.

        private void UpdateListBox()
        {
            lstBox.Items.Clear();

            foreach (var hiz in KosuHizlari)
            {
                lstBox.Items.Add($"{hiz} km/saat");
            }
        }

        // Bu metod ile ListBox'ı günceller.
        private void UpdateTotalDistanceListBox()
        {
            lstBoxTotalDistance.Items.Clear();

            foreach (var mesafe in KosuMesafeleri)
            {
                lstBoxTotalDistance.Items.Add($"{mesafe / 1000} km"); // Burada km 


            }
        }

        private bool TryGetInput(out decimal ortAdim, out decimal kacAdim, out decimal saat, out decimal dakika)
        {
            ortAdim = 0;
            kacAdim = 0;
            saat = 0;
            dakika = 0;
            List<string> errors = new List<string>();

            // Ortalama adım değerinin geçerliliğini kontrol et.
            if (!decimal.TryParse(txtOrtAdim.Text, out ortAdim) || ortAdim < 30 || ortAdim > 100)
                errors.Add("Ortalama adım değerini 30 cm ile 100 cm arasında geçerli bir sayı olarak girin.");

            // Adım sayısının geçerliliğini kontrol et.
            if (!decimal.TryParse(txtOrtAdimSayisi.Text, out kacAdim) || kacAdim < 1 || kacAdim > 50000)
                errors.Add("Adım sayısını geçerli bir sayı olarak girin.");

            // Saat değerinin geçerliliğini kontrol et.
            if (!decimal.TryParse(txtSaat.Text, out saat) || saat < 0)
                errors.Add("Saat değerini geçerli bir sayı olarak girin.");

            // Dakika değerinin geçerliliğini kontrol et.
            if (!decimal.TryParse(txtDakika.Text, out dakika) || dakika < 0 || dakika >= 60)
                errors.Add("Dakika değerini geçerli bir sayı olarak girin.");

            // Hata varsa, tüm hataları göster ve false döndür.
            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errors), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Tüm girdiler geçerliyse true döndür.
            return true;
        }


        //Bu metot, ORtalama hızı verir
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                if (KosuHizlari.Count > 0)
                {
                    // Calculate the average speed
                    decimal ortHız = KosuHizlari.Average();
                    MessageBox.Show($"Ortalama Hız: {ortHız} km/saat", "Ortalama Hız", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Henüz hız eklenmedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Kosu hızını hesaplayacak metod
        private decimal HesaplaKosuHizi(decimal ortAdim, decimal kacAdim, decimal saat, decimal dakika)
        {
            // Metre cinsinden toplam mesafe hesaplama.
            decimal toplamMesafe = (ortAdim / 100) * kacAdim;
            // Toplam dakikayı hesaplama.
            decimal toplamDakika = ConvertToMinutes(saat, dakika);


            if (toplamDakika == 0)
            {
                // Geçerli bir süre girilmediği için hız hesaplanamıyor.
                MessageBox.Show("Geçerli bir süre girilmediği için hız hesaplanamıyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            // Hız hesaplama (metre/dakika).
            decimal kosuHizi = toplamMesafe / toplamDakika;

            return Math.Round(kosuHizi, 3);  // Hesaplanan hızı döndür.
        }

        // Kosu mesafe hesaplayacak metod
        private decimal HesaplaToplamMesafe(decimal ortAdim, decimal kacAdim)
        {
            // Total km
            return (ortAdim / 100) * kacAdim;
        }

        // Bu metot, DAkikaya cevirir.
        private decimal ConvertToMinutes(decimal hours, decimal minutes)
        {
            return (hours * 60) + minutes;
        }


        //Bu metot, Çıkış butonuna tıklanıldığında çalışır.
        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            // Uygulamadan çıkış onayı iste.
            DialogResult result = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Uygulamayı kapat.
            }
        }

        //Bu metot, Tümünü temizler.
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtOrtAdim.Clear();
            txtOrtAdimSayisi.Clear();
            txtSaat.Clear();
            txtDakika.Clear();
            lstBox.Items.Clear();
            KosuHizlari.Clear();
        }




    }
}
