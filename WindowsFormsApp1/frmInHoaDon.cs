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
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApp1
{
    public partial class frmInHoaDon : Form
    {
        public frmInHoaDon()
        {
            InitializeComponent();
        }
        //----------------  in hóa đơn -----------------------------
        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            CultureInfo cul = new CultureInfo("vi-VN");


            DateTime nowTime = DateTime.Now;

            // các thuộc tính sẽ truyền vào hóa đơn
            ReportParameter p1 = new ReportParameter("tenBan",frmQuanLiBanAn.tenBan);
            ReportParameter p2 = new ReportParameter("maHoaDon", frmQuanLiBanAn.maHoaDon);
            ReportParameter p3 = new ReportParameter("time", nowTime.ToString("dd/MM/yyyy"));
            ReportParameter p4 = new ReportParameter("tongTien", frmQuanLiBanAn.tongTien.ToString("c",cul));
            ReportParameter p5 = new ReportParameter("khuyenMai", frmQuanLiBanAn.khuyenMai.ToString("c", cul));
            ReportParameter p6 = new ReportParameter("thanhTien", frmQuanLiBanAn.thanhTien.ToString("c", cul));

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1,p2,p3,p4,p5,p6});
           
            // in hóa đơn dựa vào id bàn
            this.DataTable1TableAdapter.Fill(this.dsHoaDon.DataTable1,frmQuanLiBanAn.id);

            this.reportViewer1.RefreshReport();
        }

    }
}
