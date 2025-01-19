namespace Dergi_Gazete_Abonelik
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            BtnYonetici = new Button();
            BtnKullanici = new Button();
            label1 = new Label();
            label2 = new Label();
            LblKapat = new Label();
            SuspendLayout();
            // 
            // BtnYonetici
            // 
            BtnYonetici.BackgroundImage = (Image)resources.GetObject("BtnYonetici.BackgroundImage");
            BtnYonetici.BackgroundImageLayout = ImageLayout.Stretch;
            BtnYonetici.Location = new Point(94, 99);
            BtnYonetici.Name = "BtnYonetici";
            BtnYonetici.Size = new Size(145, 113);
            BtnYonetici.TabIndex = 0;
            BtnYonetici.UseVisualStyleBackColor = true;
            BtnYonetici.Click += BtnYonetici_Click;
            // 
            // BtnKullanici
            // 
            BtnKullanici.BackgroundImage = (Image)resources.GetObject("BtnKullanici.BackgroundImage");
            BtnKullanici.BackgroundImageLayout = ImageLayout.Stretch;
            BtnKullanici.Location = new Point(319, 99);
            BtnKullanici.Name = "BtnKullanici";
            BtnKullanici.Size = new Size(145, 113);
            BtnKullanici.TabIndex = 1;
            BtnKullanici.UseVisualStyleBackColor = true;
            BtnKullanici.Click += BtnKullanici_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(319, 254);
            label1.Name = "label1";
            label1.Size = new Size(146, 24);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Girişi";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 254);
            label2.Name = "label2";
            label2.Size = new Size(138, 24);
            label2.TabIndex = 3;
            label2.Text = "Yönetici Girişi";
            // 
            // LblKapat
            // 
            LblKapat.AutoSize = true;
            LblKapat.Location = new Point(530, 9);
            LblKapat.Name = "LblKapat";
            LblKapat.Size = new Size(24, 24);
            LblKapat.TabIndex = 21;
            LblKapat.Text = "X";
            LblKapat.Click += LblKapat_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(566, 348);
            Controls.Add(LblKapat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnKullanici);
            Controls.Add(BtnYonetici);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Login";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnYonetici;
        private Button BtnKullanici;
        private Label label1;
        private Label label2;
        private Label LblKapat;
    }
}