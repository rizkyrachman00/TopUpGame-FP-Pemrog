using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.
using System.Data.SqlClient;


namespace TopUpGame.Model.Context
{
    internal class KoneksiDB
    {
        //2. koneksi SQL server
        public SqlConnection GetConn()
        {
            string lokasi = Directory.GetCurrentDirectory() + @"\Model\Repository\DB_TopUpGame.mdf" ;

            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+lokasi+";Integrated Security=True";

            return Conn;

        }
    }
}
