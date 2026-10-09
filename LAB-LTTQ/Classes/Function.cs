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
        public void FillCombo(ComboBox cb, DataTable dt, string display, string value) // Thu thập dữ liệu từ bảng và đổ vào combobox
        {                                                                              // cb dùng để nhận dữ liệu từ bảng,
                                                                                       // dt là bảng dữ liệu,
                                                                                       // display là tên cột hiển thị,
                                                                                       // value là tên cột giá trị tương ứng với display
            cb.DataSource = dt;
            cb.DisplayMember = display;
            cb.ValueMember = value;
        }
    }
}