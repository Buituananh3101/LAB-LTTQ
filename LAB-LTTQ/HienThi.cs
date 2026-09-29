using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_LTTQ
{
    public partial class HienThi : Form
    {
        public HienThi()
        {
            InitializeComponent();
        }

        string strConnect = "Data Source=localhost\\SQLEXPRESS; Database=QLSach; Integrated Security=true"; // Khai báo server name, database name, user name, password



        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------ : 7 steps tương tác dữ liệu cơ bản
        private void HienThiDuLieu()
        {
            // using tự đóng : kết nối + giải phóng tài nguyên khi kết thúc khối lệnh
            using (SqlConnection sqlConnection = new SqlConnection(strConnect))                 // 1 Tạo kết nối csdl
            {
                sqlConnection.Open();                                                           // 2 Mở kết nối csdl

                string strSQL = "SELECT * FROM tSach";                                          // 3 Tạo lệnh SQL lấy danh sách sách

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(strSQL, sqlConnection))  // 4 Tạo bộ lấy dữ liệu
                {
                    DataTable tSach = new DataTable();                                          // 5 Tạo DataTable và đổ dữ liệu vào
                    dataAdapter.Fill(tSach);

                    dgvtSach.DataSource = tSach;                                                // 6 Hiển thị dữ liệu lên DataGridView
                }
            }
        }



        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------ : Khơi tạo 
        private void HienThi_Load(object sender, EventArgs e)
        {
            dgvtSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;                   // Chọn full row + chỉ chọn 1 dòng
            dgvtSach.MultiSelect = false;

            dgvtSach.ReadOnly = true;                                                           // Chỉ đọc dữ liệu + không cho phép thêm dòng mới
            dgvtSach.AllowUserToAddRows = false;

            HienThiDuLieu();                                                                    // 3 Hiển thị danh sách sách
        }



        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------ : Lấy dữ liệu đưa vào textbox
        private void dgvtSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;                                                         // 1 Nếu bấm vào tiêu đề cột thì bỏ qua

            DataGridViewRow dong = dgvtSach.Rows[e.RowIndex];                                   // 2 Lấy dòng vừa được chọn

            txtMaSach.Text = dong.Cells["MaSach"].Value.ToString();                             // 3 Đưa dữ liệu của dòng lên các TextBox
            txtTenSach.Text = dong.Cells["TenSach"].Value.ToString();
            txtTacGia.Text = dong.Cells["TacGia"].Value.ToString();
        }



        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------ : Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text.Trim() == "" || txtTenSach.Text.Trim() == "")                    // 1 Kiểm tra thông tin bắt buộc
            {
                MessageBox.Show("Bạn phải nhập mã sách và tên sách.");
                return;
            }

            using (SqlConnection sqlConnection = new SqlConnection(strConnect))                 // 2 Tương tác dữ liệu với using --> tự động đóng kết nối và giải phóng tài nguyên
            {
                sqlConnection.Open();                                                           // 3 Mở kết nối csdl

                string strSQL = @"INSERT INTO tSach (MaSach, TenSach, TacGia)           
                          VALUES (@MaSach, @TenSach, @TacGia)";                                 // 4 Tạo lệnh SQL thêm sách

                using (SqlCommand cmd = new SqlCommand(strSQL, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@MaSach", txtMaSach.Text.Trim());              // 5 Truyền dữ liệu từ TextBox vào các tham số SQL, phải giống MaSach trong strSQL
                    cmd.Parameters.AddWithValue("@TenSach", txtTenSach.Text.Trim());
                    cmd.Parameters.AddWithValue("@TacGia", txtTacGia.Text.Trim());

                    // return index dòng bị tác động, nếu > 0 thành công, = 0 thất bại
                    cmd.ExecuteNonQuery();                                                      // 6 Thực thi lệnh thêm
                }
            }

            HienThiDuLieu();                                                                    // 7 Tải lại dữ liệu để thấy sách vừa thêm
            MessageBox.Show("Thêm sách thành công.");
        }


        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------ : Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text.Trim() == "" || txtTenSach.Text.Trim() == "")                    // 1 Kiểm tra mã sách và tên sách
            {
                MessageBox.Show("Bạn phải chọn sách và nhập tên sách.");
                return;
            }

            int soDong;                                                                         // 2 Biến lưu số dòng được sửa

            using (SqlConnection sqlConnection = new SqlConnection(strConnect))                 // 3 Tạo kết nối csdl
            {
                sqlConnection.Open();                                                           // 4 Mở kết nối csdl

                string strSQL = @"UPDATE tSach
                                 SET TenSach = @TenSach, TacGia = @TacGia
                                 WHERE MaSach = @MaSach";                                       // 5 Tạo lệnh SQL sửa sách theo mã

                using (SqlCommand cmd = new SqlCommand(strSQL, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@MaSach", txtMaSach.Text.Trim());              // 6 Truyền dữ liệu từ TextBox vào các tham số SQL
                    cmd.Parameters.AddWithValue("@TenSach", txtTenSach.Text.Trim());
                    cmd.Parameters.AddWithValue("@TacGia", txtTacGia.Text.Trim());

                    soDong = cmd.ExecuteNonQuery();                                             // 7 Thực thi lệnh sửa và lấy số dòng bị tác động
                }
            }

            HienThiDuLieu();                                                                    // 8 Tải lại dữ liệu và thông báo kết quả

            if (soDong > 0)
                MessageBox.Show("Sửa sách thành công.");
            else
                MessageBox.Show("Không tìm thấy mã sách cần sửa.");
        }



        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------ : Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text.Trim() == "")                                                // 1 Kiểm tra mã sách cần xóa
            {
                MessageBox.Show("Bạn phải chọn sách cần xóa.");
                return;
            }

            DialogResult ketQua = MessageBox.Show(                                          // 2 Hỏi lại trước khi xóa
                "Bạn có chắc muốn xóa sách này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes) return;

            int soDong;                                                                     // 3 Biến lưu số dòng được xóa

            using (SqlConnection sqlConnection = new SqlConnection(strConnect))             // 4 Tạo kết nối csdl
            {
                sqlConnection.Open();                                                       // 5 Mở kết nối csdl

                string strSQL = "DELETE FROM tSach WHERE MaSach = @MaSach";                 // 6 Tạo lệnh SQL xóa sách theo mã

                using (SqlCommand cmd = new SqlCommand(strSQL, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@MaSach", txtMaSach.Text.Trim());          // 7 Truyền mã sách cần xóa

                    soDong = cmd.ExecuteNonQuery();                                         // 8 Thực thi lệnh xóa
                }
            }

            HienThiDuLieu();                                                                // 9 Tải lại dữ liệu và thông báo kết quả

            if (soDong > 0)
                MessageBox.Show("Xóa sách thành công.");
            else
                MessageBox.Show("Không tìm thấy mã sách cần xóa.");
        }
    }
}