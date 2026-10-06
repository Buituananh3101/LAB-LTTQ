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
        //------------------------------------------------------------------------------------: Khai báo
        Classes.DataProcessing dtBase = new Classes.DataProcessing();
        Classes.Function fn = new Classes.Function();
        string fileAnh = "";


        public frmSanPham()
        {
            InitializeComponent();
        }


        //------------------------------------------------------------------------------------: Load
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


        //------------------------------------------------------------------------------------: Chọn ảnh
        private void btnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgAnh = new OpenFileDialog();
            dlgAnh.Filter = "Bitmap(*.bmp)|*.bmp|BitmapGif(*.gif)|*.gif|All files(*.*)|*.*";
            dlgAnh.InitialDirectory = Application.StartupPath;
            dlgAnh.FilterIndex = 3; // Quy định lọc mặc định là bộ lọc thứ 1
            dlgAnh.Title = "Chọn ảnh để hiển thị";

            if (dlgAnh.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Lấy tên, đường dẫn ảnh khi người dùng chọn trong hộp hội thoại OpenDialog.
                // Sau đó gán cho thuộc tính Image của PictureBox
                picAnh.Image = Image.FromFile(dlgAnh.FileName);

                string[] str = dlgAnh.FileName.Split('\\'); // Cắt tên file ảnh để lưu vào CSDL
                fileAnh = str[str.Length - 1].ToString();
            }
        }


        //------------------------------------------------------------------------------------: Nút .
        void ResetValue()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            cboChatLieu.Text = "";
            txtSoLuong.Text = "";
            txtDonGiaBan.Text = "";
            txtDonGiaNhap.Text = "";
            picAnh.Image = null;
            txtGhiChu.Text = "";
            txtMaHang.Focus();
        }

        //------------------------------------------------------------------------------------:
        private void btnThemMoi_Click(object sender, EventArgs e) // f S X, t T L B
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnThemMoi.Enabled = true;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;

            ResetValue();
        }


        //------------------------------------------------------------------------------------:
        private void btnBoQua_Click(object sender, EventArgs e) // f S X L B, t T.
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThemMoi.Enabled = true;

            ResetValue();
        }


        //------------------------------------------------------------------------------------:
        private void btnSua_Click(object sender, EventArgs e) // f T X, t L B
        {
            // Cấm Click vào các nút Thêm, Xóa. Click được vào nút Lưu, Bỏ qua
            btnThemMoi.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
        }


        //------------------------------------------------------------------------------------:
        private void btnXoa_Click(object sender, EventArgs e) // 
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Xóa mặt hàng",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtBase.CapNhatDuLieu( "Delete tblHang where MaHang='" + txtMaHang.Text + "'");
                dgvHang.DataSource = dtBase.DocBang("select * from tblHang");
            }

            // Đưa form về trạng thái ban đầu
            // Cấm click các nút Sửa, Xóa, Lưu và Bỏ qua. Click được nút Thêm mới
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThemMoi.Enabled = true;

            // Xóa trắng các dữ liệu trên các ô nhập liệu
            ResetValue();
        }


        //------------------------------------------------------------------------------------:
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính đầy đủ của dữ liệu
            if (txtMaHang.Text.Trim() == "") { MessageBox.Show("Bạn phải nhập mã hàng"); txtMaHang.Focus(); return; }
            if (txtTenHang.Text.Trim() == "") { MessageBox.Show("Bạn phải nhập tên hàng"); txtTenHang.Focus(); return; }
            if (cboChatLieu.Text.Trim() == "") { MessageBox.Show("Bạn phải chọn chất liệu"); return; }
            if (txtSoLuong.Text.Trim() == "") { MessageBox.Show("Bạn phải nhập số lượng"); txtSoLuong.Focus(); return; }
            if (txtDonGiaNhap.Text.Trim() == "") { MessageBox.Show("Bạn phải nhập đơn giá nhập"); txtDonGiaNhap.Focus(); return; }
            if (txtDonGiaBan.Text.Trim() == "") { MessageBox.Show("Bạn phải nhập đơn giá bán"); txtDonGiaBan.Focus(); return; }

            // Thực hiện thêm mới và cập nhật lại dataGridView
            if (btnThemMoi.Enabled == true)
            {
                // Kiểm tra trùng mã
                //DataTable dtSP = dtBase.DocBang("Select * from tblHang where MaHang='" + txtMaHang.Text + "'");
                DataTable dtSP = dtBase.DocBang($" Select * from tblHang where MaHang='{txtMaHang.Text}'");             // Ko cần có @ vì ko xuống dòng

                if (dtSP.Rows.Count > 0)
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại. Mời bạn nhập mã khác!!!");
                    txtMaHang.Focus();
                    return;
                }
                                                                                                                        // Phải có @ vì xuống dòng
                string sqlInsert = $@"  INSERT INTO tblHang                                                             
                                        VALUES (
                                        '{txtMaHang.Text}', 
                                        N'{txtTenHang.Text}', 
                                        '{cboChatLieu.SelectedValue}', 
                                        {int.Parse(txtSoLuong.Text)}, 
                                        {float.Parse(txtDonGiaNhap.Text)}, 
                                        {float.Parse(txtDonGiaBan.Text)}, 
                                        '{fileAnh}', 
                                        N'{txtGhiChu.Text}')
                                   ";

                dtBase.CapNhatDuLieu(sqlInsert);
            }

            // Thực hiện sửa dữ liệu
            if (btnSua.Enabled == true)
            {                                                                   // Tên cột phải giống y hệt trong csdl
                string sqlUpdate = $@"  UPDATE tblHang                              
                                    SET 
                                    Tenhang = N'{txtTenHang.Text}', 
                                    Machatlieu = '{cboChatLieu.SelectedValue}', 
                                    Soluong = {Convert.ToInt16(txtSoLuong.Text)}, 
                                    Dongianhap = {float.Parse(txtDonGiaNhap.Text)}, 
                                    Dongiaban = {float.Parse(txtDonGiaBan.Text)}, 
                                    Anh = '{fileAnh}', 
                                    GhiChu = N'{txtGhiChu.Text}' 
                                    WHERE MaHang = '{txtMaHang.Text}'
                                ";

                dtBase.CapNhatDuLieu(sqlUpdate);
            }


            // Load dữ liệu lên dgvHang
            DataTable dtHang = dtBase.DocBang("select * from tblHang");
            dgvHang.DataSource = dtHang;

            // Đưa form về trạng thái ban đầu
            // Cấm click các nút Sửa, Xóa, Lưu và Bỏ qua. Click được nút Thêm mới
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThemMoi.Enabled = true;

            // Xóa trắng các dữ liệu trên các ô nhập liệu
            ResetValue();
        }

        //------------------------------------------------------------------------------------:
        private void dgvHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nhấn được các nút Sửa, Xóa, Bỏ qua. Vô hiệu hóa nút Thêm, Lưu
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = true;
            btnThemMoi.Enabled = false;
            btnLuu.Enabled = false;

            // Hiển thị dữ liệu chi tiết
            txtMaHang.Text = dgvHang.CurrentRow.Cells[0].Value.ToString();
            txtTenHang.Text = dgvHang.CurrentRow.Cells[1].Value.ToString();
            cboChatLieu.SelectedValue = dgvHang.CurrentRow.Cells[2].Value.ToString();
            txtSoLuong.Text = dgvHang.CurrentRow.Cells[3].Value.ToString();
            txtDonGiaNhap.Text = dgvHang.CurrentRow.Cells[4].Value.ToString();
            txtDonGiaBan.Text = dgvHang.CurrentRow.Cells[5].Value.ToString();
            try
            {
                picAnh.Image = Image.FromFile("Images\\Hang\\" + dgvHang.CurrentRow.Cells[6].Value.ToString());
            }
            catch{}
            txtGhiChu.Text = dgvHang.CurrentRow.Cells[7].Value.ToString();

            
        }


        //------------------------------------------------------------------------------------:
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //------------------------------------------------------------------------------------:
        private void btnTim_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "KẾT QUẢ TÌM KIẾM";

            string strSelect = $"select * from tblHang where Mahang is not null";

            if(txtMaHang.Text.Trim() != ""){ strSelect += $" and Mahang like '%{txtMaHang.Text}%'"; }
            if(txtTenHang.Text.Trim() != "") { strSelect += $" and Tenhang like N'%{txtTenHang.Text}%'"; }
            //if(cboChatLieu.Text.Trim() != "") { strSelect += $" and Machatlieu = '{cboChatLieu.SelectedValue}'"; }

            DataTable dtKQ = dtBase.DocBang(strSelect);
            dgvHang.DataSource = dtKQ;
        }


        //------------------------------------------------------------------------------------:

    }

}
