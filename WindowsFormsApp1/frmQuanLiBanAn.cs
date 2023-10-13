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
using DTO;
using BUS;

namespace WindowsFormsApp1
{
    public partial class frmQuanLiBanAn : Form
    {
        public frmQuanLiBanAn()
        {
            InitializeComponent();
        }

        private void frmQuanLiBanAn_Load(object sender, EventArgs e)
        {
            LoadMonAn();
            LoadBanAn();
            LoadThoiGian();
        }

        //------------- lấy ngày tháng năm hiện tại ---------------------------
        void LoadThoiGian()
        {
            DateTime nowTime = DateTime.Now;
            lbTime.Text = nowTime.ToString("dd/MM/yyyy");
        }
        //---------------- Load Món Ăn ----------------------------
        private void LoadMonAn()
        {
            List<MonAn_DTO> lstMonAn = MonAn_BUS.LoadMonAn();
            dgvDanhSachMonAn.DataSource = lstMonAn;

            if (lstMonAn == null)
                return;

            dgvDanhSachMonAn.Columns["ID"].HeaderText = "ID";
            dgvDanhSachMonAn.Columns["TenMonAn"].HeaderText = "Tên Món";
            dgvDanhSachMonAn.Columns["DonViTinh"].HeaderText = "Đơn Vị Tính";
            dgvDanhSachMonAn.Columns["Gia"].HeaderText = "Giá";

            dgvDanhSachMonAn.Columns["ID"].Width = 50;
            dgvDanhSachMonAn.Columns["TenMonAn"].Width = 150;
            dgvDanhSachMonAn.Columns["DonViTinh"].Width = 100;
            dgvDanhSachMonAn.Columns["Gia"].Width = 124;

            
        }
        //--------------------  end -------------------------------------


        // --------------------- load Bàn ăn -----------------------------
        public List<BanAn_DTO> danhSachBanAn;
        ListViewItem banAn;
        private void LoadBanAn()
        {
            danhSachBanAn = BanAn_BUS.LoadBanAn();
            if (danhSachBanAn == null)
                return;
            for (int i = 0; i < danhSachBanAn.Count; i++)
            {
                banAn = new ListViewItem();
                if (danhSachBanAn[i].TrangThai == "Có Người")
                    banAn.ImageIndex = 0;
                else
                    banAn.ImageIndex = 1;

                banAn.Text = danhSachBanAn[i].TenBan;

                lstBanAn.Items.Add(banAn);
            }
        }
        //-------------------   end     ----------------------------------


        // ----------------------- Load Hóa Đơn -----------------------------
        List<HoaDon_DTO> danhSachHoaDon;
        private void LoadHoaDon(int idBan)
        {
            int tongTien = 0;
            lstHoaDon.Items.Clear();  // xóa hết các dòng trên listview đi để tránh cái sau đè lên cái trước
            danhSachHoaDon = HoaDon_BUS.LoadHoaDon(idBan);  // lấy hóa đơn của bàn đang được click
            if (danhSachHoaDon == null)                    // nếu không có hóa đơn tiền = 0
            {
                txtTongCong.Text = "0";
                txtThanhTien.Text = "0";
                return;
            }
              
            else    // nếu có hóa đơn
            {
                for (int i = 0; i < danhSachHoaDon.Count; i++)  // duyệt từ đầu danh sách hóa đơn đến cuối danh sách hóa đơn
                {
                    ListViewItem it = new ListViewItem(danhSachHoaDon[i].TenMonAn.ToString());  // tạo ra 1 items trong listview
                    it.SubItems.Add(danhSachHoaDon[i].SoLuong.ToString());                              
                    it.SubItems.Add(danhSachHoaDon[i].Gia.ToString());
                    it.SubItems.Add(danhSachHoaDon[i].ThanhTien.ToString());

                    tongTien += int.Parse(it.SubItems[3].Text.ToString());  // tính tổng tiền
                    lstHoaDon.Items.Add(it); // thêm items vừa tạo vào listview
                }
                //CultureInfo cul = new CultureInfo("vi-VN");

                // Gán Tiền vào textbox
                txtTongCong.Text = tongTien.ToString();
                txtThanhTien.Text = txtTongCong.Text.ToString();
            }

        }
        //---------------------- end ---------------------------------------


