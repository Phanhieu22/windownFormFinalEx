using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using IdGen;


namespace QL_thuoc
{
    class connect
    {
        private static string stringConnection = @"Data Source=DESKTOP-Q285043;Initial Catalog=QL_ban_thuoc;Integrated Security=True";
        public static SqlConnection createConnect()
        {
            SqlConnection conn = new SqlConnection(stringConnection);
            conn.Open();
            return conn;
        }

        public static void execution(string sql)
        {
            SqlConnection con = connect.createConnect();
            //con.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = sql;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public static DataTable query(string sql)
        {
            SqlConnection con = connect.createConnect();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = con;
            //datatable là tập hợp các dòng
            // 33, 34,35 có thể thay bằng câu lệnh
            // SqlCommand cmd = new SqlCommand(sql,con)
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
      
        public static bool checkUniqueThuoc(string id)
        {
            string sqlCheckUnique = "select *  from thuoc  where Thuoc.maThuoc ='" + id + "'";
            DataTable dt = connect.query(sqlCheckUnique);
            if (dt.Rows.Count > 0)
            {
                return true;
            }

            return false;
        }
        public static bool checkUniqueMaHd(string id)
        {
            //nếu có thì return false
            String sqlCheck = "select * from donHang where donHang.maDonHang = '" + id + "'";
            DataTable dt = connect.query(sqlCheck);

            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;

            }
        }
    }
}
