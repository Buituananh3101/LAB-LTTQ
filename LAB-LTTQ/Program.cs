using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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

//1.Tạo giao diện

//    | Điều khiển  | Đặt thuộc tính `Name` | Công dụng |
//    |---          |---             |---|
//    | ComboBox    | `cbODia`       | Chọn ổ đĩa |
//    | ComboBox    | `cbThuMuc`     | Chọn thư mục |
//    | ListBox     | `lbBaiHat`     | Danh sách bài hát |
//    | RichTextBox | `rtbLoiBaiHat` | Hiện lời bài hát |
//    | Label       | Tùy ý          | Ghi chú thích cho từng ô |

//    Để thêm Windows Media Player: chuột phải trong Toolbox → Choose Items… → tab COM Components → tích Windows Media Player → OK. Kéo nó lên Form và đặt Name là axWindowsMediaPlayer1.

//2.Luồng chạy: Form1_Load lấy ổ đĩa 
//    → chọn ổ đĩa thì lấy thư mục
//    → chọn thư mục thì lấy file nhạc 
//    → chọn bài hát thì phát và tìm file lời cùng tên. Ví dụ, đặt Baihat.mp3 và Baihat.txt trong cùng thư mục.