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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            // 1 tạo kết nối csdl : mở SQL là nhìn thấy tên
            string strConnect = "Data Source=localhost\\SQLEXPRESS; Database=QuanLyBanHang; Integrated Security=true"; // Khai báo server name, database name, user name, password
            SqlConnection sqlConnection = new SqlConnection(strConnect);

            // 2 mở kết nối csdl
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }

            // 3 tạo lệnh SQL
            string strSQL = "SELECT * FROM tblNhanVien";

            // 4 thực thi lệnh SQL
            SqlDataAdapter dataAdapter = new SqlDataAdapter(strSQL, sqlConnection);

            // 5 tạo DataTable để chứa dữ liệu
            DataTable tblNhanVien = new DataTable();
            dataAdapter.Fill(tblNhanVien);

            // 6 Đóng kết nối csdl
            if (sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
            sqlConnection.Dispose();

            // 7 Hiển thị dữ liệu lên DataGridView
            dgvNhanVien.DataSource = tblNhanVien;
        }
    }
}
