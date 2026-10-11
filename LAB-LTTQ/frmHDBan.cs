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
    public partial class frmHDBan : Form
    {
        DataProcessing dtBase = new DataProcessing();
        public frmHDBan()
        {
            InitializeComponent();
        }

        private void frmHDBan_Load(object sender, EventArgs e)
        {
            //--------------------------------------------------------------------------------------------- 1
            DataTable dt = dtBase.ReadData($"select * from tblNhanVien where Manhanvien='{Program.maNV}'");
            cboMaNhanVien.Text = dt.Rows[0]["Manhanvien"].ToString();
            txtTenNhanVien.Text = dt.Rows[0]["Tennhanvien"].ToString();

            //--------------------------------------------------------------------------------------------- 2
            cboMaHDBan.DataSource = dtBase.ReadData($"select MaHDBan from tblHDBan"); // cbo dữ liệu
            cboMaHDBan.DisplayMember = "MaHDBan";                                      // cbo hiển thị field nào trong dữ liệu


            //--------------------------------------------------------------------------------------------- 5.1
            cboMaHang.DataSource = dtBase.ReadData($"select * from tblHang");
            cboMaHang.DisplayMember = "Mahang";

        }

        //------------------------------------------------------------------------------------------------- 3
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string MaHDBan = cboMaHDBan.Text.Trim();
            txtMaHDBan.Text = MaHDBan;

            // dgv
            DataTable dt = dtBase.ReadData($@"
                                            select c.MaHang, h.TenHang, h.DonGiaBan, c.SoLuong, c.GiamGia, c.ThanhTien
                                            from tblChiTietHDBan c join tblHang h on c.MaHang=h.Mahang
                                            where c.MaHDBan = '{MaHDBan}'");
            if (dt.Rows.Count <= 0) return;
            dgvHDBan.DataSource = dt;

            // ngay ban
            DataTable dt1 = dtBase.ReadData($@"
                                            select NgayBan
                                            from tblHDBan
                                            where MaHDBan = '{MaHDBan}'");
            dtpNgayBan.Value = Convert.ToDateTime(dt1.Rows[0]["NgayBan"]);

            // khach hang
            DataTable dt2 = dtBase.ReadData($@"
                                            select * 
                                            from tblHDBan h join tblKhach k on h.MaKhach=k.Makhach");
            cboMaKhach.Text = dt2.Rows[0]["MaKhach"].ToString();
            txtTenKhach.Text = dt2.Rows[0]["TenKhach"].ToString();
            txtDiaChi.Text = dt2.Rows[0]["DiaChi"].ToString();
            txtDienThoai.Text = dt2.Rows[0]["DienThoai"].ToString();

            // tong tien 
            DataTable dt3 = dtBase.ReadData($@"
                                            select TongTien
                                            from tblHDBan
                                            where MaHDBan = '{MaHDBan}'");
            txtTongTien.Text = dt3.Rows[0]["TongTien"].ToString();


        }


        //------------------------------------------------------------------------------------------------- 4
        private void txtDienThoai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt2 = dtBase.ReadData($@"select * from tblKhach where DienThoai = '{txtDienThoai.Text.Trim()}'");

                if (dt2.Rows.Count > 0)
                {
                    cboMaKhach.Text = dt2.Rows[0]["MaKhach"].ToString();
                    txtTenKhach.Text = dt2.Rows[0]["TenKhach"].ToString();
                    txtDiaChi.Text = dt2.Rows[0]["DiaChi"].ToString();
                    txtDienThoai.Text = dt2.Rows[0]["DienThoai"].ToString();

                    //e.SuppressKeyPress = true; // Tắt tiếng "bíp" của Windows
                }
                else if(MessageBox.Show("Khach nay chua co trong CSDL, ban co muon them ko?","",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {

                    dtBase.ChangeData($@"
                                        insert into tblKhach
                                        values('{cboMaKhach.Text+"1"}','{txtTenKhach.Text}','{txtDiaChi.Text}','{txtDienThoai.Text}',NULL)");
                                                                // :)) + "1" vao de ko trung key
                }


            }
        }


        //--------------------------------------------------------------------------------------------- 5.2
        private void cboMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaHang.SelectedIndex != -1)
            {
                string Mahang = cboMaHang.Text.Trim();
                DataTable dt = dtBase.ReadData($"select * from tblHang where Mahang='{Mahang}'");
                if (dt.Rows.Count <= 0) return;
                txtTenHang.Text = dt.Rows[0]["TenHang"].ToString();
                txtDonGia.Text = dt.Rows[0]["DonGiaBan"].ToString();
                
            }
        }


        //---------------------------------------------------------------------------------------------- 6
        private void txtSoLuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSoLuong.Text != "" && txtGiamGia.Text != "")
                {
                    txtThanhTien.Text = (float.Parse(txtDonGia.Text.Trim()) *
                                         int.Parse(txtSoLuong.Text.Trim()) *
                                         float.Parse(txtGiamGia.Text.Trim()) / 100).ToString();
                }
            }
        }

        //---------------------------------------------------------------------------------------------- 7
        private void btnThem_Click(object sender, EventArgs e)
        {
            dtpNgayBan.Value = DateTime.Now;

            cboMaKhach.Text = "";
            txtTenKhach.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";

            cboMaHang.Text = "";
            txtTenHang.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            txtGiamGia.Text = "";
            txtThanhTien.Text = "";

            dgvHDBan.DataSource = null;

            txtTongTien.Text = "";

            string datePart = DateTime.Now.ToString("ddMMyyyy");
            string prefix = "HĐB_" + datePart;

            DataTable dt = dtBase.ReadData($"select top 1 MaHDBan from tblHDBan where MaHDBan like '{prefix}%' order by MaHDBan desc");

            if (dt.Rows.Count > 0)
            {
                string maCuoi = dt.Rows[0]["MaHDBan"].ToString();
                int soTiepTheo = int.Parse(maCuoi.Substring(12)) + 1; // Bỏ 12 ký tự đầu (HĐB_ddMMyyyy)

                // .ToString("D4") sẽ tự động ép thành định dạng 4 chữ số, VD: 1 -> 0001
                txtMaHDBan.Text = prefix + soTiepTheo.ToString("D4");
            }
            else
            {
                // Nếu đây là hóa đơn đầu tiên trong ngày
                txtMaHDBan.Text = prefix + "0001";
            }
        }


    }
}
