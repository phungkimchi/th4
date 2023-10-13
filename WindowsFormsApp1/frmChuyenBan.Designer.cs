namespace WindowsFormsApp1
{
    partial class frmChuyenBan
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChuyenBan = new System.Windows.Forms.ComboBox();
            this.btnChuyen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuyển Đến Bàn";
            // 
            // cmbChuyenBan
            // 
            this.cmbChuyenBan.FormattingEnabled = true;
            this.cmbChuyenBan.Location = new System.Drawing.Point(112, 75);
            this.cmbChuyenBan.Name = "cmbChuyenBan";
            this.cmbChuyenBan.Size = new System.Drawing.Size(204, 24);
            this.cmbChuyenBan.TabIndex = 1;
            this.cmbChuyenBan.SelectedIndexChanged += new System.EventHandler(this.cmbChuyenBan_SelectedIndexChanged);
            // 
            // btnChuyen
            // 
            this.btnChuyen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChuyen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChuyen.Location = new System.Drawing.Point(153, 128);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(115, 44);
            this.btnChuyen.TabIndex = 2;
            this.btnChuyen.Text = "Chuyển";
            this.btnChuyen.UseVisualStyleBackColor = false;
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // frmChuyenBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(402, 184);
            this.Controls.Add(this.btnChuyen);
            this.Controls.Add(this.cmbChuyenBan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChuyenBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lí nhà hàng";
            this.Load += new System.EventHandler(this.frmChuyenBan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChuyenBan;
        private System.Windows.Forms.Button btnChuyen;
    }
}