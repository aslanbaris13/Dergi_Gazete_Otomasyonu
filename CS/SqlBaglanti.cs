using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dergi_Gazete_Abonelik
{


    internal class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-KBTUU42\\SQLEXPRESS;Initial Catalog=Dergi_Gazete;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }
    }
}
