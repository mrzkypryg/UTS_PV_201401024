using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KasirBaru_Pertemuan6
{
    internal class Koneksi1
    {
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection
            {
                ConnectionString = "Data Source=DESKTOP-I8ILPVI\\SQLEXPRESS;Initial Catalog=Kasir;Integrated Security=True"
            };
            return Conn;

        }
    }
}
