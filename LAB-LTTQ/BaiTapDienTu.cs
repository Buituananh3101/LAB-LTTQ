using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_LTTQ
{
    internal class BaiTapDienTu
    {

        public string Debai { get; set; }                // Lưu đề bài có các chỗ trống.
        public string Dapan { get; set; }                // Lưu đoạn văn đã điền đầy đủ đáp án.
        public List<string> Dapantungcau { get; set; }   // Lưu đáp án từng câu để chấm điểm.


    }
}
