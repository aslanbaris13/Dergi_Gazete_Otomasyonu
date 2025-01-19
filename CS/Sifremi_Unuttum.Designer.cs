namespace Dergi_Gazete_Abonelik
{
    partial class Sifremi_Unuttum
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
            txtmail = new TextBox();
            btnmailgonder = new Button();
            label1 = new Label();
            BtnGeri = new Button();
            LblKapat = new Label();
            SuspendLayout();
            // 
            // txtmail
            // 
            txtmail.Location = new Point(252, 100);
            txtmail.Name = "txtmail";
            txtmail.Size = new Size(259, 30);
            txtmail.TabIndex = 0;
            txtmail.KeyDown += txtmail_KeyDown;
            // 
            // btnmailgonder
            // 
            btnmailgonder.Location = new Point(336, 146);
            btnmailgonder.Name = "btnmailgonder";
            btnmailgonder.Size = new Size(175, 38);
            btnmailgonder.TabIndex = 1;
            btnmailgonder.Text = "Mail Gönder";
            btnmailgonder.UseVisualStyleBackColor = true;
            btnmailgonder.Click += btnmailgonder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 100);
            label1.Name = "label1";
            label1.Size = new Size(219, 24);
            label1.TabIndex = 2;
            label1.Text = "Mail Adresinizi Giriniz:";
            // 
            // BtnGeri
            // 
            BtnGeri.Location = new Point(12, 12);
            BtnGeri.Name = "BtnGeri";
            BtnGeri.Size = new Size(94, 29);
            BtnGeri.TabIndex = 21;
            BtnGeri.Text = "Geri";
            BtnGeri.UseVisualStyleBackColor = true;
            BtnGeri.Click += BtnGeri_Click;
            // 
            // LblKapat
            // 
            LblKapat.AutoSize = true;
            LblKapat.Location = new Point(523, 9);
            LblKapat.Name = "LblKapat";
            LblKapat.Size = new Size(24, 24);
            LblKapat.TabIndex = 22;
            LblKapat.Text = "X";
            LblKapat.Click += LblKapat_Click;
            // 
            // Sifremi_Unuttum
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(559, 253);
            Controls.Add(LblKapat);
            Controls.Add(BtnGeri);
            Controls.Add(label1);
            Controls.Add(btnmailgonder);
            Controls.Add(txtmail);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Sifremi_Unuttum";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sifremi_Unuttum";
            Load += Sifremi_Unuttum_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtmail;
        private Button btnmailgonder;
        private Label label1;
        public Button BtnGeri;
        private Label LblKapat;
    }
}