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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Program.maNV == "")
            {
                this.Hide();
                frmDangNhap frmDN = new frmDangNhap();
                frmDN.ShowDialog();
            }
        }

        private void hoaDonBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHDBan hdb = new frmHDBan();
            hdb.ShowDialog();
        }
    }
}
