using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Common;


namespace DAO
{
    public class DataProvider
    {
        public static SqlConnection MoKetNoi()
        {
            string chuoiKetNoi = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QUANLINHAHANG1;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiKetNoi);
            conn.Open();
            return conn;
        }

        public static void DongKetNoi(SqlConnection conn)
        {
            conn.Close();
        }

        public static DataTable LayDataTable(string chuoiTruyVan,SqlConnection conn)
        {
            SqlDataAdapter da = new SqlDataAdapter(chuoiTruyVan,conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        
        public static bool ThucThiTruyVanNonQuery(string chuoiTruyVan, SqlConnection conn)
        {
            try
            {
                SqlCommand cm = new SqlCommand(chuoiTruyVan, conn);
                cm.ExecuteNonQuery();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
