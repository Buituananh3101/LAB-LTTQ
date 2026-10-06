namespace LAB_LTTQ.DanhMuc
{
    partial class frmSanPham
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMaHang = new System.Windows.Forms.Label();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.lblChatLieu = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblDonGiaNhap = new System.Windows.Forms.Label();
            this.lblDonGiaBan = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.cboChatLieu = new System.Windows.Forms.ComboBox();
            this.btnChatLieu = new System.Windows.Forms.Button();
            this.btnAnh = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.dgvHang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTieuDe.Location = new System.Drawing.Point(40, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(800, 45);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "DANH MỤC HÀNG HÓA";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaHang
            // 
            this.lblMaHang.Location = new System.Drawing.Point(40, 85);
            this.lblMaHang.Name = "lblMaHang";
            this.lblMaHang.Size = new System.Drawing.Size(110, 25);
            this.lblMaHang.TabIndex = 1;
            this.lblMaHang.Text = "Mã hàng:";
            this.lblMaHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTenHang
            // 
            this.lblTenHang.Location = new System.Drawing.Point(40, 125);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(110, 25);
            this.lblTenHang.TabIndex = 3;
            this.lblTenHang.Text = "Tên hàng:";
            this.lblTenHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblChatLieu
            // 
            this.lblChatLieu.Location = new System.Drawing.Point(40, 165);
            this.lblChatLieu.Name = "lblChatLieu";
            this.lblChatLieu.Size = new System.Drawing.Size(110, 25);
            this.lblChatLieu.TabIndex = 5;
            this.lblChatLieu.Text = "Chất liệu:";
            this.lblChatLieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Location = new System.Drawing.Point(40, 205);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(110, 25);
            this.lblSoLuong.TabIndex = 8;
            this.lblSoLuong.Text = "Số lượng:";
            this.lblSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDonGiaNhap
            // 
            this.lblDonGiaNhap.Location = new System.Drawing.Point(40, 245);
            this.lblDonGiaNhap.Name = "lblDonGiaNhap";
            this.lblDonGiaNhap.Size = new System.Drawing.Size(110, 25);
            this.lblDonGiaNhap.TabIndex = 10;
            this.lblDonGiaNhap.Text = "Đơn giá nhập:";
            this.lblDonGiaNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDonGiaBan
            // 
            this.lblDonGiaBan.Location = new System.Drawing.Point(40, 285);
            this.lblDonGiaBan.Name = "lblDonGiaBan";
            this.lblDonGiaBan.Size = new System.Drawing.Size(110, 25);
            this.lblDonGiaBan.TabIndex = 12;
            this.lblDonGiaBan.Text = "Đơn giá bán:";
            this.lblDonGiaBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.Location = new System.Drawing.Point(480, 275);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(90, 25);
            this.lblGhiChu.TabIndex = 16;
            this.lblGhiChu.Text = "Ghi chú:";
            this.lblGhiChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(155, 85);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(270, 29);
            this.txtMaHang.TabIndex = 2;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(155, 125);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(270, 29);
            this.txtTenHang.TabIndex = 4;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(155, 205);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(270, 29);
            this.txtSoLuong.TabIndex = 9;
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Location = new System.Drawing.Point(155, 245);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(270, 29);
            this.txtDonGiaNhap.TabIndex = 11;
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Location = new System.Drawing.Point(155, 285);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(270, 29);
            this.txtDonGiaBan.TabIndex = 13;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(575, 275);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGhiChu.Size = new System.Drawing.Size(245, 60);
            this.txtGhiChu.TabIndex = 17;
            // 
            // cboChatLieu
            // 
            this.cboChatLieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChatLieu.FormattingEnabled = true;
            this.cboChatLieu.Location = new System.Drawing.Point(155, 165);
            this.cboChatLieu.Name = "cboChatLieu";
            this.cboChatLieu.Size = new System.Drawing.Size(165, 29);
            this.cboChatLieu.TabIndex = 6;
            // 
            // btnChatLieu
            // 
            this.btnChatLieu.Location = new System.Drawing.Point(330, 165);
            this.btnChatLieu.Name = "btnChatLieu";
            this.btnChatLieu.Size = new System.Drawing.Size(95, 32);
            this.btnChatLieu.TabIndex = 7;
            this.btnChatLieu.Text = "Chất liệu";
            this.btnChatLieu.UseVisualStyleBackColor = true;
            // 
            // btnAnh
            // 
            this.btnAnh.Location = new System.Drawing.Point(480, 80);
            this.btnAnh.Name = "btnAnh";
            this.btnAnh.Size = new System.Drawing.Size(75, 32);
            this.btnAnh.TabIndex = 14;
            this.btnAnh.Text = "Ảnh";
            this.btnAnh.UseVisualStyleBackColor = true;
            this.btnAnh.Click += new System.EventHandler(this.btnAnh_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(40, 345);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(110, 32);
            this.btnTim.TabIndex = 18;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(170, 345);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(125, 32);
            this.btnExcel.TabIndex = 19;
            this.btnExcel.Text = "Xuất ra Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(55, 605);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(100, 38);
            this.btnThemMoi.TabIndex = 21;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(185, 605);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 38);
            this.btnLuu.TabIndex = 22;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(315, 605);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 38);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(445, 605);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 38);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(575, 605);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(100, 38);
            this.btnBoQua.TabIndex = 25;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(705, 605);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 38);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // picAnh
            // 
            this.picAnh.BackColor = System.Drawing.Color.White;
            this.picAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnh.Location = new System.Drawing.Point(575, 80);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(245, 175);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabIndex = 15;
            this.picAnh.TabStop = false;
            // 
            // dgvHang
            // 
            this.dgvHang.AllowUserToAddRows = false;
            this.dgvHang.AllowUserToDeleteRows = false;
            this.dgvHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHang.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHang.Location = new System.Drawing.Point(40, 390);
            this.dgvHang.MultiSelect = false;
            this.dgvHang.Name = "dgvHang";
            this.dgvHang.ReadOnly = true;
            this.dgvHang.RowHeadersWidth = 30;
            this.dgvHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHang.Size = new System.Drawing.Size(780, 185);
            this.dgvHang.TabIndex = 20;
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(233)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(870, 665);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblMaHang);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.lblTenHang);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.lblChatLieu);
            this.Controls.Add(this.cboChatLieu);
            this.Controls.Add(this.btnChatLieu);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lblDonGiaNhap);
            this.Controls.Add(this.txtDonGiaNhap);
            this.Controls.Add(this.lblDonGiaBan);
            this.Controls.Add(this.txtDonGiaBan);
            this.Controls.Add(this.btnAnh);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dgvHang);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnThoat);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục hàng hóa";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaHang;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.Label lblChatLieu;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblDonGiaNhap;
        private System.Windows.Forms.Label lblDonGiaBan;
        private System.Windows.Forms.Label lblGhiChu;

        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.TextBox txtGhiChu;

        private System.Windows.Forms.ComboBox cboChatLieu;

        private System.Windows.Forms.Button btnChatLieu;
        private System.Windows.Forms.Button btnAnh;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnThoat;

        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.DataGridView dgvHang;
    }
}