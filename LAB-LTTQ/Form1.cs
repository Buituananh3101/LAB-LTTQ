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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void baiTapDienTu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaiTapDienTu bt = new BaiTapDienTu();                   // Tạo đối tượng chứa dữ liệu bài tập.

            bt.Debai =                                              // Gán đề bài có 10 chỗ trống.
                "My grandfather was born in China. " +
                "He came from a very poor family and was (1) ____ of seven children. " +
                "His parents lived (2) ____ a small farm. " +
                "He didn't have a very good education. " +
                "At the age of 17 he (3) ____ home. " +
                "First he went to Shanghai and (4) ____ he went to Hong Kong. " +
                "He worked (5) ____ a waiter and then as a cook. " +
                "When he was 21, he (6) ____ my grandmother and had four children.\n\n" +
                "My mother was (7) ____ oldest. " +
                "My grandmother died recently, and my grandfather lives alone now. " +
                "He is almost 80, (8) ____ he is still very active and interested " +
                "in everything (9) ____ is going on. " +
                "He reads the papers and (10) ____ television " +
                "even though his eyesight is fairly poor.";

            bt.Dapan =                                             // Gán đoạn văn đã điền đầy đủ đáp án.
                "My grandfather was born in China. " +
                "He came from a very poor family and was (1) one of seven children. " +
                "His parents lived (2) on a small farm. " +
                "He didn't have a very good education. " +
                "At the age of 17 he (3) left home. " +
                "First he went to Shanghai and (4) then he went to Hong Kong. " +
                "He worked (5) as a waiter and then as a cook. " +
                "When he was 21, he (6) married my grandmother and had four children.\n\n" +
                "My mother was (7) the oldest. " +
                "My grandmother died recently, and my grandfather lives alone now. " +
                "He is almost 80, (8) but he is still very active and interested " +
                "in everything (9) that is going on. " +
                "He reads the papers and (10) watches television " +
                "even though his eyesight is fairly poor.";

            List<string> lists = new List<string>();              // Tạo danh sách đáp án từng câu.

            lists.Add("one");
            lists.Add("on");
            lists.Add("left");
            lists.Add("then");
            lists.Add("as");
            lists.Add("married");
            lists.Add("the");
            lists.Add("but");
            lists.Add("that");
            lists.Add("watches");

            bt.Dapantungcau = lists;                              // Lưu danh sách đáp án vào bài tập.

            BTDienTu btdt = new BTDienTu(bt);                      // Tạo Form, truyền bài tập bt sang.
            btdt.Show();                                          // Hiển thị Form bài tập.
        }
    }
}
