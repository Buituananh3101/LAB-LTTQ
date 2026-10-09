namespace LAB_LTTQ
{
    partial class frmQuanLiNhap
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
            this.grpPhieuNhapXuat = new System.Windows.Forms.GroupBox();
            this.lblSoPhieu = new System.Windows.Forms.Label();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.lblLoaiPhieu = new System.Windows.Forms.Label();
            this.radNhapKho = new System.Windows.Forms.RadioButton();
            this.radXuatKho = new System.Windows.Forms.RadioButton();
            this.lblMatHang = new System.Windows.Forms.Label();
            this.cboMatHang = new System.Windows.Forms.ComboBox();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.grpSoNhapXuat = new System.Windows.Forms.GroupBox();
            this.lstSoNhapXuat = new System.Windows.Forms.ListBox();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoaPhieu = new System.Windows.Forms.Button();
            this.btnXemTonKho = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpPhieuNhapXuat.SuspendLayout();
            this.grpSoNhapXuat.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPhieuNhapXuat
            // 
            this.grpPhieuNhapXuat.Controls.Add(this.lblSoPhieu);
            this.grpPhieuNhapXuat.Controls.Add(this.txtSoPhieu);
            this.grpPhieuNhapXuat.Controls.Add(this.lblLoaiPhieu);
            this.grpPhieuNhapXuat.Controls.Add(this.radNhapKho);
            this.grpPhieuNhapXuat.Controls.Add(this.radXuatKho);
            this.grpPhieuNhapXuat.Controls.Add(this.lblMatHang);
            this.grpPhieuNhapXuat.Controls.Add(this.cboMatHang);
            this.grpPhieuNhapXuat.Controls.Add(this.lblDonViTinh);
            this.grpPhieuNhapXuat.Controls.Add(this.txtDonViTinh);
            this.grpPhieuNhapXuat.Controls.Add(this.lblSoLuong);
            this.grpPhieuNhapXuat.Controls.Add(this.txtSoLuong);
            this.grpPhieuNhapXuat.Controls.Add(this.lblDonGia);
            this.grpPhieuNhapXuat.Controls.Add(this.txtDonGia);
            this.grpPhieuNhapXuat.Controls.Add(this.lblNgayLap);
            this.grpPhieuNhapXuat.Controls.Add(this.dtpNgayLap);
            this.grpPhieuNhapXuat.Controls.Add(this.lblThanhTien);
            this.grpPhieuNhapXuat.Controls.Add(this.txtThanhTien);
            this.grpPhieuNhapXuat.Location = new System.Drawing.Point(14, 13);
            this.grpPhieuNhapXuat.Name = "grpPhieuNhapXuat";
            this.grpPhieuNhapXuat.Size = new System.Drawing.Size(423, 384);
            this.grpPhieuNhapXuat.TabIndex = 0;
            this.grpPhieuNhapXuat.TabStop = false;
            this.grpPhieuNhapXuat.Text = "Phiếu nhập / xuất";
            // 
            // lblSoPhieu
            // 
            this.lblSoPhieu.AutoSize = true;
            this.lblSoPhieu.Location = new System.Drawing.Point(21, 32);
            this.lblSoPhieu.Name = "lblSoPhieu";
            this.lblSoPhieu.Size = new System.Drawing.Size(60, 16);
            this.lblSoPhieu.TabIndex = 0;
            this.lblSoPhieu.Text = "Số phiếu";
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(131, 29);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.ReadOnly = true;
            this.txtSoPhieu.Size = new System.Drawing.Size(205, 22);
            this.txtSoPhieu.TabIndex = 1;
            this.txtSoPhieu.Text = "PN0001";
            // 
            // lblLoaiPhieu
            // 
            this.lblLoaiPhieu.AutoSize = true;
            this.lblLoaiPhieu.Location = new System.Drawing.Point(21, 73);
            this.lblLoaiPhieu.Name = "lblLoaiPhieu";
            this.lblLoaiPhieu.Size = new System.Drawing.Size(69, 16);
            this.lblLoaiPhieu.TabIndex = 2;
            this.lblLoaiPhieu.Text = "Loại phiếu";
            // 
            // radNhapKho
            // 
            this.radNhapKho.AutoSize = true;
            this.radNhapKho.Checked = true;
            this.radNhapKho.Location = new System.Drawing.Point(131, 70);
            this.radNhapKho.Name = "radNhapKho";
            this.radNhapKho.Size = new System.Drawing.Size(86, 20);
            this.radNhapKho.TabIndex = 3;
            this.radNhapKho.TabStop = true;
            this.radNhapKho.Text = "Nhập kho";
            this.radNhapKho.UseVisualStyleBackColor = true;
            // 
            // radXuatKho
            // 
            this.radXuatKho.AutoSize = true;
            this.radXuatKho.Location = new System.Drawing.Point(240, 70);
            this.radXuatKho.Name = "radXuatKho";
            this.radXuatKho.Size = new System.Drawing.Size(79, 20);
            this.radXuatKho.TabIndex = 4;
            this.radXuatKho.Text = "Xuất kho";
            this.radXuatKho.UseVisualStyleBackColor = true;
            // 
            // lblMatHang
            // 
            this.lblMatHang.AutoSize = true;
            this.lblMatHang.Location = new System.Drawing.Point(21, 115);
            this.lblMatHang.Name = "lblMatHang";
            this.lblMatHang.Size = new System.Drawing.Size(62, 16);
            this.lblMatHang.TabIndex = 5;
            this.lblMatHang.Text = "Mặt hàng";
            // 
            // cboMatHang
            // 
            this.cboMatHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMatHang.FormattingEnabled = true;
            this.cboMatHang.Location = new System.Drawing.Point(131, 112);
            this.cboMatHang.Name = "cboMatHang";
            this.cboMatHang.Size = new System.Drawing.Size(205, 24);
            this.cboMatHang.TabIndex = 6;
            // 
            // lblDonViTinh
            // 
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.Location = new System.Drawing.Point(21, 158);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Size = new System.Drawing.Size(67, 16);
            this.lblDonViTinh.TabIndex = 7;
            this.lblDonViTinh.Text = "Đơn vị tính";
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(131, 155);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.ReadOnly = true;
            this.txtDonViTinh.Size = new System.Drawing.Size(205, 22);
            this.txtDonViTinh.TabIndex = 8;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(21, 201);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(60, 16);
            this.lblSoLuong.TabIndex = 9;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(131, 197);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(205, 22);
            this.txtSoLuong.TabIndex = 10;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(21, 243);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(53, 16);
            this.lblDonGia.TabIndex = 11;
            this.lblDonGia.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(131, 240);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(205, 22);
            this.txtDonGia.TabIndex = 12;
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Location = new System.Drawing.Point(21, 286);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(62, 16);
            this.lblNgayLap.TabIndex = 13;
            this.lblNgayLap.Text = "Ngày lập";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpNgayLap.CustomFormat = "";
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(131, 283);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(205, 22);
            this.dtpNgayLap.TabIndex = 14;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblThanhTien.Location = new System.Drawing.Point(21, 329);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(84, 20);
            this.lblThanhTien.TabIndex = 15;
            this.lblThanhTien.Text = "Thành tiền";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(131, 325);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(205, 22);
            this.txtThanhTien.TabIndex = 16;
            this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpSoNhapXuat
            // 
            this.grpSoNhapXuat.Controls.Add(this.lstSoNhapXuat);
            this.grpSoNhapXuat.Location = new System.Drawing.Point(451, 13);
            this.grpSoNhapXuat.Name = "grpSoNhapXuat";
            this.grpSoNhapXuat.Size = new System.Drawing.Size(526, 384);
            this.grpSoNhapXuat.TabIndex = 1;
            this.grpSoNhapXuat.TabStop = false;
            this.grpSoNhapXuat.Text = "Sổ nhập - xuất";
            // 
            // lstSoNhapXuat
            // 
            this.lstSoNhapXuat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstSoNhapXuat.FormattingEnabled = true;
            this.lstSoNhapXuat.ItemHeight = 20;
            this.lstSoNhapXuat.Location = new System.Drawing.Point(24, 39);
            this.lstSoNhapXuat.Name = "lstSoNhapXuat";
            this.lstSoNhapXuat.Size = new System.Drawing.Size(481, 324);
            this.lstSoNhapXuat.TabIndex = 0;
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Location = new System.Drawing.Point(40, 411);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(114, 32);
            this.btnLapPhieu.TabIndex = 2;
            this.btnLapPhieu.Text = "&Lập phiếu";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(177, 411);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(114, 32);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm &mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnXoaPhieu
            // 
            this.btnXoaPhieu.Location = new System.Drawing.Point(503, 411);
            this.btnXoaPhieu.Name = "btnXoaPhieu";
            this.btnXoaPhieu.Size = new System.Drawing.Size(120, 32);
            this.btnXoaPhieu.TabIndex = 4;
            this.btnXoaPhieu.Text = "&Xóa phiếu";
            this.btnXoaPhieu.UseVisualStyleBackColor = true;
            // 
            // btnXemTonKho
            // 
            this.btnXemTonKho.Location = new System.Drawing.Point(646, 411);
            this.btnXemTonKho.Name = "btnXemTonKho";
            this.btnXemTonKho.Size = new System.Drawing.Size(131, 32);
            this.btnXemTonKho.TabIndex = 5;
            this.btnXemTonKho.Text = "Xem tồn &kho";
            this.btnXemTonKho.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(800, 411);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(114, 32);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // frmQuanLiNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 464);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXemTonKho);
            this.Controls.Add(this.btnXoaPhieu);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnLapPhieu);
            this.Controls.Add(this.grpSoNhapXuat);
            this.Controls.Add(this.grpPhieuNhapXuat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQuanLiNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhập - xuất kho vật liệu";
            this.grpPhieuNhapXuat.ResumeLayout(false);
            this.grpPhieuNhapXuat.PerformLayout();
            this.grpSoNhapXuat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPhieuNhapXuat;
        private System.Windows.Forms.Label lblSoPhieu;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.Label lblLoaiPhieu;
        private System.Windows.Forms.RadioButton radNhapKho;
        private System.Windows.Forms.RadioButton radXuatKho;
        private System.Windows.Forms.Label lblMatHang;
        private System.Windows.Forms.ComboBox cboMatHang;
        private System.Windows.Forms.Label lblDonViTinh;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.TextBox txtThanhTien;

        private System.Windows.Forms.GroupBox grpSoNhapXuat;
        private System.Windows.Forms.ListBox lstSoNhapXuat;

        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoaPhieu;
        private System.Windows.Forms.Button btnXemTonKho;
        private System.Windows.Forms.Button btnThoat;
    }
}