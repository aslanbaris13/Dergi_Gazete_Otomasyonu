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

namespace Dergi_Gazete_Abonelik
{
    public partial class Yonetici_Personel_Islemleri : Form
    {
        public Yonetici_Personel_Islemleri()
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
        public void tumListePersonel()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Admin", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            metinKutulariniTemizle();
        }

        private void LblKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tumListePersonel();
        }

        private void btnpersonelekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Admin (Admin_Ad,Admin_Sifre) values (@d1,@d2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", TxtPersonelAdı.Text);
            komut.Parameters.AddWithValue("@d2", TxtPersonelSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tumListePersonel();
            dataGridView1.ClearSelection();
        }

        private void btnpersonelsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Admin where Admin_ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtpersonelID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            tumListePersonel();
            dataGridView1.ClearSelection();
        }

        private void btnpersonelguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Admin set Admin_Ad=@d1,Admin_Sifre=@d2 where Admin_ID=@d5", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", TxtPersonelAdı.Text);
            komut.Parameters.AddWithValue("@d2", TxtPersonelSifre.Text);
            komut.Parameters.AddWithValue("@d5", TxtpersonelID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tumListePersonel();
            dataGridView1.ClearSelection();
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
                TxtpersonelID.Text = selectedRow.Cells["Admin_ID"].Value?.ToString();
                TxtPersonelAdı.Text = selectedRow.Cells["Admin_Ad"].Value?.ToString();
                TxtPersonelSifre.Text = selectedRow.Cells["Admin_Sifre"].Value?.ToString();


            }
        }

        private void Yonetici_Personel_Islemleri_Load(object sender, EventArgs e)
        {
            tumListePersonel();
            dataGridView1.ClearSelection();
        }

        public void metinKutulariniTemizle()
        {
            TxtpersonelID.Clear();
            TxtPersonelAdı.Clear();
            TxtPersonelSifre.Clear();
        }
    }
}
