using LAB_LTTQ;
using LAB_LTTQ.classes; // Thêm namespace chứa class DataProcessing của bạn
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LAB_LTTQ
{
    public partial class frmHang : Form
    {
        DataProcessing dp = new DataProcessing();
        string tenFileAnh = "";

        public frmHang()
        {
            InitializeComponent();

        }

        private void frmHang_Load(object sender, EventArgs e)
        {
            // 1: frmDangNhap sẽ được hiển thị đầu tiên
            if (Program.tenNV == "")
            {
                frmDangNhap frm = new frmDangNhap();
                frm.ShowDialog();
                if (Program.tenNV == "")
                {
                    Application.Exit();
                    return;
                }
            }

            // 2: Hiển thị UserName vừa đăng Nhập vào
            lblXinChao.Text = "Xin chao: " + Program.tenNV;

            // 3.2: ComboBox chất liệu có sẵn các chất liệu
            cboChatLieu.DataSource = new string[] { "Vàng", "Bông", "Mây", "Tre", "Tổng hợp" };

            // 3.1: Khi form mới hiển thị lên, Load dữ liệu lên GridView
            LoadDataToGridView();
        }

        private void LoadDataToGridView()
        {
            string sql = "SELECT * FROM tblHang";
            dgvHang.DataSource = dp.ReadData(sql);

        }

        // 3.3: Hàm xử lý chỉ cho phép người dùng nhập số nguyên --> event keypress
        private void ChiNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            // 3.4: Dùng hộp hội thoại OpenFile để chọn ảnh
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(ofd.FileName);
                tenFileAnh = Path.GetFileName(ofd.FileName);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // 3.5.1: Kiểm tra xem đã nhập đủ thông tin
            if (txtMaHang.Text == "" || txtTenHang.Text == "" || txtDonGiaNhap.Text == "" || txtDonGiaBan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            float giaNhap = float.Parse(txtDonGiaNhap.Text);
            float giaBan = float.Parse(txtDonGiaBan.Text);

            // 3.5.2: Kiểm tra đơn giá bán phải lớn hơn đơn giá nhập
            if (giaBan <= giaNhap)
            {
                MessageBox.Show("Đơn giá bán phải lớn hơn đơn giá nhập!");
                return;
            }

            // 3.5.3: Kiểm tra mã sản phẩm không được trùng
            DataTable dtCheck = dp.ReadData($"SELECT * FROM tblHang WHERE MaHang = '{txtMaHang.Text}'");
            if (dtCheck.Rows.Count > 0)
            {
                MessageBox.Show("Mã hàng này đã tồn tại!");
                return;
            }

            // 3.5.4: Thêm vào bảng tblHang (Ảnh chỉ Lưu Tên)
            string sqlInsert = $@"INSERT INTO tblHang   
                                  VALUES ('{txtMaHang.Text}', N'{txtTenHang.Text}', N'{cboChatLieu.Text}', 
                                          {txtSoLuong.Text}, {giaNhap}, {giaBan}, '{tenFileAnh}', N'{txtGhiChu.Text}')";
            dp.ChangeData(sqlInsert);

            // 3.5.5: Hiển thị trên GridView
            LoadDataToGridView();

            // 3.5.6: Sau khi thêm sẽ xóa trắng các TextBox
            txtMaHang.Clear(); txtTenHang.Clear(); txtSoLuong.Clear();
            txtDonGiaNhap.Clear(); txtDonGiaBan.Clear(); txtGhiChu.Clear();
            picAnh.Image = null; tenFileAnh = "";
            txtMaHang.Focus();
        }

        private void dgvHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 3.6: Click vào một sản phẩm trên GridView thì thông tin được hiển thị lên Form
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHang.Rows[e.RowIndex];
                txtMaHang.Text = row.Cells["MaHang"].Value.ToString();
                txtTenHang.Text = row.Cells["TenHang"].Value.ToString();
                cboChatLieu.Text = row.Cells["ChatLieu"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                txtDonGiaNhap.Text = row.Cells["DonGiaNhap"].Value.ToString();
                txtDonGiaBan.Text = row.Cells["DonGiaBan"].Value.ToString();

                try { txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString(); } catch { }

                // Hiển thị ảnh
                try
                {
                    tenFileAnh = row.Cells["Anh"].Value.ToString();
                    string duongDan = Application.StartupPath + @"\Images\Hang\" + tenFileAnh; //Application.StartupPath tro den thu muc chua file .exe
                    picAnh.Image = Image.FromFile(duongDan);
                }
                catch
                {
                    // Bất kỳ lỗi gì (tên rỗng, không tìm thấy file, v.v.) thì cứ cho ảnh bằng null
                    picAnh.Image = null;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // 3.7.1: Kiểm tra xem người dùng đã chọn hàng để xóa chưa
            if (txtMaHang.Text=="")
            {
                MessageBox.Show("Vui lòng chọn một mặt hàng trên lưới để xóa!");
                return;
            }

            // 3.7.2: Hỏi người dùng có muốn xóa không
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa mặt hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // 3.7.3: Chọn Yes sẽ xóa hàng
                string sqlDelete = $"DELETE FROM tblHang WHERE MaHang = '{txtMaHang.Text}'";
                dp.ChangeData(sqlDelete);

                // 3.7.4: Load lại dữ liệu
                LoadDataToGridView();
                txtMaHang.Clear(); txtTenHang.Clear();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // 3.8: Cho phép cập nhật thông tin của SP
            if (txtMaHang.Text == "") return;

            string sqlUpdate = $@"UPDATE tblHang SET 
                                  TenHang = N'{txtTenHang.Text}', 
                                  ChatLieu = N'{cboChatLieu.Text}', 
                                  SoLuong = {txtSoLuong.Text}, 
                                  DonGiaNhap = {txtDonGiaNhap.Text}, 
                                  DonGiaBan = {txtDonGiaBan.Text}, 
                                  Anh = '{tenFileAnh}', 
                                  GhiChu = N'{txtGhiChu.Text}' 
                                  WHERE MaHang = '{txtMaHang.Text}'";
            dp.ChangeData(sqlUpdate);
            LoadDataToGridView();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}