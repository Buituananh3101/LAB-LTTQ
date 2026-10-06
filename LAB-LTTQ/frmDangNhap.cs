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
    public partial class frmDangNhap : Form
    {
        classes.DataProcessing dtBase = new classes.DataProcessing(); //NV01 123456
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập userName");
                txtUserName.Focus();
                return;
            }

            if (txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập Mật khẩu");
                txtPass.Focus();
                return;
            }

            DataTable dt = dtBase.ReadData("Select * from tblNhanVien where MaNhanVien='" +
                txtUserName.Text +
                "' and Pass like '" + txtPass.Text + "'");

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Tài khoản không tồn tại. Mời bạn kiểm tra lại");
            }
            else
            {
                Program.maNV = txtUserName.Text;
                frmMain frm = new frmMain();
                this.Hide();
                frm.ShowDialog();
            }
        }
    }
}
