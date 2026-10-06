using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_LTTQ.Classes
{
    internal class Function
    {
        public void FillComboBox(ComboBox cb, DataTable dt, string display, string value)  // cài đặt nhannh combobox
            {                                                                              // cb        nhận dữ liệu
                                                                                           // dt        dữ liệu từ csdl
                                                                                           // display   tên chất liệu
                                                                                           // value     mã chất liệu
            cb.DataSource = dt;
            cb.DisplayMember = display;
            cb.ValueMember = value;
        }
    }
}
