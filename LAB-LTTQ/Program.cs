using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LAB_LTTQ
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}


//2 mục tiêu: 

//    1. sử dụng các điều khiển 
//            Combobox,
//            listBox,
//            lable,
//            RichTextBox,
//            Windows Media Player

//    2. tổ chức chương trình  có có nhiều mẫu biểu

//| Bài   | Việc cần làm                                                       |
//|---    |---                                                                 |
//| Bài 3 | Chọn ổ đĩa → thư mục → bài hát; phát nhạc và hiện lời nếu có       |
//| Bài 4 | Dùng MenuStrip mở Form điền từ; chấm 10 câu, tô màu và hiện đáp án |

//Bài 4 — Dùng class BaiTapDienTu như tài liệu

//| Thành phần              | Nhiệm vụ                                       |
//| ----------------------- | ---------------------------------------------- |
//| `frmMain`               | Có menu chọn bài tập; tạo đề và đáp án         |
//| Class `BaiTapDienTu`    | Chứa đề bài, bài giải đầy đủ và đáp án từng câu|
//| Form `BTDienTu`         | Nhận đối tượng bài tập, hiển thị đề và chấm điểm|

//| Điều khiển              | Name                                           |
//| ----------------------- | ---------------------------------------------- |
//| RichTextBox chứa đề bài | `rtbDeBai`                                     |
//| 10 TextBox nhập đáp án  | `txt1` đến `txt10`                             |
//| Button OK               | `btnOK`                                        |
//| Button Đáp án           | `btnDapan`                                     |
//| Button Làm lại          | `btnLamLai`                                    |
//| Button Thoát            | `btnThoat`                                     |