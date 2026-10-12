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
    public partial class frmDangNhap : Form
    {
        DataProcessing dtBase = new DataProcessing();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string userName = txtTenDangNhap.Text.Trim();
            string passWord = txtMatKhau.Text.Trim();

            DataTable dt = dtBase.ReadData($@"select * from tblUser where userName='{userName}' and passWord like '{passWord}'");
            if (dt.Rows.Count > 0)
            {
                Program.tenNV = userName;
                this.Hide();
                frmMain frm = new frmMain();
                frm.ShowDialog();
            }
        }
    }
}
