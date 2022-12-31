using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Frm_Giris
{
    class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection connect = new SqlConnection("Data Source=LAPTOP-PSSP83FQ\\SQLEXPRESS;Initial Catalog=StokKontrol;Integrated Security=True");
            connect.Open();
            return connect;

        }
    }
}
