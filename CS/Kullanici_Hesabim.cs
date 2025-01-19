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
    public partial class Kullanici_Hesabim : Form
    {
        public Kullanici_Hesabim()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        public string Ad;
        
            


        private void Kullanici_Hesabim_Load(object sender, EventArgs e)
        {

            TxtAd.Text = Ad;

            SqlCommand komut = new SqlCommand("Select Musteri_ID,Ad,Soyad,Sifre,Tel_No,Mail,Kayit_Tarihi,Adres From Abone where Ad=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", TxtAd.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAboneID.Text = dr[0] + " ";
                TxtAd.Text = dr[1] + " ";
                TxtSoyad.Text = dr[2] + " ";
                TxtSifre.Text = dr[3] + " ";
                MskTelNo.Text = dr[4] + " ";
                TxtMail.Text = dr[5] + " ";
                LblKayit_Tarihi.Text = dr[6] + " ";
                TxtAdres.Text = dr[7] + " ";


            }
            bgl.baglanti().Close();

            //try
            //{
            //    // Kullanıcı adı üzerinden bilgileri getirme
            //    SqlCommand komut = new SqlCommand(
            //        "SELECT Musteri_ID, Ad, Soyad, Sifre, Tel_No, Mail, Kayit_Tarihi, Adres FROM Abone WHERE Ad = @p2",
            //        bgl.baglanti()
            //    );

            //    komut.Parameters.AddWithValue("@p2", Ad); // Ad değişkeni, giriş yapan kullanıcının adı olmalı.
            //    SqlDataReader dr = komut.ExecuteReader();

            //    if (dr.Read())
            //    {
            //        TxtAboneID.Text = dr["Musteri_ID"].ToString();
            //        TxtAd.Text = dr["Ad"].ToString();
            //        TxtSoyad.Text = dr["Soyad"].ToString();
            //        TxtSifre.Text = dr["Sifre"].ToString();
            //        MskTelNo.Text = dr["Tel_No"].ToString();
            //        TxtMail.Text = dr["Mail"].ToString();
            //        MskKayitTarihi.Text = dr["Kayit_Tarihi"].ToString();
            //        TxtAdres.Text = dr["Adres"].ToString();
            //    }
            //    dr.Close();
            //    bgl.baglanti().Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}





        }

        private void btnbilgilerimigüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Abone set Ad=@d1,Soyad=@d2,Sifre=@d3,Tel_No=@d4,Mail=@d5, Adres=@d6 where Musteri_ID=@d7", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", TxtAd.Text);
            komut.Parameters.AddWithValue("@d2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", TxtSifre.Text);
            komut.Parameters.AddWithValue("@d4", MskTelNo.Text);
            komut.Parameters.AddWithValue("@d5", TxtMail.Text);
            //komut.Parameters.AddWithValue("@d6", MskKayitTarihi.Text.ToString());
            komut.Parameters.AddWithValue("@d6", TxtAdres.Text);
            komut.Parameters.AddWithValue("@d7", TxtAboneID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Kullanici_Girisi fr = new Kullanici_Girisi();
            fr.Show();
            this.Hide();
        }

        private void LblKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LblAdSoyad_Click(object sender, EventArgs e)
        {

        }

        private void BtnHesabimiSil_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show(
                "Hesabınızı silmek istediğinize emin misiniz? Bu işlem geri alınamaz.",
                "Hesap Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );


            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection baglanti = bgl.baglanti())
                    {

                        string query = "DELETE FROM Abone WHERE Musteri_ID = @Musteri_ID";


                        using (SqlCommand komut = new SqlCommand(query, baglanti))
                        {

                            komut.Parameters.AddWithValue("@Musteri_ID", TxtAboneID.Text);


                            int sonuc = komut.ExecuteNonQuery();

                            if (sonuc > 0)
                            {
                                MessageBox.Show("Hesabınız başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                Kullanici_Girisi fr = new Kullanici_Girisi();
                                fr.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Hesap silme başarısız oldu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //            DialogResult dialogResult = MessageBox.Show(
                //    "Hesabınızı silmek istediğinize emin misiniz? Bu işlem geri alınamaz.",
                //    "Hesap Silme Onayı",
                //    MessageBoxButtons.YesNo,
                //    MessageBoxIcon.Warning
                //);

                //            if (dialogResult == DialogResult.Yes)
                //            {
                //                try
                //                {
                //                    using (SqlConnection baglanti = bgl.baglanti())
                //                    {
                //                        // İlk olarak, SatınAlınanDergi tablosundaki ilişkili kayıtları sil
                //                        string deleteSatinalinanDergiQuery = "DELETE FROM SatınAlınanDergi WHERE Musteri_ID = @Musteri_ID";
                //                        using (SqlCommand komut = new SqlCommand(deleteSatinalinanDergiQuery, baglanti))
                //                        {
                //                            komut.Parameters.AddWithValue("@Musteri_ID", TxtAboneID.Text);
                //                            komut.ExecuteNonQuery();
                //                        }

                //                        // Daha sonra, Abone kaydını sil
                //                        string deleteAboneQuery = "DELETE FROM Abone WHERE Musteri_ID = @Musteri_ID";
                //                        using (SqlCommand komut = new SqlCommand(deleteAboneQuery, baglanti))
                //                        {
                //                            komut.Parameters.AddWithValue("@Musteri_ID", TxtAboneID.Text);

                //                            int sonuc = komut.ExecuteNonQuery();

                //                            if (sonuc > 0)
                //                            {
                //                                MessageBox.Show("Hesabınız başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //                                Kullanici_Girisi fr = new Kullanici_Girisi();
                //                                fr.Show();
                //                                this.Close();
                //                            }
                //                            else
                //                            {
                //                                MessageBox.Show("Hesap silme başarısız oldu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //                            }
                //                        }
                //                    }
                //                }
                //                catch (Exception ex)
                //                {
                //                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //                }
                //            }
            }
        }

        private void BtnDergilerim_Click(object sender, EventArgs e)
        {
            Dergi fr = new Dergi();
            fr.AboneID = TxtAboneID.Text;
            fr.Show();
            //this.Hide();
        }

        private void BtnGazetelerim_Click(object sender, EventArgs e)
        {
            Gazete fr = new Gazete();
            fr.AboneID= TxtAboneID.Text;
            fr.Show();
            //this.Hide();
        }

        private void Kullanici_Hesabim_Activated(object sender, EventArgs e)
        {
            // Sayfa aktif olduğunda, verileri tekrar yükle
            Kullanici_Hesabim_Load(sender, e);
        }
    }
}
