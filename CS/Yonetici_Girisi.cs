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
    public partial class Yonetici_Girisi : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public Yonetici_Girisi()
        {
            InitializeComponent();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Login fr = new Login();
            fr.Show();
            this.Hide();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlBaglanti bgl = new SqlBaglanti();
            SqlCommand komut = new SqlCommand("Select * From Admin Where Admin_Ad=@p1 and Admin_Sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtPersonelAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Yonetici_Anasayfa fr = new Yonetici_Anasayfa();
                fr.AD = TxtPersonelAdi.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Ad veya Şifre", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }

        private void Yonetici_Girisi_Load(object sender, EventArgs e)
        {

        }

        private void LblKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Enter tuşuna basıldıysa
            {
                SqlCommand komut = new SqlCommand("Select * From Admin Where Admin_Ad=@p1 and Admin_Sifre=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtPersonelAdi.Text);
                komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    Yonetici_Anasayfa fr = new Yonetici_Anasayfa();
                    fr.AD = TxtPersonelAdi.Text;
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Ad veya Şifre", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                bgl.baglanti().Close();
            }
        }
    }
}
