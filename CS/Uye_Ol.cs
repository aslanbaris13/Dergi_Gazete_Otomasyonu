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
    public partial class Uye_Ol : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public Uye_Ol()
        {
            InitializeComponent();
        }



        private void LblKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Kullanici_Girisi fr = new Kullanici_Girisi();
            fr.Show();
            this.Hide();
        }

        private void BtnUyeOl_Click(object sender, EventArgs e)
        {
            //    bgl.baglanti().Open();
            SqlCommand komut = new SqlCommand("insert into  Abone ( Ad,Soyad,Sifre,Tel_No,Mail,Kayit_Tarihi,Adres)  values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p4", MskTel.Text);
            komut.Parameters.AddWithValue("@p5", TxtMail.Text);
            komut.Parameters.AddWithValue("@p6", DateTime.Now);
            komut.Parameters.AddWithValue("@p7", TxtAdres.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Üye Olunmuştur.Şifreniz: " + TxtSifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TxtSoyad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
