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

        private void HienThi_Load(object sender, EventArgs e)
        {
            // 1 tạo kết nối csdl : mở SQL là nhìn thấy tên
            string strConnect = "Data Source=localhost\\SQLEXPRESS; Database=QLSach; Integrated Security=true"; // Khai báo server name, database name, user name, password
            SqlConnection sqlConnection = new SqlConnection(strConnect);

            // 2 mở kết nối csdl
            if(sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }

            // 3 tạo lệnh SQL
            string strSQL = "SELECT * FROM tSach"; 

            // 4 thực thi lệnh SQL
            SqlDataAdapter dataAdapter = new SqlDataAdapter(strSQL, sqlConnection);

            // 5 tạo DataTable để chứa dữ liệu
            DataTable tSach = new DataTable();
            dataAdapter.Fill(tSach);

            // 6 Đóng kết nối csdl
            if(sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
            sqlConnection.Dispose();

            // 7 Hiển thị dữ liệu lên DataGridView
            dgvtSach.DataSource = tSach;
        }
    }
}
