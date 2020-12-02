using System;
using System.Data;
using System.Data.SqlClient;

namespace QLHangHoa3Layers
{
    class DAL
    {
        public SqlConnection GetConnect()
        {
            String connString = @"Data Source=Localhost;Initial Catalog=QLHangHoa;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
        public DataTable GetTable(String sql)
        {
            SqlConnection con = GetConnect();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public void ExecuteNonQuery(String sql)
        {
            SqlConnection con = GetConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
    }
}
