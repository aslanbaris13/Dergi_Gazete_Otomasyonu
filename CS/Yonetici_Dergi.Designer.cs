namespace Dergi_Gazete_Abonelik
{
    partial class Yonetici_Dergi
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
            btndergisil = new Button();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            pDFDIŞAAKTARToolStripMenuItem = new ToolStripMenuItem();
            tümDergilerToolStripMenuItem = new ToolStripMenuItem();
            satınAlınanDergilerToolStripMenuItem = new ToolStripMenuItem();
            silinmişDergilerToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            btnExport = new Button();
            btnImport = new Button();
            btndergiekle = new Button();
            btndergiguncelle = new Button();
            btnsatinalinandergiler = new Button();
            btnsilinmisdergiler = new Button();
            btntumdergiler = new Button();
            TxtDergiYayinEvi = new TextBox();
            TxtUcret = new TextBox();
            TxtDergiTuru = new TextBox();
            TxtDergiAd = new TextBox();
            TxtDergiBarkodID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BtnGeri = new Button();
            LblKapat = new Label();
            BtnAra = new Button();
            TxtArama = new TextBox();
            panel2 = new Panel();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btndergisil
            // 
            btndergisil.Location = new Point(15, 54);
            btndergisil.Name = "btndergisil";
            btndergisil.Size = new Size(304, 35);
            btndergisil.TabIndex = 27;
            btndergisil.Text = "Dergi Sil";
            btndergisil.UseVisualStyleBackColor = true;
            btndergisil.Click += btndergisil_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(menuStrip1);
            groupBox2.Location = new Point(428, 73);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1071, 687);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dergiler";
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
            dataGridView1.Size = new Size(1065, 630);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { pDFDIŞAAKTARToolStripMenuItem });
            menuStrip1.Location = new Point(3, 26);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1065, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // pDFDIŞAAKTARToolStripMenuItem
            // 
            pDFDIŞAAKTARToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tümDergilerToolStripMenuItem, satınAlınanDergilerToolStripMenuItem, silinmişDergilerToolStripMenuItem });
            pDFDIŞAAKTARToolStripMenuItem.Name = "pDFDIŞAAKTARToolStripMenuItem";
            pDFDIŞAAKTARToolStripMenuItem.Padding = new Padding(20, 0, 5, 0);
            pDFDIŞAAKTARToolStripMenuItem.Size = new Size(150, 24);
            pDFDIŞAAKTARToolStripMenuItem.Text = "PDF DIŞA AKTAR";
            // 
            // tümDergilerToolStripMenuItem
            // 
            tümDergilerToolStripMenuItem.Name = "tümDergilerToolStripMenuItem";
            tümDergilerToolStripMenuItem.Size = new Size(229, 26);
            tümDergilerToolStripMenuItem.Text = "Tüm Dergiler";
            tümDergilerToolStripMenuItem.Click += tümDergilerToolStripMenuItem_Click;
            // 
            // satınAlınanDergilerToolStripMenuItem
            // 
            satınAlınanDergilerToolStripMenuItem.Name = "satınAlınanDergilerToolStripMenuItem";
            satınAlınanDergilerToolStripMenuItem.Size = new Size(229, 26);
            satınAlınanDergilerToolStripMenuItem.Text = "Satın Alınan Dergiler";
            satınAlınanDergilerToolStripMenuItem.Click += satınAlınanDergilerToolStripMenuItem_Click;
            // 
            // silinmişDergilerToolStripMenuItem
            // 
            silinmişDergilerToolStripMenuItem.Name = "silinmişDergilerToolStripMenuItem";
            silinmişDergilerToolStripMenuItem.Size = new Size(229, 26);
            silinmişDergilerToolStripMenuItem.Text = "Silinmiş Dergiler";
            silinmişDergilerToolStripMenuItem.Click += silinmişDergilerToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(btnsatinalinandergiler);
            groupBox1.Controls.Add(btnsilinmisdergiler);
            groupBox1.Controls.Add(btntumdergiler);
            groupBox1.Controls.Add(TxtDergiYayinEvi);
            groupBox1.Controls.Add(TxtUcret);
            groupBox1.Controls.Add(TxtDergiTuru);
            groupBox1.Controls.Add(TxtDergiAd);
            groupBox1.Controls.Add(TxtDergiBarkodID);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 687);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dergi Bilgileri";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExport);
            panel1.Controls.Add(btnImport);
            panel1.Controls.Add(btndergiekle);
            panel1.Controls.Add(btndergiguncelle);
            panel1.Controls.Add(btndergisil);
            panel1.Location = new Point(6, 441);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 240);
            panel1.TabIndex = 36;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(15, 202);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(304, 35);
            btnExport.TabIndex = 29;
            btnExport.Text = "Dergi Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(15, 154);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(304, 35);
            btnImport.TabIndex = 28;
            btnImport.Text = "Dergi İmport";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btndergiekle
            // 
            btndergiekle.Location = new Point(15, 3);
            btndergiekle.Name = "btndergiekle";
            btndergiekle.Size = new Size(304, 35);
            btndergiekle.TabIndex = 24;
            btndergiekle.Text = "Dergi Ekle";
            btndergiekle.UseVisualStyleBackColor = true;
            btndergiekle.Click += btndergiekle_Click;
            // 
            // btndergiguncelle
            // 
            btndergiguncelle.Location = new Point(15, 104);
            btndergiguncelle.Name = "btndergiguncelle";
            btndergiguncelle.Size = new Size(304, 35);
            btndergiguncelle.TabIndex = 26;
            btndergiguncelle.Text = "Dergi Güncelle";
            btndergiguncelle.UseVisualStyleBackColor = true;
            btndergiguncelle.Click += btndergiguncelle_Click;
            // 
            // btnsatinalinandergiler
            // 
            btnsatinalinandergiler.Location = new Point(21, 340);
            btnsatinalinandergiler.Name = "btnsatinalinandergiler";
            btnsatinalinandergiler.Size = new Size(304, 35);
            btnsatinalinandergiler.TabIndex = 35;
            btnsatinalinandergiler.Text = "Satın Alınan Dergiler";
            btnsatinalinandergiler.UseVisualStyleBackColor = true;
            btnsatinalinandergiler.Click += btnsatinalinandergiler_Click;
            // 
            // btnsilinmisdergiler
            // 
            btnsilinmisdergiler.Location = new Point(21, 390);
            btnsilinmisdergiler.Name = "btnsilinmisdergiler";
            btnsilinmisdergiler.Size = new Size(304, 35);
            btnsilinmisdergiler.TabIndex = 34;
            btnsilinmisdergiler.Text = "Silinmiş Dergiler";
            btnsilinmisdergiler.UseVisualStyleBackColor = true;
            btnsilinmisdergiler.Click += btnsilinmisdergiler_Click;
            // 
            // btntumdergiler
            // 
            btntumdergiler.Location = new Point(21, 289);
            btntumdergiler.Name = "btntumdergiler";
            btntumdergiler.Size = new Size(304, 35);
            btntumdergiler.TabIndex = 25;
            btntumdergiler.Text = "Tüm Dergiler";
            btntumdergiler.UseVisualStyleBackColor = true;
            btntumdergiler.Click += btntumdergiler_Click;
            // 
            // TxtDergiYayinEvi
            // 
            TxtDergiYayinEvi.Location = new Point(156, 234);
            TxtDergiYayinEvi.Name = "TxtDergiYayinEvi";
            TxtDergiYayinEvi.Size = new Size(169, 30);
            TxtDergiYayinEvi.TabIndex = 4;
            // 
            // TxtUcret
            // 
            TxtUcret.Location = new Point(156, 195);
            TxtUcret.Name = "TxtUcret";
            TxtUcret.Size = new Size(169, 30);
            TxtUcret.TabIndex = 3;
            // 
            // TxtDergiTuru
            // 
            TxtDergiTuru.Location = new Point(156, 150);
            TxtDergiTuru.Name = "TxtDergiTuru";
            TxtDergiTuru.Size = new Size(169, 30);
            TxtDergiTuru.TabIndex = 2;
            // 
            // TxtDergiAd
            // 
            TxtDergiAd.Location = new Point(156, 102);
            TxtDergiAd.Name = "TxtDergiAd";
            TxtDergiAd.Size = new Size(169, 30);
            TxtDergiAd.TabIndex = 1;
            // 
            // TxtDergiBarkodID
            // 
            TxtDergiBarkodID.Enabled = false;
            TxtDergiBarkodID.Location = new Point(156, 54);
            TxtDergiBarkodID.Name = "TxtDergiBarkodID";
            TxtDergiBarkodID.Size = new Size(169, 30);
            TxtDergiBarkodID.TabIndex = 0;
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
            label3.Size = new Size(114, 24);
            label3.TabIndex = 2;
            label3.Text = "Dergi Türü:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 105);
            label2.Name = "label2";
            label2.Size = new Size(100, 24);
            label2.TabIndex = 1;
            label2.Text = "Dergi Adı:";
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
            // BtnGeri
            // 
            BtnGeri.Location = new Point(12, 12);
            BtnGeri.Name = "BtnGeri";
            BtnGeri.Size = new Size(94, 29);
            BtnGeri.TabIndex = 32;
            BtnGeri.Text = "Geri";
            BtnGeri.UseVisualStyleBackColor = true;
            BtnGeri.Click += BtnGeri_Click;
            // 
            // LblKapat
            // 
            LblKapat.AutoSize = true;
            LblKapat.Location = new Point(1475, 9);
            LblKapat.Name = "LblKapat";
            LblKapat.Size = new Size(24, 24);
            LblKapat.TabIndex = 33;
            LblKapat.Text = "X";
            LblKapat.Click += LblKapat_Click;
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
            // TxtArama
            // 
            TxtArama.Location = new Point(3, 13);
            TxtArama.Name = "TxtArama";
            TxtArama.Size = new Size(229, 30);
            TxtArama.TabIndex = 35;
            // 
            // panel2
            // 
            panel2.Controls.Add(TxtArama);
            panel2.Controls.Add(BtnAra);
            panel2.Location = new Point(431, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(347, 46);
            panel2.TabIndex = 36;
            // 
            // Yonetici_Dergi
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
            Name = "Yonetici_Dergi";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Yonetici_Dergi_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button btndergisil;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button btndergiekle;
        private Button btntumdergiler;
        private Button btndergiguncelle;
        private TextBox TxtDergiYayinEvi;
        private TextBox TxtUcret;
        private TextBox TxtDergiTuru;
        private TextBox TxtDergiAd;
        private TextBox TxtDergiBarkodID;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public Button BtnGeri;
        private Label LblKapat;
        private Button btnsilinmisdergiler;
        private Button btnsatinalinandergiler;
        private Button BtnAra;
        private TextBox TxtArama;
        private Panel panel1;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem pDFDIŞAAKTARToolStripMenuItem;
        private ToolStripMenuItem tümDergilerToolStripMenuItem;
        private ToolStripMenuItem satınAlınanDergilerToolStripMenuItem;
        private ToolStripMenuItem silinmişDergilerToolStripMenuItem;
        private Button btnExport;
        private Button btnImport;
    }
}