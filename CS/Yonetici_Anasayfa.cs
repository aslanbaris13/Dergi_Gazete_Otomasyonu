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
using System.IO;


namespace Dergi_Gazete_Abonelik
{
    public partial class Yonetici_Anasayfa : Form
    {
        public Yonetici_Anasayfa()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        public string AD;




        private void LblKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Login fr = new Login();
            fr.Show();
            this.Hide();
        }

        private void Yonetici_Anasayfa_Load(object sender, EventArgs e)
        {




            LblPersonelAd.Text = AD;

            if (LblPersonelAd.Text.ToString() == "Admin")
            {
                panel1.Visible = true;  // Kullanıcı adı "Admin" ise panel1 gözüksün
            }
            else
            {
                panel1.Visible = false;  // Diğer kullanıcılar için panel1 gizlensin
            }

            SqlCommand komut = new SqlCommand("Select Admin_Ad From Admin where Admin_Ad=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblPersonelAd.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblPersonelAd.Text = dr[0] + " ";

            }
            bgl.baglanti().Close();
        }

        private void BtnAboneİslemleri_Click(object sender, EventArgs e)
        {
            Yonetici_Abone_İslemleri fr = new Yonetici_Abone_İslemleri();
            fr.Show();
            //this.Hide();
        }

        private void BtnDergilerim_Click(object sender, EventArgs e)
        {
            Yonetici_Dergi fr = new Yonetici_Dergi();
            fr.Show();
            //this.Hide();
        }

        private void BtnGazetelerim_Click(object sender, EventArgs e)
        {
            Yonetici_Gazete fr = new Yonetici_Gazete();
            fr.Show();
            //this.Hide();
        }

        private void BtnYedekle_Click(object sender, EventArgs e)
        {
            try
            {
                // SQL bağlantı dizesi
                string connectionString = "Server=DESKTOP-KBTUU42\\SQLEXPRESS;Database=Dergi_Gazete;Integrated Security=True;";

                // Yedekleme dosyasının kaydedileceği konumu ayarlar.
                string backupFolder = @"C:\DatabaseBackups"; // Yedek dosyasının tutulacağı klasör
                if (!Directory.Exists(backupFolder))
                {
                    Directory.CreateDirectory(backupFolder); // Klasör yoksa oluşturur.
                }
                string backupFileName = Path.Combine(backupFolder, $"Backup_{DateTime.Now:yyyyMMdd_HHmmss}.bak");

                // SQL yedekleme komutu
                // "WITH INIT" parametresi kullanarak eski yedek dosyasının üzerine yazılmasını sağlar.
                string backupQuery = $"BACKUP DATABASE [Dergi_Gazete] TO DISK = '{backupFileName}' WITH INIT";

                // SQL bağlantısı ve komut çalıştırır.
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(backupQuery, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                }

                // Başarılı mesajı
                MessageBox.Show($"Veritabanı başarıyla yedeklendi.\nDosya Konumu: {backupFileName}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Hata mesajı
                MessageBox.Show($"Yedekleme sırasında bir hata oluştu:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnPersonelİslemleri_Click(object sender, EventArgs e)
        {
            Yonetici_Personel_Islemleri fr = new Yonetici_Personel_Islemleri();
            fr.Show();
            //this.Hide();
        }

        private void BtnYedektenDon_Click(object sender, EventArgs e)
        {
            try
            {
                // SQL bağlantı dizesi
                string connectionString = "Server=DESKTOP-KBTUU42\\SQLEXPRESS;Database=master;Integrated Security=True;";  // master veritabanını kullanıyoruz

                // Kullanıcıya yedek dosyasını seçtirmek için OpenFileDialog kullanıyoruz
                OpenFileDialog openFileDialog = new OpenFileDialog();
                // openFileDialog.Filter = "Yedek Dosyaları (.bak)|.bak"; // sadece .bak dosyalarını gösterir.
                openFileDialog.Filter = "Yedek Dosyaları (*.bak)|*.bak|Tüm Dosyalar (*.*)|*.*";
                openFileDialog.Title = "Yedek Dosyasını Seçin";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string backupFile = openFileDialog.FileName;  // Kullanıcının seçtiği dosya yolu

                    // Geri yükleme komutu
                    string restoreQuery = $"RESTORE DATABASE [Dergi_Gazete] FROM DISK = '{backupFile}' WITH REPLACE;";

                    // SQL bağlantısı ve komut çalıştırır.
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(restoreQuery, connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    // Başarılı mesajı
                    MessageBox.Show($"Veritabanı başarıyla geri yüklendi.\nYedek Dosyası: {backupFile}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Hata mesajı
                MessageBox.Show($"Yedekten dönme sırasında bir hata oluştu:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
