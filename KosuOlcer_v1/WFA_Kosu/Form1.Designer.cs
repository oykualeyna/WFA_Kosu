namespace WFA_Kosu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnEkle = new Button();
            btnHesapla = new Button();
            btnCıkıs = new Button();
            txtOrtAdim = new TextBox();
            txtOrtAdimSayisi = new TextBox();
            txtSaat = new TextBox();
            txtDakika = new TextBox();
            lstBox = new ListBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnTemizle = new Button();
            label7 = new Label();
            lstBoxTotalDistance = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(128, 64, 64);
            btnEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEkle.ForeColor = Color.Black;
            btnEkle.Location = new Point(69, 395);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(184, 43);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnHesapla
            // 
            btnHesapla.BackColor = Color.FromArgb(128, 64, 64);
            btnHesapla.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHesapla.Location = new Point(287, 395);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(184, 43);
            btnHesapla.TabIndex = 1;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = false;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // btnCıkıs
            // 
            btnCıkıs.BackColor = SystemColors.ControlDark;
            btnCıkıs.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCıkıs.Location = new Point(528, 395);
            btnCıkıs.Name = "btnCıkıs";
            btnCıkıs.Size = new Size(184, 43);
            btnCıkıs.TabIndex = 2;
            btnCıkıs.Text = "Cıkıs";
            btnCıkıs.UseVisualStyleBackColor = false;
            btnCıkıs.Click += btnCıkıs_Click;
            // 
            // txtOrtAdim
            // 
            txtOrtAdim.BackColor = Color.Snow;
            txtOrtAdim.Location = new Point(74, 213);
            txtOrtAdim.Name = "txtOrtAdim";
            txtOrtAdim.Size = new Size(208, 27);
            txtOrtAdim.TabIndex = 3;
            // 
            // txtOrtAdimSayisi
            // 
            txtOrtAdimSayisi.BackColor = Color.Snow;
            txtOrtAdimSayisi.Location = new Point(74, 283);
            txtOrtAdimSayisi.Name = "txtOrtAdimSayisi";
            txtOrtAdimSayisi.Size = new Size(208, 27);
            txtOrtAdimSayisi.TabIndex = 4;
            // 
            // txtSaat
            // 
            txtSaat.BackColor = Color.Snow;
            txtSaat.Location = new Point(123, 353);
            txtSaat.Name = "txtSaat";
            txtSaat.Size = new Size(95, 27);
            txtSaat.TabIndex = 5;
            // 
            // txtDakika
            // 
            txtDakika.BackColor = Color.Snow;
            txtDakika.Location = new Point(299, 353);
            txtDakika.Name = "txtDakika";
            txtDakika.Size = new Size(95, 27);
            txtDakika.TabIndex = 6;
            // 
            // lstBox
            // 
            lstBox.BackColor = Color.Snow;
            lstBox.FormattingEnabled = true;
            lstBox.Location = new Point(458, 155);
            lstBox.Name = "lstBox";
            lstBox.Size = new Size(148, 184);
            lstBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.Location = new Point(458, 37);
            label1.Name = "label1";
            label1.Size = new Size(319, 68);
            label1.TabIndex = 8;
            label1.Text = "Koşu Ölçer uygulaması, kullanıcıdan alınan verilerle koşu mesafesini hesaplayarak performans takibi yapmanızı sağlar.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(359, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 190);
            label2.Name = "label2";
            label2.Size = new Size(368, 20);
            label2.TabIndex = 10;
            label2.Text = "Ortalama adım uzunluğunuzu giriniz (30-100 cm arası)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 260);
            label3.Name = "label3";
            label3.Size = new Size(251, 20);
            label3.TabIndex = 11;
            label3.Text = "Adım sayısını giriniz. (1-50000 arası) ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 330);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 12;
            label4.Text = "Süre giriniz.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 360);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 13;
            label5.Text = "Saat:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(236, 356);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 14;
            label6.Text = "Dakika:";
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = SystemColors.ControlDark;
            btnTemizle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTemizle.ForeColor = Color.Black;
            btnTemizle.Location = new Point(528, 345);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(184, 43);
            btnTemizle.TabIndex = 15;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(611, 126);
            label7.Name = "label7";
            label7.Size = new Size(166, 20);
            label7.TabIndex = 16;
            label7.Text = "Saglikli gunler dileriz.";
            // 
            // lstBoxTotalDistance
            // 
            lstBoxTotalDistance.FormattingEnabled = true;
            lstBoxTotalDistance.Location = new Point(623, 155);
            lstBoxTotalDistance.Name = "lstBoxTotalDistance";
            lstBoxTotalDistance.Size = new Size(154, 184);
            lstBoxTotalDistance.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(lstBoxTotalDistance);
            Controls.Add(label7);
            Controls.Add(btnTemizle);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(lstBox);
            Controls.Add(txtDakika);
            Controls.Add(txtSaat);
            Controls.Add(txtOrtAdimSayisi);
            Controls.Add(txtOrtAdim);
            Controls.Add(btnCıkıs);
            Controls.Add(btnHesapla);
            Controls.Add(btnEkle);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private Button btnHesapla;
        private Button btnCıkıs;
        private TextBox txtOrtAdim;
        private TextBox txtOrtAdimSayisi;
        private TextBox txtSaat;
        private TextBox txtDakika;
        private ListBox lstBox;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnTemizle;
        private Label label7;
        private ListBox lstBoxTotalDistance;
    }
}
