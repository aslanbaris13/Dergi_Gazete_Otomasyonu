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

namespace Dergi_Gazete_Abonelik
{
    public partial class Dergi : Form
    {

        public Dergi()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        public string AboneID;

        private void Dergi_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            paneldergisil.Visible = false;
            txtAbone_ID.Text = AboneID;
            SqlDataAdapter da = new SqlDataAdapter("Select * From Dergi", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            SqlCommand komut = new SqlCommand("Select Musteri_ID From Abone where Musteri_ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAbone_ID.Text);
            SqlDataReader dr = komut.ExecuteReader();

            dataGridView1.ClearSelection();


        }


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
                TxtDergiBarkodID.Text = selectedRow.Cells["Dergi_Barkod_ID"].Value?.ToString();
                TxtDergiAd.Text = selectedRow.Cells["Dergi_Ad"].Value?.ToString();
                TxtDergiTuru.Text = selectedRow.Cells["Dergi_Tur"].Value?.ToString();
                TxtUcret.Text = selectedRow.Cells["Dergi_Ucret"].Value?.ToString();
                TxtDergiYayinEvi.Text = selectedRow.Cells["Dergi_Yayin_evi"].Value?.ToString();



            }
        }

        private void btnsatınal_Click(object sender, EventArgs e)
        {
          panel1.Visible = true;
            paneldergisil.Visible = false;

            // Kullanıcıdan alınan değerler
            int musteriID = Convert.ToInt32(txtAbone_ID.Text);
            int dergiBarkodID = Convert.ToInt32(TxtDergiBarkodID.Text);

            // SQL bağlantısını SqlBaglanti sınıfı üzerinden alıyoruz
            using (SqlConnection connection = bgl.baglanti())
            {
                try
                {
                    // Daha önce satın alınıp alınmadığını kontrol eden sorgu
                    string checkQuery = "SELECT COUNT(*) FROM SatınAlınanDergi WHERE Musteri_ID = @MusteriID AND Dergi_Barkod_ID = @DergiBarkodID";

                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        // Parametreleri ata
                        checkCommand.Parameters.AddWithValue("@MusteriID", musteriID);
                        checkCommand.Parameters.AddWithValue("@DergiBarkodID", dergiBarkodID);

                        // Kayıt var mı kontrol et
                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (count > 0)
                        {
                            // Dergi zaten satın alınmış
                            MessageBox.Show("Bu dergi zaten satın alınmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // İşlemi sonlandır
                        }
                    }

                    // Eğer dergi daha önce alınmamışsa satın alma işlemini gerçekleştir
                    string insertQuery = "INSERT INTO SatınAlınanDergi (Musteri_ID, Dergi_Barkod_ID) VALUES (@MusteriID, @DergiBarkodID)";

                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        // Parametreleri ata
                        insertCommand.Parameters.AddWithValue("@MusteriID", musteriID);
                        insertCommand.Parameters.AddWithValue("@DergiBarkodID", dergiBarkodID);

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

        private void btntumdergiler_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

            paneldergisil.Visible = false;
            groupBox2.Text = "Dergiler";

            // DataGridView'deki seçili satırı al
            if (dataGridView1.CurrentRow != null || dataGridView1.CurrentRow == null)
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From Dergi", bgl.baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;

                // Hücre değerlerini metin kutularına ata
                TxtDergiBarkodID.Text = selectedRow.Cells["Dergi_Barkod_ID"].Value?.ToString();
                TxtDergiAd.Text = selectedRow.Cells["Dergi_Ad"].Value?.ToString();
                TxtDergiTuru.Text = selectedRow.Cells["Dergi_Tur"].Value?.ToString();
                TxtUcret.Text = selectedRow.Cells["Dergi_Ucret"].Value?.ToString();
                TxtDergiYayinEvi.Text = selectedRow.Cells["Dergi_Yayin_evi"].Value?.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen bir dergi seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataGridView1.ClearSelection();
            metinKutulariniTemizle();
        }

        private void btndergilerim_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            paneldergisil.Visible = true;
            groupBox2.Text = "Dergilerim";
            // Kullanıcıdan alınan Abone ID
            int musteriID = Convert.ToInt32(txtAbone_ID.Text);

            // SQL sorgusu
            string query = @"
        SELECT 
            d.Dergi_Barkod_ID AS [Dergi_Barkod_ID], 
            d.Dergi_Ad AS [Dergi_Ad], 
            d.Dergi_Tur AS [Dergi_Tur], 
            d.Dergi_Ucret AS [Dergi_Ucret], 
            d.Dergi_Yayin_evi AS [Dergi_Yayin_evi]
        FROM 
            SatınAlınanDergi s 
        INNER JOIN 
            Dergi d 
        ON 
            s.Dergi_Barkod_ID = d.Dergi_Barkod_ID 
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

        private void btndergisil_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            // DataGridView'de bir satır seçilip seçilmediğini kontrol et
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçilen satırdaki Barkod ID değerini al
                string barkodID = dataGridView1.SelectedRows[0].Cells["Dergi_Barkod_ID"].Value.ToString();

                // Kullanıcıdan alınan Abone ID (müşteri ID)
                int musteriID = Convert.ToInt32(txtAbone_ID.Text);

                // Silme işlemi için SQL sorgusu
                string deleteQuery = @" DELETE FROM SatınAlınanDergi WHERE Musteri_ID = @MusteriID AND Dergi_Barkod_ID = @BarkodID";

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
                                MessageBox.Show("Dergi başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // DataGridView'i güncelle
                                btndergilerim_Click(null, null); // Dergilerim butonunu tekrar çağır
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
                MessageBox.Show("Lütfen silmek istediğiniz dergiyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void FilterYoneticiTumDergiler(string filterValue) // Küçük harfle parametre adı düzeltilmiş
        {
            // SqlBaglanti sınıfı üzerinden bağlantıyı alıyoruz.
            SqlConnection connection = bgl.baglanti();

            using (SqlCommand command = new SqlCommand("FilterYoneticiTumDergiler", connection))
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

            FilterYoneticiTumDergiler(filterValue); // Arama işlemini başlatıyoruz.
        }

        public void metinKutulariniTemizle()
        {
            TxtDergiBarkodID.Clear();
            TxtDergiAd.Clear();
            TxtDergiTuru.Clear();
            TxtUcret.Clear();
            TxtDergiYayinEvi.Clear();
        }
    }
}







