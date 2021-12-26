using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Market_Form
{
    class Sql_Baglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=MERTU;Initial Catalog=deneme;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
        

    }
}
