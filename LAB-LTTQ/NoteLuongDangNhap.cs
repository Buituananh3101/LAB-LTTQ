using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_LTTQ
{
    internal class NoteLuongDangNhap
    {
    }
}
/*
Note luồng đăng nhập:

1. Logic đăng nhập

vào file program 

    --> khai báo thuộc tính string maNV: 

        --> trong event Load frmMain kiểm tra

            --> biến rỗng --> mở frmDangNhap + ẩn frmMain

            --> có        --> Mở frmMain

                --> event Click MenuStrip mở frmHDBan

    --> đổi form start thành frmMain

nhap frmDangNhap

    --> Khai báo DataProcessing

    --> event Click frmDangNhap
        
        --> Truy vấn dữ liệu dựa trên txt nhập vào Datatable --> kiểm tra nếu có dữ liệu 

            --> Ghi vào Program.amNv + mở frmMain + ẩm frmDangNhap

Chú ý: truy vấn dữ liệu

    --> Manhanvien='{Manhanvien}' and Pass like '{Pass}'

        --> 1. phải có ' 
        --:>2. nếu là kiểu ntext thì phải dùng like
 */