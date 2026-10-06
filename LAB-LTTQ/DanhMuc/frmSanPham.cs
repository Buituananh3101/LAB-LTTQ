using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_LTTQ.DanhMuc
{
    public partial class frmSanPham : Form
    {

        Classes.DataProcessing dtBase = new Classes.DataProcessing();
        Classes.Function fn = new Classes.Function();
        string fileAnh = "";


        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            // Lấy dữ liệu của bảng Chất liệu đổ vào cboChatLieu
            DataTable dtChatLieu = dtBase.DocBang("Select * from tblChatLieu");
            fn.FillComboBox(cboChatLieu, dtChatLieu, "TenChatLieu", "MaChatLieu");
            cboChatLieu.SelectedIndex = -1;

            // Load dữ liệu lên dgvHang
            DataTable dtHang = dtBase.DocBang("select * from tblHang");
            dgvHang.DataSource = dtHang;
            dtHang.Dispose(); 

            // Định dạng dataGrid
            dgvHang.Columns[0].HeaderText = "Mã hàng";
            dgvHang.Columns[1].HeaderText = "Tên hàng";
            dgvHang.Columns[2].HeaderText = "Mã CL";
            dgvHang.Columns[3].HeaderText = "Số lượng";
            dgvHang.Columns[4].HeaderText = "Giá nhập";
            dgvHang.Columns[5].HeaderText = "Giá bán";
            dgvHang.Columns[6].HeaderText = "File ảnh";

            //dgvHang.Columns[0].Width = 150;
            //dgvHang.Columns[1].Width = 250;
            //dgvHang.Columns[2].Width = 150;
            //dgvHang.Columns[3].Width = 150;
            //dgvHang.Columns[4].Width = 150;
            //dgvHang.Columns[5].Width = 150;
            //dgvHang.Columns[6].Width = 150;

            // Cấm click các nút Sửa, Xóa, Lưu và Bỏ qua
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = false;
        }
    }

}
