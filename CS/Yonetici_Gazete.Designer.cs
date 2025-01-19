namespace Dergi_Gazete_Abonelik
{
    partial class Yonetici_Gazete
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
            btnsilinmisgazeteler = new Button();
            btngazetesil = new Button();
            btngazeteguncelle = new Button();
            btngazeteekle = new Button();
            btntumgazeteler = new Button();
            TxtGazeteYayinEvi = new TextBox();
            TxtUcret = new TextBox();
            TxtGazeteTuru = new TextBox();
            TxtGazeteAd = new TextBox();
            TxtGazeteBarkodID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            LblKapat = new Label();
            BtnGeri = new Button();
            groupBox2 = new GroupBox();
            menuStrip1 = new MenuStrip();
            pDFAKTARToolStripMenuItem = new ToolStripMenuItem();
            tümGazetelerToolStripMenuItem = new ToolStripMenuItem();
            satınAlınanGazetelerToolStripMenuItem = new ToolStripMenuItem();
            silinmişGazetelerToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            btnExport = new Button();
            btnImport = new Button();
            btnsatinalinangazeteler = new Button();
            panel2 = new Panel();
            TxtArama = new TextBox();
            BtnAra = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnsilinmisgazeteler
            // 
            btnsilinmisgazeteler.Location = new Point(21, 391);
            btnsilinmisgazeteler.Name = "btnsilinmisgazeteler";
            btnsilinmisgazeteler.Size = new Size(304, 35);
            btnsilinmisgazeteler.TabIndex = 34;
            btnsilinmisgazeteler.Text = "Silinmiş Gazeteler";
            btnsilinmisgazeteler.UseVisualStyleBackColor = true;
            btnsilinmisgazeteler.Click += btnsilinmisgazeteler_Click;
            // 
            // btngazetesil
            // 
            btngazetesil.Location = new Point(15, 54);
            btngazetesil.Name = "btngazetesil";
            btngazetesil.Size = new Size(304, 35);
            btngazetesil.TabIndex = 27;
            btngazetesil.Text = "Gazete Sil";
            btngazetesil.UseVisualStyleBackColor = true;
            btngazetesil.Click += btngazetesil_Click;
            // 
            // btngazeteguncelle
            // 
            btngazeteguncelle.Location = new Point(15, 104);
            btngazeteguncelle.Name = "btngazeteguncelle";
            btngazeteguncelle.Size = new Size(304, 35);
            btngazeteguncelle.TabIndex = 26;
            btngazeteguncelle.Text = "Gazete Güncelle";
            btngazeteguncelle.UseVisualStyleBackColor = true;
            btngazeteguncelle.Click += btngazeteguncelle_Click;
            // 
            // btngazeteekle
            // 
            btngazeteekle.Location = new Point(15, 3);
            btngazeteekle.Name = "btngazeteekle";
            btngazeteekle.Size = new Size(304, 35);
            btngazeteekle.TabIndex = 24;
            btngazeteekle.Text = "Gazete Ekle";
            btngazeteekle.UseVisualStyleBackColor = true;
            btngazeteekle.Click += btngazeteekle_Click;
            // 
            // btntumgazeteler
            // 
            btntumgazeteler.Location = new Point(21, 289);
            btntumgazeteler.Name = "btntumgazeteler";
            btntumgazeteler.Size = new Size(304, 35);
            btntumgazeteler.TabIndex = 25;
            btntumgazeteler.Text = "Tüm Gazeteler";
            btntumgazeteler.UseVisualStyleBackColor = true;
            btntumgazeteler.Click += btntumgazeteler_Click;
            // 
            // TxtGazeteYayinEvi
            // 
            TxtGazeteYayinEvi.Location = new Point(156, 234);
            TxtGazeteYayinEvi.Name = "TxtGazeteYayinEvi";
            TxtGazeteYayinEvi.Size = new Size(169, 30);
            TxtGazeteYayinEvi.TabIndex = 4;
            // 
            // TxtUcret
            // 
            TxtUcret.Location = new Point(156, 195);
            TxtUcret.Name = "TxtUcret";
            TxtUcret.Size = new Size(169, 30);
            TxtUcret.TabIndex = 3;
            // 
            // TxtGazeteTuru
            // 
            TxtGazeteTuru.Location = new Point(156, 150);
            TxtGazeteTuru.Name = "TxtGazeteTuru";
            TxtGazeteTuru.Size = new Size(169, 30);
            TxtGazeteTuru.TabIndex = 2;
            // 
            // TxtGazeteAd
            // 
            TxtGazeteAd.Location = new Point(156, 102);
            TxtGazeteAd.Name = "TxtGazeteAd";
            TxtGazeteAd.Size = new Size(169, 30);
            TxtGazeteAd.TabIndex = 1;
            // 
            // TxtGazeteBarkodID
            // 
            TxtGazeteBarkodID.Enabled = false;
            TxtGazeteBarkodID.Location = new Point(156, 54);
            TxtGazeteBarkodID.Name = "TxtGazeteBarkodID";
            TxtGazeteBarkodID.Size = new Size(169, 30);
            TxtGazeteBarkodID.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 240);
            label5.Name = "label5";
            label5.Size = new Size(100, 24);
            label5.TabIndex = 4;
            label5.Text = "Yayın Evi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 201);
            label4.Name = "label4";
            label4.Size = new Size(65, 24);
            label4.TabIndex = 3;
            label4.Text = "Ücret:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 153);
            label3.Name = "label3";
            label3.Size = new Size(126, 24);
            label3.TabIndex = 2;
            label3.Text = "Gazete Türü:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 105);
            label2.Name = "label2";
            label2.Size = new Size(112, 24);
            label2.TabIndex = 1;
            label2.Text = "Gazete Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 57);
            label1.Name = "label1";
            label1.Size = new Size(108, 24);
            label1.TabIndex = 0;
            label1.Text = "Barkod ID:";
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
            dataGridView1.Size = new Size(1065, 636);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // LblKapat
            // 
            LblKapat.AutoSize = true;
            LblKapat.Location = new Point(1475, 9);
            LblKapat.Name = "LblKapat";
            LblKapat.Size = new Size(24, 24);
            LblKapat.TabIndex = 41;
            LblKapat.Text = "X";
            LblKapat.Click += LblKapat_Click;
            // 
            // BtnGeri
            // 
            BtnGeri.Location = new Point(12, 12);
            BtnGeri.Name = "BtnGeri";
            BtnGeri.Size = new Size(94, 29);
            BtnGeri.TabIndex = 40;
            BtnGeri.Text = "Geri";
            BtnGeri.UseVisualStyleBackColor = true;
            BtnGeri.Click += BtnGeri_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(menuStrip1);
            groupBox2.Location = new Point(428, 61);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1071, 693);
            groupBox2.TabIndex = 39;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gazeteler";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { pDFAKTARToolStripMenuItem });
            menuStrip1.Location = new Point(3, 26);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1065, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // pDFAKTARToolStripMenuItem
            // 
            pDFAKTARToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tümGazetelerToolStripMenuItem, satınAlınanGazetelerToolStripMenuItem, silinmişGazetelerToolStripMenuItem });
            pDFAKTARToolStripMenuItem.Name = "pDFAKTARToolStripMenuItem";
            pDFAKTARToolStripMenuItem.Size = new Size(98, 24);
            pDFAKTARToolStripMenuItem.Text = "PDF AKTAR";
            // 
            // tümGazetelerToolStripMenuItem
            // 
            tümGazetelerToolStripMenuItem.Name = "tümGazetelerToolStripMenuItem";
            tümGazetelerToolStripMenuItem.Size = new Size(238, 26);
            tümGazetelerToolStripMenuItem.Text = "Tüm Gazeteler";
            tümGazetelerToolStripMenuItem.Click += tümGazetelerToolStripMenuItem_Click;
            // 
            // satınAlınanGazetelerToolStripMenuItem
            // 
            satınAlınanGazetelerToolStripMenuItem.Name = "satınAlınanGazetelerToolStripMenuItem";
            satınAlınanGazetelerToolStripMenuItem.Size = new Size(238, 26);
            satınAlınanGazetelerToolStripMenuItem.Text = "Satın Alınan Gazeteler";
            satınAlınanGazetelerToolStripMenuItem.Click += satınAlınanGazetelerToolStripMenuItem_Click;
            // 
            // silinmişGazetelerToolStripMenuItem
            // 
            silinmişGazetelerToolStripMenuItem.Name = "silinmişGazetelerToolStripMenuItem";
            silinmişGazetelerToolStripMenuItem.Size = new Size(238, 26);
            silinmişGazetelerToolStripMenuItem.Text = "Silinmiş Gazeteler";
            silinmişGazetelerToolStripMenuItem.Click += silinmişGazetelerToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(btnsatinalinangazeteler);
            groupBox1.Controls.Add(btnsilinmisgazeteler);
            groupBox1.Controls.Add(btntumgazeteler);
            groupBox1.Controls.Add(TxtGazeteYayinEvi);
            groupBox1.Controls.Add(TxtUcret);
            groupBox1.Controls.Add(TxtGazeteTuru);
            groupBox1.Controls.Add(TxtGazeteAd);
            groupBox1.Controls.Add(TxtGazeteBarkodID);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 693);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gazete Bilgileri";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExport);
            panel1.Controls.Add(btngazeteekle);
            panel1.Controls.Add(btngazeteguncelle);
            panel1.Controls.Add(btnImport);
            panel1.Controls.Add(btngazetesil);
            panel1.Location = new Point(6, 432);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 255);
            panel1.TabIndex = 42;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(15, 217);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(304, 35);
            btnExport.TabIndex = 43;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(15, 159);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(304, 35);
            btnImport.TabIndex = 44;
            btnImport.Text = "İmport";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnsatinalinangazeteler
            // 
            btnsatinalinangazeteler.Location = new Point(21, 340);
            btnsatinalinangazeteler.Name = "btnsatinalinangazeteler";
            btnsatinalinangazeteler.Size = new Size(304, 35);
            btnsatinalinangazeteler.TabIndex = 35;
            btnsatinalinangazeteler.Text = "Satın Alınan Gazeteler";
            btnsatinalinangazeteler.UseVisualStyleBackColor = true;
            btnsatinalinangazeteler.Click += btnsatinalinangazeteler_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(TxtArama);
            panel2.Controls.Add(BtnAra);
            panel2.Location = new Point(720, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(347, 46);
            panel2.TabIndex = 42;
            // 
            // TxtArama
            // 
            TxtArama.Location = new Point(3, 13);
            TxtArama.Name = "TxtArama";
            TxtArama.Size = new Size(229, 30);
            TxtArama.TabIndex = 35;
            // 
            // BtnAra
            // 
            BtnAra.Location = new Point(238, 13);
            BtnAra.Name = "BtnAra";
            BtnAra.Size = new Size(94, 29);
            BtnAra.TabIndex = 34;
            BtnAra.Text = "Ara";
            BtnAra.UseVisualStyleBackColor = true;
            BtnAra.Click += BtnAra_Click;
            // 
            // Yonetici_Gazete
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1511, 787);
            Controls.Add(panel2);
            Controls.Add(LblKapat);
            Controls.Add(BtnGeri);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Yonetici_Gazete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yonetici_Gazete";
            Load += Yonetici_Gazete_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsilinmisgazeteler;
        private Button btngazetesil;
        private Button btngazeteguncelle;
        private Button btngazeteekle;
        private Button btntumgazeteler;
        private TextBox TxtGazeteYayinEvi;
        private TextBox TxtUcret;
        private TextBox TxtGazeteTuru;
        private TextBox TxtGazeteAd;
        private TextBox TxtGazeteBarkodID;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Label LblKapat;
        public Button BtnGeri;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button btnsatinalinangazeteler;
        private Panel panel1;
        private Panel panel2;
        private TextBox TxtArama;
        private Button BtnAra;
        private Button btnExport;
        private Button btnImport;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem pDFAKTARToolStripMenuItem;
        private ToolStripMenuItem tümGazetelerToolStripMenuItem;
        private ToolStripMenuItem satınAlınanGazetelerToolStripMenuItem;
        private ToolStripMenuItem silinmişGazetelerToolStripMenuItem;
    }
}