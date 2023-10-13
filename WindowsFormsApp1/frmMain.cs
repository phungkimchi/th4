using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnQuanLiBanAn_Click(object sender, EventArgs e)
        {
            frmQuanLiBanAn quanLiBanAn = new frmQuanLiBanAn();
            quanLiBanAn.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát Khỏi Hệ Thống", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnQuanLiThucDon_Click(object sender, EventArgs e)
        {
            frmQuanLiThucDon quanLiThucDon = new frmQuanLiThucDon();
            quanLiThucDon.ShowDialog();
        }

        private void btnQuanLiNhanSu_Click(object sender, EventArgs e)
        {
            frmQuanLiNhanSu quanLiNhanSu = new frmQuanLiNhanSu();
            quanLiNhanSu.ShowDialog();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            frmDoanhThu doanhThu = new frmDoanhThu();
            doanhThu.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe thongKe = new frmThongKe();
            thongKe.ShowDialog();
        }

        private void btnLiênHệ_Click(object sender, EventArgs e)
        {
            frmLienHe lienHe = new frmLienHe();
            lienHe.ShowDialog();
        }
    }
}
