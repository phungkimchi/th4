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
using DTO;

namespace DAO
{
    public class MonAn_DAO
    {
        static SqlConnection conn;

        public static List<MonAn_DTO> LoadMonAn()
        {
            string chuoiTruyVan = "Select * From MONAN";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDataTable(chuoiTruyVan,conn);
            if (dt.Rows.Count == 0)
                return null;

            List<MonAn_DTO> lstMonAn = new List<MonAn_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MonAn_DTO monAn = new MonAn_DTO();
                monAn.ID = int.Parse(dt.Rows[i]["ID"].ToString());
                monAn.TenMonAn = dt.Rows[i]["TenMonAn"].ToString();
                monAn.DonViTinh = dt.Rows[i]["DonViTinh"].ToString();
                monAn.Gia = int.Parse(dt.Rows[i]["Gia"].ToString());

                lstMonAn.Add(monAn);
            }
            DataProvider.DongKetNoi(conn);
            return lstMonAn;
        }

        // ------------  lấy id của món ăn dựa vào tên --------------------------
        public static int layIDMonAn(string tenMonAn)
        {
            string chuoiTruyVan = string.Format("Select MONAN.ID from MONAN where TenMonAn = N'{0}'",tenMonAn);
            conn = DataProvider.MoKetNoi();
            DataTable dtIDMonAn = DataProvider.LayDataTable(chuoiTruyVan,conn);
            if (dtIDMonAn.Rows.Count == 0)
                return -1;
            int idMonAn = int.Parse(dtIDMonAn.Rows[0]["ID"].ToString());
            DataProvider.DongKetNoi(conn);
            return idMonAn;
        }

        // ----------- tìm món ăn --------------------------
        public static List<MonAn_DTO> TimMonAn(string tenMonAn)
        {
            string chuoiTruyVan = "Select * From MONAN where TenMonAn like N'%"+tenMonAn+"%'";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<MonAn_DTO> lstMonAn = new List<MonAn_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MonAn_DTO monAn = new MonAn_DTO();
                monAn.ID = int.Parse(dt.Rows[i]["ID"].ToString());
                monAn.TenMonAn = dt.Rows[i]["TenMonAn"].ToString();
                monAn.DonViTinh = dt.Rows[i]["DonViTinh"].ToString();
                monAn.Gia = int.Parse(dt.Rows[i]["Gia"].ToString());

                lstMonAn.Add(monAn);
            }
            DataProvider.DongKetNoi(conn);
            return lstMonAn;
        }

        // ------------------------ thêm món ăn -----------------------
        public static bool ThemMonAn(MonAn_DTO monAn)
        {
            // chuỗi truy vấn thêm 1 món ăn vào bảng Món Ăn
            string chuoiTruyVan = string.Format("insert into MONAN(TenMonAn,DonViTinh,Gia) values(N'{0}',N'{1}',{2})",monAn.TenMonAn,monAn.DonViTinh,monAn.Gia);
            conn = DataProvider.MoKetNoi();
            try
            {
                DataProvider.ThucThiTruyVanNonQuery(chuoiTruyVan, conn);
                DataProvider.DongKetNoi(conn);
                return true;
            }
            catch (Exception)
            {
                DataProvider.DongKetNoi(conn);
                return false;
            }
        }

        //------------------------ sửa món ăn ---------------------------------
        public static bool SuaMonAn(MonAn_DTO monAn)
        {
            // chuỗi truy vấn sửa món ăn
            string chuoiTruyVan = string.Format("Update MONAN Set TenMonAn = N'{0}', DonViTinh = N'{1}', Gia = {2} Where ID = {3}",monAn.TenMonAn,monAn.DonViTinh,monAn.Gia,monAn.ID);
            conn = DataProvider.MoKetNoi();
            try
            {
                DataProvider.ThucThiTruyVanNonQuery(chuoiTruyVan, conn);
                DataProvider.DongKetNoi(conn);
                return true;
            }
            catch (Exception)
            {
                DataProvider.DongKetNoi(conn);
                return false;
            }
        }
        // --------------------------- xóa món ăn   --------------------------------
        public static bool XoaMonAn(MonAn_DTO monAn)
        {
            // chuỗi truy vấn xóa 1 món ăn
            string chuoiTruyVan = string.Format("Delete from MONAN Where ID = {0}",monAn.ID);
            conn = DataProvider.MoKetNoi();
            try
            {
                DataProvider.ThucThiTruyVanNonQuery(chuoiTruyVan, conn);
                DataProvider.DongKetNoi(conn);
                return true;
            }
            catch (Exception)
            {
                DataProvider.DongKetNoi(conn);
                return false;
            }
        }

        // ------------------------- xóa toàn bộ món ăn -------------------------------------
        public static bool XoaToanBoMonAn()
        {
            // chuỗi truy vấn xóa toàn bộ dữ liệu bảng món ăn
            string chuoiTruyVan = string.Format("Delete MONAN");
            conn = DataProvider.MoKetNoi();
            try
            {
                DataProvider.ThucThiTruyVanNonQuery(chuoiTruyVan, conn);
                DataProvider.DongKetNoi(conn);
                return true;
            }
            catch (Exception)
            {
                DataProvider.DongKetNoi(conn);
                return false;
            }
        }

    }
}
