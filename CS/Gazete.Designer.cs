namespace Dergi_Gazete_Abonelik
{
    partial class Gazete
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
            BtnGeri = new Button();
            LblKapat = new Label();
            paneldergisil = new Panel();
            btngazetesil = new Button();
            label6 = new Label();
            txtAbone_ID = new TextBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            btnsatınal = new Button();
            btntumgazeteler = new Button();
            TxtGazeteYayinEvi = new TextBox();
            TxtGazeteUcret = new TextBox();
            btngazetelerim = new Button();
            TxtGazeteTuru = new TextBox();
            TxtGazeteAd = new TextBox();
            TxtGazeteBarkodID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            BtnAra = new Button();
            TxtAra = new TextBox();
            paneldergisil.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            LblKapat.Location = new Point(1155, 9);
            LblKapat.Name = "LblKapat";
            LblKapat.Size = new Size(24, 24);
            LblKapat.TabIndex = 22;
            LblKapat.Text = "X";
            LblKapat.Click += LblKapat_Click;
            // 
            // paneldergisil
            // 
            paneldergisil.Controls.Add(btngazetesil);
            paneldergisil.Location = new Point(400, 615);
            paneldergisil.Name = "paneldergisil";
            paneldergisil.Size = new Size(356, 63);
            paneldergisil.TabIndex = 31;
            // 
            // btngazetesil
            // 
            btngazetesil.Location = new Point(12, 14);
            btngazetesil.Name = "btngazetesil";
            btngazetesil.Size = new Size(304, 35);
            btngazetesil.TabIndex = 27;
            btngazetesil.Text = "Gazete Sil";
            btngazetesil.UseVisualStyleBackColor = true;
            btngazetesil.Click += btngazetesil_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 61);
            label6.Name = "label6";
            label6.Size = new Size(101, 24);
            label6.TabIndex = 30;
            label6.Text = "Abone ID:";
            // 
            // txtAbone_ID
            // 
            txtAbone_ID.Enabled = false;
            txtAbone_ID.Location = new Point(134, 55);
            txtAbone_ID.Name = "txtAbone_ID";
            txtAbone_ID.Size = new Size(179, 30);
            txtAbone_ID.TabIndex = 29;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(397, 116);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(782, 480);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gazeteler";
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
            dataGridView1.Size = new Size(776, 451);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnsatınal);
            groupBox1.Controls.Add(btntumgazeteler);
            groupBox1.Controls.Add(TxtGazeteYayinEvi);
            groupBox1.Controls.Add(TxtGazeteUcret);
            groupBox1.Controls.Add(btngazetelerim);
            groupBox1.Controls.Add(TxtGazeteTuru);
            groupBox1.Controls.Add(TxtGazeteAd);
            groupBox1.Controls.Add(TxtGazeteBarkodID);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(7, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 562);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gazete Bilgileri";
            // 
            // btnsatınal
            // 
            btnsatınal.Location = new Point(55, 364);
            btnsatınal.Name = "btnsatınal";
            btnsatınal.Size = new Size(304, 35);
            btnsatınal.TabIndex = 24;
            btnsatınal.Text = "Satın Al";
            btnsatınal.UseVisualStyleBackColor = true;
            btnsatınal.Click += btnsatınal_Click;
            // 
            // btntumgazeteler
            // 
            btntumgazeteler.Location = new Point(55, 413);
            btntumgazeteler.Name = "btntumgazeteler";
            btntumgazeteler.Size = new Size(304, 35);
            btntumgazeteler.TabIndex = 25;
            btntumgazeteler.Text = "Tüm Gazeteler";
            btntumgazeteler.UseVisualStyleBackColor = true;
            btntumgazeteler.Click += btntumgazeteler_Click;
            // 
            // TxtGazeteYayinEvi
            // 
            TxtGazeteYayinEvi.Enabled = false;
            TxtGazeteYayinEvi.Location = new Point(156, 306);
            TxtGazeteYayinEvi.Name = "TxtGazeteYayinEvi";
            TxtGazeteYayinEvi.Size = new Size(203, 30);
            TxtGazeteYayinEvi.TabIndex = 5;
            // 
            // TxtGazeteUcret
            // 
            TxtGazeteUcret.Enabled = false;
            TxtGazeteUcret.Location = new Point(156, 243);
            TxtGazeteUcret.Name = "TxtGazeteUcret";
            TxtGazeteUcret.Size = new Size(203, 30);
            TxtGazeteUcret.TabIndex = 4;
            // 
            // btngazetelerim
            // 
            btngazetelerim.Location = new Point(55, 466);
            btngazetelerim.Name = "btngazetelerim";
            btngazetelerim.Size = new Size(304, 35);
            btngazetelerim.TabIndex = 26;
            btngazetelerim.Text = "Gazetelerim";
            btngazetelerim.UseVisualStyleBackColor = true;
            btngazetelerim.Click += btngazetelerim_Click;
            // 
            // TxtGazeteTuru
            // 
            TxtGazeteTuru.Enabled = false;
            TxtGazeteTuru.Location = new Point(156, 177);
            TxtGazeteTuru.Name = "TxtGazeteTuru";
            TxtGazeteTuru.Size = new Size(203, 30);
            TxtGazeteTuru.TabIndex = 3;
            // 
            // TxtGazeteAd
            // 
            TxtGazeteAd.Enabled = false;
            TxtGazeteAd.Location = new Point(156, 118);
            TxtGazeteAd.Name = "TxtGazeteAd";
            TxtGazeteAd.Size = new Size(203, 30);
            TxtGazeteAd.TabIndex = 2;
            // 
            // TxtGazeteBarkodID
            // 
            TxtGazeteBarkodID.Enabled = false;
            TxtGazeteBarkodID.Location = new Point(156, 54);
            TxtGazeteBarkodID.Name = "TxtGazeteBarkodID";
            TxtGazeteBarkodID.Size = new Size(203, 30);
            TxtGazeteBarkodID.TabIndex = 1;
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
            label3.Size = new Size(126, 24);
            label3.TabIndex = 2;
            label3.Text = "Gazete Türü:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 121);
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
            // panel1
            // 
            panel1.Controls.Add(BtnAra);
            panel1.Controls.Add(TxtAra);
            panel1.Location = new Point(412, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 57);
            panel1.TabIndex = 32;
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
            // Gazete
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
            Controls.Add(groupBox1);
            Controls.Add(LblKapat);
            Controls.Add(BtnGeri);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Gazete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gazete";
            Load += Gazete_Load;
            paneldergisil.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button BtnGeri;
        private Label LblKapat;
        private Panel paneldergisil;
        private Button btndergisil;
        private Label label6;
        private TextBox txtAbone_ID;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button btnsatınal;
        private Button btntumgazeteler;
        private Button btngazetelerim;
        private TextBox TxtGazeteYayinEvi;
        private TextBox TxtGazeteUcret;
        private TextBox TxtGazeteTuru;
        private TextBox TxtGazeteAd;
        private TextBox TxtGazeteBarkodID;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btngazetesil;
        private Panel panel1;
        private Button BtnAra;
        private TextBox TxtAra;
    }
}