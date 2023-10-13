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
    public partial class frmQuanLiThucDon : Form
    {
        public frmQuanLiThucDon()
        {
            InitializeComponent();
        }

        private void frmQuanLiThucDon_Load(object sender, EventArgs e)
        {
            LoadMonAn();
            LoadBanAn();
        }
        List<MonAn_DTO> lstMonAn;
        private void LoadMonAn()
        {
            lstMonAn = MonAn_BUS.LoadMonAn();
            dgvDanhSachMonAn.DataSource = lstMonAn;

            if (lstMonAn == null)
                return;

            dgvDanhSachMonAn.Columns["ID"].HeaderText = "ID";
            dgvDanhSachMonAn.Columns["TenMonAn"].HeaderText = "Tên Món";
            dgvDanhSachMonAn.Columns["DonViTinh"].HeaderText = "Đơn Vị Tính";
            dgvDanhSachMonAn.Columns["Gia"].HeaderText = "Giá";

            dgvDanhSachMonAn.Columns["ID"].Width = 50;
            dgvDanhSachMonAn.Columns["TenMonAn"].Width = 221;
            dgvDanhSachMonAn.Columns["DonViTinh"].Width = 100;
            dgvDanhSachMonAn.Columns["Gia"].Width = 124;
        }

        List<BanAn_DTO> lstBanAn;
        private void LoadBanAn()
        {
            lstBanAn = BanAn_BUS.LoadBanAn();
            dgvBanAn.DataSource = lstBanAn;

            if (lstBanAn == null)
                return;

            dgvBanAn.Columns["ID"].HeaderText = "ID";
            dgvBanAn.Columns["TenBan"].HeaderText = "Tên Bàn";
            dgvBanAn.Columns["TrangThai"].HeaderText = "Trạng Thái";

            dgvBanAn.Columns["TenBan"].Width = 200;
            dgvBanAn.Columns["TrangThai"].Width = 200;

            if (lstBanAn != null)
                lbBanDangCo.Text = (lstBanAn.Count).ToString();
            else
                lbBanDangCo.Text = "0";
        }





        //----------------- chuẩn hóa chuỗi ---------------------------------
        public static string ChuanHoaChuoi(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        // ------------- thêm món ăn --------------------------
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if(txtTenMonAn.Text == "")
            {
                MessageBox.Show("Nhập tên món ăn");
                return;
            }
            if(txtDonViTinh.Text == "")
            {
                MessageBox.Show("Nhập đơn vị tính");
                return;
            }
            if(txtDonGia.Text == "")
            {
                MessageBox.Show("Nhập đơn giá");
                return;
            }

            MonAn_DTO monAn = new MonAn_DTO();
            monAn.TenMonAn = txtTenMonAn.Text.ToString();
            monAn.DonViTinh = txtDonViTinh.Text.ToString();
            try
            {
                monAn.Gia = int.Parse(txtDonGia.Text.ToString());
            }
            catch(Exception)
            {
                MessageBox.Show("Dữ liệu nhập có lỗi. Xin kiểm tra lại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(lstMonAn != null)
            {
                for (int i = 0; i < lstMonAn.Count; i++)
                {
                    if (ChuanHoaChuoi(monAn.TenMonAn.ToLower()) == ChuanHoaChuoi(lstMonAn[i].TenMonAn.ToLower()))
                    {
                        MessageBox.Show("Món ăn đã có trong thực đơn rồi");
                        return;
                    }
                }
            }
            if(MonAn_BUS.ThemMonAn(monAn))
            {
                MessageBox.Show("Đã Thêm");
                LoadMonAn();
                return;
            }
            MessageBox.Show("Thêm thất bại !");
        }

        // ------------------- không cho phép nhập chữ ---------------------------------------
        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        DataGridViewRow dr; // lấy dữ liệu của dòng của món ăn được chọn
        private void dgvDanhSachMonAn_Click(object sender, EventArgs e)
        {
            try
            {
                dr = dgvDanhSachMonAn.SelectedRows[0];
            }
            catch(Exception)
            {
                return;
            }

            txtTenMonAn.Text = dr.Cells["TenMonAn"].Value.ToString();
            txtDonViTinh.Text = dr.Cells["DonViTinh"].Value.ToString();
            txtDonGia.Text = dr.Cells["Gia"].Value.ToString();
        }

        // --------------  sửa món ăn --------------------------
        private void btnSuaMon_Click(object sender, EventArgs e)
        {
           if(dr == null)
            {
                MessageBox.Show("Chọn món ăn muốn sửa");
                return;
            }
            MonAn_DTO monAn = new MonAn_DTO();
            try
            {
                monAn.ID = int.Parse(dr.Cells["ID"].Value.ToString());
                monAn.TenMonAn = txtTenMonAn.Text.ToString();
                monAn.DonViTinh = txtDonViTinh.Text.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Đã Sửa");
                return;
            }
            try
            {
                monAn.Gia = int.Parse(txtDonGia.Text.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu nhập có lỗi. Xin kiểm tra lại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            if (MonAn_BUS.SuaMonAn(monAn))
            {
                dr = null;
                txtTenMonAn.Text = "";
                txtDonViTinh.Text = "";
                txtDonGia.Text = "";
                MessageBox.Show("Sửa thành công");
                LoadMonAn();
                return;
            }
            MessageBox.Show("Sửa thất bại");
            return;
        }

        // -------------- xóa món ăn ------------------------------
        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if(dr == null)
            {
                MessageBox.Show("Chọn món ăn muốn xóa");
                return;
            }

            MonAn_DTO monAn = new MonAn_DTO();
            monAn.ID = int.Parse(dr.Cells["ID"].Value.ToString());

            if(MessageBox.Show("Xác nhận xóa !","Xóa",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                if (MonAn_BUS.XoaMonAn(monAn))
                {
                    dr = null;
                    txtTenMonAn.Text = "";
                    txtDonViTinh.Text = "";
                    txtDonGia.Text = "";
                    MessageBox.Show("Đã xóa");
                    LoadMonAn();
                    return;
                }
                MessageBox.Show("Xóa thất bại");
            }
        }

        //----------------- tìm kiếm món ăn ------------------------------
        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            txtTimKiem.ForeColor = Color.Black;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            List<MonAn_DTO> ketQua = MonAn_BUS.TimMonAn(txtTimKiem.Text);
            if (ketQua == null)
                return;
            dgvDanhSachMonAn.DataSource = ketQua;
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            txtTimKiem.Text = "Nhập tên món ăn ... ";
            txtTimKiem.ForeColor = Color.Gray;
        }

        // xóa toàn bộ món ăn
        private void btnXoaToanBo_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Xóa toàn bộ món ăn có trong thực đơn","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if(MonAn_BUS.XoaToanBoMonAn())
                {
                    MessageBox.Show("Đã Xóa !");
                    LoadMonAn();
                    return;
                }
                MessageBox.Show("Lỗi","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }





        //------------------  thêm bàn ăn -----------------------------
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenBan.Text == "")
            {
                MessageBox.Show("Nhập tên bàn");
                return;
            }
            BanAn_DTO banAn = new BanAn_DTO();
            banAn.TenBan = txtTenBan.Text.ToString();
            banAn.TrangThai = "Trống";
            if(lstBanAn != null)
            {
                for (int i = 0; i < lstBanAn.Count; i++)
                {
                    if (ChuanHoaChuoi(banAn.TenBan.ToLower()) == ChuanHoaChuoi(lstBanAn[i].TenBan.ToLower()))
                    {
                        MessageBox.Show("Tên đã có rồi");
                        return;
                    }
                }
            }
            if(BanAn_BUS.ThemBanAn(banAn))
            {
                MessageBox.Show("Thêm thành công");
                LoadBanAn();
                if (lstBanAn != null)
                    lbBanDangCo.Text = (lstBanAn.Count).ToString();
                else
                    lbBanDangCo.Text = "0";
                return;
            }
            MessageBox.Show("Thêm thất bại");
        }

        // sự kiện click của datagirdview bàn ăn
        DataGridViewRow drBan;
        private void dgvBanAn_Click(object sender, EventArgs e)
        {
            try
            {
                drBan = dgvBanAn.SelectedRows[0];
            }
            catch(Exception)
            {
                return;
            }

            txtTenBan.Text = drBan.Cells["TenBan"].Value.ToString();
            if(drBan.Cells["TrangThai"].Value.ToString() == "Trống")
            {
                txtTrangThai.Text = drBan.Cells["TrangThai"].Value.ToString();
                txtTrangThai.ForeColor = Color.Red;
            }
            else
            {
                txtTrangThai.ForeColor = Color.ForestGreen;
                txtTrangThai.Text = drBan.Cells["TrangThai"].Value.ToString();
            }
        }

        // ------------------------ xóa bàn ăn --------------------------------

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(drBan == null)
            {
                MessageBox.Show("Chọn bàn muốn xóa");
                return;
            }
            BanAn_DTO banAnXoa = new BanAn_DTO();
            banAnXoa.ID = int.Parse(drBan.Cells["ID"].Value.ToString());
            if(drBan.Cells["TrangThai"].Value.ToString() == "Có Người")
            {
                MessageBox.Show("Không thể xóa bàn đang có người");
                return;
            }

            if (MessageBox.Show("Xóa bàn sẽ xóa toàn bộ hóa đơn của bàn đó", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    HoaDon_BUS.XoaHoaDonCoIDBan(banAnXoa.ID); // xóa các hóa đơn có liên quan đến bàn đó
                }
                catch(Exception)
                {
                    return;
                }

                if (BanAn_BUS.XoaBanAn(banAnXoa))
                {
                    drBan = null;
                    txtTenBan.Text = "";
                    txtTrangThai.Text = "";
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBanAn();

                    if(lstBanAn != null)
                        lbBanDangCo.Text = (lstBanAn.Count).ToString();
                    else
                        lbBanDangCo.Text = "0";
                    
                    return;
                }
            }
            else
                return;
            MessageBox.Show("Xóa thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // ------------------------- sửa bàn ăn -------------------------------
        private void btnSua_Click(object sender, EventArgs e)
        {
            if(drBan == null)
            {
                MessageBox.Show("Chọn bàn muốn sửa");
                return;
            }
            BanAn_DTO banAnSua = new BanAn_DTO();
            banAnSua.TenBan = txtTenBan.Text.ToString();
            try
            {
                banAnSua.ID = int.Parse(drBan.Cells["ID"].Value.ToString());
            }
            catch(Exception)
            {
                return;
            }
            for (int i = 0; i < lstBanAn.Count; i++)
            {
                if (ChuanHoaChuoi(banAnSua.TenBan.ToLower()) == ChuanHoaChuoi(lstBanAn[i].TenBan.ToLower()))
                {
                    MessageBox.Show("Tên Bàn đã có rồi");
                    return;
                }
            }
            if(BanAn_BUS.SuaBanAn(banAnSua))
            {
                drBan = null;
                txtTenBan.Text = "";
                txtTrangThai.Text = "";
                MessageBox.Show("Sửa thành công");
                LoadBanAn();
                return;
            }
            MessageBox.Show("Sửa thất bại");
        }

        // ------------- tìm kiếm bàn ăn ----------------------------
        private void txtTimKiemBanAn_Click(object sender, EventArgs e)
        {
            txtTimKiemBanAn.Text = "";
            txtTimKiemBanAn.ForeColor = Color.Black;
        }

        private void txtTimKiemBanAn_Leave(object sender, EventArgs e)
        {
            txtTimKiemBanAn.Text = "Nhập tên bàn ăn ... ";
            txtTimKiemBanAn.ForeColor = Color.Gray;
        }

        private void txtTimKiemBanAn_TextChanged(object sender, EventArgs e)
        {
            List<BanAn_DTO> ketQua = BanAn_BUS.TimBanAn(txtTimKiemBanAn.Text);
            if (ketQua == null)
                return;
            dgvBanAn.DataSource = ketQua;
        }

       
    }
}