        // Sự kiện khi nhấn vào 1 bàn ăn thì tất cập nhật trạng thái và cập nhật hóa đơn cho bàn đó
        public int indexTable = -1; // lưu chỉ số của bàn đang được chọn
        private void lstBanAn_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            indexTable = e.ItemIndex;  // khi click vào bàn nào thì lưu lại chỉ số của bàn đó

            for (int i = 0; i < lstBanAn.Items.Count; i++)  // duyệt tất cả các bàn
            {
                if (lstBanAn.Items[i].Selected)  // kiểm tra nếu bàn nào được click thì
                {
                    if(lstBanAn.Items[i].ImageIndex == 1)  // nếu bàn đó đang trống thì màu chữ trạng thái có màu đỏ
                    {
                        lbBan.ForeColor = Color.Red;
                        lbTrangThai.ForeColor = Color.Red;
                        lbTrangThai.Text = "Trống";
                    }
                    else  // ngược lại thì màu chữ là màu xanh
                    {
                        lbBan.ForeColor = Color.ForestGreen;
                        lbTrangThai.ForeColor = Color.ForestGreen;
                        lbTrangThai.Text = "Có Người";
                    }
                    // load trạng thái cho label
                    lbBan.Text = danhSachBanAn[i].TenBan.ToString();

                    // hiển thị hóa đơn
                    LoadHoaDon(danhSachBanAn[i].ID); 
                }
            }
        }



        //---------------------------------- KHUYẾN MÃI ----------------------------------------------------------------
        // chỉ cho phép nhập số vào textbox khuyến mãi
        private void txtKhuyenMai_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // khuyến mãi theo tiền
        private void txtKhuyenMai_TextChanged_1(object sender, EventArgs e)
        {     
            if (txtKhuyenMai.Text != "" && txtTongCong.Text != "")
            {
                int tongCong, khuyenMai;
                try
                {
                    tongCong = int.Parse(txtTongCong.Text.ToString());
                    khuyenMai = int.Parse(txtKhuyenMai.Text.ToString());
                }
                catch(Exception)
                {
                    return;
                }
                
                if (khuyenMai > tongCong)
                {
                    MessageBox.Show("Khuyễn mãi không hợp lệ !");
                    txtKhuyenMai.Text = "0";
                    return;
                }
                else
                {
                    txtThanhTien.Text = (tongCong - khuyenMai).ToString();
                }
            }
        }

        // chỉ cho phép nhập số vào textbox khuyến mãi theo %
        private void txtPhanCham_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // khuyến mãi theo phần trăm
        private void txtPhanCham_TextChanged_1(object sender, EventArgs e)
        {
            if (txtPhanCham.Text != "" && txtTongCong.Text != "")
            {

                int tongCong = int.Parse(txtTongCong.Text.ToString());
                int khuyenMai = int.Parse(txtPhanCham.Text.ToString());
           
                if (khuyenMai > 100)
                {
                    MessageBox.Show("Khuyễn mãi không hợp lệ !");
                    txtPhanCham.Text = "0";
                    return;
                }
                else
                {
                    txtThanhTien.Text = (tongCong - ((tongCong * khuyenMai) / 100)).ToString();
                }
            }
        }
        //----------------------------------  END ------------------------------------------------------------------------



        //  ----------------------------------- Mở Bàn ---------------------------------------------------
        private void btnMoBan_Click(object sender, EventArgs e)
        {
            if(indexTable == -1) // nếu chưa có bàn nào được chọn
            {
                MessageBox.Show("Chọn 1 Bàn Để Mở", "Thông Báo");
                return;
            }
            if (lstBanAn.Items[indexTable].ImageIndex == 0)  // Nếu Bàn Đang Mở thì không thêm hóa đơn nữa
            {
                MessageBox.Show("Bàn Đang Mở", "Thông Báo");
                return;
            }
            // khi click thì thêm 1 hóa đơn vào bảng hóa đơn

            // nếu Thêm hóa đơn thành công thì Bàn sẽ màu xanh và trạng thái thành có người
            if (HoaDon_BUS.ThemHoaDon(danhSachBanAn[indexTable].ID) == true && BanAn_BUS.SuaTrangThaiBanAn(danhSachBanAn[indexTable].ID) == true) 
            {
               
                lbTrangThai.Text = "Có Người";
                lstBanAn.Items[indexTable].ImageIndex = 0;

                lbBan.ForeColor = Color.Green;
                lbTrangThai.ForeColor = Color.Green;
               
                MessageBox.Show("Đã Mở Bàn", "Thông Báo");

                return;
            }
            MessageBox.Show("Lỗi", "Thông Báo");
        }
        //-------------------------------------- END -----------------------------------------------------

