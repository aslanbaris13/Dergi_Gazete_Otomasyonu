using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Dergi_Gazete_Abonelik
{
    public partial class Yonetici_Abone_İslemleri : Form
    {
        public Yonetici_Abone_İslemleri()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();




        private void LblKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            //Yonetici_Anasayfa fr = new Yonetici_Anasayfa();
            //fr.Show();
            this.Hide();
        }

        private void Yonetici_Abone_İslemleri_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Musteri_ID,Ad,Soyad,Sifre,Tel_No,Mail,Kayit_Tarihi,Adres From Abone", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.ClearSelection();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            groupBox1.Text = "Aboneler";
            tumListe();

        }

        private void BtnAboneEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlBaglanti bgl = new SqlBaglanti();

                // Abone tablosuna veri ekleme sorgusu
                SqlCommand komut = new SqlCommand(
                    "INSERT INTO Abone (Ad, Soyad, Sifre, Tel_No, Mail, Adres) VALUES (@d1, @d2, @d3, @d4, @d5, @d7)",
                    bgl.baglanti()
                );

                // Parametreler
                komut.Parameters.AddWithValue("@d1", TxtAd.Text);
                komut.Parameters.AddWithValue("@d2", TxtSoyad.Text);
                komut.Parameters.AddWithValue("@d3", TxtSifre.Text);
                komut.Parameters.AddWithValue("@d4", MskTel.Text);
                komut.Parameters.AddWithValue("@d5", TxtMail.Text);
                komut.Parameters.AddWithValue("@d7", TxtAdres.Text);

                // Sorguyu çalıştır ve bağlantıyı kapat
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                // Kullanıcıya bilgilendirme mesajı
                MessageBox.Show("Abone başarıyla eklendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Listeyi yenile
                tumListe();
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıyı bilgilendir
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tumListe();
        }

        public void tumListe()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Musteri_ID,Ad,Soyad,Sifre,Tel_No,Mail,Kayit_Tarihi,Adres From Abone", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.ClearSelection();

            metinKutulariniTemizle();


        }

        private void BtnAboneGuncelle_Click(object sender, EventArgs e)
        {


            SqlCommand komut = new SqlCommand("Update Abone set Ad=@d1,Soyad=@d2,Sifre=@d3,Tel_No=@d4,Mail=@d5,Adres=@d7 where Musteri_ID=@d8", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", TxtAd.Text);
            komut.Parameters.AddWithValue("@d2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", TxtSifre.Text);
            komut.Parameters.AddWithValue("@d4", MskTel.Text);
            komut.Parameters.AddWithValue("@d5", TxtMail.Text);
            //komut.Parameters.AddWithValue("@d6", MskTarih.Text);
            komut.Parameters.AddWithValue("@d7", TxtAdres.Text);
            komut.Parameters.AddWithValue("@d8", TxtAboneID.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgiler Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tumListe();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int selectedRowIndex = e.RowIndex;

            // Eğer tıklanan satır geçerliyse
            if (selectedRowIndex >= 0)
            {
                // DataGridView'deki satırı al
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                // Hücre değerlerini metin kutularına ata
                TxtAboneID.Text = selectedRow.Cells["Musteri_ID"].Value?.ToString();
                TxtAd.Text = selectedRow.Cells["Ad"].Value?.ToString();
                TxtSoyad.Text = selectedRow.Cells["Soyad"].Value?.ToString();
                TxtSifre.Text = selectedRow.Cells["Sifre"].Value?.ToString();
                MskTel.Text = selectedRow.Cells["Tel_No"].Value?.ToString();
                TxtMail.Text = selectedRow.Cells["Mail"].Value?.ToString();
                LblKayit_Tarihi.Text = selectedRow.Cells["Kayit_Tarihi"].Value?.ToString();
                TxtAdres.Text = selectedRow.Cells["Adres"].Value?.ToString();


            }
        }

        private void BtnAboneSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Abone where Musteri_ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAboneID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            tumListe();
        }

        private void BtnSilinmisAboneler_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            groupBox1.Text = "Silinmiş Aboneler";
            SqlDataAdapter da = new SqlDataAdapter("Select * From DeletedAbone", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.ClearSelection();

            metinKutulariniTemizle();

        }

        private void BtnGuncellenmisAbone_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            groupBox1.Text = "Güncellenmiş Aboneler";
            SqlDataAdapter da = new SqlDataAdapter("Select * From UpdatedAbone", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.ClearSelection();

            metinKutulariniTemizle();
        }

        public void metinKutulariniTemizle()
        {
            TxtAboneID.Clear();
            TxtAd.Clear();
            TxtSoyad.Clear();
            TxtSifre.Clear();
            TxtMail.Clear();
            TxtAdres.Clear();
            LblKayit_Tarihi.Visible = false;
            MskTel.Clear();
        }
        private void FilterYoneticiTumAboneler(string filterValue) // Küçük harfle parametre adı düzeltilmiş
        {
            // SqlBaglanti sınıfı üzerinden bağlantıyı alıyoruz.
            SqlConnection connection = bgl.baglanti();

            using (SqlCommand command = new SqlCommand("FilterYoneticiTumAboneler", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Stored procedure parametresini ekliyoruz.
                command.Parameters.AddWithValue("@FilterValue", filterValue); // Doğru parametre adı eşleşiyor

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                try
                {
                    adapter.Fill(dt); // Veriyi DataTable'a dolduruyoruz.
                    dataGridView1.DataSource = dt; // DataGridView'e bağlıyoruz.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    connection.Close(); // Bağlantıyı kapatıyoruz.

                }


            }
        }
        private void FilterYoneticiTumAbonelerAd(string filterValue) // Küçük harfle parametre adı düzeltilmiş
        {
            // SqlBaglanti sınıfı üzerinden bağlantıyı alıyoruz.
            SqlConnection connection = bgl.baglanti();

            using (SqlCommand command = new SqlCommand("FilterYoneticiTumAbonelerAd", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Stored procedure parametresini ekliyoruz.
                command.Parameters.AddWithValue("@FilterValue", filterValue); // Doğru parametre adı eşleşiyor

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                try
                {
                    adapter.Fill(dt); // Veriyi DataTable'a dolduruyoruz.
                    dataGridView1.DataSource = dt; // DataGridView'e bağlıyoruz.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    connection.Close(); // Bağlantıyı kapatıyoruz.

                }


            }
        }
        private void FilterYoneticiTumAbonelerSoyad(string filterValue) // Küçük harfle parametre adı düzeltilmiş
        {
            // SqlBaglanti sınıfı üzerinden bağlantıyı alıyoruz.
            SqlConnection connection = bgl.baglanti();

            using (SqlCommand command = new SqlCommand("FilterYoneticiTumAbonelerSoyad", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Stored procedure parametresini ekliyoruz.
                command.Parameters.AddWithValue("@FilterValue", filterValue); // Doğru parametre adı eşleşiyor

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                try
                {
                    adapter.Fill(dt); // Veriyi DataTable'a dolduruyoruz.
                    dataGridView1.DataSource = dt; // DataGridView'e bağlıyoruz.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    connection.Close(); // Bağlantıyı kapatıyoruz.

                }


            }
        }
        private void FilterYoneticiTumAbonelerTel_No(string filterValue) // Küçük harfle parametre adı düzeltilmiş
        {
            // SqlBaglanti sınıfı üzerinden bağlantıyı alıyoruz.
            SqlConnection connection = bgl.baglanti();

            using (SqlCommand command = new SqlCommand("FilterYoneticiTumAbonelerTel_No", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Stored procedure parametresini ekliyoruz.
                command.Parameters.AddWithValue("@FilterValue", filterValue); // Doğru parametre adı eşleşiyor

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                try
                {
                    adapter.Fill(dt); // Veriyi DataTable'a dolduruyoruz.
                    dataGridView1.DataSource = dt; // DataGridView'e bağlıyoruz.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    connection.Close(); // Bağlantıyı kapatıyoruz.

                }


            }
        }
        private void FilterYoneticiTumAbonelerMail(string filterValue) // Küçük harfle parametre adı düzeltilmiş
        {
            // SqlBaglanti sınıfı üzerinden bağlantıyı alıyoruz.
            SqlConnection connection = bgl.baglanti();

            using (SqlCommand command = new SqlCommand("FilterYoneticiTumAbonelerMail", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Stored procedure parametresini ekliyoruz.
                command.Parameters.AddWithValue("@FilterValue", filterValue); // Doğru parametre adı eşleşiyor

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                try
                {
                    adapter.Fill(dt); // Veriyi DataTable'a dolduruyoruz.
                    dataGridView1.DataSource = dt; // DataGridView'e bağlıyoruz.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    connection.Close(); // Bağlantıyı kapatıyoruz.

                }


            }
        }
        private void FilterYoneticiTumAbonelerAdres(string filterValue) // Küçük harfle parametre adı düzeltilmiş
        {
            // SqlBaglanti sınıfı üzerinden bağlantıyı alıyoruz.
            SqlConnection connection = bgl.baglanti();

            using (SqlCommand command = new SqlCommand("FilterYoneticiTumAbonelerAdres", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Stored procedure parametresini ekliyoruz.
                command.Parameters.AddWithValue("@FilterValue", filterValue); // Doğru parametre adı eşleşiyor

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                try
                {
                    adapter.Fill(dt); // Veriyi DataTable'a dolduruyoruz.
                    dataGridView1.DataSource = dt; // DataGridView'e bağlıyoruz.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    connection.Close(); // Bağlantıyı kapatıyoruz.

                }


            }
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            string filterValue = TxtArama.Text.Trim(); // Metin kutusundaki değeri alıyoruz.

            // Eğer metin kutusu boşsa kullanıcıyı uyarabiliriz
            if (string.IsNullOrEmpty(filterValue))
            {
                MessageBox.Show("Lütfen bir arama kriteri giriniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FilterYoneticiTumAboneler(filterValue); // Arama işlemini başlatıyoruz.
        }
        private void ExportToPDF(DataTable dataTable, string filePath)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();

            // Başlık
            document.Add(new Paragraph("Dergi Tablosu"));
            document.Add(new Paragraph(" "));

            // PDF tablosu oluştur
            PdfPTable pdfTable = new PdfPTable(dataTable.Columns.Count);
            foreach (DataColumn column in dataTable.Columns)
            {
                pdfTable.AddCell(new Phrase(column.ColumnName));
            }

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var cell in row.ItemArray)
                {
                    pdfTable.AddCell(new Phrase(cell.ToString()));
                }
            }

            document.Add(pdfTable);
            document.Close();
        }

        private static string GetDesktopPDFDirectory()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string pdfFolderPath = Path.Combine(desktopPath, "PDF");

            if (!Directory.Exists(pdfFolderPath))
            {
                Directory.CreateDirectory(pdfFolderPath);
            }

            return pdfFolderPath;
        }

        private void GeneratePDF(string tableName, DataTable dataTable)
        {
            // Masaüstündeki "PDF" klasörünü al
            string pdfDirectory = GetDesktopPDFDirectory(); // Burada çağırıyorsunuz

            // Dosya adını belirle
            string filePath = Path.Combine(pdfDirectory, $"{tableName}.pdf");

            // Eğer tablo doluysa PDF oluştur
            if (dataTable.Rows.Count > 0)
            {
                ExportToPDF(dataTable, filePath);
                MessageBox.Show($"{tableName}.pdf başarıyla oluşturuldu ve Masaüstü'ndeki PDF klasörüne yedeği kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{tableName} tablosu boş, dışa aktarılacak veri yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private DataTable TümAboneler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Musteri_ID,Ad,Soyad,Sifre,Tel_No,Mail,Kayit_Tarihi,Adres From Abone", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            return dt;
        }

        private DataTable GüncellenmişAboneler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From UpdatedAbone", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            return dt;
        }

        private DataTable SilinmişAboneler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From DeletedAbone", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            return dt;
        }

        private void tümAbonelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedMenuItem = ((ToolStripMenuItem)sender).Text;
            DataTable dataTable = new DataTable();

            dataTable = TümAboneler(); // Tüm dergileri döndüren metod
            if (dataTable.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF dosyası (*.pdf)|*.pdf";
                saveFileDialog.Title = "PDF olarak dışa aktar";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToPDF(dataTable, saveFileDialog.FileName);
                    MessageBox.Show("PDF başarıyla oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Tablo boş, dışa aktarılacak veri yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            GeneratePDF("TümAboneler", dataTable);
        }

        private void güncellenmişAbonelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedMenuItem = ((ToolStripMenuItem)sender).Text;
            DataTable dataTable = new DataTable();

            dataTable = GüncellenmişAboneler(); // Tüm dergileri döndüren metod
            if (dataTable.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF dosyası (*.pdf)|*.pdf";
                saveFileDialog.Title = "PDF olarak dışa aktar";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToPDF(dataTable, saveFileDialog.FileName);
                    MessageBox.Show("PDF başarıyla oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Tablo boş, dışa aktarılacak veri yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            GeneratePDF("GüncellenmişAboneler", dataTable);
        }

        private void silinmişAbonelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedMenuItem = ((ToolStripMenuItem)sender).Text;
            DataTable dataTable = new DataTable();

            dataTable = SilinmişAboneler(); // Tüm dergileri döndüren metod
            if (dataTable.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF dosyası (*.pdf)|*.pdf";
                saveFileDialog.Title = "PDF olarak dışa aktar";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToPDF(dataTable, saveFileDialog.FileName);
                    MessageBox.Show("PDF başarıyla oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Tablo boş, dışa aktarılacak veri yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            GeneratePDF("SilinmişAboneler", dataTable);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filterValue = TxtArama.Text.Trim(); // Metin kutusundaki değeri alıyoruz.

            // Eğer metin kutusu boşsa kullanıcıyı uyarabiliriz
            if (string.IsNullOrEmpty(filterValue))
            {
                MessageBox.Show("Lütfen bir arama kriteri giriniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FilterYoneticiTumAbonelerAd(filterValue); // Arama işlemini başlatıyoruz.
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string filterValue = TxtArama.Text.Trim(); // Metin kutusundaki değeri alıyoruz.

            // Eğer metin kutusu boşsa kullanıcıyı uyarabiliriz
            if (string.IsNullOrEmpty(filterValue))
            {
                MessageBox.Show("Lütfen bir arama kriteri giriniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FilterYoneticiTumAbonelerSoyad(filterValue); // Arama işlemini başlatıyoruz.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filterValue = TxtArama.Text.Trim(); // Metin kutusundaki değeri alıyoruz.

            // Eğer metin kutusu boşsa kullanıcıyı uyarabiliriz
            if (string.IsNullOrEmpty(filterValue))
            {
                MessageBox.Show("Lütfen bir arama kriteri giriniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FilterYoneticiTumAbonelerTel_No(filterValue); // Arama işlemini başlatıyoruz.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filterValue = TxtArama.Text.Trim(); // Metin kutusundaki değeri alıyoruz.

            // Eğer metin kutusu boşsa kullanıcıyı uyarabiliriz
            if (string.IsNullOrEmpty(filterValue))
            {
                MessageBox.Show("Lütfen bir arama kriteri giriniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FilterYoneticiTumAbonelerMail(filterValue); // Arama işlemini başlatıyoruz.
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string filterValue = TxtArama.Text.Trim(); // Metin kutusundaki değeri alıyoruz.

            // Eğer metin kutusu boşsa kullanıcıyı uyarabiliriz
            if (string.IsNullOrEmpty(filterValue))
            {
                MessageBox.Show("Lütfen bir arama kriteri giriniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FilterYoneticiTumAbonelerAdres(filterValue); // Arama işlemini başlatıyoruz.
        }
    }
}
