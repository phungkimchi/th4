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
    public class NhanVien_DAO
    {
        static SqlConnection conn;

        public static List<NhanVien_DTO> LoadNhanVien()
        {
            string chuoiTruyVan = "Select * From NhanVien";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<NhanVien_DTO> danhSachNhanVien = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nhanVien = new NhanVien_DTO();

                nhanVien.ID = int.Parse(dt.Rows[i]["ID"].ToString());
                nhanVien.MaNhanVien = dt.Rows[i]["MaNhanVien"].ToString();
                nhanVien.TenNhanVien = dt.Rows[i]["TenNhanVien"].ToString();
                nhanVien.NgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                nhanVien.GioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                nhanVien.SoDienThoai = dt.Rows[i]["SoDienThoai"].ToString();
                nhanVien.ChucVu = dt.Rows[i]["ChucVu"].ToString();
                nhanVien.Luong = dt.Rows[i]["Luong"].ToString();
                nhanVien.DiaChi = dt.Rows[i]["DiaChi"].ToString();

                danhSachNhanVien.Add(nhanVien);
            }
            DataProvider.DongKetNoi(conn);
            return danhSachNhanVien;
        }

        //------------- thêm nhân viên ---------------
        public static bool ThemNhanVien(NhanVien_DTO nhanVien)
        {
            // chuỗi truy vấn thêm 1 món ăn vào bảng Món Ăn
            string chuoiTruyVan = string.Format("insert into NhanVien(MaNhanVien,TenNhanVien,NgaySinh,GioiTinh,SoDienThoai,ChucVu,Luong,DiaChi) Values (N'{0}',N'{1}','{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}')",nhanVien.MaNhanVien,nhanVien.TenNhanVien,nhanVien.NgaySinh,nhanVien.GioiTinh,nhanVien.SoDienThoai,nhanVien.ChucVu,nhanVien.Luong,nhanVien.DiaChi);
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
        //------------------------ sửa nhân viên ---------------------------------
        public static bool SuaNhanVien(NhanVien_DTO nhanVien)
        {
            // chuỗi truy vấn sửa món ăn
            string chuoiTruyVan = string.Format("Update NhanVien Set TenNhanVien = N'{0}', NgaySinh = '{1}', GioiTinh = N'{2}',SoDienThoai = N'{3}',ChucVu = N'{4}', Luong = N'{5}', DiaChi = N'{6}' where MaNhanVien = N'{7}'",nhanVien.TenNhanVien,nhanVien.NgaySinh,nhanVien.GioiTinh,nhanVien.SoDienThoai,nhanVien.ChucVu,nhanVien.Luong,nhanVien.DiaChi,nhanVien.MaNhanVien);
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

        //---------------- xóa nhân viên ---------------------------------
        public static bool XoaNhanVien(NhanVien_DTO nhanVien)
        {
            // chuỗi truy vấn xóa món ăn
            string chuoiTruyVan = string.Format("Delete from NhanVien Where MaNhanVien = N'{0}'",nhanVien.MaNhanVien);
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

        // ---------------- tìm kiếm nhân viên ---------------------------

        public static List<NhanVien_DTO> TimNhanVien(string tenNhanVien)
        {
            string chuoiTruyVan = "Select * From NhanVien where TenNhanVien like N'%" + tenNhanVien + "%'";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDataTable(chuoiTruyVan, conn);
            if (dt.Rows.Count == 0)
                return null;

            List<NhanVien_DTO> lstNhanVien = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nhanVien = new NhanVien_DTO();

                nhanVien.ID = int.Parse(dt.Rows[i]["ID"].ToString());
                nhanVien.MaNhanVien = dt.Rows[i]["MaNhanVien"].ToString();
                nhanVien.TenNhanVien = dt.Rows[i]["TenNhanVien"].ToString();
                nhanVien.NgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                nhanVien.GioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                nhanVien.SoDienThoai = dt.Rows[i]["SoDienThoai"].ToString();
                nhanVien.ChucVu = dt.Rows[i]["ChucVu"].ToString();
                nhanVien.Luong = dt.Rows[i]["Luong"].ToString();
                nhanVien.DiaChi = dt.Rows[i]["DiaChi"].ToString();

                lstNhanVien.Add(nhanVien);
            }
            DataProvider.DongKetNoi(conn);
            return lstNhanVien;
        }
    }
}
