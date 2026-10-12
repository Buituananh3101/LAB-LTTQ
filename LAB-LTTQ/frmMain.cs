using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LAB_LTTQ
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void hangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHang frm = new frmHang();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Program.tenNV == "")
            {
                frmDangNhap frmDN = new frmDangNhap();
                frmDN.ShowDialog();
                this.Hide();
            }
        }
    }
}
