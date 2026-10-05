using LAB_LTTQ.classes;
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
    public partial class frmMatHang : Form
    {
        //----------------------------------------------------------------------------------------------------
        DataProcessing dtbase = new DataProcessing();


        //----------------------------------------------------------------------------------------------------
        public frmMatHang()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        //----------------------------------------------------------------------------------------------------
        private void HienChiTiet(bool hien)                                              //Phương thức ẩn hiện các control trong groupBox Chi tiết
        {
            txtMaSP.Enabled = hien;
            txtTenSP.Enabled = hien;
            dtpNgayHH.Enabled = hien;
            dtpNgaySX.Enabled = hien;
            txtDonVi.Enabled = hien;
            txtDonGia.Enabled = hien;
            txtGhiChu.Enabled = hien;
            //Ẩn hiện 2 nút Lưu và Hủy
            btnLuu.Enabled = hien;
            btnHuy.Enabled = hien;
        }
        private void frmMatHang_Load(object sender, EventArgs e)                        //Sự kiện load_Form
        {
            //Load dữ liệu lên DataGridView
            dgvKetQua.DataSource = dtbase.ReadData("Select * from tblMatHang");
            //Ẩn nút Sửa,xóa 
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //Ẩn groupBox chi tiết
            HienChiTiet(false);

        }



        //----------------------------------------------------------------------------------------------------
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "TÌM KIẾM MẶT HÀNG";                                               // Cập nhật trên nhãn tiêu đề
            btnSua.Enabled = false;                                                             // Cấm nút Sửa và Xóa
            btnXoa.Enabled = false;

            string sql = "SELECT * FROM tblMatHang where MaSP is not null ";                    // Viết câu lệnh SQL cho tìm kiếm 

            if (txtTKMaSP.Text.Trim() != "")                                                    // Tìm theo MaSP khác rỗng
            {
                sql += " and MaSP like '%" + txtTKMaSP.Text + "%'";
            }

            if (txtTKTenSP.Text.Trim() != "")                                                   // Kiểm tra TenSP 
            {
                sql += " AND TenSP like N'%" + txtTKTenSP.Text + "%'";
            }

            dgvKetQua.DataSource = dtbase.ReadData(sql);                                        // Load dữ liệu tìm được lên dataGridView
        }


        //----------------------------------------------------------------------------------------------------
        private void dgvKetQua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Hien thi nut sua
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            //Bắt lỗi khi người sử dụng kích linh tinh lên datagrid
            try
            {
                txtMaSP.Text = dgvKetQua.CurrentRow.Cells[0].Value.ToString();
                txtTenSP.Text = dgvKetQua.CurrentRow.Cells[1].Value.ToString();
                dtpNgaySX.Value = (DateTime)dgvKetQua.CurrentRow.Cells[2].Value;
                dtpNgayHH.Value = (DateTime)dgvKetQua.CurrentRow.Cells[3].Value;
                txtDonVi.Text = dgvKetQua.CurrentRow.Cells[4].Value.ToString();
                txtDonGia.Text = dgvKetQua.CurrentRow.Cells[5].Value.ToString();
                txtGhiChu.Text = dgvKetQua.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }


        //----------------------------------------------------------------------------------------------------
        private void XoaTrangChiTiet()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            dtpNgaySX.Value = DateTime.Today;
            dtpNgayHH.Value = DateTime.Today;
            txtDonVi.Text = "";
            txtDonGia.Text = "";
            txtGhiChu.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "THÊM MẶT HÀNG";
            //Xoa trang GroupBox chi tiết sản phẩm
            XoaTrangChiTiet();
            //Cam nut sua xoa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //Hiện GroupBox Chi tiết
            HienChiTiet(true);
        }


        //----------------------------------------------------------------------------------------------------
        private void btnSua_Click(object sender, EventArgs e)
        {
            //Cập nhật tiêu đề
            lblTieuDe.Text = "CẬP NHẬT MẶ HÀNG";
            //Ẩn hai nút Thêm và Xóa
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            //Hiện gropbox chi tiết
            HienChiTiet(true);
        }


        //----------------------------------------------------------------------------------------------------
        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Bật Message Box cảnh báo người sử dụng
            if (MessageBox.Show("Bạn có chắc chắn xóa mã mặt hàng " + txtMaSP.Text + " không ? Nếu có ấn nút Lưu, không thì ấn nút Hủy", "Xóa sản phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lblTieuDe.Text = "XÓA MẶT HÀNG";
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                //Hiện gropbox chi tiết
                HienChiTiet(true);
            }
        }


        //----------------------------------------------------------------------------------------------------
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";                                                                    // Khởi tạo chuỗi câu lệnh SQL
                                                                                                // Sử dụng control ErrorProvider để hiển thị lỗi

            //------------- 1. Kiểm tra fields

            if (txtTenSP.Text.Trim() == "")         { errChiTiet.SetError(txtTenSP, "Bạn không để trống tên sản phẩm!"); return; }      else { errChiTiet.Clear(); }
            if (dtpNgaySX.Value > DateTime.Now)     { errChiTiet.SetError(dtpNgaySX, "Ngày sản xuất không hợp lệ!"); return; }          else { errChiTiet.Clear(); }
            if (dtpNgayHH.Value < dtpNgaySX.Value)  { errChiTiet.SetError(dtpNgayHH, "Ngày hết hạn nhỏ hơn ngày sản xuất!"); return; }  else { errChiTiet.Clear(); }
            if (txtDonVi.Text.Trim() == "")         { errChiTiet.SetError(txtDonVi, "Bạn không để trống đơn vị!"); return; }            else { errChiTiet.Clear(); }
            if (txtDonGia.Text.Trim() == "")        { errChiTiet.SetError(txtDonGia, "Bạn không để trống đơn giá!"); return; }          else { errChiTiet.Clear(); }


            //------------- 2. Thực hiện nút

            if (btnThem.Enabled == true)                                                        // Thực hiện thêm mới nếu nút Thêm bật
            {
                if (txtMaSP.Text.Trim() == "")                                                  // Kiểm tra xem ô nhập MaSP có bị trống không
                {
                    errChiTiet.SetError(txtMaSP, "Bạn không để trống mã sản phẩm trường này!");
                    return;
                }
                else
                {
                    sql = "Select * From tblMatHang Where MaSP ='" + txtMaSP.Text + "'";        // Kiểm tra xem mã sản phẩm đã tồn tại chưa để tránh lỗi
                    DataTable dtSP = dtbase.ReadData(sql);
                    if (dtSP.Rows.Count > 0)
                    {
                        errChiTiet.SetError(txtMaSP, "Mã sản phẩm trùng trong cơ sở dữ liệu");
                        return;
                    }
                    errChiTiet.Clear();
                }



                sql = "INSERT INTO tblMatHang(MaSP, TenSP, NgaySX, NgayHH, DonVi, DonGia, GhiChu) VALUES("; // Tạo câu lệnh Insert vào CSDL (dùng N' để hỗ trợ tiếng Việt)
                sql += "N'" + txtMaSP.Text + "',N'" + txtTenSP.Text + "','" + dtpNgaySX.Value.ToString("yyyy-MM-dd") + "','" +
                       dtpNgayHH.Value.ToString("yyyy-MM-dd") + "',N'" + txtDonVi.Text + "',N'" + txtDonGia.Text + "',N'" + txtGhiChu.Text + "')";
            }

            if (btnSua.Enabled == true)                                                         // Thực hiện cập nhật dữ liệu nếu nút Sửa bật
            {                                                                                   // Ko sửa MaSP
                sql = "Update tblMatHang SET ";
                sql += "TenSP = N'" + txtTenSP.Text + "',";
                sql += "NgaySX = '" + dtpNgaySX.Value.ToString("yyyy-MM-dd") + "',";
                sql += "NgayHH = '" + dtpNgayHH.Value.ToString("yyyy-MM-dd") + "',";
                sql += "DonVi = N'" + txtDonVi.Text + "',";
                sql += "DonGia = '" + txtDonGia.Text + "',";
                sql += "GhiChu = N'" + txtGhiChu.Text + "' ";
                sql += "Where MaSP = N'" + txtMaSP.Text + "'";
            }

            if (btnXoa.Enabled == true)                                                         // Thực hiện xóa dữ liệu nếu nút Xóa bật
            {
                sql = "Delete From tblMatHang Where MaSP =N'" + txtMaSP.Text + "'";
            }

            //------------- 3. Tương tác dữ liệu

            dtbase.ChangeData(sql);                                                             // Thực thi câu lệnh SQL xuống cơ sở dữ liệu

            sql = "Select * from tblMatHang";                                                      // Cập nhật lại DataGridView
            dgvKetQua.DataSource = dtbase.ReadData(sql);

            HienChiTiet(false);                                                                 // Ẩn hiện các nút phù hợp chức năng
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }


        //----------------------------------------------------------------------------------------------------
        private void btnHuy_Click(object sender, EventArgs e)
        {
            //Thiết lập lại các nút như ban đầu
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = true;
            //xoa trang chi tiết
            XoaTrangChiTiet();
            //Cam nhap vào groupBox chi tiết
            HienChiTiet(false);
        }


        //----------------------------------------------------------------------------------------------------
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close();
        }
    }
}
