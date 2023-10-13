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
    public class HoaDon_DAO
    {
        static SqlConnection conn;
        // load hoa don
        public static List<HoaDon_DTO> LoadHoaDon(int idBan)
        {
            string chuoiTruyVan = "select HoaDonInFo.ID,MONAN.TenMonAn,HoaDonInFo.SoLuong,MONAN.Gia, (HoaDonInFo.SoLuong * MONAN.Gia) as ThanhTien from BAN, HoaDon, MONAN, HoaDonInFo where HoaDonInFo.IDMonAn = MONAN.ID AND HoaDonInFo.IDHoaDon = HoaDon.ID and HoaDon.IDBan = BAN.ID AND BAN.ID = " + idBan;
            conn = DataProvider.MoKetNoi();
            DataTable dtHoaDon = DataProvider.LayDataTable(chuoiTruyVan,conn);
            if (dtHoaDon.Rows.Count == 0)
                return null;

            List<HoaDon_DTO> lstHoaDon = new List<HoaDon_DTO>();

            for(int i=0;i<dtHoaDon.Rows.Count;i++)
            {
                HoaDon_DTO hoaDon = new HoaDon_DTO();
                hoaDon.ID = int.Parse(dtHoaDon.Rows[i]["ID"].ToString());
                hoaDon.TenMonAn = dtHoaDon.Rows[i]["TenMonAn"].ToString();
                hoaDon.SoLuong = int.Parse(dtHoaDon.Rows[i]["SoLuong"].ToString());
                hoaDon.Gia = int.Parse(dtHoaDon.Rows[i]["Gia"].ToString());
                hoaDon.ThanhTien = int.Parse(dtHoaDon.Rows[i]["ThanhTien"].ToString());

                lstHoaDon.Add(hoaDon); 
            }
            DataProvider.DongKetNoi(conn);
            return lstHoaDon;
        }

        // Lấy id của hóa đơn
        public static int layIDHoaDon(int iDban)
        {
            string chuoiTruyVan = "Select HoaDon.ID from BAN,HoaDon where HoaDon.IDBan = " + iDban+" AND TinhTrang = 0";
            conn = DataProvider.MoKetNoi();
            DataTable dtIDHoaDon = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dtIDHoaDon.Rows.Count == 0)
                return -1;
            int iDHoaHon = int.Parse(dtIDHoaDon.Rows[0]["ID"].ToString());
            DataProvider.DongKetNoi(conn);
            return iDHoaHon;
        }

        // thêm hóa đơn
        public static bool ThemHoaDon(int idBan)
        {
            // chuỗi truy vấn thêm 1 hóa đơn vào bảng HoaDon
            string chuoiTruyVan = string.Format("insert into HoaDon(IDBan,TinhTrang) values({0},{1})", idBan,0);
            conn = DataProvider.MoKetNoi();
            try
            {
                DataProvider.ThucThiTruyVanNonQuery(chuoiTruyVan, conn);
                DataProvider.DongKetNoi(conn);
                return true;
            }
            catch(Exception)
            {
                DataProvider.DongKetNoi(conn);
                return false;
            }
        }
        // thêm thông tin cho hóa đơn
        public static bool ThemThongTinHoaDon(int iDHoaDon,int iDMonAn,int soLuong)
        {
            string chuoiTruyVan = string.Format("insert into HoaDonInFo(IDHoaDon,IDMonAn,SoLuong) values({0},{1},{2})", iDHoaDon, iDMonAn,soLuong);
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

        // cập nhật số lượng món ăn
        public static bool CapNhatSoLuongMonAn(int soLuong,int IDHoaDon,int IDMonAn)
        {
            // chuỗi truy vấn thêm 1 hóa đơn vào bảng HoaDon
            string chuoiTruyVan = string.Format("Update HoaDonInFo Set SoLuong = {0} Where IDHoaDon = {1} AND IDMonAn = {2}",soLuong,IDHoaDon,IDMonAn);
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
        // xóa món ăn khỏi hóa đơn
        public static bool XoaMonAn(int IDHoaDon, int IDMonAn)
        {
            // chuỗi truy vấn xóa 1 món ăn
            string chuoiTruyVan = string.Format("Delete from HoaDonInFo where HoaDonInFo.IDHoaDon = {0} AND HoaDonInFo.IDMonAn = {1}",IDHoaDon,IDMonAn);
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

        // xóa hêt thông tin hóa đơn của bàn
        public static bool XoaThongTinHoaDon(int IDHoaDon)
        {
            // chuỗi truy vấn xóa thông tin hóa đơn
            string chuoiTruyVan = string.Format("Delete from HoaDonInFo where HoaDonInFo.IDHoaDon = {0}", IDHoaDon);
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

        // xóa hóa đơn dựa vào id bàn
        public static bool XoaHoaDonCoIDBan(int IDBan)
        {
            // chuỗi truy vấn xóa thông tin hóa đơn
            string chuoiTruyVan = string.Format("Delete from HoaDon where HoaDon.IDBan = {0}", IDBan);
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
        // chuyển bàn 
        public static bool ChuyenBan(int idFromTable, int idToTable)
        {
            // chuỗi truy vấn update lại bảng hóa đơn
           string chuoiTruyVan = string.Format("Update HoaDon Set IDBan = {0} Where IDBan = {1} AND TinhTrang = 0",idToTable,idFromTable);
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

        // update số tiền cho hóa đơn
        public static bool UpdateHoaDon(int tinhTrang,string ngayThanhToan,int soTien, int idBan)
        {
            // chuỗi truy vấn update lại bảng hóa đơn
            string chuoiTruyVan = string.Format("Update HoaDon Set TinhTrang = {0}, NgayThanhToan = '{1}', SoTien = {2} Where IDBan = {3} AND TinhTrang = 0",tinhTrang,ngayThanhToan,soTien,idBan);
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
        // lấy danh sách hóa đơn đã thanh toán
        public static List<QuanLiHoaDon_DTO> DanhSachHoaDon()
        {
            string chuoiTruyVan = "select HoaDon.ID,BAN.TenBan,HoaDon.NgayThanhToan,HoaDon.SoTien from HoaDon,BAN where HoaDon.IDBan = BAN.ID AND TinhTrang = 1 ";
            conn = DataProvider.MoKetNoi();
            DataTable dtHoaDon = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dtHoaDon.Rows.Count == 0)
                return null;

            List<QuanLiHoaDon_DTO> danhSachHoaDon = new List<QuanLiHoaDon_DTO>();

            for (int i = 0; i < dtHoaDon.Rows.Count; i++)
            {
                QuanLiHoaDon_DTO hoaDon = new QuanLiHoaDon_DTO();
                hoaDon.IDHoaDon = int.Parse(dtHoaDon.Rows[i]["ID"].ToString());
                hoaDon.TenBan = dtHoaDon.Rows[i]["TenBan"].ToString();
                hoaDon.TinhTrangThanhToan = "Đã thanh toán";
                hoaDon.NgayThanhToan = DateTime.Parse(dtHoaDon.Rows[i]["NgayThanhToan"].ToString());
                hoaDon.SoTien = dtHoaDon.Rows[i]["SoTien"].ToString();

                danhSachHoaDon.Add(hoaDon);
            }
            DataProvider.DongKetNoi(conn);
            return danhSachHoaDon;
        }
        // lọc danh sách hóa đơn
        public static List<QuanLiHoaDon_DTO> LocHoaDon(string tuNgay,string denNgay)
        {
            string chuoiTruyVan = "select HoaDon.ID,BAN.TenBan,HoaDon.NgayThanhToan,HoaDon.SoTien from HoaDon,BAN where HoaDon.IDBan = BAN.ID AND TinhTrang = 1 AND NgayThanhToan >= '"+tuNgay+"' AND NgayThanhToan <= '"+denNgay+"'";
            conn = DataProvider.MoKetNoi();
            DataTable dtHoaDon = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dtHoaDon.Rows.Count == 0)
                return null;

            List<QuanLiHoaDon_DTO> danhSachHoaDon = new List<QuanLiHoaDon_DTO>();

            for (int i = 0; i < dtHoaDon.Rows.Count; i++)
            {
                QuanLiHoaDon_DTO hoaDon = new QuanLiHoaDon_DTO();
                hoaDon.IDHoaDon = int.Parse(dtHoaDon.Rows[i]["ID"].ToString());
                hoaDon.TenBan = dtHoaDon.Rows[i]["TenBan"].ToString();
                hoaDon.TinhTrangThanhToan = "Đã thanh toán";
                hoaDon.NgayThanhToan = DateTime.Parse(dtHoaDon.Rows[i]["NgayThanhToan"].ToString());
                hoaDon.SoTien = dtHoaDon.Rows[i]["SoTien"].ToString();

                danhSachHoaDon.Add(hoaDon);
            }
            DataProvider.DongKetNoi(conn);
            return danhSachHoaDon;
        }
        // XÓA HÓA ĐƠN
        public static bool XoaHoaDon(int IDHoaDon)
        {
            // chuỗi truy vấn xóa thông tin hóa đơn
            string chuoiTruyVan = string.Format("Delete from HoaDon where HoaDon.ID = {0}", IDHoaDon);
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
        // xóa toàn bộ hóa đơn
        public static bool XoaToanBoHoaDon()
        {
            // chuỗi truy vấn xóa toàn bộ dữ liệu bảng món ăn
            string chuoiTruyVan = string.Format("Delete HoaDon");
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
