namespace LAB_LTTQ
{
    partial class frmHDBan
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
            this.grpThongTinChung = new System.Windows.Forms.GroupBox();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.txtMaHDBan = new System.Windows.Forms.TextBox();
            this.lblNgayBan = new System.Windows.Forms.Label();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.cboMaNhanVien = new System.Windows.Forms.ComboBox();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.lblMaKhach = new System.Windows.Forms.Label();
            this.cboMaKhach = new System.Windows.Forms.ComboBox();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.lblTenKhach = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.grpMatHang = new System.Windows.Forms.GroupBox();
            this.lblMaHang = new System.Windows.Forms.Label();
            this.cboMaHang = new System.Windows.Forms.ComboBox();
            this.btnHang = new System.Windows.Forms.Button();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.lblPhanTram = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.dgvHDBan = new System.Windows.Forms.DataGridView();
            this.lblHuongDan = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblBangChu = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.lblTimMaHD = new System.Windows.Forms.Label();
            this.cboMaHDBan = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grpThongTinChung.SuspendLayout();
            this.grpMatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.Color.White;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.Location = new System.Drawing.Point(25, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(890, 55);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "HÓA ĐƠN BÁN";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpThongTinChung
            // 
            this.grpThongTinChung.BackColor = System.Drawing.Color.White;
            this.grpThongTinChung.Controls.Add(this.lblMaHD);
            this.grpThongTinChung.Controls.Add(this.txtMaHDBan);
            this.grpThongTinChung.Controls.Add(this.lblNgayBan);
            this.grpThongTinChung.Controls.Add(this.dtpNgayBan);
            this.grpThongTinChung.Controls.Add(this.lblMaNhanVien);
            this.grpThongTinChung.Controls.Add(this.cboMaNhanVien);
            this.grpThongTinChung.Controls.Add(this.btnNhanVien);
            this.grpThongTinChung.Controls.Add(this.lblTenNhanVien);
            this.grpThongTinChung.Controls.Add(this.txtTenNhanVien);
            this.grpThongTinChung.Controls.Add(this.lblMaKhach);
            this.grpThongTinChung.Controls.Add(this.cboMaKhach);
            this.grpThongTinChung.Controls.Add(this.btnKhachHang);
            this.grpThongTinChung.Controls.Add(this.lblTenKhach);
            this.grpThongTinChung.Controls.Add(this.txtTenKhach);
            this.grpThongTinChung.Controls.Add(this.lblDiaChi);
            this.grpThongTinChung.Controls.Add(this.txtDiaChi);
            this.grpThongTinChung.Controls.Add(this.lblDienThoai);
            this.grpThongTinChung.Controls.Add(this.txtDienThoai);
            this.grpThongTinChung.ForeColor = System.Drawing.Color.Firebrick;
            this.grpThongTinChung.Location = new System.Drawing.Point(25, 80);
            this.grpThongTinChung.Name = "grpThongTinChung";
            this.grpThongTinChung.Size = new System.Drawing.Size(890, 205);
            this.grpThongTinChung.TabIndex = 0;
            this.grpThongTinChung.TabStop = false;
            this.grpThongTinChung.Text = "Thông tin chung";
            // 
            // lblMaHD
            // 
            this.lblMaHD.ForeColor = System.Drawing.Color.Black;
            this.lblMaHD.Location = new System.Drawing.Point(20, 32);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(115, 23);
            this.lblMaHD.TabIndex = 0;
            this.lblMaHD.Text = "Mã hóa đơn:";
            // 
            // txtMaHDBan
            // 
            this.txtMaHDBan.Location = new System.Drawing.Point(140, 29);
            this.txtMaHDBan.Name = "txtMaHDBan";
            this.txtMaHDBan.ReadOnly = true;
            this.txtMaHDBan.Size = new System.Drawing.Size(270, 29);
            this.txtMaHDBan.TabIndex = 0;
            // 
            // lblNgayBan
            // 
            this.lblNgayBan.ForeColor = System.Drawing.Color.Black;
            this.lblNgayBan.Location = new System.Drawing.Point(20, 69);
            this.lblNgayBan.Name = "lblNgayBan";
            this.lblNgayBan.Size = new System.Drawing.Size(115, 23);
            this.lblNgayBan.TabIndex = 1;
            this.lblNgayBan.Text = "Ngày bán:";
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBan.Location = new System.Drawing.Point(140, 66);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(270, 29);
            this.dtpNgayBan.TabIndex = 1;
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.ForeColor = System.Drawing.Color.Black;
            this.lblMaNhanVien.Location = new System.Drawing.Point(20, 106);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(115, 23);
            this.lblMaNhanVien.TabIndex = 2;
            this.lblMaNhanVien.Text = "Mã nhân viên:";
            // 
            // cboMaNhanVien
            // 
            this.cboMaNhanVien.FormattingEnabled = true;
            this.cboMaNhanVien.Location = new System.Drawing.Point(140, 103);
            this.cboMaNhanVien.Name = "cboMaNhanVien";
            this.cboMaNhanVien.Size = new System.Drawing.Size(215, 29);
            this.cboMaNhanVien.TabIndex = 2;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.ForeColor = System.Drawing.Color.Black;
            this.btnNhanVien.Location = new System.Drawing.Point(365, 102);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(45, 27);
            this.btnNhanVien.TabIndex = 3;
            this.btnNhanVien.Text = "...";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.ForeColor = System.Drawing.Color.Black;
            this.lblTenNhanVien.Location = new System.Drawing.Point(20, 143);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(115, 23);
            this.lblTenNhanVien.TabIndex = 4;
            this.lblTenNhanVien.Text = "Tên nhân viên:";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(140, 140);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.ReadOnly = true;
            this.txtTenNhanVien.Size = new System.Drawing.Size(270, 29);
            this.txtTenNhanVien.TabIndex = 4;
            // 
            // lblMaKhach
            // 
            this.lblMaKhach.ForeColor = System.Drawing.Color.Black;
            this.lblMaKhach.Location = new System.Drawing.Point(460, 32);
            this.lblMaKhach.Name = "lblMaKhach";
            this.lblMaKhach.Size = new System.Drawing.Size(120, 23);
            this.lblMaKhach.TabIndex = 5;
            this.lblMaKhach.Text = "Mã khách hàng:";
            // 
            // cboMaKhach
            // 
            this.cboMaKhach.FormattingEnabled = true;
            this.cboMaKhach.Location = new System.Drawing.Point(590, 29);
            this.cboMaKhach.Name = "cboMaKhach";
            this.cboMaKhach.Size = new System.Drawing.Size(215, 29);
            this.cboMaKhach.TabIndex = 5;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.ForeColor = System.Drawing.Color.Black;
            this.btnKhachHang.Location = new System.Drawing.Point(815, 28);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(45, 27);
            this.btnKhachHang.TabIndex = 6;
            this.btnKhachHang.Text = "...";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // lblTenKhach
            // 
            this.lblTenKhach.ForeColor = System.Drawing.Color.Black;
            this.lblTenKhach.Location = new System.Drawing.Point(460, 69);
            this.lblTenKhach.Name = "lblTenKhach";
            this.lblTenKhach.Size = new System.Drawing.Size(120, 23);
            this.lblTenKhach.TabIndex = 7;
            this.lblTenKhach.Text = "Tên khách hàng:";
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(590, 66);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.ReadOnly = true;
            this.txtTenKhach.Size = new System.Drawing.Size(270, 29);
            this.txtTenKhach.TabIndex = 7;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.ForeColor = System.Drawing.Color.Black;
            this.lblDiaChi.Location = new System.Drawing.Point(460, 106);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(120, 23);
            this.lblDiaChi.TabIndex = 8;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(590, 103);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(270, 48);
            this.txtDiaChi.TabIndex = 8;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.ForeColor = System.Drawing.Color.Black;
            this.lblDienThoai.Location = new System.Drawing.Point(460, 165);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(120, 23);
            this.lblDienThoai.TabIndex = 9;
            this.lblDienThoai.Text = "Điện thoại:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(590, 162);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(270, 29);
            this.txtDienThoai.TabIndex = 9;
            this.txtDienThoai.Leave += new System.EventHandler(this.txtDienThoai_Leave);
            // 
            // grpMatHang
            // 
            this.grpMatHang.Controls.Add(this.lblMaHang);
            this.grpMatHang.Controls.Add(this.cboMaHang);
            this.grpMatHang.Controls.Add(this.btnHang);
            this.grpMatHang.Controls.Add(this.lblSoLuong);
            this.grpMatHang.Controls.Add(this.txtSoLuong);
            this.grpMatHang.Controls.Add(this.lblTenHang);
            this.grpMatHang.Controls.Add(this.txtTenHang);
            this.grpMatHang.Controls.Add(this.lblGiamGia);
            this.grpMatHang.Controls.Add(this.txtGiamGia);
            this.grpMatHang.Controls.Add(this.lblPhanTram);
            this.grpMatHang.Controls.Add(this.lblDonGia);
            this.grpMatHang.Controls.Add(this.txtDonGia);
            this.grpMatHang.Controls.Add(this.lblThanhTien);
            this.grpMatHang.Controls.Add(this.txtThanhTien);
            this.grpMatHang.Controls.Add(this.dgvHDBan);
            this.grpMatHang.Controls.Add(this.lblHuongDan);
            this.grpMatHang.Controls.Add(this.lblTongTien);
            this.grpMatHang.Controls.Add(this.txtTongTien);
            this.grpMatHang.Controls.Add(this.lblBangChu);
            this.grpMatHang.Controls.Add(this.btnThem);
            this.grpMatHang.Controls.Add(this.btnLuu);
            this.grpMatHang.Controls.Add(this.btnHuy);
            this.grpMatHang.Controls.Add(this.btnIn);
            this.grpMatHang.Controls.Add(this.btnDong);
            this.grpMatHang.ForeColor = System.Drawing.Color.Firebrick;
            this.grpMatHang.Location = new System.Drawing.Point(25, 300);
            this.grpMatHang.Name = "grpMatHang";
            this.grpMatHang.Size = new System.Drawing.Size(890, 385);
            this.grpMatHang.TabIndex = 1;
            this.grpMatHang.TabStop = false;
            this.grpMatHang.Text = "Thông tin các mặt hàng";
            // 
            // lblMaHang
            // 
            this.lblMaHang.ForeColor = System.Drawing.Color.Black;
            this.lblMaHang.Location = new System.Drawing.Point(20, 32);
            this.lblMaHang.Name = "lblMaHang";
            this.lblMaHang.Size = new System.Drawing.Size(80, 23);
            this.lblMaHang.TabIndex = 0;
            this.lblMaHang.Text = "Mã hàng:";
            // 
            // cboMaHang
            // 
            this.cboMaHang.FormattingEnabled = true;
            this.cboMaHang.Location = new System.Drawing.Point(100, 29);
            this.cboMaHang.Name = "cboMaHang";
            this.cboMaHang.Size = new System.Drawing.Size(120, 29);
            this.cboMaHang.TabIndex = 0;
            // 
            // btnHang
            // 
            this.btnHang.ForeColor = System.Drawing.Color.Black;
            this.btnHang.Location = new System.Drawing.Point(230, 28);
            this.btnHang.Name = "btnHang";
            this.btnHang.Size = new System.Drawing.Size(40, 27);
            this.btnHang.TabIndex = 1;
            this.btnHang.Text = "...";
            this.btnHang.UseVisualStyleBackColor = true;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.ForeColor = System.Drawing.Color.Black;
            this.lblSoLuong.Location = new System.Drawing.Point(20, 67);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(80, 23);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(100, 64);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(170, 29);
            this.txtSoLuong.TabIndex = 2;
            // 
            // lblTenHang
            // 
            this.lblTenHang.ForeColor = System.Drawing.Color.Black;
            this.lblTenHang.Location = new System.Drawing.Point(300, 32);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(85, 23);
            this.lblTenHang.TabIndex = 3;
            this.lblTenHang.Text = "Tên hàng:";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(385, 29);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.ReadOnly = true;
            this.txtTenHang.Size = new System.Drawing.Size(200, 29);
            this.txtTenHang.TabIndex = 3;
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.ForeColor = System.Drawing.Color.Black;
            this.lblGiamGia.Location = new System.Drawing.Point(300, 67);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(85, 23);
            this.lblGiamGia.TabIndex = 4;
            this.lblGiamGia.Text = "Giảm giá:";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(385, 64);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(165, 29);
            this.txtGiamGia.TabIndex = 4;
            // 
            // lblPhanTram
            // 
            this.lblPhanTram.ForeColor = System.Drawing.Color.Red;
            this.lblPhanTram.Location = new System.Drawing.Point(557, 67);
            this.lblPhanTram.Name = "lblPhanTram";
            this.lblPhanTram.Size = new System.Drawing.Size(28, 23);
            this.lblPhanTram.TabIndex = 5;
            this.lblPhanTram.Text = "%";
            // 
            // lblDonGia
            // 
            this.lblDonGia.ForeColor = System.Drawing.Color.Black;
            this.lblDonGia.Location = new System.Drawing.Point(620, 32);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(90, 23);
            this.lblDonGia.TabIndex = 6;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(715, 29);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(150, 29);
            this.txtDonGia.TabIndex = 5;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.ForeColor = System.Drawing.Color.Black;
            this.lblThanhTien.Location = new System.Drawing.Point(620, 67);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(90, 23);
            this.lblThanhTien.TabIndex = 7;
            this.lblThanhTien.Text = "Thành tiền:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(715, 64);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(150, 29);
            this.txtThanhTien.TabIndex = 6;
            // 
            // dgvHDBan
            // 
            this.dgvHDBan.AllowUserToAddRows = false;
            this.dgvHDBan.AllowUserToDeleteRows = false;
            this.dgvHDBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHDBan.BackgroundColor = System.Drawing.Color.White;
            this.dgvHDBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDBan.Location = new System.Drawing.Point(20, 110);
            this.dgvHDBan.MultiSelect = false;
            this.dgvHDBan.Name = "dgvHDBan";
            this.dgvHDBan.ReadOnly = true;
            this.dgvHDBan.RowHeadersWidth = 30;
            this.dgvHDBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHDBan.Size = new System.Drawing.Size(845, 150);
            this.dgvHDBan.TabIndex = 7;
            // 
            // lblHuongDan
            // 
            this.lblHuongDan.ForeColor = System.Drawing.Color.Firebrick;
            this.lblHuongDan.Location = new System.Drawing.Point(25, 273);
            this.lblHuongDan.Name = "lblHuongDan";
            this.lblHuongDan.Size = new System.Drawing.Size(380, 25);
            this.lblHuongDan.TabIndex = 8;
            this.lblHuongDan.Text = "Kích đúp vào một dòng hàng để xóa";
            // 
            // lblTongTien
            // 
            this.lblTongTien.BackColor = System.Drawing.Color.White;
            this.lblTongTien.ForeColor = System.Drawing.Color.Blue;
            this.lblTongTien.Location = new System.Drawing.Point(620, 276);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(90, 23);
            this.lblTongTien.TabIndex = 9;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(715, 273);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(150, 29);
            this.txtTongTien.TabIndex = 8;
            // 
            // lblBangChu
            // 
            this.lblBangChu.ForeColor = System.Drawing.Color.Blue;
            this.lblBangChu.Location = new System.Drawing.Point(25, 307);
            this.lblBangChu.Name = "lblBangChu";
            this.lblBangChu.Size = new System.Drawing.Size(840, 25);
            this.lblBangChu.TabIndex = 10;
            this.lblBangChu.Text = "Bằng chữ:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(200, 338);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(140, 35);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm hóa đơn";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.ForeColor = System.Drawing.Color.Green;
            this.btnLuu.Location = new System.Drawing.Point(360, 338);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(110, 35);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(490, 338);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(115, 35);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy hóa đơn";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(625, 338);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(110, 35);
            this.btnIn.TabIndex = 12;
            this.btnIn.Text = "In hóa đơn";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(755, 338);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(110, 35);
            this.btnDong.TabIndex = 13;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // lblTimMaHD
            // 
            this.lblTimMaHD.Location = new System.Drawing.Point(25, 705);
            this.lblTimMaHD.Name = "lblTimMaHD";
            this.lblTimMaHD.Size = new System.Drawing.Size(110, 25);
            this.lblTimMaHD.TabIndex = 2;
            this.lblTimMaHD.Text = "Mã hóa đơn:";
            // 
            // cboMaHDBan
            // 
            this.cboMaHDBan.FormattingEnabled = true;
            this.cboMaHDBan.Location = new System.Drawing.Point(140, 702);
            this.cboMaHDBan.Name = "cboMaHDBan";
            this.cboMaHDBan.Size = new System.Drawing.Size(210, 29);
            this.cboMaHDBan.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(370, 699);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(110, 31);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmHDBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 750);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.grpThongTinChung);
            this.Controls.Add(this.grpMatHang);
            this.Controls.Add(this.lblTimMaHD);
            this.Controls.Add(this.cboMaHDBan);
            this.Controls.Add(this.btnTimKiem);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "frmHDBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn bán";
            this.Load += new System.EventHandler(this.frmHDBan_Load);
            this.grpThongTinChung.ResumeLayout(false);
            this.grpThongTinChung.PerformLayout();
            this.grpMatHang.ResumeLayout(false);
            this.grpMatHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpThongTinChung;
        private System.Windows.Forms.GroupBox grpMatHang;

        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label lblNgayBan;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Label lblMaKhach;
        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblDienThoai;

        private System.Windows.Forms.TextBox txtMaHDBan;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.ComboBox cboMaNhanVien;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.ComboBox cboMaKhach;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnKhachHang;

        private System.Windows.Forms.Label lblMaHang;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.Label lblPhanTram;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblHuongDan;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblBangChu;

        private System.Windows.Forms.ComboBox cboMaHang;
        private System.Windows.Forms.Button btnHang;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtTongTien;

        private System.Windows.Forms.DataGridView dgvHDBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnDong;

        private System.Windows.Forms.Label lblTimMaHD;
        private System.Windows.Forms.ComboBox cboMaHDBan;
        private System.Windows.Forms.Button btnTimKiem;
    }
}