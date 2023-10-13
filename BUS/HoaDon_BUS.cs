using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class HoaDon_BUS
    {
        public static List<HoaDon_DTO> LoadHoaDon(int idBan)
        {
            return HoaDon_DAO.LoadHoaDon(idBan);
        }

        public static bool ThemHoaDon(int idBan)
        {
            return HoaDon_DAO.ThemHoaDon(idBan);
        }
        public static bool ThemThongTinHoaDon(int iDHoaDon, int iDMonAn, int soLuong)
        {
            return HoaDon_DAO.ThemThongTinHoaDon(iDHoaDon,iDMonAn,soLuong);
        }

        public static int layIDHoaDon(int iDban)
        {
            return HoaDon_DAO.layIDHoaDon(iDban);
        }

        public static bool CapNhatSoLuongMonAn(int soLuong, int IDHoaDon, int IDMonAn)
        {
            return HoaDon_DAO.CapNhatSoLuongMonAn(soLuong,IDHoaDon,IDMonAn);
        }

        public static bool XoaMonAn(int IDHoaDon, int IDMonAn)
        {
            return HoaDon_DAO.XoaMonAn(IDHoaDon, IDMonAn);
        }

        // xóa thông tin hóa đơn
        public static bool XoaThongTinHoaDon(int IDHoaDon)
        {
            return HoaDon_DAO.XoaThongTinHoaDon(IDHoaDon);
        }
        // xóa hóa đơn
        public static bool XoaHoaDon(int IDHoaDon)
        {
            return HoaDon_DAO.XoaHoaDon(IDHoaDon);
        }

        // chuyển bàn
        public static bool ChuyenBan(int idFromTable, int idToTable)
        {
            return HoaDon_DAO.ChuyenBan(idFromTable, idToTable);
        }

        // update tiền cho hóa đơn
        public static bool UpdateHoaDon(int tinhTrang,string ngayThanhToan, int soTien, int idBan)
        {
            return HoaDon_DAO.UpdateHoaDon(tinhTrang,ngayThanhToan,soTien,idBan);
        }

        // lấy hóa đơn
        public static List<QuanLiHoaDon_DTO> DanhSachHoaDon()
        {
            return HoaDon_DAO.DanhSachHoaDon();
        }
        // lọc hóa đơn
        public static List<QuanLiHoaDon_DTO> LocHoaDon(string tuNgay,string denNgay)
        {
            return HoaDon_DAO.LocHoaDon(tuNgay,denNgay);
        }
        // xóa toàn bộ hóa đơn
        public static bool XoaToanBoHoaDon()
        {
            return HoaDon_DAO.XoaToanBoHoaDon();
        }
        // Xóa hóa đơn dựa vào ID bàn
        public static bool XoaHoaDonCoIDBan(int IDBan)
        {
            return HoaDon_DAO.XoaHoaDonCoIDBan(IDBan);
        }
    }
}
