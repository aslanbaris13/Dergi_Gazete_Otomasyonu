namespace Dergi_Gazete_Abonelik
{
    partial class Yonetici_Personel_Islemleri
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
            TxtpersonelID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxtPersonelAdı = new TextBox();
            label3 = new Label();
            TxtPersonelSifre = new TextBox();
            btnpersonelekle = new Button();
            btnpersonelguncelle = new Button();
            btnpersonelsil = new Button();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            LblKapat = new Label();
            BtnGeri = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // TxtpersonelID
            // 
            TxtpersonelID.Enabled = false;
            TxtpersonelID.Location = new Point(149, 73);
            TxtpersonelID.Name = "TxtpersonelID";
            TxtpersonelID.Size = new Size(195, 30);
            TxtpersonelID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 79);
            label1.Name = "label1";
            label1.Size = new Size(122, 24);
            label1.TabIndex = 1;
            label1.Text = "Personel ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 121);
            label2.Name = "label2";
            label2.Size = new Size(129, 24);
            label2.TabIndex = 3;
            label2.Text = "Personel Adı:";
            // 
            // TxtPersonelAdı
            // 
            TxtPersonelAdı.Location = new Point(149, 115);
            TxtPersonelAdı.Name = "TxtPersonelAdı";
            TxtPersonelAdı.Size = new Size(195, 30);
            TxtPersonelAdı.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 161);
            label3.Name = "label3";
            label3.Size = new Size(141, 24);
            label3.TabIndex = 5;
            label3.Text = "Personel Sifre:";
            // 
            // TxtPersonelSifre
            // 
            TxtPersonelSifre.Location = new Point(149, 158);
            TxtPersonelSifre.Name = "TxtPersonelSifre";
            TxtPersonelSifre.Size = new Size(195, 30);
            TxtPersonelSifre.TabIndex = 4;
            // 
            // btnpersonelekle
            // 
            btnpersonelekle.Location = new Point(79, 251);
            btnpersonelekle.Name = "btnpersonelekle";
            btnpersonelekle.Size = new Size(265, 43);
            btnpersonelekle.TabIndex = 10;
            btnpersonelekle.Text = "Personel Ekle";
            btnpersonelekle.UseVisualStyleBackColor = true;
            btnpersonelekle.Click += btnpersonelekle_Click;
            // 
            // btnpersonelguncelle
            // 
            btnpersonelguncelle.Location = new Point(79, 349);
            btnpersonelguncelle.Name = "btnpersonelguncelle";
            btnpersonelguncelle.Size = new Size(265, 43);
            btnpersonelguncelle.TabIndex = 11;
            btnpersonelguncelle.Text = "Personel Güncelle";
            btnpersonelguncelle.UseVisualStyleBackColor = true;
            btnpersonelguncelle.Click += btnpersonelguncelle_Click;
            // 
            // btnpersonelsil
            // 
            btnpersonelsil.Location = new Point(79, 300);
            btnpersonelsil.Name = "btnpersonelsil";
            btnpersonelsil.Size = new Size(265, 43);
            btnpersonelsil.TabIndex = 12;
            btnpersonelsil.Text = "Personel Sil";
            btnpersonelsil.UseVisualStyleBackColor = true;
            btnpersonelsil.Click += btnpersonelsil_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(392, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(620, 462);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(614, 433);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // LblKapat
            // 
            LblKapat.AutoSize = true;
            LblKapat.Location = new Point(997, 7);
            LblKapat.Name = "LblKapat";
            LblKapat.Size = new Size(24, 24);
            LblKapat.TabIndex = 24;
            LblKapat.Text = "X";
            LblKapat.Click += LblKapat_Click;
            // 
            // BtnGeri
            // 
            BtnGeri.Location = new Point(10, 7);
            BtnGeri.Name = "BtnGeri";
            BtnGeri.Size = new Size(94, 29);
            BtnGeri.TabIndex = 25;
            BtnGeri.Text = "Geri";
            BtnGeri.UseVisualStyleBackColor = true;
            BtnGeri.Click += BtnGeri_Click;
            // 
            // button1
            // 
            button1.Location = new Point(79, 202);
            button1.Name = "button1";
            button1.Size = new Size(265, 43);
            button1.TabIndex = 26;
            button1.Text = "Tüm Personeller";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtpersonelID);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(TxtPersonelAdı);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(TxtPersonelSifre);
            groupBox2.Controls.Add(btnpersonelsil);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnpersonelguncelle);
            groupBox2.Controls.Add(btnpersonelekle);
            groupBox2.Location = new Point(12, 75);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(355, 462);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personel Bilgileri";
            // 
            // Yonetici_Personel_Islemleri
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1033, 558);
            Controls.Add(groupBox2);
            Controls.Add(BtnGeri);
            Controls.Add(LblKapat);
            Controls.Add(groupBox1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Yonetici_Personel_Islemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yonetici_Personel_Islemleri";
            Load += Yonetici_Personel_Islemleri_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtpersonelID;
        private Label label1;
        private Label label2;
        private TextBox TxtPersonelAdı;
        private Label label3;
        private TextBox TxtPersonelSifre;
        private Button btnpersonelekle;
        private Button btnpersonelguncelle;
        private Button btnpersonelsil;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label LblKapat;
        public Button BtnGeri;
        private Button button1;
        private GroupBox groupBox2;
    }
}