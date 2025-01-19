using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;

using DataTable = System.Data.DataTable;
using Application = System.Windows.Forms.Application;
using Excel = Microsoft.Office.Interop.Excel;
using excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;

using ClosedXML.Excel;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Dergi_Gazete_Abonelik
{
    public partial class Yonetici_Gazete : Form
    {
        public Yonetici_Gazete()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            //Yonetici_Anasayfa fr = new Yonetici_Anasayfa();
            //fr.Show();
            this.Hide();
        }

        private void LblKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void tumListeGazete()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Gazete", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.ClearSelection();

            metinKutulariniTemizle();


        }

        private void btntumgazeteler_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            groupBox2.Text = "Gazeteler";
            tumListeGazete();
        }

        private void Yonetici_Gazete_Load(object sender, EventArgs e)
        {
            tumListeGazete();
        }

        private void btngazeteekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Gazete (Gazete_Ad,Gazete_Tur,Gazete_Ucret,Gazete_Yayin_evi) values (@d1,@d2,@d3,@d4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", TxtGazeteAd.Text);
            komut.Parameters.AddWithValue("@d2", TxtGazeteTuru.Text);
            komut.Parameters.AddWithValue("@d3", TxtUcret.Text);
            komut.Parameters.AddWithValue("@d4", TxtGazeteYayinEvi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gazete Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tumListeGazete();
        }

        private void btngazetesil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Gazete where Gazete_Barkod_ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtGazeteBarkodID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gazete Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            tumListeGazete();
        }

        private void btngazeteguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Gazete set Gazete_Ad=@d1,Gazete_Tur=@d2,Gazete_Ucret=@d3,Gazete_Yayin_evi=@d4 where Gazete_Barkod_ID=@d5", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", TxtGazeteAd.Text);
            komut.Parameters.AddWithValue("@d2", TxtGazeteTuru.Text);
            komut.Parameters.AddWithValue("@d3", Convert.ToDecimal(TxtUcret.Text));
            komut.Parameters.AddWithValue("@d4", TxtGazeteYayinEvi.Text);
            komut.Parameters.AddWithValue("@d5", TxtGazeteBarkodID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gazete Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tumListeGazete();
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
                TxtGazeteBarkodID.Text = selectedRow.Cells["Gazete_Barkod_ID"].Value?.ToString();
                TxtGazeteAd.Text = selectedRow.Cells["Gazete_Ad"].Value?.ToString();
                TxtGazeteTuru.Text = selectedRow.Cells["Gazete_Tur"].Value?.ToString();
                TxtUcret.Text = selectedRow.Cells["Gazete_Ucret"].Value?.ToString();
                TxtGazeteYayinEvi.Text = selectedRow.Cells["Gazete_Yayin_evi"].Value?.ToString();

            }
        }

        private void btnsilinmisgazeteler_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            groupBox2.Text = "Silinmiş Gazeteler";
            SqlDataAdapter da = new SqlDataAdapter("Select * From DeletedGazete", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            metinKutulariniTemizle();
        }


        private void btnsatinalinangazeteler_Click(object sender, EventArgs e)
        {
            
            panel1.Visible = false;
            panel2.Visible = false;
            groupBox2.Text = "Satın Alınan Gazeteler";
            try
            {
                using (SqlConnection baglanti = bgl.baglanti()) // Bağlantı nesnesi
                {
                    // SQL sorgusu
                    string query = @"
        SELECT
            S.Satis_No,
            A.Musteri_ID,
            A.Ad,
            A.Soyad,
            G.Gazete_Barkod_ID,
            G.Gazete_Ad,
            G.Gazete_Tur,
            G.Gazete_Ucret,
            G.Gazete_Yayin_evi
        FROM 
            SatınAlınanGazete S
        INNER JOIN 
            Abone A ON S.Musteri_ID = A.Musteri_ID
        INNER JOIN 
            Gazete G ON S.Gazete_Barkod_ID = G.Gazete_Barkod_ID;";

                    // SqlDataAdapter ile veriyi al
                    SqlDataAdapter da = new SqlDataAdapter(query, baglanti);

                    // DataTable oluştur ve veriyi doldur
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // DataGridView'e veriyi ata
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj göster
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            metinKutulariniTemizle();
        }

        public void metinKutulariniTemizle()
        {
            TxtGazeteBarkodID.Clear();
            TxtGazeteAd.Clear();
            TxtGazeteTuru.Clear();
            TxtUcret.Clear();
            TxtGazeteYayinEvi.Clear();
        }
        private void FilterYoneticiTumGazeteler(string filterValue) // Küçük harfle parametre adı düzeltilmiş
        {
            // SqlBaglanti sınıfı üzerinden bağlantıyı alıyoruz.
            SqlConnection connection = bgl.baglanti();

            using (SqlCommand command = new SqlCommand("FilterYoneticiTumGazeteler", connection))
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

            FilterYoneticiTumGazeteler(filterValue); // Arama işlemini başlatıyoruz.
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
        private DataTable TümGazeteler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Gazete", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            return dt;
        }

        private DataTable SatınAlınanGazeteler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From SatınAlınanGazete", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            return dt;
        }

        private DataTable SilinmişGazeteler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From DeletedGazete", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            return dt;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                DataTable dataTable = new DataTable();

                // ClosedXML kullanarak Excel'den veriyi okur.
                using (var workbook = new ClosedXML.Excel.XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet(1); // İlk sayfa
                    bool firstRow = true;

                    foreach (var row in worksheet.RowsUsed())
                    {
                        if (firstRow)
                        {
                            // Excel başlıklarını DataTable'a sütun olarak ekler.
                            foreach (var cell in row.Cells())
                            {
                                dataTable.Columns.Add(cell.Value.ToString());
                            }
                            firstRow = false;
                        }
                        else
                        {
                            // Satır verilerini DataTable'a ekler.
                            dataTable.Rows.Add(row.Cells().Select(c => c.Value.ToString()).ToArray());
                        }
                    }
                }

                // DataGridView'e veriyi yükler.
                dataGridView1.DataSource = dataTable;

                // SQL veritabanına aktarır.
                SqlBaglanti bgl = new SqlBaglanti(); // SqlBaglanti sınıfı ile bağlantı oluşturur.
                using (SqlConnection dbConnection = bgl.baglanti())
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = dbConnection;

                        foreach (DataRow row in dataTable.Rows)
                        {
                            cmd.CommandText = "INSERT INTO Gazete (Gazete_Ad, Gazete_Tur, Gazete_Ucret, Gazete_Yayin_evi) " +
                                              "VALUES ( @Ad, @Tur, @Ucret, @YayinEvi)";

                            // Parametreleri ekler.

                            cmd.Parameters.AddWithValue("@Ad", row["Gazete_Ad"]);
                            cmd.Parameters.AddWithValue("@Tur", row["Gazete_Tur"]);
                            cmd.Parameters.AddWithValue("@Ucret", Convert.ToDecimal(row["Gazete_Ucret"]));
                            cmd.Parameters.AddWithValue("@YayinEvi", row["Gazete_Yayin_evi"]);

                            // Komutu çalıştırır.
                            cmd.ExecuteNonQuery();

                            // Parametreleri temizler.
                            cmd.Parameters.Clear();
                        }
                    }
                }

                MessageBox.Show("Veriler başarıyla veritabanına aktarıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application app = new Excel.Application();
                app.Visible = true;
                Excel.Workbook kitap = app.Workbooks.Add(System.Reflection.Missing.Value);
                Excel.Worksheet sayfa = (Excel.Worksheet)kitap.Sheets[1];

                // Sütun başlıklarını Excel'e yazdırır.
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    Excel.Range alan = (Excel.Range)sayfa.Cells[1, i + 1];
                    alan.Value = dataGridView1.Columns[i].HeaderText;
                }

                // Satır verilerini Excel'e yazdırır.
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        Excel.Range alan = (Excel.Range)sayfa.Cells[i + 2, j + 1];
                        alan.Value = dataGridView1[j, i].Value?.ToString();
                    }
                }

                MessageBox.Show("Veriler Excel'e başarıyla aktarıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler Excel'e aktarılamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tümGazetelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedMenuItem = ((ToolStripMenuItem)sender).Text;
            DataTable dataTable = new DataTable();

            dataTable = TümGazeteler(); // Tüm dergileri döndüren metod
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
            GeneratePDF("TümGazeteler", dataTable);
        }

        private void satınAlınanGazetelerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string selectedMenuItem = ((ToolStripMenuItem)sender).Text;
            DataTable dataTable = new DataTable();

            dataTable = SatınAlınanGazeteler(); // Tüm dergileri döndüren metod
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
            GeneratePDF("SatınAlınanGazeteler", dataTable);
        }

        private void silinmişGazetelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedMenuItem = ((ToolStripMenuItem)sender).Text;
            DataTable dataTable = new DataTable();

            dataTable = SilinmişGazeteler(); // Tüm dergileri döndüren metod
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
            GeneratePDF("SilinmişGazeteler", dataTable);
        }
    }
}
