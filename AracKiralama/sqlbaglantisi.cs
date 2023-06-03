using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AracKiralama
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-3G5S0FO\\SQLEXPRESS;Initial Catalog=PrjAracKiralama;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
