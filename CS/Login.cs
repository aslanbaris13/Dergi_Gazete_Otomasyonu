namespace Dergi_Gazete_Abonelik
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnKullanici_Click(object sender, EventArgs e)
        {
            Kullanici_Girisi fr = new Kullanici_Girisi();
            fr.Show();
            this.Hide();
        }

        private void BtnYonetici_Click(object sender, EventArgs e)
        {
            Yonetici_Girisi fr = new Yonetici_Girisi();
            fr.Show();
            this.Hide();
        }

        private void LblKapat_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}