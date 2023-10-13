using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Text.RegularExpressions;
using DTO;
using BUS;

namespace WindowsFormsApp1
{
    public partial class frmQuanLiNhanSu : Form
    {
        public frmQuanLiNhanSu()
        {
            InitializeComponent();
        }

        private void frmQuanLiNhanSu_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        List<NhanVien_DTO> danhSachNhanVien;
        private void LoadNhanVien()
        {
            danhSachNhanVien = NhanVien_BUS.LoadNhanVien();
            dgvDanhSachNhanVien.DataSource = danhSachNhanVien;

            if (danhSachNhanVien == null)
                return;

            dgvDanhSachNhanVien.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
            dgvDanhSachNhanVien.Columns["TenNhanVien"].HeaderText = "Tên Nhân Viên";
            dgvDanhSachNhanVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgvDanhSachNhanVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dgvDanhSachNhanVien.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            dgvDanhSachNhanVien.Columns["ChucVu"].HeaderText = "Chức Vụ";
            dgvDanhSachNhanVien.Columns["Luong"].HeaderText = "Lương";
            dgvDanhSachNhanVien.Columns["DiaChi"].HeaderText = "Địa Chỉ";

            dgvDanhSachNhanVien.Columns["ID"].Width = 50;
            dgvDanhSachNhanVien.Columns["MaNhanVien"].Width = 100;
            dgvDanhSachNhanVien.Columns["TenNhanVien"].Width = 200;
            dgvDanhSachNhanVien.Columns["NgaySinh"].Width = 120;
            dgvDanhSachNhanVien.Columns["GioiTinh"].Width = 70;
            dgvDanhSachNhanVien.Columns["SoDienThoai"].Width = 150;
            dgvDanhSachNhanVien.Columns["ChucVu"].Width = 150;
            dgvDanhSachNhanVien.Columns["Luong"].Width = 150;
            dgvDanhSachNhanVien.Columns["DiaChi"].Width = 285;
        }

