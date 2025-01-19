namespace Dergi_Gazete_Abonelik
{
    partial class Yonetici_Girisi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnGirisYap = new Button();
            label2 = new Label();
            label1 = new Label();
            TxtSifre = new TextBox();
            TxtPersonelAdi = new TextBox();
            BtnGeri = new Button();
            LblKapat = new Label();
            SuspendLayout();
            // 
            // BtnGirisYap
            // 
            BtnGirisYap.BackColor = Color.Transparent;
            BtnGirisYap.Location = new Point(217, 209);
            BtnGirisYap.Name = "BtnGirisYap";
            BtnGirisYap.Size = new Size(208, 38);
            BtnGirisYap.TabIndex = 11;
            BtnGirisYap.Text = "Giriş Yap";
            BtnGirisYap.UseVisualStyleBackColor = false;
            BtnGirisYap.Click += BtnGirisYap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 165);
            label2.Name = "label2";
            label2.Size = new Size(58, 24);
            label2.TabIndex = 10;
            label2.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 110);
            label1.Name = "label1";
            label1.Size = new Size(129, 24);
            label1.TabIndex = 9;
            label1.Text = "Personel Adı:";
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(217, 159);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(208, 30);
            TxtSifre.TabIndex = 8;
            TxtSifre.UseSystemPasswordChar = true;
            TxtSifre.KeyDown += TxtSifre_KeyDown;
            // 
            // TxtPersonelAdi
            // 
            TxtPersonelAdi.Location = new Point(217, 107);
            TxtPersonelAdi.Name = "TxtPersonelAdi";
            TxtPersonelAdi.Size = new Size(208, 30);
            TxtPersonelAdi.TabIndex = 7;
            // 
            // BtnGeri
            // 
            BtnGeri.Location = new Point(12, 12);
            BtnGeri.Name = "BtnGeri";
            BtnGeri.Size = new Size(87, 31);
            BtnGeri.TabIndex = 12;
            BtnGeri.Text = "Geri";
            BtnGeri.UseVisualStyleBackColor = true;
            BtnGeri.Click += BtnGeri_Click;
            // 
            // LblKapat
            // 
            LblKapat.AutoSize = true;
            LblKapat.Location = new Point(530, 9);
            LblKapat.Name = "LblKapat";
            LblKapat.Size = new Size(24, 24);
            LblKapat.TabIndex = 23;
            LblKapat.Text = "X";
            LblKapat.Click += LblKapat_Click;
            // 
            // Yonetici_Girisi
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(566, 348);
            Controls.Add(LblKapat);
            Controls.Add(BtnGeri);
            Controls.Add(BtnGirisYap);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtSifre);
            Controls.Add(TxtPersonelAdi);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Yonetici_Girisi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yonetici_Girisi";
            Load += Yonetici_Girisi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGirisYap;
        private Label label2;
        private Label label1;
        private TextBox TxtSifre;
        private TextBox TxtPersonelAdi;
        private Button BtnGeri;
        private Label LblKapat;
    }
}