namespace Dergi_Gazete_Abonelik
{
    partial class Kullanici_Girisi
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
            TxtAd = new TextBox();
            TxtSifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BtnGirisYap = new Button();
            button2 = new Button();
            button3 = new Button();
            BtnGeri = new Button();
            LblKapat = new Label();
            SuspendLayout();
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(194, 81);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(208, 30);
            TxtAd.TabIndex = 0;
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(194, 133);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(208, 30);
            TxtSifre.TabIndex = 1;
            TxtSifre.UseSystemPasswordChar = true;
            TxtSifre.KeyDown += TxtSifre_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 87);
            label1.Name = "label1";
            label1.Size = new Size(40, 24);
            label1.TabIndex = 2;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 139);
            label2.Name = "label2";
            label2.Size = new Size(58, 24);
            label2.TabIndex = 3;
            label2.Text = "Şifre:";
            // 
            // BtnGirisYap
            // 
            BtnGirisYap.BackColor = Color.Transparent;
            BtnGirisYap.Location = new Point(194, 187);
            BtnGirisYap.Name = "BtnGirisYap";
            BtnGirisYap.Size = new Size(209, 38);
            BtnGirisYap.TabIndex = 4;
            BtnGirisYap.Text = "Giriş Yap";
            BtnGirisYap.UseVisualStyleBackColor = false;
            BtnGirisYap.Click += BtnGirisYap_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Location = new Point(193, 231);
            button2.Name = "button2";
            button2.Size = new Size(209, 38);
            button2.TabIndex = 5;
            button2.Text = "Üye Ol";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Location = new Point(193, 275);
            button3.Name = "button3";
            button3.Size = new Size(209, 38);
            button3.TabIndex = 6;
            button3.Text = "Şifremi Unuttum?";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // BtnGeri
            // 
            BtnGeri.Location = new Point(12, 12);
            BtnGeri.Name = "BtnGeri";
            BtnGeri.Size = new Size(87, 31);
            BtnGeri.TabIndex = 7;
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
            LblKapat.TabIndex = 20;
            LblKapat.Text = "X";
            LblKapat.Click += LblKapat_Click;
            // 
            // Kullanici_Girisi
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(566, 348);
            Controls.Add(LblKapat);
            Controls.Add(BtnGeri);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(BtnGirisYap);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtSifre);
            Controls.Add(TxtAd);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Kullanici_Girisi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanici_Girisi";
            Load += Kullanici_Girisi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtAd;
        private TextBox TxtSifre;
        private Label label1;
        private Label label2;
        private Button BtnGirisYap;
        private Button button2;
        private Button button3;
        private Button BtnGeri;
        private Label LblKapat;
    }
}