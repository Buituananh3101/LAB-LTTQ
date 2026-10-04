using LAB_LTTQ.Classes;
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
        //----------------------------------------------------------------------------------------------------
        Classes.DataProcessing db = new Classes.DataProcessing();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        //----------------------------------------------------------------------------------------------------: //1.
        private void NhanVien_Load(object sender, EventArgs e)
        {
            DataTable dt = db.ReadData("SELECT * FROM tblNhanVien"); // Đọc dữ liệu từ bảng
            dgvNhanVien.DataSource = dt;                             // Hiển thị lên DataGridView

            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        //----------------------------------------------------------------------------------------------------: //2.
        private void dgvNhanVien_Click(object sender, EventArgs e)
        {

        }


        //----------------------------------------------------------------------------------------------------
    }
}


//YÊU CẦU FORM NHÂN VIÊN
//1.	Khi form bắt đầu xuất hiện thì danh sách nhân viên đã hiển thị hết tại datagridview
//2.	Khi click vào 1 nhân viên trên lưới thì thông tin nhân viên đó được hiển thì tương ứng.
//3.	Khi nhấn nút Ảnh, cho phép chọn ảnh của nhân viên trên máy tính
//4.	Thực hiện các thao tác nút: Thêm, sửa, xóa, thoát để thêm, sửa, xóa thông tin nhân viên.