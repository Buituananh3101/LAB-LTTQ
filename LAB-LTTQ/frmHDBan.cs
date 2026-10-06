using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_LTTQ
{
    public partial class frmHDBan : Form
    {

        classes.DataProcessing dtBase = new classes.DataProcessing();
        classes.Function fn = new classes.Function();


        public frmHDBan()
        {
            InitializeComponent();
        }

        private void frmHDBan_Load(object sender, EventArgs e)
        {
            DataTable dtHoaDon = dtBase.ReadData("Select MaHDBan from tblHDBan");

            fn.FillComboBox(cboMaHDBan, dtHoaDon, "MaHDBan", "MaHDBan");

            cboMaHDBan.SelectedIndex = -1;
            cboMaHDBan.Text = "";

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboMaHDBan.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập hoặc chọn mã hóa đơn");
                cboMaHDBan.Focus();
                return;
            }

            // Xử lý dấu nháy đơn trước khi ghép vào câu SQL
            string maHD = cboMaHDBan.Text.Trim().Replace("'", "''");

            // Lấy thông tin chung của hóa đơn
            string sqlHoaDon = $@"
                                    Select hd.MaHDBan, hd.NgayBan, hd.MaNhanVien,
                                            nv.Tennhanvien,
                                            hd.MaKhach, kh.TenKhach, kh.DiaChi, kh.DienThoai,
                                            hd.TongTien
                                    From tblHDBan hd
                                    Left Join tblNhanVien nv On hd.MaNhanVien = nv.Manhanvien
                                    Left Join tblKhach kh On hd.MaKhach = kh.Makhach
                                    Where hd.MaHDBan = N'{maHD}'
                                ";

            DataTable dtHoaDon = dtBase.ReadData(sqlHoaDon);

            if (dtHoaDon.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy hóa đơn này");
                cboMaHDBan.Focus();
                return;
            }

            // Hiển thị thông tin hóa đơn
            txtMaHDBan.Text = dtHoaDon.Rows[0]["MaHDBan"].ToString();
            dtpNgayBan.Value = Convert.ToDateTime(dtHoaDon.Rows[0]["NgayBan"]);
            

            // Hóa đơn cũ hiển thị nhân viên đã lập hóa đơn đó
            cboMaNhanVien.Text =dtHoaDon.Rows[0]["MaNhanVien"].ToString().Trim();
            txtTenNhanVien.Text =dtHoaDon.Rows[0]["Tennhanvien"].ToString();

            // Hiển thị thông tin khách hàng
            cboMaKhach.Text = dtHoaDon.Rows[0]["MaKhach"].ToString();
            txtTenKhach.Text = dtHoaDon.Rows[0]["TenKhach"].ToString();
            txtDiaChi.Text = dtHoaDon.Rows[0]["DiaChi"].ToString();
            txtDienThoai.Text = dtHoaDon.Rows[0]["DienThoai"].ToString();
            txtTongTien.Text = dtHoaDon.Rows[0]["TongTien"].ToString();
            lblBangChu.Text = "Bằng chữ:";


            // Lấy các mặt hàng thuộc hóa đơn
            string sqlChiTiet = $@"
                                    Select ct.MaHang, h.TenHang, h.DonGiaBan,
                                           ct.SoLuong, ct.GiamGia, ct.ThanhTien
                                    From tblChiTietHDBan ct
                                    Left Join tblHang h On ct.MaHang = h.Mahang
                                    Where ct.MaHDBan = N'{maHD}'
                                ";

            DataTable dtChiTiet = dtBase.ReadData(sqlChiTiet);
            dgvHDBan.DataSource = dtChiTiet;
        }

        
        //------------------------------------------------------------------------------------: Tìm khách theo số điện thoại
        private void txtDienThoai_Leave(object sender, EventArgs e)
        {
            // Xóa thông tin khách cũ trước khi tìm
            cboMaKhach.Text = "";
            txtTenKhach.Text = "";
            txtDiaChi.Text = "";


            if (txtDienThoai.Text.Trim() == "") return;

            string dienThoai = txtDienThoai.Text.Trim().Replace("'", "''");

            DataTable dtKhach = dtBase.ReadData(
                $"Select * from tblKhach where DienThoai = N'{dienThoai}'");

            // Nếu khách đã có trong CSDL thì hiển thị thông tin
            if (dtKhach.Rows.Count > 0)
            {
                cboMaKhach.Text = dtKhach.Rows[0]["Makhach"].ToString();
                txtTenKhach.Text = dtKhach.Rows[0]["TenKhach"].ToString();
                txtDiaChi.Text = dtKhach.Rows[0]["DiaChi"].ToString();
            }
            else MessageBox.Show("Khách hàng chưa có trong CSDL");

        }

            

        //------------------------------------------------------------------------------------: Lưu khách hàng mới
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            // Kiểm tra đầy đủ thông tin
            if (txtDienThoai.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại");
                txtDienThoai.Focus();
                return;
            }

            if (cboMaKhach.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng");
                cboMaKhach.Focus();
                return;
            }

            if (txtTenKhach.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng");
                txtTenKhach.Focus();
                return;
            }

            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ");
                txtDiaChi.Focus();
                return;
            }

            // Xử lý dấu nháy đơn trong dữ liệu nhập
            string maKhach = cboMaKhach.Text.Trim().Replace("'", "''");
            string tenKhach = txtTenKhach.Text.Trim().Replace("'", "''");
            string diaChi = txtDiaChi.Text.Trim().Replace("'", "''");
            string dienThoai = txtDienThoai.Text.Trim().Replace("'", "''");

            // Kiểm tra trùng mã khách
            DataTable dtMaKhach = dtBase.ReadData($"Select * from tblKhach where Makhach = N'{maKhach}'");

            if (dtMaKhach.Rows.Count > 0)
            {
                MessageBox.Show("Mã khách đã tồn tại. Bạn hãy nhập mã khác");
                cboMaKhach.Focus();
                return;
            }

            // Kiểm tra trùng số điện thoại
            DataTable dtDienThoai = dtBase.ReadData($"Select * from tblKhach where DienThoai = N'{dienThoai}'");

            if (dtDienThoai.Rows.Count > 0)
            {
                MessageBox.Show("Số điện thoại này đã có trong CSDL");

                // Hiển thị khách đã tồn tại để sử dụng
                cboMaKhach.Text = dtDienThoai.Rows[0]["Makhach"].ToString();
                txtTenKhach.Text = dtDienThoai.Rows[0]["TenKhach"].ToString();
                txtDiaChi.Text = dtDienThoai.Rows[0]["DiaChi"].ToString();

                return;
            }

            string sqlInsert = $@"
                                Insert Into tblKhach
                                    (Makhach, TenKhach, DiaChi, DienThoai, NgaySinh)
                                Values
                                    (N'{maKhach}', N'{tenKhach}', N'{diaChi}',
                                     N'{dienThoai}', NULL)
                               ";

            dtBase.ChangeData(sqlInsert);

            MessageBox.Show("Thêm khách hàng thành công");

    
        }
    }
}