        // ------------------------------ THÊM MÓN ĂN --------------------------------------------------
        DataGridViewRow dr; // lưu thông tin của 1 dòng trong datagirdview món ăn
        private void dgvDanhSachMonAn_Click(object sender, EventArgs e)
        {
            try
            {
                dr = dgvDanhSachMonAn.SelectedRows[0]; // lưu lại thông tin của 1 dòng được chọn
            }
            catch(Exception)
            {
                return;
            }
            
        }

        int soLuong = 1; // số lượng món ăn auto = 1;
        // --------------------------- thêm 1 món ăn vào hóa đơn -----------------------------------------
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if(indexTable == -1)
            {
                MessageBox.Show("Chọn Bàn Muốn Thêm");
                return;
            }
         
            if (lstBanAn.Items[indexTable].ImageIndex == 1)
            {
                MessageBox.Show("Phải Mở Bàn Để Thêm Món");
                return;
            }
            if (lstBanAn.Items.Count > 0)
            {
                for (int i = 0; i < lstHoaDon.Items.Count; i++)
                {
                    try
                    {
                        if (lstHoaDon.Items[i].SubItems[0].Text.ToString() == dr.Cells["TenMonAn"].Value.ToString())
                        {
                            MessageBox.Show("Món ăn đã có rồi", "Thông Báo");
                            return;
                        }
                    }
                    catch(Exception) // có lỗi ở chỗ này thì thoát
                    {
                        MessageBox.Show("Món ăn đã có rồi", "Thông Báo");
                        return;
                    }
                }
            }
            ListViewItem lstItem;
            try
            {
                lstItem = new ListViewItem(dr.Cells["TenMonAn"].Value.ToString());
                lstItem.SubItems.Add("1");
                lstItem.SubItems.Add(dr.Cells["Gia"].Value.ToString());
                lstItem.SubItems.Add((soLuong * int.Parse(dr.Cells["Gia"].Value.ToString())).ToString());
            }
            catch(Exception)
            {
                MessageBox.Show("Chọn Món Ăn Muốn Thêm", "Thông Báo");
                return;
            }
            lstHoaDon.Items.Add(lstItem);
                                          //------------ iD Hóa Đơn ----------------------- //  //----------- ID Món Ăn ----------------// //---------------- Số Lượng -----------------//
            HoaDon_BUS.ThemThongTinHoaDon(HoaDon_BUS.layIDHoaDon(danhSachBanAn[indexTable].ID), int.Parse(dr.Cells["ID"].Value.ToString()), int.Parse(lstItem.SubItems[1].Text.ToString()));

