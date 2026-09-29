using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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


        // 1. Ngay khi mở Form → đưa các ổ đĩa vào ComboBox
        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives(); // Lấy danh sách các ổ đĩa trong máy

            foreach (DriveInfo d in drives)             // Duyệt từng ổ đĩa.
            {
                cbODia.Items.Add(d.Name);               // Thêm tên ổ đĩa vào ComboBox, ví dụ: C:\, D:\.
            }
        }


        // 2. Chọn ổ đĩa → đưa thư mục vào ComboBox
        private void cbODia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbThuMuc.Items.Clear();                                          // Xóa danh sách thư mục của ổ đã chọn trước đó.

            DirectoryInfo directory = new DirectoryInfo(cbODia.Text);        // Tạo đối tượng đại diện cho ổ đang chọn.

            DirectoryInfo[] directories = directory.GetDirectories("*.*");   // Lấy các thư mục nằm trong ổ đó.

            foreach (DirectoryInfo d in directories)                         // Duyệt từng thư mục.
            {
                cbThuMuc.Items.Add(d.Name);                                  // Thêm tên thư mục vào ComboBox.
                                                                             // Ví dụ: Nhac.
            }
        }


        //3. Chọn thư mục → đưa bài hát vào ListBox
        private void cbThuMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbBaiHat.Items.Clear();                      // Xóa danh sách bài hát cũ.
            rtbLoiBaiHat.Text = "";                      // Xóa lời bài hát cũ.

            string[] files = Directory.GetFiles(         // Ghép tên ổ với tên thư mục.
                cbODia.Text + cbThuMuc.Text, "*.mp3");   // Ví dụ: "D:\" + "Nhac" thành "D:\Nhac".
                                                         // Lấy các file MP3 trong thư mục đó.   

            foreach (string d in files)                  // Duyệt từng file nhạc.
            {
                lbBaiHat.Items.Add(d);                   // Thêm đường dẫn đầy đủ của bài hát vào ListBox.
                                                         // Ví dụ: D:\Nhac\Baihat.mp3.
            }
        }


        //4. Chọn bài hát → phát nhạc và đọc lời
        private void lbBaiHat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBaiHat.SelectedItem == null)                          // Kiểm tra chưa có bài hát được chọn.
                return;                                                

            string baiHat = lbBaiHat.SelectedItem.ToString();           // Lấy đường dẫn bài hát được chọn.
            axWindowsMediaPlayer1.URL = baiHat;                         // Phát bài hát.

            rtbLoiBaiHat.Text = "";                                     // Xóa lời bài hát cũ.

            string fileTxt = Path.ChangeExtension(baiHat, ".txt");      // Đổi đuôi .mp3 thành .txt để tìm file lời.
            string fileRtf = Path.ChangeExtension(baiHat, ".rtf");      // Đổi đuôi .mp3 thành .rtf để tìm file lời.

            if (File.Exists(fileTxt))                                   // Kiểm tra file lời TXT có tồn tại không.
            {
                FileStream fs = new FileStream(fileTxt, FileMode.Open); // Mở file lời.
                StreamReader rd = new StreamReader(fs, Encoding.UTF8);  // Tạo bộ đọc nội dung theo mã UTF-8.
                string giaTri = rd.ReadToEnd();                         // Đọc toàn bộ nội dung file.
                rtbLoiBaiHat.Text = giaTri;                             // Hiển thị lời bài hát.

                rd.Close();                                             // Đóng bộ đọc và luồng file bên dưới.
                fs.Close();                                             // Đóng FileStream; lúc này đã được rd.Close() đóng.
            }
            else if (File.Exists(fileRtf))                              // Nếu không có TXT, kiểm tra file RTF.
            {
                rtbLoiBaiHat.LoadFile(fileRtf);                         // Hiển thị lời từ file RTF.
            }
        }



        

    }
}
