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

        public void loadLaiBangChiTietHoaDon(string MaHDBan)
        {
            dgvHDBan.DataSource = dtBase.ReadData($@"
                                            select c.MaHang, h.TenHang, h.DonGiaBan, c.SoLuong, c.GiamGia, c.ThanhTien
                                            from tblChiTietHDBan c join tblHang h on c.MaHang=h.Mahang
                                            where c.MaHDBan = '{MaHDBan}'");
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
                                         (100-float.Parse(txtGiamGia.Text.Trim())) / 100).ToString();
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


        //---------------------------------------------------------------------------------------------- 8
        //Khi nhấn nút lưu hóa đơn thì lưu thông tin hóa đơn và chi tiết hóa đơn vào
        //CSDL đồng thời trừ số lượng tương ứng của các mặt hàng. (đồng thời kiểm
        //tra việc ko đủ số lượng). Tính tổng tiền hóa đơn.Trên form cần hiển thị các
        //thông tin của hóa đơn đó.
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. KIỂM TRA DỮ LIỆU ĐẦU VÀO CỦA MẶT HÀNG
            if (cboMaHang.Text == "" || txtTenHang.Text == "" || txtDonGia.Text == "" || 
                txtSoLuong.Text == "" || txtGiamGia.Text == "" || txtThanhTien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin mặt hàng cần thêm!");
                return;
            }

            string Mahang = cboMaHang.Text.Trim();
            int SoLuong = int.Parse(txtSoLuong.Text.Trim());
            string MaHDBan = txtMaHDBan.Text.Trim();

            // 2. KIỂM TRA SỐ LƯỢNG TỒN TRONG KHO
            DataTable dt = dtBase.ReadData($"select * from tblHang where Mahang='{Mahang}'");
            if (dt.Rows.Count > 0)
            {
                int soLuongTon = int.Parse(dt.Rows[0]["SoLuong"].ToString());
                if (soLuongTon < SoLuong)
                {
                    MessageBox.Show($"Số lượng không đủ! Mặt hàng này chỉ còn {soLuongTon} sản phẩm.");
                    return;
                }
            }

            // 3. XỬ LÝ VỎ HÓA ĐƠN (Thông tin chung)
            DataTable dt1 = dtBase.ReadData($"select * from tblHDBan where MaHDBan = '{MaHDBan}'");
            if (dt1.Rows.Count == 0) 
            {
                if (cboMaKhach.Text == "" || txtTenKhach.Text == "" || txtDiaChi.Text == "" || txtDienThoai.Text == "")
                {
                    MessageBox.Show("Đây là hóa đơn mới, vui lòng nhập đủ thông tin Khách hàng!");
                    return;
                }

                dtBase.ChangeData($@"
                    INSERT INTO tblHDBan (MaHDBan, MaNhanVien, NgayBan, MaKhach, TongTien) 
                    VALUES ('{MaHDBan}', '{Program.maNV}', '{dtpNgayBan.Value.ToString("yyyy-MM-dd")}', '{cboMaKhach.Text.Trim()}', 0)");
            }

            // 4. KIỂM TRA TRÙNG MẶT HÀNG TRONG HÓA ĐƠN NÀY
            DataTable dtChiTiet = dtBase.ReadData($"select * from tblChiTietHDBan where MaHDBan='{MaHDBan}' and MaHang='{Mahang}'");
            if (dtChiTiet.Rows.Count > 0)
            {
                MessageBox.Show("Mặt hàng này đã có trong hóa đơn. Vui lòng chọn mã hàng khác!");
                return;
            }

            // 5. THÊM VÀO CHI TIẾT HÓA ĐƠN VÀ TRỪ TỒN KHO
            float donGia = float.Parse(txtDonGia.Text.Trim());
            float giamGia = float.Parse(txtGiamGia.Text.Trim());
            float thanhTien = float.Parse(txtThanhTien.Text.Trim());

            // Thêm mặt hàng
            dtBase.ChangeData($@"
                    INSERT INTO tblChiTietHDBan (MaHDBan, MaHang, SoLuong, GiamGia, ThanhTien) 
                    VALUES ('{MaHDBan}', '{Mahang}', {SoLuong}, {giamGia}, {thanhTien})");
            
            // Trừ số lượng kho
            dtBase.ChangeData($"UPDATE tblHang SET SoLuong = SoLuong - {SoLuong} WHERE MaHang = '{Mahang}'");
            
            // Cộng dồn tiền vào tổng hóa đơn
            dtBase.ChangeData($"UPDATE tblHDBan SET TongTien = TongTien + {thanhTien} WHERE MaHDBan = '{MaHDBan}'");

            // 6. CẬP NHẬT LẠI GIAO DIỆN FORM
            loadLaiBangChiTietHoaDon(MaHDBan);

            // Lấy lại tổng tiền mới đưa lên text box
            DataTable dtTongTien = dtBase.ReadData($"select TongTien from tblHDBan where MaHDBan = '{MaHDBan}'");
            if (dtTongTien.Rows.Count > 0)
            {
                txtTongTien.Text = dtTongTien.Rows[0]["TongTien"].ToString();
            }

            // Xóa các ô nhập mặt hàng để người dùng nhập món tiếp theo
            cboMaHang.Text = ""; 
            txtTenHang.Text = ""; 
            txtSoLuong.Text = ""; 
            txtGiamGia.Text = ""; 
            txtDonGia.Text = ""; 
            txtThanhTien.Text = "";
    
            // Đưa con trỏ chuột quay lại ô chọn mặt hàng
            cboMaHang.Focus();

            //Bắt đầu
            //➔ Kiểm tra rỗng(Nếu thiếu thông tin mặt hàng: Báo lỗi, Dừng)
            //➔ Kiểm tra tồn kho(Nếu Kho < Số lượng mua: Báo lỗi, Dừng)
            //➔ Kiểm tra Hóa đơn(Nếu chưa có mã hóa đơn này trong CSDL ➔ Tạo mới vỏ Hóa đơn)
            //➔ Kiểm tra trùng mã hàng(Nếu mặt hàng đã có trong hóa đơn này: Báo lỗi, Dừng)
            //➔ Lưu Chi tiết Hóa đơn(Thêm mặt hàng vừa chọn vào CSDL)
            //➔ Trừ kho(Cập nhật lại số lượng hàng)
            //➔ Tính tổng tiền(Cộng dồn thành tiền vào Hóa đơn)
            //➔ Làm mới Giao diện(Tải lại lưới, hiện tổng tiền mới, xóa trắng các ô mặt hàng)
            //➔ Kết thúc.
        }


        //---------------------------------------------------------------------------------------------- 9
        //Khi khách muốn trả một sản phẩm thì có thể click đúp vào sản phẩm đó và 
        //xóa.
        private void dgvHDBan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if (MessageBox.Show("Xac nhan xoa", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string MaHang = dgvHDBan.Rows[e.RowIndex].Cells["MaHang"].Value.ToString();
                    dtBase.ChangeData($"delete from tblChiTietHDBan where MaHang='{MaHang}'");
                    loadLaiBangChiTietHoaDon(txtMaHDBan.Text.Trim());
                }
            }
        }


        //---------------------------------------------------------------------------------------------- 10
        private void btnHuy_Click(object sender, EventArgs e)
        {
            string MaHDBan = txtMaHDBan.Text.Trim();

            if (MaHDBan == "")
            {
                MessageBox.Show("Chưa chọn hoặc chưa có hóa đơn nào để hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Yêu cầu người dùng xác nhận trước khi xóa
            if (MessageBox.Show($"Bạn có chắc chắn muốn hủy hóa đơn {MaHDBan} không?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // 1. Lấy danh sách các mặt hàng trong hóa đơn này để hoàn lại số lượng tồn kho
                DataTable dtChiTiet = dtBase.ReadData($"select MaHang, SoLuong from tblChiTietHDBan where MaHDBan = '{MaHDBan}'");

                if (dtChiTiet.Rows.Count > 0)
                {
                    for (int i = 0; i < dtChiTiet.Rows.Count; i++)
                    {
                        string maHang = dtChiTiet.Rows[i]["MaHang"].ToString();
                        int soLuong = int.Parse(dtChiTiet.Rows[i]["SoLuong"].ToString());

                        // Trả lại số lượng cho bảng Hàng
                        dtBase.ChangeData($"update tblHang set SoLuong = SoLuong + {soLuong} where Mahang = '{maHang}'");
                    }
                }

                // 2. Xóa các bản ghi trong bảng Chi Tiết Hóa Đơn
                dtBase.ChangeData($"delete from tblChiTietHDBan where MaHDBan = '{MaHDBan}'");

                // 3. Xóa bản ghi trong bảng Hóa Đơn (vỏ hóa đơn)
                dtBase.ChangeData($"delete from tblHDBan where MaHDBan = '{MaHDBan}'");

                MessageBox.Show("Đã hủy hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 4. Làm mới lại giao diện (gọi lại hàm thêm mới để reset toàn bộ textbox và datagridview)
                btnThem_Click(sender, e);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }
    }
}
