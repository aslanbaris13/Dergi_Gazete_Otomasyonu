namespace Dergi_Gazete_Abonelik
{
    partial class Dergi
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
            btnsatınal = new Button();
            btntumdergiler = new Button();
            btndergilerim = new Button();
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
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            txtAbone_ID = new TextBox();
            label6 = new Label();
            paneldergisil = new Panel();
            btndergisil = new Button();
            panel1 = new Panel();
            BtnAra = new Button();
            TxtAra = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            paneldergisil.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnsatınal);
            groupBox1.Controls.Add(btntumdergiler);
            groupBox1.Controls.Add(btndergilerim);
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
            groupBox1.Location = new Point(12, 119);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 562);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dergi Bilgileri";
            // 
            // btnsatınal
            // 
            btnsatınal.Location = new Point(47, 365);
            btnsatınal.Name = "btnsatınal";
            btnsatınal.Size = new Size(304, 35);
            btnsatınal.TabIndex = 24;
            btnsatınal.Text = "Satın Al";
            btnsatınal.UseVisualStyleBackColor = true;
            btnsatınal.Click += btnsatınal_Click;
            // 
            // btntumdergiler
            // 
            btntumdergiler.Location = new Point(47, 414);
            btntumdergiler.Name = "btntumdergiler";
            btntumdergiler.Size = new Size(304, 35);
            btntumdergiler.TabIndex = 25;
            btntumdergiler.Text = "Tüm Dergiler";
            btntumdergiler.UseVisualStyleBackColor = true;
            btntumdergiler.Click += btntumdergiler_Click;
            // 
            // btndergilerim
            // 
            btndergilerim.Location = new Point(47, 461);
            btndergilerim.Name = "btndergilerim";
            btndergilerim.Size = new Size(304, 35);
            btndergilerim.TabIndex = 26;
            btndergilerim.Text = "Dergilerim";
            btndergilerim.UseVisualStyleBackColor = true;
            btndergilerim.Click += btndergilerim_Click;
            // 
            // TxtDergiYayinEvi
            // 
            TxtDergiYayinEvi.Enabled = false;
            TxtDergiYayinEvi.Location = new Point(156, 306);
            TxtDergiYayinEvi.Name = "TxtDergiYayinEvi";
            TxtDergiYayinEvi.Size = new Size(195, 30);
            TxtDergiYayinEvi.TabIndex = 5;
            // 
            // TxtUcret
            // 
            TxtUcret.Enabled = false;
            TxtUcret.Location = new Point(156, 243);
            TxtUcret.Name = "TxtUcret";
            TxtUcret.Size = new Size(195, 30);
            TxtUcret.TabIndex = 4;
            // 
            // TxtDergiTuru
            // 
            TxtDergiTuru.Enabled = false;
            TxtDergiTuru.Location = new Point(156, 177);
            TxtDergiTuru.Name = "TxtDergiTuru";
            TxtDergiTuru.Size = new Size(195, 30);
            TxtDergiTuru.TabIndex = 3;
            // 
            // TxtDergiAd
            // 
            TxtDergiAd.Enabled = false;
            TxtDergiAd.Location = new Point(156, 118);
            TxtDergiAd.Name = "TxtDergiAd";
            TxtDergiAd.Size = new Size(195, 30);
            TxtDergiAd.TabIndex = 2;
            // 
            // TxtDergiBarkodID
            // 
            TxtDergiBarkodID.Enabled = false;
            TxtDergiBarkodID.Location = new Point(156, 54);
            TxtDergiBarkodID.Name = "TxtDergiBarkodID";
            TxtDergiBarkodID.Size = new Size(195, 30);
            TxtDergiBarkodID.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 312);
            label5.Name = "label5";
            label5.Size = new Size(100, 24);
            label5.TabIndex = 4;
            label5.Text = "Yayın Evi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 246);
            label4.Name = "label4";
            label4.Size = new Size(65, 24);
            label4.TabIndex = 3;
            label4.Text = "Ücret:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 180);
            label3.Name = "label3";
            label3.Size = new Size(114, 24);
            label3.TabIndex = 2;
            label3.Text = "Dergi Türü:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 121);
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
            BtnGeri.TabIndex = 21;
            BtnGeri.Text = "Geri";
            BtnGeri.UseVisualStyleBackColor = true;
            BtnGeri.Click += BtnGeri_Click;
            // 
            // LblKapat
            // 
            LblKapat.AutoSize = true;
            LblKapat.Location = new Point(1164, 9);
            LblKapat.Name = "LblKapat";
            LblKapat.Size = new Size(24, 24);
            LblKapat.TabIndex = 22;
            LblKapat.Text = "X";
            LblKapat.Click += LblKapat_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(402, 119);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(777, 480);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dergiler";
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
            dataGridView1.Size = new Size(771, 451);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtAbone_ID
            // 
            txtAbone_ID.Enabled = false;
            txtAbone_ID.Location = new Point(139, 58);
            txtAbone_ID.Name = "txtAbone_ID";
            txtAbone_ID.Size = new Size(179, 30);
            txtAbone_ID.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 64);
            label6.Name = "label6";
            label6.Size = new Size(101, 24);
            label6.TabIndex = 25;
            label6.Text = "Abone ID:";
            // 
            // paneldergisil
            // 
            paneldergisil.Controls.Add(btndergisil);
            paneldergisil.Location = new Point(405, 618);
            paneldergisil.Name = "paneldergisil";
            paneldergisil.Size = new Size(351, 63);
            paneldergisil.TabIndex = 26;
            // 
            // btndergisil
            // 
            btndergisil.Location = new Point(12, 14);
            btndergisil.Name = "btndergisil";
            btndergisil.Size = new Size(304, 35);
            btndergisil.TabIndex = 27;
            btndergisil.Text = "Dergi Sil";
            btndergisil.UseVisualStyleBackColor = true;
            btndergisil.Click += btndergisil_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnAra);
            panel1.Controls.Add(TxtAra);
            panel1.Location = new Point(405, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 57);
            panel1.TabIndex = 33;
            // 
            // BtnAra
            // 
            BtnAra.Location = new Point(229, 6);
            BtnAra.Name = "BtnAra";
            BtnAra.Size = new Size(84, 35);
            BtnAra.TabIndex = 33;
            BtnAra.Text = "Ara";
            BtnAra.UseVisualStyleBackColor = true;
            BtnAra.Click += BtnAra_Click;
            // 
            // TxtAra
            // 
            TxtAra.Location = new Point(12, 8);
            TxtAra.Name = "TxtAra";
            TxtAra.Size = new Size(211, 30);
            TxtAra.TabIndex = 33;
            // 
            // Dergi
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1191, 718);
            Controls.Add(panel1);
            Controls.Add(paneldergisil);
            Controls.Add(label6);
            Controls.Add(txtAbone_ID);
            Controls.Add(groupBox2);
            Controls.Add(LblKapat);
            Controls.Add(BtnGeri);
            Controls.Add(groupBox1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Dergi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dergi";
            Load += Dergi_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            paneldergisil.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        public Button BtnGeri;
        private Label LblKapat;
        private GroupBox groupBox2;
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
        private DataGridView dataGridView1;
        private Button btnsatınal;
        private Button btntumdergiler;
        private Button btndergilerim;
        private TextBox txtAbone_ID;
        private Label label6;
        private Panel paneldergisil;
        private Button btndergisil;
        private Panel panel1;
        private Button BtnAra;
        private TextBox TxtAra;
    }
}