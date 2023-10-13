namespace WindowsFormsApp1
{
    partial class frmQuanLiBanAn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLiBanAn));
            this.imgBan = new System.Windows.Forms.ImageList(this.components);
            this.tabBanHang = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabBaoTri = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.txtPhanCham = new System.Windows.Forms.TextBox();
            this.lstHoaDon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.lbBan = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbT = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lstBanAn = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnBotMon = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.dgvDanhSachMonAn = new System.Windows.Forms.DataGridView();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKhuyenMai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongCong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMoBan = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnThem1 = new System.Windows.Forms.Button();
            this.btnGiam1 = new System.Windows.Forms.Button();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.ttThemSoLuong = new System.Windows.Forms.ToolTip(this.components);
            this.ttGiamSoLuongMon = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBan
            // 
            this.imgBan.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgBan.ImageStream")));
            this.imgBan.TransparentColor = System.Drawing.Color.Transparent;
            this.imgBan.Images.SetKeyName(0, "ban.png");
            this.imgBan.Images.SetKeyName(1, "banko.png");
            // 
            // tabBanHang
            // 
            this.tabBanHang.BackColor = System.Drawing.Color.Black;
            this.tabBanHang.Name = "tabBanHang";
            this.tabBanHang.Text = "Bán Hàng";
            // 
            // tabBaoTri
            // 
            this.tabBaoTri.Name = "tabBaoTri";
            this.tabBaoTri.Text = "Bảo Trì Bàn";
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1390, 725);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Text = "tabControl1";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.btnInHoaDon);
            this.tabControlPanel1.Controls.Add(this.lbTime);
            this.tabControlPanel1.Controls.Add(this.label9);
            this.tabControlPanel1.Controls.Add(this.btnChuyenBan);
            this.tabControlPanel1.Controls.Add(this.txtPhanCham);
            this.tabControlPanel1.Controls.Add(this.lstHoaDon);
            this.tabControlPanel1.Controls.Add(this.lbTrangThai);
            this.tabControlPanel1.Controls.Add(this.lbBan);
            this.tabControlPanel1.Controls.Add(this.label11);
            this.tabControlPanel1.Controls.Add(this.lbT);
            this.tabControlPanel1.Controls.Add(this.lb);
            this.tabControlPanel1.Controls.Add(this.lstBanAn);
            this.tabControlPanel1.Controls.Add(this.label8);
            this.tabControlPanel1.Controls.Add(this.label7);
            this.tabControlPanel1.Controls.Add(this.label6);
            this.tabControlPanel1.Controls.Add(this.label5);
            this.tabControlPanel1.Controls.Add(this.label4);
            this.tabControlPanel1.Controls.Add(this.txtTimKiem);
            this.tabControlPanel1.Controls.Add(this.btnBotMon);
            this.tabControlPanel1.Controls.Add(this.btnThemMon);
            this.tabControlPanel1.Controls.Add(this.dgvDanhSachMonAn);
            this.tabControlPanel1.Controls.Add(this.txtThanhTien);
            this.tabControlPanel1.Controls.Add(this.label3);
            this.tabControlPanel1.Controls.Add(this.txtKhuyenMai);
            this.tabControlPanel1.Controls.Add(this.label2);
            this.tabControlPanel1.Controls.Add(this.txtTongCong);
            this.tabControlPanel1.Controls.Add(this.label1);
            this.tabControlPanel1.Controls.Add(this.btnMoBan);
            this.tabControlPanel1.Controls.Add(this.btnThanhToan);
            this.tabControlPanel1.Controls.Add(this.btnThem1);
            this.tabControlPanel1.Controls.Add(this.btnGiam1);
            this.tabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(1390, 699);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.ForestGreen;
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.White;
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = -90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItem1;
            this.tabControlPanel1.Text = "Bảo Trì Bàn";
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.SystemColors.Control;
            this.btnInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.Image = global::WindowsFormsApp1.Properties.Resources.print;
            this.btnInHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHoaDon.Location = new System.Drawing.Point(423, 631);
            this.btnInHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(163, 57);
            this.btnInHoaDon.TabIndex = 145;
            this.btnInHoaDon.Text = "             In Hóa Đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.lbTime.Location = new System.Drawing.Point(686, 39);
            this.lbTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(0, 16);
            this.lbTime.TabIndex = 144;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(632, 39);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 143;
            this.label9.Text = "Ngày : ";
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.BackColor = System.Drawing.SystemColors.Control;
            this.btnChuyenBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChuyenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenBan.ForeColor = System.Drawing.Color.Black;
            this.btnChuyenBan.Location = new System.Drawing.Point(791, 317);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(113, 54);
            this.btnChuyenBan.TabIndex = 142;
            this.btnChuyenBan.Text = "Chuyển Bàn";
            this.btnChuyenBan.UseVisualStyleBackColor = false;
            this.btnChuyenBan.Click += new System.EventHandler(this.btnChuyenBan_Click);
            // 
            // txtPhanCham
            // 
            this.txtPhanCham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhanCham.Location = new System.Drawing.Point(690, 542);
            this.txtPhanCham.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhanCham.Name = "txtPhanCham";
            this.txtPhanCham.Size = new System.Drawing.Size(48, 22);
            this.txtPhanCham.TabIndex = 141;
            this.txtPhanCham.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPhanCham.TextChanged += new System.EventHandler(this.txtPhanCham_TextChanged_1);
            this.txtPhanCham.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhanCham_KeyPress_1);
            // 
            // lstHoaDon
            // 
            this.lstHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstHoaDon.FullRowSelect = true;
            this.lstHoaDon.GridLines = true;
            this.lstHoaDon.Location = new System.Drawing.Point(414, 120);
            this.lstHoaDon.Name = "lstHoaDon";
            this.lstHoaDon.Size = new System.Drawing.Size(373, 358);
            this.lstHoaDon.TabIndex = 140;
            this.lstHoaDon.UseCompatibleStateImageBehavior = false;
            this.lstHoaDon.View = System.Windows.Forms.View.Details;
            this.lstHoaDon.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstHoaDon_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món Ăn";
            this.columnHeader1.Width = 123;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng";
            this.columnHeader2.Width = 74;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Giá";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 96;
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.lbTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangThai.ForeColor = System.Drawing.Color.Red;
            this.lbTrangThai.Location = new System.Drawing.Point(679, 92);
            this.lbTrangThai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(72, 16);
            this.lbTrangThai.TabIndex = 139;
            this.lbTrangThai.Text = "Không có";
            // 
            // lbBan
            // 
            this.lbBan.AutoSize = true;
            this.lbBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.lbBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBan.ForeColor = System.Drawing.Color.Red;
            this.lbBan.Location = new System.Drawing.Point(679, 65);
            this.lbBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBan.Name = "lbBan";
            this.lbBan.Size = new System.Drawing.Size(80, 16);
            this.lbBan.TabIndex = 138;
            this.lbBan.Text = "Chưa chọn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(911, 100);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 137;
            this.label11.Text = "Tìm Kiếm";
            // 
            // lbT
            // 
            this.lbT.AutoSize = true;
            this.lbT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.lbT.Location = new System.Drawing.Point(598, 92);
            this.lbT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbT.Name = "lbT";
            this.lbT.Size = new System.Drawing.Size(80, 16);
            this.lbT.TabIndex = 136;
            this.lbT.Text = "Trạng Thái :";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.lb.Location = new System.Drawing.Point(641, 65);
            this.lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(41, 16);
            this.lb.TabIndex = 135;
            this.lb.Text = "Bàn : ";
            // 
            // lstBanAn
            // 
            this.lstBanAn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBanAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstBanAn.LargeImageList = this.imgBan;
            this.lstBanAn.Location = new System.Drawing.Point(11, 120);
            this.lstBanAn.Margin = new System.Windows.Forms.Padding(2);
            this.lstBanAn.Name = "lstBanAn";
            this.lstBanAn.Size = new System.Drawing.Size(398, 568);
            this.lstBanAn.SmallImageList = this.imgBan;
            this.lstBanAn.TabIndex = 134;
            this.lstBanAn.UseCompatibleStateImageBehavior = false;
            this.lstBanAn.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstBanAn_ItemSelectionChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(144, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 23);
            this.label8.TabIndex = 133;
            this.label8.Text = "Sơ Đồ Bàn Ăn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1074, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 23);
            this.label7.TabIndex = 132;
            this.label7.Text = "Danh Sách Món Ăn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(742, 545);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 130;
            this.label6.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(662, 545);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 16);
            this.label5.TabIndex = 129;
            this.label5.Text = "|";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(633, 545);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 16);
            this.label4.TabIndex = 128;
            this.label4.Text = "đ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.Location = new System.Drawing.Point(979, 95);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(397, 22);
            this.txtTimKiem.TabIndex = 127;
            this.txtTimKiem.Text = "  Nhập tên món ăn ...";
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // btnBotMon
            // 
            this.btnBotMon.BackColor = System.Drawing.SystemColors.Control;
            this.btnBotMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBotMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBotMon.ForeColor = System.Drawing.Color.Black;
            this.btnBotMon.Location = new System.Drawing.Point(792, 260);
            this.btnBotMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnBotMon.Name = "btnBotMon";
            this.btnBotMon.Size = new System.Drawing.Size(113, 52);
            this.btnBotMon.TabIndex = 126;
            this.btnBotMon.Text = "Bớt Món    >>";
            this.btnBotMon.UseVisualStyleBackColor = false;
            this.btnBotMon.Click += new System.EventHandler(this.btnBotMon_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.ForeColor = System.Drawing.Color.Black;
            this.btnThemMon.Location = new System.Drawing.Point(792, 203);
            this.btnThemMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(113, 53);
            this.btnThemMon.TabIndex = 125;
            this.btnThemMon.Text = "<<   Thêm Món";
            this.btnThemMon.UseVisualStyleBackColor = false;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // dgvDanhSachMonAn
            // 
            this.dgvDanhSachMonAn.AllowUserToAddRows = false;
            this.dgvDanhSachMonAn.AllowUserToDeleteRows = false;
            this.dgvDanhSachMonAn.AllowUserToResizeColumns = false;
            this.dgvDanhSachMonAn.AllowUserToResizeRows = false;
            this.dgvDanhSachMonAn.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMonAn.Location = new System.Drawing.Point(911, 122);
            this.dgvDanhSachMonAn.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDanhSachMonAn.MultiSelect = false;
            this.dgvDanhSachMonAn.Name = "dgvDanhSachMonAn";
            this.dgvDanhSachMonAn.ReadOnly = true;
            this.dgvDanhSachMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachMonAn.Size = new System.Drawing.Size(465, 567);
            this.dgvDanhSachMonAn.TabIndex = 123;
            this.dgvDanhSachMonAn.Click += new System.EventHandler(this.dgvDanhSachMonAn_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BackColor = System.Drawing.SystemColors.Window;
            this.txtThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtThanhTien.Location = new System.Drawing.Point(567, 573);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(192, 26);
            this.txtThanhTien.TabIndex = 122;
            this.txtThanhTien.Text = "0";
            this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 573);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 121;
            this.label3.Text = "Thành Tiền";
            // 
            // txtKhuyenMai
            // 
            this.txtKhuyenMai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKhuyenMai.Location = new System.Drawing.Point(567, 542);
            this.txtKhuyenMai.Margin = new System.Windows.Forms.Padding(2);
            this.txtKhuyenMai.Name = "txtKhuyenMai";
            this.txtKhuyenMai.Size = new System.Drawing.Size(62, 22);
            this.txtKhuyenMai.TabIndex = 120;
            this.txtKhuyenMai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtKhuyenMai.TextChanged += new System.EventHandler(this.txtKhuyenMai_TextChanged_1);
            this.txtKhuyenMai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKhuyenMai_KeyPress_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(435, 542);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 119;
            this.label2.Text = "Khuyến Mãi";
            // 
            // txtTongCong
            // 
            this.txtTongCong.BackColor = System.Drawing.SystemColors.Window;
            this.txtTongCong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongCong.ForeColor = System.Drawing.Color.Red;
            this.txtTongCong.Location = new System.Drawing.Point(567, 505);
            this.txtTongCong.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongCong.Name = "txtTongCong";
            this.txtTongCong.ReadOnly = true;
            this.txtTongCong.Size = new System.Drawing.Size(192, 26);
            this.txtTongCong.TabIndex = 118;
            this.txtTongCong.Text = "0";
            this.txtTongCong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 513);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 117;
            this.label1.Text = "Tổng Cộng";
            // 
            // btnMoBan
            // 
            this.btnMoBan.BackColor = System.Drawing.Color.White;
            this.btnMoBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoBan.Location = new System.Drawing.Point(414, 63);
            this.btnMoBan.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoBan.Name = "btnMoBan";
            this.btnMoBan.Size = new System.Drawing.Size(94, 45);
            this.btnMoBan.TabIndex = 115;
            this.btnMoBan.Text = "Mở Bàn";
            this.btnMoBan.UseVisualStyleBackColor = false;
            this.btnMoBan.Click += new System.EventHandler(this.btnMoBan_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.SystemColors.Control;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Image = global::WindowsFormsApp1.Properties.Resources.money;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(611, 631);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(164, 57);
            this.btnThanhToan.TabIndex = 124;
            this.btnThanhToan.Text = "            Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnThem1
            // 
            this.btnThem1.BackColor = System.Drawing.Color.ForestGreen;
            this.btnThem1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem1.Image = global::WindowsFormsApp1.Properties.Resources.them1;
            this.btnThem1.Location = new System.Drawing.Point(520, 87);
            this.btnThem1.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem1.Name = "btnThem1";
            this.btnThem1.Size = new System.Drawing.Size(22, 20);
            this.btnThem1.TabIndex = 131;
            this.ttThemSoLuong.SetToolTip(this.btnThem1, "Thếm số lượng món");
            this.btnThem1.UseVisualStyleBackColor = false;
            this.btnThem1.Click += new System.EventHandler(this.btnThem1_Click);
            // 
            // btnGiam1
            // 
            this.btnGiam1.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGiam1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGiam1.Image = global::WindowsFormsApp1.Properties.Resources.tru1;
            this.btnGiam1.Location = new System.Drawing.Point(555, 87);
            this.btnGiam1.Margin = new System.Windows.Forms.Padding(2);
            this.btnGiam1.Name = "btnGiam1";
            this.btnGiam1.Size = new System.Drawing.Size(22, 20);
            this.btnGiam1.TabIndex = 116;
            this.ttGiamSoLuongMon.SetToolTip(this.btnGiam1, "Giảm số lượng món ăn");
            this.btnGiam1.UseVisualStyleBackColor = false;
            this.btnGiam1.Click += new System.EventHandler(this.btnGiam1_Click);
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.BackColor = System.Drawing.Color.ForestGreen;
            this.tabItem1.BackColor2 = System.Drawing.Color.White;
            this.tabItem1.BorderColor = System.Drawing.Color.ForestGreen;
            this.tabItem1.DarkBorderColor = System.Drawing.Color.ForestGreen;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "Quản Lí Bàn Ăn";
            this.tabItem1.TextColor = System.Drawing.Color.ForestGreen;
            // 
            // ttThemSoLuong
            // 
            this.ttThemSoLuong.AutoPopDelay = 3000;
            this.ttThemSoLuong.InitialDelay = 100;
            this.ttThemSoLuong.IsBalloon = true;
            this.ttThemSoLuong.ReshowDelay = 100;
            // 
            // ttGiamSoLuongMon
            // 
            this.ttGiamSoLuongMon.AutoPopDelay = 3000;
            this.ttGiamSoLuongMon.InitialDelay = 100;
            this.ttGiamSoLuongMon.IsBalloon = true;
            this.ttGiamSoLuongMon.ReshowDelay = 100;
            // 
            // frmQuanLiBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1390, 725);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLiBanAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mền Quản Lí Nhà Hàng";
            this.Load += new System.EventHandler(this.frmQuanLiBanAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.tabControlPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMonAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imgBan;
        private DevComponents.DotNetBar.TabItem tabBaoTri;
        private DevComponents.DotNetBar.TabItem tabBanHang;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private System.Windows.Forms.TextBox txtPhanCham;
        private System.Windows.Forms.ListView lstHoaDon;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.Label lbBan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbT;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.ListView lstBanAn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThem1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnBotMon;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridView dgvDanhSachMonAn;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKhuyenMai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTongCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGiam1;
        private System.Windows.Forms.Button btnMoBan;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnChuyenBan;
        private System.Windows.Forms.ToolTip ttThemSoLuong;
        private System.Windows.Forms.ToolTip ttGiamSoLuongMon;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnInHoaDon;
    }
}