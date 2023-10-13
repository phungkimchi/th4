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
    public partial class frmChuyenBan : Form
    {
        public frmChuyenBan()
        {
            InitializeComponent();
        }

        private void frmChuyenBan_Load(object sender, EventArgs e)
        {
            LoadBanAn();
        }
        public List<BanAn_DTO> lstBanAn;
        void LoadBanAn()
        {
            lstBanAn = BanAn_BUS.LoadBanAn();
            cmbChuyenBan.DataSource = lstBanAn;

            cmbChuyenBan.SelectedIndex = 0;
            cmbChuyenBan.DisplayMember = "TenBan";
            cmbChuyenBan.ValueMember = "ID";
        }

        public int inDexTable;
        private void cmbChuyenBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            inDexTable = cmbChuyenBan.SelectedIndex;
        }

        public int idToTable;
        public bool chuyenBan; // chuyen ban = true thì đc chuyển ko thì ko đc chuyển
        private void btnChuyen_Click(object sender, EventArgs e)
        {
            if(lstBanAn[inDexTable].TrangThai == "Có Người")
            {
                MessageBox.Show("Bàn này có người rồi");
                chuyenBan = false;
                return;
            }
            chuyenBan = true;
            idToTable = int.Parse(cmbChuyenBan.SelectedValue.ToString());
            this.Close();
        }
        
    }
}
