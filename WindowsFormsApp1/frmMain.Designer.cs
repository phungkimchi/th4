namespace WindowsFormsApp1
{
    partial class frmMain
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLiênHệ = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnQuanLiThucDon = new System.Windows.Forms.Button();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.btnQuanLiNhanSu = new System.Windows.Forms.Button();
            this.btnQuanLiBanAn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Black;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Image = global::WindowsFormsApp1.Properties.Resources.close1;
            this.btnThoat.Location = new System.Drawing.Point(501, 482);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(477, 120);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLiênHệ
            // 
            this.btnLiênHệ.BackColor = System.Drawing.Color.Aquamarine;
            this.btnLiênHệ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLiênHệ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLiênHệ.Image = global::WindowsFormsApp1.Properties.Resources.phone;
            this.btnLiênHệ.Location = new System.Drawing.Point(745, 233);
            this.btnLiênHệ.Margin = new System.Windows.Forms.Padding(6);
            this.btnLiênHệ.Name = "btnLiênHệ";
            this.btnLiênHệ.Size = new System.Drawing.Size(233, 237);
            this.btnLiênHệ.TabIndex = 7;
            this.btnLiênHệ.Text = "Thông Tin - Liên Hệ";
            this.btnLiênHệ.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLiênHệ.UseVisualStyleBackColor = false;
            this.btnLiênHệ.Click += new System.EventHandler(this.btnLiênHệ_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThongKe.Image = global::WindowsFormsApp1.Properties.Resources.thongke;
            this.btnThongKe.Location = new System.Drawing.Point(501, 233);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(6);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(232, 237);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnQuanLiThucDon
            // 
            this.btnQuanLiThucDon.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnQuanLiThucDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLiThucDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuanLiThucDon.Image = global::WindowsFormsApp1.Properties.Resources.menu;
            this.btnQuanLiThucDon.Location = new System.Drawing.Point(501, 15);
            this.btnQuanLiThucDon.Margin = new System.Windows.Forms.Padding(6);
            this.btnQuanLiThucDon.Name = "btnQuanLiThucDon";
            this.btnQuanLiThucDon.Size = new System.Drawing.Size(477, 206);
            this.btnQuanLiThucDon.TabIndex = 5;
            this.btnQuanLiThucDon.Text = "Quản Lí Thực Đơn";
            this.btnQuanLiThucDon.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnQuanLiThucDon.UseVisualStyleBackColor = false;
            this.btnQuanLiThucDon.Click += new System.EventHandler(this.btnQuanLiThucDon_Click);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDoanhThu.Image = global::WindowsFormsApp1.Properties.Resources.doanhthu;
            this.btnDoanhThu.Location = new System.Drawing.Point(294, 343);
            this.btnDoanhThu.Margin = new System.Windows.Forms.Padding(6);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(194, 259);
            this.btnDoanhThu.TabIndex = 2;
            this.btnDoanhThu.Text = "Quản Lí Hóa Đơn";
            this.btnDoanhThu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDoanhThu.UseVisualStyleBackColor = false;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // btnQuanLiNhanSu
            // 
            this.btnQuanLiNhanSu.BackColor = System.Drawing.Color.Crimson;
            this.btnQuanLiNhanSu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLiNhanSu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuanLiNhanSu.Image = global::WindowsFormsApp1.Properties.Resources.person;
            this.btnQuanLiNhanSu.Location = new System.Drawing.Point(9, 343);
            this.btnQuanLiNhanSu.Margin = new System.Windows.Forms.Padding(6);
            this.btnQuanLiNhanSu.Name = "btnQuanLiNhanSu";
            this.btnQuanLiNhanSu.Size = new System.Drawing.Size(270, 259);
            this.btnQuanLiNhanSu.TabIndex = 1;
            this.btnQuanLiNhanSu.Text = "Quản Lí Nhân Sự";
            this.btnQuanLiNhanSu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnQuanLiNhanSu.UseVisualStyleBackColor = false;
            this.btnQuanLiNhanSu.Click += new System.EventHandler(this.btnQuanLiNhanSu_Click);
            // 
            // btnQuanLiBanAn
            // 
            this.btnQuanLiBanAn.BackColor = System.Drawing.Color.ForestGreen;
            this.btnQuanLiBanAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLiBanAn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuanLiBanAn.ForeColor = System.Drawing.Color.Black;
            this.btnQuanLiBanAn.Image = global::WindowsFormsApp1.Properties.Resources.tb;
            this.btnQuanLiBanAn.Location = new System.Drawing.Point(12, 15);
            this.btnQuanLiBanAn.Margin = new System.Windows.Forms.Padding(6);
            this.btnQuanLiBanAn.Name = "btnQuanLiBanAn";
            this.btnQuanLiBanAn.Size = new System.Drawing.Size(477, 316);
            this.btnQuanLiBanAn.TabIndex = 0;
            this.btnQuanLiBanAn.Text = "Quản Lí Bàn Ăn";
            this.btnQuanLiBanAn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnQuanLiBanAn.UseVisualStyleBackColor = false;
            this.btnQuanLiBanAn.Click += new System.EventHandler(this.btnQuanLiBanAn_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 618);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLiênHệ);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnQuanLiThucDon);
            this.Controls.Add(this.btnDoanhThu);
            this.Controls.Add(this.btnQuanLiNhanSu);
            this.Controls.Add(this.btnQuanLiBanAn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lí Nhà Hàng";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuanLiBanAn;
        private System.Windows.Forms.Button btnQuanLiNhanSu;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Button btnQuanLiThucDon;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnLiênHệ;
        private System.Windows.Forms.Button btnThoat;
    }
}

