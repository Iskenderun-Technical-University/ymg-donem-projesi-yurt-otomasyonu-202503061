using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace YurtOt
{
    public class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-LJ30V5U\\SQLEXPRESS;Initial Catalog=YurtKayit;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