        //----------------------------- thêm nhân viên --------------------------------------
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Nhập mã nhân viên");
                return;
            }
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Nhập tên nhân viên");
                return;
            }
            if (txtSoDienThoai.Text == "")
            {
                MessageBox.Show("Nhập số điện thoại");
                return;
            }
            if (txtChucVu.Text == "")
            {
                MessageBox.Show("Nhập chức vụ");
                return;
            }
            if (txtBacLuong.Text == "")
            {
                MessageBox.Show("Nhập lương");
                return;
            }
            if (rtxtDiaChi.Text == "")
            {
                MessageBox.Show("Nhập địa chỉ");
                return;
            }
            NhanVien_DTO nhanVien = new NhanVien_DTO();
            nhanVien.MaNhanVien = txtMaNhanVien.Text;
            nhanVien.TenNhanVien = txtHoTen.Text;
            nhanVien.NgaySinh = DateTime.Parse(dtpNgaySinh.Text);
            if (rdNam.Checked)
                nhanVien.GioiTinh = "Nam";
            else
                nhanVien.GioiTinh = "Nữ";
            nhanVien.SoDienThoai = txtSoDienThoai.Text;
            nhanVien.ChucVu = txtChucVu.Text;
            nhanVien.Luong = txtBacLuong.Text;
            nhanVien.DiaChi = rtxtDiaChi.Text;
            if(danhSachNhanVien != null)
            {
                foreach (NhanVien_DTO nv in danhSachNhanVien)
                {
                    if (nhanVien.MaNhanVien == nv.MaNhanVien)
                    {
                        MessageBox.Show("Mã nhân viên đã có rồi");
                        return;
                    }
                }
            }
            if(NhanVien_BUS.ThemNhanVien(nhanVien))
            {
                LoadNhanVien();
                MessageBox.Show("Thêm thành công");
                return;
            }
            MessageBox.Show("Thêm thất bại");
        }

        //-------------- không cho phép nhập chữ ----------------------------
        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBacLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        // -------- sự kiện click vào 1 dòng
        DataGridViewRow drNhanVien;
        private void dgvDanhSachNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                drNhanVien = dgvDanhSachNhanVien.SelectedRows[0];
            }
            catch(Exception)
            {
                return;
            }

            txtMaNhanVien.Text = drNhanVien.Cells["MaNhanVien"].Value.ToString();
            txtHoTen.Text = drNhanVien.Cells["TenNhanVien"].Value.ToString();
            dtpNgaySinh.Text = drNhanVien.Cells["NgaySinh"].Value.ToString();
            if (drNhanVien.Cells["GioiTinh"].Value.ToString() == "Nam")
                rdNam.Checked = true;
            else
                rdNu.Checked = true;
            txtSoDienThoai.Text = drNhanVien.Cells["SoDienThoai"].Value.ToString();
            txtChucVu.Text = drNhanVien.Cells["ChucVu"].Value.ToString();
            txtBacLuong.Text = drNhanVien.Cells["Luong"].Value.ToString();
            rtxtDiaChi.Text = drNhanVien.Cells["DiaChi"].Value.ToString();
        }

        //---------------- sửa nhân viên ------------------------------
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(drNhanVien == null)
            {
                MessageBox.Show("Chọn nhân viên muốn cập nhật");
                return;
            }

            NhanVien_DTO nhanVien = new NhanVien_DTO();

            nhanVien.MaNhanVien = drNhanVien.Cells["MaNhanVien"].Value.ToString();
            nhanVien.TenNhanVien = txtHoTen.Text;
            nhanVien.NgaySinh = DateTime.Parse(dtpNgaySinh.Text);
            if (rdNam.Checked)
                nhanVien.GioiTinh = "Nam";
            else
                nhanVien.GioiTinh = "Nữ";
            nhanVien.SoDienThoai = txtSoDienThoai.Text;
            nhanVien.ChucVu = txtChucVu.Text;
            nhanVien.Luong = txtBacLuong.Text;
            nhanVien.DiaChi = rtxtDiaChi.Text;

            if(NhanVien_BUS.SuaNhanVien(nhanVien))
            {
                
                drNhanVien = null;
                txtMaNhanVien.Text = "";
                txtHoTen.Text = "";
                txtSoDienThoai.Text = "";
                txtChucVu.Text = "";
                txtBacLuong.Text = "";
                rtxtDiaChi.Text = "";
                
                LoadNhanVien();
                MessageBox.Show("Sửa thành công");
                return;
            }
            MessageBox.Show("Sửa thất bại");
        }


        //------------------ xóa nhân viên ----------------------------
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(drNhanVien ==  null)
            {
                MessageBox.Show("Chọn nhân viên muốn xóa");
                return;
            }

            NhanVien_DTO nhanVien = new NhanVien_DTO();
            nhanVien.MaNhanVien = txtMaNhanVien.Text;

            if (MessageBox.Show("Xác nhận xóa","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (danhSachNhanVien == null)
                    dgvDanhSachNhanVien.DataSource = null;
                if (NhanVien_BUS.XoaNhanVien(nhanVien))
                {
                    drNhanVien = null;
                    txtMaNhanVien.Text = "";
                    txtHoTen.Text = "";
                    txtSoDienThoai.Text = "";
                    txtChucVu.Text = "";
                    txtBacLuong.Text = "";
                    rtxtDiaChi.Text = "";
                    MessageBox.Show("Xóa thành công");
                    LoadNhanVien();
                    return;
                } 
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            txtTimKiem.ForeColor = Color.Black;
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            txtTimKiem.Text = "Nhập tên nhân viên ...";
            txtTimKiem.ForeColor = Color.Gray;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            List<NhanVien_DTO> ketQua = NhanVien_BUS.TimNhanVien(txtTimKiem.Text);
            if (ketQua == null)
                return;
            dgvDanhSachNhanVien.DataSource = ketQua;
        }
    }
}
