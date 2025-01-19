namespace Dergi_Gazete_Abonelik
{
    partial class Uye_Ol
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
            TxtSoyad = new TextBox();
            TxtSifre = new TextBox();
            TxtMail = new TextBox();
            TxtAdres = new TextBox();
            MskTel = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            BtnUyeOl = new Button();
            LblKapat = new Label();
            BtnGeri = new Button();
            SuspendLayout();
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(182, 80);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(208, 30);
            TxtAd.TabIndex = 1;
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(182, 128);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(208, 30);
            TxtSoyad.TabIndex = 2;
            TxtSoyad.TextChanged += TxtSoyad_TextChanged;
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(182, 179);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(208, 30);
            TxtSifre.TabIndex = 3;
            // 
            // TxtMail
            // 
            TxtMail.Location = new Point(182, 278);
            TxtMail.Name = "TxtMail";
            TxtMail.Size = new Size(208, 30);
            TxtMail.TabIndex = 5;
            // 
            // TxtAdres
            // 
            TxtAdres.Location = new Point(182, 327);
            TxtAdres.Name = "TxtAdres";
            TxtAdres.Size = new Size(208, 30);
            TxtAdres.TabIndex = 6;
            // 
            // MskTel
            // 
            MskTel.Location = new Point(182, 228);
            MskTel.Mask = "(999) 000-0000";
            MskTel.Name = "MskTel";
            MskTel.Size = new Size(208, 30);
            MskTel.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 80);
            label2.Name = "label2";
            label2.Size = new Size(40, 24);
            label2.TabIndex = 8;
            label2.Text = "Ad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 134);
            label1.Name = "label1";
            label1.Size = new Size(69, 24);
            label1.TabIndex = 9;
            label1.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 185);
            label3.Name = "label3";
            label3.Size = new Size(58, 24);
            label3.TabIndex = 10;
            label3.Text = "Şifre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 333);
            label4.Name = "label4";
            label4.Size = new Size(67, 24);
            label4.TabIndex = 11;
            label4.Text = "Adres:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 278);
            label5.Name = "label5";
            label5.Size = new Size(57, 24);
            label5.TabIndex = 12;
            label5.Text = "Mail:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 234);
            label6.Name = "label6";
            label6.Size = new Size(115, 24);
            label6.TabIndex = 13;
            label6.Text = "Telefon No:";
            // 
            // BtnUyeOl
            // 
            BtnUyeOl.BackColor = Color.Transparent;
            BtnUyeOl.Location = new Point(261, 380);
            BtnUyeOl.Name = "BtnUyeOl";
            BtnUyeOl.Size = new Size(129, 42);
            BtnUyeOl.TabIndex = 14;
            BtnUyeOl.Text = "Üye Ol";
            BtnUyeOl.UseVisualStyleBackColor = false;
            BtnUyeOl.Click += BtnUyeOl_Click;
            // 
            // LblKapat
            // 
            LblKapat.AutoSize = true;
            LblKapat.Location = new Point(426, 19);
            LblKapat.Name = "LblKapat";
            LblKapat.Size = new Size(24, 24);
            LblKapat.TabIndex = 15;
            LblKapat.Text = "X";
            LblKapat.Click += LblKapat_Click;
            // 
            // BtnGeri
            // 
            BtnGeri.Location = new Point(12, 12);
            BtnGeri.Name = "BtnGeri";
            BtnGeri.Size = new Size(94, 29);
            BtnGeri.TabIndex = 16;
            BtnGeri.Text = "Geri";
            BtnGeri.UseVisualStyleBackColor = true;
            BtnGeri.Click += BtnGeri_Click;
            // 
            // Uye_Ol
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(476, 469);
            Controls.Add(BtnGeri);
            Controls.Add(LblKapat);
            Controls.Add(BtnUyeOl);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(MskTel);
            Controls.Add(TxtAdres);
            Controls.Add(TxtMail);
            Controls.Add(TxtSifre);
            Controls.Add(TxtSoyad);
            Controls.Add(TxtAd);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Uye_Ol";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Uye_Ol";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtAd;
        private TextBox TxtSoyad;
        private TextBox TxtSifre;
        private TextBox TxtMail;
        private TextBox TxtAdres;
        private MaskedTextBox MskTel;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button BtnUyeOl;
        private Label LblKapat;
        public Button BtnGeri;
    }
}