using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DataBaseProject1
{
    internal class DataBase
    {
        SqlConnection connectionString = new SqlConnection(@"Data Source=DESKTOP-KUCSK9S; Initial Catalog=MyDataBase; Integrated Security=True");

        public void open()
        {
            if (connectionString.State == System.Data.ConnectionState.Closed)
            { connectionString.Open(); }
        }
        public void close()
        {
            if (connectionString.State == System.Data.ConnectionState.Open)
            { connectionString.Close(); }
        }
        public SqlConnection GetConnection() { return connectionString; }
    }
}
