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
            cboMaHDBan.DataSource = dtBase.ReadData($"select MaHDBan from  tblHDBan"); // cbo dữ liệu
            cboMaHDBan.DisplayMember = "MaHDBan";                                      // cbo hiển thị field nào trong dữ liệu




        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
