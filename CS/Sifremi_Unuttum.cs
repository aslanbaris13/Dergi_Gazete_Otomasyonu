using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Dergi_Gazete_Abonelik
{
    public partial class Sifremi_Unuttum : Form
    {
        SqlBaglanti bgl = new SqlBaglanti(); // SqlBaglanti sınıfı kullanılıyor
        public Sifremi_Unuttum()
        {
            InitializeComponent();
        }

        private void Sifremi_Unuttum_Load(object sender, EventArgs e)
        {

        }

        private void btnmailgonder_Click(object sender, EventArgs e)
        {
            string userMail = txtmail.Text.Trim(); // Kullanıcının girdiği e-posta
            if (string.IsNullOrEmpty(userMail))
            {
                MessageBox.Show("Lütfen e-posta adresinizi giriniz.");
                return;
            }

            // SQL bağlantısı
            using (SqlConnection connection = bgl.baglanti())
            {
                try
                {

                    string query = "SELECT Ad, Sifre FROM Abone WHERE Mail = @Mail";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Mail", userMail);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string userName = reader["Ad"].ToString();
                        string userPassword = reader["Sifre"].ToString();

                        // Kullanıcıya mail gönder
                        SendMail(userMail, userName, userPassword);
                        MessageBox.Show("Şifreniz e-posta adresinize gönderildi.");
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı bulunamadı. Lütfen geçerli bir e-posta adresi giriniz.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close(); // Bağlantıyı kapat
                    }
                }
            }
        }
        private void SendMail(string userMail, string userName, string userPassword)
        {
       
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("dergigazete81@gmail.com"); // Gönderen e-posta
                mail.To.Add(userMail); // Alıcı e-posta
                mail.Subject = "Şifre Hatırlatma";
                mail.Body = $"Merhaba {userName},\nŞifreniz: {userPassword}\nİyi günler dileriz.";

                smtpServer.Port = 587;
                smtpServer.Credentials = new System.Net.NetworkCredential("dergigazete81@gmail.com", "amci bxiw jtwl ckqs"); // App password
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);
                MessageBox.Show("E-posta başarıyla gönderildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail gönderilirken hata oluştu: " + ex.Message);
            }

        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Kullanici_Girisi fr = new Kullanici_Girisi();
            fr.Show();
            this.Close();
        }

        private void LblKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Enter tuşuna basıldıysa
            {
                string userMail = txtmail.Text.Trim(); // Kullanıcının girdiği e-posta
                if (string.IsNullOrEmpty(userMail))
                {
                    MessageBox.Show("Lütfen e-posta adresinizi giriniz.");
                    return;
                }

                // SQL bağlantısı
                using (SqlConnection connection = bgl.baglanti())
                {
                    try
                    {

                        string query = "SELECT Ad, Sifre FROM Abone WHERE Mail = @Mail";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Mail", userMail);

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            string userName = reader["Ad"].ToString();
                            string userPassword = reader["Sifre"].ToString();

                            // Kullanıcıya mail gönder
                            SendMail(userMail, userName, userPassword);
                            MessageBox.Show("Şifreniz e-posta adresinize gönderildi.");
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı bulunamadı. Lütfen geçerli bir e-posta adresi giriniz.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close(); // Bağlantıyı kapat
                        }
                    }
                }
            }
        }
    }
}

