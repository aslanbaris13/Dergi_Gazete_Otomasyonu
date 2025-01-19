namespace Dergi_Gazete_Abonelik
{
    partial class Yonetici_Abone_İslemleri
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
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            pDFAKTARToolStripMenuItem = new ToolStripMenuItem();
            tümAbonelerToolStripMenuItem = new ToolStripMenuItem();
            güncellenmişAbonelerToolStripMenuItem = new ToolStripMenuItem();
            silinmişAbonelerToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            TxtAboneID = new TextBox();
            TxtAd = new TextBox();
            label2 = new Label();
            label3 = new Label();
            TxtSoyad = new TextBox();
            label4 = new Label();
            TxtAdres = new TextBox();
            label5 = new Label();
            MskTel = new MaskedTextBox();
            label6 = new Label();
            TxtMail = new TextBox();
            label7 = new Label();
            button1 = new Button();
            BtnAboneEkle = new Button();
            BtnAboneGuncelle = new Button();
            BtnAboneSil = new Button();
            LblKapat = new Label();
            BtnGeri = new Button();
            BtnSilinmisAboneler = new Button();
            TxtSifre = new TextBox();
            label8 = new Label();
            BtnGuncellenmisAbone = new Button();
            groupBox2 = new GroupBox();
            LblKayit_Tarihi = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            button6 = new Button();
            button5 = new Button();
            TxtArama = new TextBox();
            button4 = new Button();
            BtnAra = new Button();
            button3 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(menuStrip1);
            groupBox1.Location = new Point(363, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(871, 668);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Aboneler";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(865, 611);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { pDFAKTARToolStripMenuItem });
            menuStrip1.Location = new Point(3, 26);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(865, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // pDFAKTARToolStripMenuItem
            // 
            pDFAKTARToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tümAbonelerToolStripMenuItem, güncellenmişAbonelerToolStripMenuItem, silinmişAbonelerToolStripMenuItem });
            pDFAKTARToolStripMenuItem.Name = "pDFAKTARToolStripMenuItem";
            pDFAKTARToolStripMenuItem.Size = new Size(98, 24);
            pDFAKTARToolStripMenuItem.Text = "PDF AKTAR";
            // 
            // tümAbonelerToolStripMenuItem
            // 
            tümAbonelerToolStripMenuItem.Name = "tümAbonelerToolStripMenuItem";
            tümAbonelerToolStripMenuItem.Size = new Size(245, 26);
            tümAbonelerToolStripMenuItem.Text = "Tüm Aboneler";
            tümAbonelerToolStripMenuItem.Click += tümAbonelerToolStripMenuItem_Click;
            // 
            // güncellenmişAbonelerToolStripMenuItem
            // 
            güncellenmişAbonelerToolStripMenuItem.Name = "güncellenmişAbonelerToolStripMenuItem";
            güncellenmişAbonelerToolStripMenuItem.Size = new Size(245, 26);
            güncellenmişAbonelerToolStripMenuItem.Text = "Güncellenmiş Aboneler";
            güncellenmişAbonelerToolStripMenuItem.Click += güncellenmişAbonelerToolStripMenuItem_Click;
            // 
            // silinmişAbonelerToolStripMenuItem
            // 
            silinmişAbonelerToolStripMenuItem.Name = "silinmişAbonelerToolStripMenuItem";
            silinmişAbonelerToolStripMenuItem.Size = new Size(245, 26);
            silinmişAbonelerToolStripMenuItem.Text = "Silinmiş Aboneler";
            silinmişAbonelerToolStripMenuItem.Click += silinmişAbonelerToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 37);
            label1.Name = "label1";
            label1.Size = new Size(101, 24);
            label1.TabIndex = 1;
            label1.Text = "Abone ID:";
            // 
            // TxtAboneID
            // 
            TxtAboneID.Enabled = false;
            TxtAboneID.Location = new Point(133, 34);
            TxtAboneID.Name = "TxtAboneID";
            TxtAboneID.Size = new Size(195, 30);
            TxtAboneID.TabIndex = 1;
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(133, 70);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(195, 30);
            TxtAd.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 73);
            label2.Name = "label2";
            label2.Size = new Size(40, 24);
            label2.TabIndex = 3;
            label2.Text = "Ad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 182);
            label3.Name = "label3";
            label3.Size = new Size(115, 24);
            label3.TabIndex = 7;
            label3.Text = "Telefon No:";
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(133, 106);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(195, 30);
            TxtSoyad.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 109);
            label4.Name = "label4";
            label4.Size = new Size(69, 24);
            label4.TabIndex = 5;
            label4.Text = "Soyad:";
            // 
            // TxtAdres
            // 
            TxtAdres.Location = new Point(133, 290);
            TxtAdres.Name = "TxtAdres";
            TxtAdres.Size = new Size(195, 30);
            TxtAdres.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 293);
            label5.Name = "label5";
            label5.Size = new Size(67, 24);
            label5.TabIndex = 9;
            label5.Text = "Adres:";
            // 
            // MskTel
            // 
            MskTel.Location = new Point(133, 179);
            MskTel.Mask = "(999) 000-0000";
            MskTel.Name = "MskTel";
            MskTel.Size = new Size(195, 30);
            MskTel.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 254);
            label6.Name = "label6";
            label6.Size = new Size(127, 24);
            label6.TabIndex = 12;
            label6.Text = " Kayıt Tarihi:";
            // 
            // TxtMail
            // 
            TxtMail.Location = new Point(133, 218);
            TxtMail.Name = "TxtMail";
            TxtMail.Size = new Size(195, 30);
            TxtMail.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(70, 218);
            label7.Name = "label7";
            label7.Size = new Size(57, 24);
            label7.TabIndex = 14;
            label7.Text = "Mail:";
            // 
            // button1
            // 
            button1.Location = new Point(6, 339);
            button1.Name = "button1";
            button1.Size = new Size(322, 45);
            button1.TabIndex = 16;
            button1.Text = "Tüm Aboneler ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BtnAboneEkle
            // 
            BtnAboneEkle.Location = new Point(6, 3);
            BtnAboneEkle.Name = "BtnAboneEkle";
            BtnAboneEkle.Size = new Size(322, 45);
            BtnAboneEkle.TabIndex = 17;
            BtnAboneEkle.Text = "Abone Ekle";
            BtnAboneEkle.UseVisualStyleBackColor = true;
            BtnAboneEkle.Click += BtnAboneEkle_Click;
            // 
            // BtnAboneGuncelle
            // 
            BtnAboneGuncelle.Location = new Point(6, 105);
            BtnAboneGuncelle.Name = "BtnAboneGuncelle";
            BtnAboneGuncelle.Size = new Size(322, 45);
            BtnAboneGuncelle.TabIndex = 18;
            BtnAboneGuncelle.Text = "Abone Güncelle";
            BtnAboneGuncelle.UseVisualStyleBackColor = true;
            BtnAboneGuncelle.Click += BtnAboneGuncelle_Click;
            // 
            // BtnAboneSil
            // 
            BtnAboneSil.Location = new Point(6, 54);
            BtnAboneSil.Name = "BtnAboneSil";
            BtnAboneSil.Size = new Size(322, 45);
            BtnAboneSil.TabIndex = 19;
            BtnAboneSil.Text = "Abone Sil";
            BtnAboneSil.UseVisualStyleBackColor = true;
            BtnAboneSil.Click += BtnAboneSil_Click;
            // 
            // LblKapat
            // 
            LblKapat.AutoSize = true;
            LblKapat.Location = new Point(1475, 9);
            LblKapat.Name = "LblKapat";
            LblKapat.Size = new Size(24, 24);
            LblKapat.TabIndex = 24;
            LblKapat.Text = "X";
            LblKapat.Click += LblKapat_Click;
            // 
            // BtnGeri
            // 
            BtnGeri.Location = new Point(12, 12);
            BtnGeri.Name = "BtnGeri";
            BtnGeri.Size = new Size(94, 29);
            BtnGeri.TabIndex = 25;
            BtnGeri.Text = "Geri";
            BtnGeri.UseVisualStyleBackColor = true;
            BtnGeri.Click += BtnGeri_Click;
            // 
            // BtnSilinmisAboneler
            // 
            BtnSilinmisAboneler.Location = new Point(6, 441);
            BtnSilinmisAboneler.Name = "BtnSilinmisAboneler";
            BtnSilinmisAboneler.Size = new Size(322, 45);
            BtnSilinmisAboneler.TabIndex = 26;
            BtnSilinmisAboneler.Text = "Silinmiş Aboneler";
            BtnSilinmisAboneler.UseVisualStyleBackColor = true;
            BtnSilinmisAboneler.Click += BtnSilinmisAboneler_Click;
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(133, 142);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(195, 30);
            TxtSifre.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(69, 148);
            label8.Name = "label8";
            label8.Size = new Size(58, 24);
            label8.TabIndex = 27;
            label8.Text = "Şifre:";
            // 
            // BtnGuncellenmisAbone
            // 
            BtnGuncellenmisAbone.Location = new Point(6, 390);
            BtnGuncellenmisAbone.Name = "BtnGuncellenmisAbone";
            BtnGuncellenmisAbone.Size = new Size(322, 45);
            BtnGuncellenmisAbone.TabIndex = 29;
            BtnGuncellenmisAbone.Text = "Güncellenmiş Aboneler";
            BtnGuncellenmisAbone.UseVisualStyleBackColor = true;
            BtnGuncellenmisAbone.Click += BtnGuncellenmisAbone_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(LblKayit_Tarihi);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(BtnGuncellenmisAbone);
            groupBox2.Controls.Add(TxtAboneID);
            groupBox2.Controls.Add(TxtSifre);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(TxtAd);
            groupBox2.Controls.Add(BtnSilinmisAboneler);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(TxtSoyad);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(TxtAdres);
            groupBox2.Controls.Add(MskTel);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(TxtMail);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(12, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(345, 668);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Abone Bilgileri";
            // 
            // LblKayit_Tarihi
            // 
            LblKayit_Tarihi.AutoSize = true;
            LblKayit_Tarihi.Location = new Point(133, 254);
            LblKayit_Tarihi.Name = "LblKayit_Tarihi";
            LblKayit_Tarihi.Size = new Size(0, 24);
            LblKayit_Tarihi.TabIndex = 53;
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnAboneEkle);
            panel1.Controls.Add(BtnAboneSil);
            panel1.Controls.Add(BtnAboneGuncelle);
            panel1.Location = new Point(12, 540);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 173);
            panel1.TabIndex = 30;
            // 
            // panel2
            // 
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(TxtArama);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(BtnAra);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(1253, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 653);
            panel2.TabIndex = 43;
            // 
            // button6
            // 
            button6.Location = new Point(57, 521);
            button6.Name = "button6";
            button6.Size = new Size(137, 68);
            button6.TabIndex = 48;
            button6.Text = "Adrese Göre Ara";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(57, 253);
            button5.Name = "button5";
            button5.Size = new Size(137, 68);
            button5.TabIndex = 47;
            button5.Text = "Soyada Göre Ara";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // TxtArama
            // 
            TxtArama.Location = new Point(23, 17);
            TxtArama.Name = "TxtArama";
            TxtArama.Size = new Size(197, 30);
            TxtArama.TabIndex = 35;
            // 
            // button4
            // 
            button4.Location = new Point(57, 341);
            button4.Name = "button4";
            button4.Size = new Size(137, 68);
            button4.TabIndex = 46;
            button4.Text = "Tel_No'ya Göre Ara";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // BtnAra
            // 
            BtnAra.Location = new Point(57, 62);
            BtnAra.Name = "BtnAra";
            BtnAra.Size = new Size(137, 68);
            BtnAra.TabIndex = 34;
            BtnAra.Text = "Genel Arama";
            BtnAra.UseVisualStyleBackColor = true;
            BtnAra.Click += BtnAra_Click;
            // 
            // button3
            // 
            button3.Location = new Point(57, 435);
            button3.Name = "button3";
            button3.Size = new Size(137, 68);
            button3.TabIndex = 45;
            button3.Text = "Mail'e Göre Ara";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(57, 159);
            button2.Name = "button2";
            button2.Size = new Size(137, 68);
            button2.TabIndex = 44;
            button2.Text = "Ada Göre Ara";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Yonetici_Abone_İslemleri
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1511, 787);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(BtnGeri);
            Controls.Add(LblKapat);
            Controls.Add(groupBox1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Yonetici_Abone_İslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Abone_İşlemleri";
            Load += Yonetici_Abone_İslemleri_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox TxtAboneID;
        private TextBox TxtAd;
        private Label label2;
        private Label label3;
        private TextBox TxtSoyad;
        private Label label4;
        private TextBox TxtAdres;
        private Label label5;
        private MaskedTextBox MskTel;
        private Label label6;
        private TextBox TxtMail;
        private Label label7;
        private Button button1;
        private Button BtnAboneEkle;
        private Button BtnAboneGuncelle;
        private Button BtnAboneSil;
        private Label LblKapat;
        public Button BtnGeri;
        private Button BtnSilinmisAboneler;
        private TextBox TxtSifre;
        private Label label8;
        private Button BtnGuncellenmisAbone;
        private GroupBox groupBox2;
        private Panel panel1;
        private Panel panel2;
        private TextBox TxtArama;
        private Button BtnAra;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem pDFAKTARToolStripMenuItem;
        private ToolStripMenuItem tümAbonelerToolStripMenuItem;
        private ToolStripMenuItem güncellenmişAbonelerToolStripMenuItem;
        private ToolStripMenuItem silinmişAbonelerToolStripMenuItem;
        private Label LblKayit_Tarihi;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}