using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace Frm_Giris
{
    class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            string sql = ConfigurationManager.ConnectionStrings["Frm_Giris.Properties.Settings.StokKontrolConnectionString"].ConnectionString;
            SqlConnection connect = new SqlConnection(sql);
            connect.Open();
            return connect;

        }
    }
}
