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
    public partial class BTDienTu : Form
    {
        private BaiTapDienTu bt;                                   // Lưu bài tập được Form menu truyền sang.

        internal BTDienTu(BaiTapDienTu baitap)                     // Hàm tạo nhận một đối tượng bài tập.
        {
            InitializeComponent();                                 

            bt = baitap;                                           // Giữ lại bài tập để dùng khi chấm điểm.
            rtbDeBai.Text = bt.Debai;                              // Hiển thị đề bài lên RichTextBox.
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int diem = 0;                                         // Mỗi lần chấm bắt đầu từ 0 điểm.

            TextBox[] txtBoxes = { txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9, txt10 };

            for (int i = 0; i < 10  ; i++)
            {
                string cauTL = txtBoxes[i].Text;                  // Lấy câu trả lời 

                if (cauTL.Equals(bt.Dapantungcau[i]))             // So sánh với đáp án 
                {
                    txtBoxes[i].BackColor = Color.Green;          // Đúng: đổi xanh.
                    diem++;                                       // Cộng thêm 1 điểm.
                }
                else
                {
                    txtBoxes[i].BackColor = Color.Pink;           // Sai: đổi hồng.
                }
            }

            MessageBox.Show("Điểm của bạn là " + diem);          
        }

        private void btnDapan_Click(object sender, EventArgs e)
        {
            rtbDeBai.Text = bt.Dapan;                             // Hiện đoạn văn đã điền đáp án.
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            rtbDeBai.Text = bt.Debai;                             // Hiển thị lại đề bài có chỗ trống.

            TextBox[] txtBoxes = { txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9, txt10 };

            foreach (var txt in txtBoxes)
            {
                txt.Clear();                                      // Xóa câu trả lời.
                txt.BackColor = Color.White;                      // Đưa màu nền về trắng.
            }

            txt1.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();                                        
        }
    }
}
