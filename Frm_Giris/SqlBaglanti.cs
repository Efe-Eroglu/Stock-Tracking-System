//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.Sql;
//using System.Data.SqlClient;
//using System.Configuration;

//namespace Frm_Giris
//{
//    class SqlBaglanti
//    {
//        public SqlConnection baglanti()
//        {
//            string sql = ConfigurationManager.ConnectionStrings["Frm_Giris.Properties.Settings.StokKontrolConnectionString"].ConnectionString;
//            SqlConnection connect = new SqlConnection(sql);
//            connect.Open();
//            return connect;

//        }
//    }
//}

using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Frm_Giris
{
    class SqlBaglanti
    {
        private static SqlBaglanti _instance;
        private SqlConnection _connection;

        private SqlBaglanti() { }

        public static SqlBaglanti Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SqlBaglanti();
                }
                return _instance;
            }
        }

        public SqlConnection Baglanti()
        {
            if (_connection == null)
            {
                string sql = ConfigurationManager.ConnectionStrings["Frm_Giris.Properties.Settings.StokKontrolConnectionString"].ConnectionString;
                _connection = new SqlConnection(sql);
                _connection.Open();
            }
            return _connection;
        }
    }
}

