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
    public class BanAn_DAO
    {
        static SqlConnection conn;

        public static List<BanAn_DTO> LayBanAn()
        {
            string chuoiTruyVan = "Select * From BAN";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<BanAn_DTO> lstBanAn = new List<BanAn_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BanAn_DTO banAn = new BanAn_DTO();

                banAn.ID = int.Parse(dt.Rows[i]["ID"].ToString());
                banAn.TenBan = dt.Rows[i]["TenBan"].ToString();
                banAn.TrangThai = dt.Rows[i]["TrangThai"].ToString();

                lstBanAn.Add(banAn);
            }
            DataProvider.DongKetNoi(conn);
            return lstBanAn;
        }

        // sửa trạng thái bàn ăn thành trạng thái có người
        public static bool SuaTrangThaiBanAn(int idBan)
        {
            // chuỗi truy vấn thêm 1 hóa đơn vào bảng HoaDon
            string chuoiTruyVan = string.Format("Update BAN Set TrangThai = N'Có Người' Where ID = {0}", idBan);
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

        // sửa thành trạng thái thành trống
        public static bool SuaTrangThaiBanAn2(int idBan)
        {
            // chuỗi truy vấn thêm 1 hóa đơn vào bảng HoaDon
            string chuoiTruyVan = string.Format("Update BAN Set TrangThai = N'Trống' Where ID = {0}", idBan);
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

        // thêm bàn ăn 
        public static bool ThemBanAn(BanAn_DTO banAn)
        {
            // chuỗi truy vấn thêm 1 món ăn vào bảng Món Ăn
            string chuoiTruyVan = string.Format("insert into BAN(TenBan,TrangThai) values(N'{0}',N'{1}')", banAn.TenBan, banAn.TrangThai);
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
        // xóa bàn ăn
        public static bool XoaBanAn(BanAn_DTO banAn)
        {
            // chuỗi truy vấn thêm xóa 1 hàng trong bảng ban
            string chuoiTruyVan = string.Format("Delete from BAN Where ID = {0}", banAn.ID);
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
        // sửa bàn ăn
        public static bool SuaBanAn(BanAn_DTO banAn)
        {
            // chuỗi truy vấn sửa bàn ăn
            string chuoiTruyVan = string.Format("Update BAN Set TenBan = N'{0}' Where ID = {1}", banAn.TenBan, banAn.ID);
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
        // tìm bàn ăn 
        public static List<BanAn_DTO> TimBanAn(string tenBanAn)
        {
            string chuoiTruyVan = "Select * From BAN where TenBan like N'%" + tenBanAn + "%'";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<BanAn_DTO> lstBanAn = new List<BanAn_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BanAn_DTO banAn = new BanAn_DTO();
                banAn.ID = int.Parse(dt.Rows[i]["ID"].ToString());
                banAn.TenBan = dt.Rows[i]["TenBan"].ToString();
                banAn.TrangThai = dt.Rows[i]["TrangThai"].ToString();
     
                lstBanAn.Add(banAn);
            }
            DataProvider.DongKetNoi(conn);
            return lstBanAn;
        }
    }
}
