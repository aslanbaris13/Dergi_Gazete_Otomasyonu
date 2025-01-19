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

namespace Dergi_Gazete_Abonelik
{
    public partial class Gazete : Form
    {
        public Gazete()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();



        private void BtnGeri_Click(object sender, EventArgs e)
        {
            paneldergisil.Visible = false;

            //Kullanici_Hesabim fr = new Kullanici_Hesabim();
            //fr.Show();
            this.Hide();
        }

        private void LblKapat_Click(object sender, EventArgs e)
        {
            paneldergisil.Visible = false;

            Application.Exit();


        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Seçilen satırın indeksi
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
                TxtGazeteUcret.Text = selectedRow.Cells["Gazete_Ucret"].Value?.ToString();
                TxtGazeteYayinEvi.Text = selectedRow.Cells["Gazete_Yayin_evi"].Value?.ToString();



            }
        }

        private void btnsatınal_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            paneldergisil.Visible = false;
            groupBox2.Text = "Gazeteler";
            // Kullanıcıdan alınan değerler
            int musteriID = Convert.ToInt32(txtAbone_ID.Text);
            int GazeteBarkodID = Convert.ToInt32(TxtGazeteBarkodID.Text);

            // SQL bağlantısını SqlBaglanti sınıfı üzerinden alıyoruz
            using (SqlConnection connection = bgl.baglanti())
            {
                try
                {
                    // Daha önce satın alınıp alınmadığını kontrol eden sorgu
                    string checkQuery = "SELECT COUNT(*) FROM SatınAlınanGazete WHERE Musteri_ID = @MusteriID AND Gazete_Barkod_ID = @GazeteBarkodID";

                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        // Parametreleri ata
                        checkCommand.Parameters.AddWithValue("@MusteriID", musteriID);
                        checkCommand.Parameters.AddWithValue("@GazeteBarkodID", GazeteBarkodID);

                        // Kayıt var mı kontrol et
                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (count > 0)
                        {
                            // Dergi zaten satın alınmış
                            MessageBox.Show("Bu gazete zaten satın alınmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // İşlemi sonlandır
                        }
                    }

                    // Eğer dergi daha önce alınmamışsa satın alma işlemini gerçekleştir
                    string insertQuery = "INSERT INTO SatınAlınanGazete (Musteri_ID, Gazete_Barkod_ID) VALUES (@MusteriID, @GazeteBarkodID)";

                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        // Parametreleri ata
                        insertCommand.Parameters.AddWithValue("@MusteriID", musteriID);
                        insertCommand.Parameters.AddWithValue("@GazeteBarkodID", GazeteBarkodID);

                        // Sorguyu çalıştır
                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        // Başarılı mesajı
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Satın alma işlemi başarıyla tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Satın alma işlemi başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hata mesajı
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dataGridView1.ClearSelection();
                metinKutulariniTemizle();
            }
        }
        public string AboneID;
        private void Gazete_Load(object sender, EventArgs e)
        {   panel1.Visible = true;
            paneldergisil.Visible = false;
            txtAbone_ID.Text = AboneID;
            SqlDataAdapter da = new SqlDataAdapter("Select * From Gazete", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            SqlCommand komut = new SqlCommand("Select Musteri_ID From Abone where Musteri_ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAbone_ID.Text);
            SqlDataReader dr = komut.ExecuteReader();

            dataGridView1.ClearSelection();
        }

        private void btntumgazeteler_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            paneldergisil.Visible = false;

            // DataGridView'deki seçili satırı al
            if (dataGridView1.CurrentRow != null || dataGridView1.CurrentRow == null)
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From Gazete", bgl.baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;

                // Hücre değerlerini metin kutularına ata
                TxtGazeteBarkodID.Text = selectedRow.Cells["Gazete_Barkod_ID"].Value?.ToString();
                TxtGazeteAd.Text = selectedRow.Cells["Gazete_Ad"].Value?.ToString();
                TxtGazeteTuru.Text = selectedRow.Cells["Gazete_Tur"].Value?.ToString();
                TxtGazeteUcret.Text = selectedRow.Cells["Gazete_Ucret"].Value?.ToString();
                TxtGazeteYayinEvi.Text = selectedRow.Cells["Gazete_Yayin_evi"].Value?.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen bir dergi seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataGridView1.ClearSelection();
            metinKutulariniTemizle();
        }

        private void btngazetelerim_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            paneldergisil.Visible = true;
            groupBox2.Text = "Gazetelerim";
            // Kullanıcıdan alınan Abone ID
            int musteriID = Convert.ToInt32(txtAbone_ID.Text);

            // SQL sorgusu
            string query = @"
        SELECT 
            d.Gazete_Barkod_ID AS [Gazete_Barkod_ID], 
            d.Gazete_Ad AS [Gazete_Ad], 
            d.Gazete_Tur AS [Gazete_Tur], 
            d.Gazete_Ucret AS [Gazete_Ucret], 
            d.Gazete_Yayin_evi AS [Gazete_Yayin_evi]
        FROM 
            SatınAlınanGazete s 
        INNER JOIN 
            Gazete d 
        ON 
            s.Gazete_Barkod_ID = d.Gazete_Barkod_ID 
        WHERE 
            s.Musteri_ID = @MusteriID";

            // Bağlantı sınıfını kullanıyoruz
            SqlBaglanti bgl = new SqlBaglanti();

            using (SqlConnection connection = bgl.baglanti())
            {
                try
                {
                    // SQL Komutu
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametre ata
                        command.Parameters.AddWithValue("@MusteriID", musteriID);

                        // Veriyi almak için SqlDataAdapter kullanıyoruz
                        SqlDataAdapter da = new SqlDataAdapter(command);

                        // DataTable ile verileri DataGridView'de göstermek için hazırlıyoruz
                        System.Data.DataTable dt = new System.Data.DataTable();
                        da.Fill(dt);

                        // DataGridView'e veriyi bağla
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    // Hata mesajı
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dataGridView1.ClearSelection();
                metinKutulariniTemizle();
            }
        }

        private void btngazetesil_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            // DataGridView'de bir satır seçilip seçilmediğini kontrol et
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçilen satırdaki Barkod ID değerini al
                string barkodID = dataGridView1.SelectedRows[0].Cells["Gazete_Barkod_ID"].Value.ToString();

                // Kullanıcıdan alınan Abone ID (müşteri ID)
                int musteriID = Convert.ToInt32(txtAbone_ID.Text);

                // Silme işlemi için SQL sorgusu
                string deleteQuery = @" DELETE FROM SatınAlınanGazete WHERE Musteri_ID = @MusteriID AND Gazete_Barkod_ID = @BarkodID";

                using (SqlConnection connection = bgl.baglanti())
                {
                    try
                    {
                        // SQL komutunu oluştur
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            // Parametreleri ata
                            command.Parameters.AddWithValue("@MusteriID", musteriID);
                            command.Parameters.AddWithValue("@BarkodID", barkodID);

                            // Bağlantıyı aç ve komutu çalıştır
                            //connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            // Silme işlemi başarıyla gerçekleştiyse mesaj göster
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Gazete başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // DataGridView'i güncelle
                                btngazetelerim_Click(null, null); // Dergilerim butonunu tekrar çağır
                            }
                            else
                            {
                                MessageBox.Show("Silme işlemi başarısız oldu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        // Hata mesajı
                        MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Eğer bir satır seçilmediyse kullanıcıyı uyar
                MessageBox.Show("Lütfen silmek istediğiniz gazeteyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataGridView1.ClearSelection();
            metinKutulariniTemizle();

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
            string filterValue = TxtAra.Text.Trim(); // Metin kutusundaki değeri alıyoruz.

            // Eğer metin kutusu boşsa kullanıcıyı uyarabiliriz
            if (string.IsNullOrEmpty(filterValue))
            {
                MessageBox.Show("Lütfen bir arama kriteri giriniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FilterYoneticiTumGazeteler(filterValue); // Arama işlemini başlatıyoruz.
        }

        public void metinKutulariniTemizle()
        {
            TxtGazeteBarkodID.Clear();
            TxtGazeteAd.Clear();
            TxtGazeteTuru.Clear();
            TxtGazeteUcret.Clear();
            TxtGazeteYayinEvi.Clear();
        }
    }
}