            LoadHoaDon(danhSachBanAn[indexTable].ID); //sau khi thêm thì load lại hóa đơn
        }

        // lấy dòng 1 dòng của 1 món ăn trong lsthoadon
        int chiSoCuaLsvHoaDon = -1;
        private void lstHoaDon_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            chiSoCuaLsvHoaDon = e.ItemIndex;
        }

        // tăng số lượng của món ăn lên 1
        private void btnThem1_Click(object sender, EventArgs e)
        {
            int sl;
            try
            {
                sl = int.Parse(lstHoaDon.Items[chiSoCuaLsvHoaDon].SubItems[1].Text.ToString());
            }
            catch(Exception)
            {
                return;
            }
            if (chiSoCuaLsvHoaDon != -1)
            {
                sl = sl + 1;
                lstHoaDon.Items[chiSoCuaLsvHoaDon].SubItems[1].Text = sl.ToString(); // tăng số lượng món ăn trong lstHoaDon lên 1

                // cập nhật số lượng món ăn trong Cơ Sở Dữ Liệu
                                                   // ------------------  ID hóa đơn --------------- // //----------------- id món ăn -----------------------------------------------------//
                HoaDon_BUS.CapNhatSoLuongMonAn(sl, HoaDon_BUS.layIDHoaDon(danhSachBanAn[indexTable].ID),MonAn_BUS.layIDMonAn(lstHoaDon.Items[chiSoCuaLsvHoaDon].SubItems[0].Text.ToString()));

                LoadHoaDon(danhSachBanAn[indexTable].ID); // sau khi thêm thì load lại hóa đơn 
            }
        }


        // giảm số lượng của món ăn đi 1
        private void btnGiam1_Click(object sender, EventArgs e)
        {
            int sl;
            try
            {
                sl = int.Parse(lstHoaDon.Items[chiSoCuaLsvHoaDon].SubItems[1].Text.ToString());
            }
            catch (Exception)
            {
                return;
            }
            if (chiSoCuaLsvHoaDon != -1)
            {
                if(sl > 1)
                    sl = sl - 1;
                lstHoaDon.Items[chiSoCuaLsvHoaDon].SubItems[1].Text = sl.ToString(); // Giảm số lượng món ăn đi 1
                // cập nhật lại số lượng món ăn trong cơ sở dữ liệu
                                                   // ------------------  ID hóa đơn --------------- //  // -------------------- id món ăn -------------------------------------------------//
                HoaDon_BUS.CapNhatSoLuongMonAn(sl, HoaDon_BUS.layIDHoaDon(danhSachBanAn[indexTable].ID), MonAn_BUS.layIDMonAn(lstHoaDon.Items[chiSoCuaLsvHoaDon].SubItems[0].Text.ToString()));

                LoadHoaDon(danhSachBanAn[indexTable].ID);  // sau khi thêm thì load lại hóa đơn 
            }
        }

        // ----------------------------- END THÊM MÓN ĂN ---------------------------------------------------


        // -----------------------  Bớt Món Ăn -------------------------
        private void btnBotMon_Click(object sender, EventArgs e)
        {
           
            if(lstHoaDon.Items.Count < 1)
            {
                return;
            }
            if (chiSoCuaLsvHoaDon != -1)
            {
                // xóa món ăn đã chọn dựa vào id hóa đơn và id món ăn
                try
                {
                    // xóa món ăn trong cơ sở dữ liệu dựa vào IDHoaDon và IDMonAN
                    HoaDon_BUS.XoaMonAn(HoaDon_BUS.layIDHoaDon(danhSachBanAn[indexTable].ID), MonAn_BUS.layIDMonAn(lstHoaDon.Items[chiSoCuaLsvHoaDon].SubItems[0].Text.ToString()));
                }
                catch(Exception)
                {
                    return;
                }

                lstHoaDon.Items.RemoveAt(chiSoCuaLsvHoaDon); // xóa món ăn trên listview

                LoadHoaDon(danhSachBanAn[indexTable].ID); // sau khi xóa thì load lại hóa đơn 
            }
            
        }


        //---------------------- thanh toán ------------------------------------------
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if(indexTable == -1)
            {
                return;
            }
            if(lstBanAn.Items[indexTable].ImageIndex == 1)
            {
                MessageBox.Show("Mở Bàn Để Thanh Tóan");
                return;
            }
            int tien = int.Parse(txtThanhTien.Text);

            CultureInfo cul = new CultureInfo("vi-VN"); // định dạng tiền việt
            string tienThanhToan = tien.ToString("c", cul);

            if (MessageBox.Show("Thanh Toán: " + tienThanhToan, "Thanh Toán",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                //  xóa hết món ăn trên bàn ăn đó 
                HoaDon_BUS.XoaThongTinHoaDon(HoaDon_BUS.layIDHoaDon(danhSachBanAn[indexTable].ID));

                // update số tiền
                DateTime time = DateTime.Now;
                string ngayThanhToan = time.ToString("yyyy/MM/dd");
                try
                {
                    HoaDon_BUS.UpdateHoaDon(1, ngayThanhToan, int.Parse(txtThanhTien.Text), danhSachBanAn[indexTable].ID);
                }
                catch(Exception)
                {
                    MessageBox.Show("bug rồi. huhuhu");
                    return;
                }

                // sửa lại trạng thái bàn ăn thành trống
                BanAn_BUS.SuaTrangThaiBanAn2(danhSachBanAn[indexTable].ID);

                lstBanAn.Items[indexTable].ImageIndex = 1;

                lbTrangThai.Text = "Trống";

                lbBan.ForeColor = Color.Red; // load lại màu chữ
                lbTrangThai.ForeColor = Color.Red; // load lại màu chữ

                LoadHoaDon(danhSachBanAn[indexTable].ID); // sau khi xóa thì load lại hóa đơn
            }
        }

        // --------------------- tìm kiếm ----------------------------------------
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



        // --------------------- chuyển bàn ------------------------------- 
        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            if(indexTable == -1)
            {
                MessageBox.Show("Chọn bàn muốn chuyển");
                return;
            }
            if (lstBanAn.Items[indexTable].ImageIndex == 1)
            {
                MessageBox.Show("Mở bàn để chuyển bàn");
                return;
            }
            frmChuyenBan frmChuyenBan = new frmChuyenBan();  // khởi tạo form chuyển bàn để lấy dữ liệu từ form
            frmChuyenBan.ShowDialog();

            int idToTable = frmChuyenBan.idToTable;   // lấy id của bàn muốn chuyển đến

            if(frmChuyenBan.chuyenBan == false)   // chuyển bàn = false thì không được chuyển
            {
                return;
            }

            // chuyển từ bàn có id là idfromTable đến bàn có id là idTotable
            if (HoaDon_BUS.ChuyenBan(danhSachBanAn[indexTable].ID, idToTable))
            {
                BanAn_BUS.SuaTrangThaiBanAn2(danhSachBanAn[indexTable].ID); // cập nhật lại trạng thái cho bàn vừa bị chuyển thành trống
                BanAn_BUS.SuaTrangThaiBanAn(idToTable); // cập nhật lại trạng thái cho bàn được chuyển đến thành có người
                lstBanAn.Clear();   // load lại bàn ăn
                LoadBanAn(); 

                LoadHoaDon(danhSachBanAn[indexTable].ID); // load lại hóa đơn
                
                // cập nhật lại màu chữ cho label
                lbTrangThai.Text = "Trống";
                lbBan.ForeColor = Color.Red;
                lbTrangThai.ForeColor = Color.Red;

                MessageBox.Show("Chuyển thành công");
                return;
            }
            MessageBox.Show("Chuyển thất bại !","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }



        // -------------------- in hóa đơn ---------------------------------------

        public static int id;                   // các biến sẽ truyền vào reportviewer
        public static string tenBan;            // các biến sẽ truyền vào reportviewer
        public static long tongTien;           // các biến sẽ truyền vào reportviewer
        public static long khuyenMai;          // các biến sẽ truyền vào reportviewer
        public static string maHoaDon;          // các biến sẽ truyền vào reportviewer
        public static long thanhTien;         // các biến sẽ truyền vào reportviewer

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if(indexTable == -1)
            {
                MessageBox.Show("Chọn bàn muốn in");
                return;
            }
            if(lstBanAn.Items[indexTable].ImageIndex == 1)
            {
                MessageBox.Show("Mở bàn để in hóa đơn");
                return;
            }
            id = danhSachBanAn[indexTable].ID;
            tenBan = danhSachBanAn[indexTable].TenBan;
            maHoaDon = (HoaDon_BUS.layIDHoaDon(danhSachBanAn[indexTable].ID)).ToString();
            tongTien =  long.Parse(txtTongCong.Text);
            khuyenMai = long.Parse(txtTongCong.Text) - long.Parse(txtThanhTien.Text);
            thanhTien = long.Parse(txtThanhTien.Text);

            frmInHoaDon inHoaDon = new frmInHoaDon();
            inHoaDon.ShowDialog();
        }
    }
}
