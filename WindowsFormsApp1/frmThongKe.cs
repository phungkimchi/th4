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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        DateTime now;
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            now = DateTime.Now;
            lbNgay.Text = now.ToString();

            lbTongSoHoaDon.Text = TongSoHoaDon().ToString();
            lbDoanhThu.Text = DoanhThu();
        }

        private int TongSoHoaDon()
        {
            List<QuanLiHoaDon_DTO> lstHoaDon = HoaDon_BUS.LocHoaDon(now.ToString("yyyy/MM/dd"), now.ToString("yyyy/MM/dd"));

            return lstHoaDon.Count;
        }
        private string DoanhThu()
        {
            List<QuanLiHoaDon_DTO> lstHoaDon = HoaDon_BUS.LocHoaDon(now.ToString("yyyy/MM/dd"), now.ToString("yyyy/MM/dd"));

            long doanhThu = 0;

            foreach(QuanLiHoaDon_DTO hd in lstHoaDon)
            {
                doanhThu += long.Parse(hd.SoTien);
            }
            CultureInfo cul = new CultureInfo("vi-VN");
            return doanhThu.ToString("c",cul);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<QuanLiHoaDon_DTO> lstHoaDon = HoaDon_BUS.LocHoaDon(dtpTuNgay.Text, dtpDenNgay.Text);
            if (lstHoaDon == null)
            {
                MessageBox.Show("Không có kết quả nào");
                return;
            }
            
            
            lbHD.Text = lstHoaDon.Count.ToString();
            

            long doanhThu = 0;
            foreach (QuanLiHoaDon_DTO hd in lstHoaDon)
            {
                doanhThu += long.Parse(hd.SoTien);
            }
            CultureInfo cul = new CultureInfo("vi-VN");
            lbDT.Text = doanhThu.ToString("c", cul);
        }
    }
}
