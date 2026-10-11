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
using System.Xml;

namespace LAB_LTTQ
{
    public partial class frmDangNhap : Form
    {
        DataProcessing dtBase = new DataProcessing();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string Manhanvien = txtUserName.Text.Trim();
            string Pass = txtPass.Text.Trim();

            DataTable dt = dtBase.ReadData($@"select * from tblNhanVien where Manhanvien='{Manhanvien}' and Pass like '{Pass}'");
            if (dt.Rows.Count > 0)
            {
                Program.maNV = Manhanvien;
                this.Hide();
                frmMain frm = new frmMain();
                frm.ShowDialog();
            }
        }
    }
}
