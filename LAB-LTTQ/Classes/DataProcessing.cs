using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_LTTQ.classes
{
    internal class DataProcessing
    {
        //----------------------------------------------------------------------------------------------------
        string strConnect = "Data Source=localhost\\SQLEXPRESS; Database=lttqclass8; Integrated Security=true"; // Khai báo server name, database name, user name, password
        SqlConnection sqlConnection = null;



        //----------------------------------------------------------------------------------------------------
        void openConnect()
        {
            sqlConnection = new SqlConnection(strConnect);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }


        //----------------------------------------------------------------------------------------------------

        void closeConnect()
        {
            if (sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
        }



        //----------------------------------------------------------------------------------------------------
        public DataTable ReadData(string sqlSelect)
        {
            openConnect();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlSelect, sqlConnection); // Tạo đối tượng chạy query thông qua sqlConnection
            DataTable tblMatHang = new DataTable();
            dataAdapter.Fill(tblMatHang);                                             // Đổ dữ liệu 

            closeConnect();

            return tblMatHang;
        }



        //----------------------------------------------------------------------------------------------------
        public void ChangeData(string sql)               // Truyền vào query
        {
            openConnect();

            SqlCommand sqlcomm = new SqlCommand();       // 2. Tạo đối tượng thực thi SQL
            sqlcomm.Connection = sqlConnection;          // 3. Gán kết nối cho đối tượng
            sqlcomm.CommandText = sql;                   // 4. Gán câu lệnh SQL cần chạy
            sqlcomm.ExecuteNonQuery();                   // 5. Thực thi INSERT, UPDATE, DELETE

            closeConnect();
        }


        //----------------------------------------------------------------------------------------------------
    }
}








//USE [DuLieu]
//GO
///****** Object:  Table [dbo].[tblChatLieu]    Script Date: 06/10/2026 1:44:59 PM ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[tblChatLieu](
//	[MaChatLieu] [nvarchar](50) NOT NULL,
//	[TenChatLieu] [nchar](10) NULL,
//PRIMARY KEY CLUSTERED 
//(
//	[MaChatLieu] ASC
//)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
//) ON [PRIMARY]
//GO
///****** Object:  Table [dbo].[tblChiTietHDBan]    Script Date: 06/10/2026 1:44:59 PM ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[tblChiTietHDBan](
//	[MaHDBan] [nvarchar](50) NOT NULL,
//	[MaHang] [nvarchar](50) NOT NULL,
//	[SoLuong] [int] NULL,
//	[GiamGia] [nvarchar](50) NULL,
//	[ThanhTien] [nvarchar](50) NULL,
//PRIMARY KEY CLUSTERED 
//(
//	[MaHDBan] ASC,
//	[MaHang] ASC
//)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
//) ON [PRIMARY]
//GO
///****** Object:  Table [dbo].[tblHang]    Script Date: 06/10/2026 1:44:59 PM ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[tblHang](
//	[Mahang] [nvarchar](50) NOT NULL,
//	[TenHang] [nvarchar](50) NULL,
//	[MaChatLieu] [nvarchar](50) NULL,
//	[SoLuong] [int] NULL,
//	[DonGiaNhap] [float] NULL,
//	[DonGiaBan] [float] NULL,
//	[Anh] [ntext] NULL,
//	[GhiChu] [ntext] NULL,
//PRIMARY KEY CLUSTERED 
//(
//	[Mahang] ASC
//)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
//) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
//GO
///****** Object:  Table [dbo].[tblHDBan]    Script Date: 06/10/2026 1:44:59 PM ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[tblHDBan](
//	[MaHDBan] [nvarchar](50) NOT NULL,
//	[MaNhanVien] [nchar](10) NULL,
//	[NgayBan] [date] NULL,
//	[MaKhach] [nvarchar](50) NULL,
//	[TongTien] [nvarchar](50) NULL,
//PRIMARY KEY CLUSTERED 
//(
//	[MaHDBan] ASC
//)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
//) ON [PRIMARY]
//GO
///****** Object:  Table [dbo].[tblKhach]    Script Date: 06/10/2026 1:44:59 PM ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[tblKhach](
//	[Makhach] [nvarchar](50) NOT NULL,
//	[TenKhach] [nvarchar](50) NULL,
//	[DiaChi] [ntext] NULL,
//	[DienThoai] [nvarchar](50) NULL,
//	[NgaySinh] [date] NULL,
//PRIMARY KEY CLUSTERED 
//(
//	[Makhach] ASC
//)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
//) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
//GO
///****** Object:  Table [dbo].[tblNhanVien]    Script Date: 06/10/2026 1:44:59 PM ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[tblNhanVien](
//	[Manhanvien] [nvarchar](50) NOT NULL,
//	[Tennhanvien] [nvarchar](50) NULL,
//	[ngaysinh] [date] NULL,
//	[GioiTinh] [nchar](10) NULL,
//	[DiaChi] [ntext] NULL,
//	[Dienthoai] [nvarchar](50) NULL,
//	[Anh] [ntext] NULL,
//	[Pass] [ntext] NULL,
//PRIMARY KEY CLUSTERED 
//(
//	[Manhanvien] ASC
//)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
//) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
//GO
//USE [DuLieu]
//GO
///****** Object:  Table [dbo].[tblChatLieu]    Script Date: 06/10/2026 1:44:59 PM ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[tblChatLieu](
//	[MaChatLieu] [nvarchar](50) NOT NULL,
//	[TenChatLieu] [nchar](10) NULL,
//PRIMARY KEY CLUSTERED 
//(
//	[MaChatLieu] ASC
//)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
//) ON [PRIMARY]
//GO
///****** Object:  Table [dbo].[tblChiTietHDBan]    Script Date: 06/10/2026 1:44:59 PM ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[tblChiTietHDBan](
//	[MaHDBan] [nvarchar](50) NOT NULL,
//	[MaHang] [nvarchar](50) NOT NULL,
//	[SoLuong] [int] NULL,
//	[GiamGia] [nvarchar](50) NULL,
//	[ThanhTien] [nvarchar](50) NULL,
//PRIMARY KEY CLUSTERED 
//(
//	[MaHDBan] ASC,
//	[MaHang] ASC
//)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
//) ON [PRIMARY]
//GO
///****** Object:  Table [dbo].[tblHang]    Script Date: 06/10/2026 1:44:59 PM ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[tblHang](
//	[Mahang] [nvarchar](50) NOT NULL,
//	[TenHang] [nvarchar](50) NULL,
//	[MaChatLieu] [nvarchar](50) NULL,
//	[SoLuong] [int] NULL,
//	[DonGiaNhap] [float] NULL,
//	[DonGiaBan] [float] NULL,
//	[Anh] [ntext] NULL,
//	[GhiChu] [ntext] NULL,
//PRIMARY KEY CLUSTERED 
//(
//	[Mahang] ASC
//)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
//) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
//GO
///****** Object:  Table [dbo].[tblHDBan]    Script Date: 06/10/2026 1:44:59 PM ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[tblHDBan](
//	[MaHDBan] [nvarchar](50) NOT NULL,
//	[MaNhanVien] [nchar](10) NULL,
//	[NgayBan] [date] NULL,
//	[MaKhach] [nvarchar](50) NULL,
//	[TongTien] [nvarchar](50) NULL,
//PRIMARY KEY CLUSTERED 
//(
//	[MaHDBan] ASC
//)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
//) ON [PRIMARY]
//GO
///****** Object:  Table [dbo].[tblKhach]    Script Date: 06/10/2026 1:44:59 PM ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[tblKhach](
//	[Makhach] [nvarchar](50) NOT NULL,
//	[TenKhach] [nvarchar](50) NULL,
//	[DiaChi] [ntext] NULL,
//	[DienThoai] [nvarchar](50) NULL,
//	[NgaySinh] [date] NULL,
//PRIMARY KEY CLUSTERED 
//(
//	[Makhach] ASC
//)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
//) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
//GO
///****** Object:  Table [dbo].[tblNhanVien]    Script Date: 06/10/2026 1:44:59 PM ******/
//SET ANSI_NULLS ON
//GO
//SET QUOTED_IDENTIFIER ON
//GO
//CREATE TABLE [dbo].[tblNhanVien](
//	[Manhanvien] [nvarchar](50) NOT NULL,
//	[Tennhanvien] [nvarchar](50) NULL,
//	[ngaysinh] [date] NULL,
//	[GioiTinh] [nchar](10) NULL,
//	[DiaChi] [ntext] NULL,
//	[Dienthoai] [nvarchar](50) NULL,
//	[Anh] [ntext] NULL,
//	[Pass] [ntext] NULL,
//PRIMARY KEY CLUSTERED 
//(
//	[Manhanvien] ASC
//)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
//) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
//GO











///* Nhân viên */
//IF NOT EXISTS (SELECT 1 FROM dbo.tblNhanVien WHERE Manhanvien = N'NV01')
//    INSERT INTO dbo.tblNhanVien
//        (Manhanvien, Tennhanvien, ngaysinh, GioiTinh, DiaChi, Dienthoai, Anh, Pass)
//    VALUES
//        (N'NV01', N'Nguyen Van An', '2000-05-15',
//         N'Nam', N'Ha Noi', N'0901000001', NULL, N'123456');


///* Chất liệu */
//IF NOT EXISTS (SELECT 1 FROM dbo.tblChatLieu WHERE MaChatLieu = N'CLV')
//    INSERT INTO dbo.tblChatLieu (MaChatLieu, TenChatLieu)
//    VALUES (N'CLV', N'Vai');

//IF NOT EXISTS (SELECT 1 FROM dbo.tblChatLieu WHERE MaChatLieu = N'CLN')
//    INSERT INTO dbo.tblChatLieu (MaChatLieu, TenChatLieu)
//    VALUES (N'CLN', N'Nhua');

//IF NOT EXISTS (SELECT 1 FROM dbo.tblChatLieu WHERE MaChatLieu = N'CLG')
//    INSERT INTO dbo.tblChatLieu (MaChatLieu, TenChatLieu)
//    VALUES (N'CLG', N'Go');


///* Khách hàng */
//IF NOT EXISTS (SELECT 1 FROM dbo.tblKhach WHERE Makhach = N'KH01')
//    INSERT INTO dbo.tblKhach (Makhach, TenKhach, DiaChi, DienThoai, NgaySinh)
//    VALUES (N'KH01', N'Nguyen Van Minh', N'Ha Noi', N'0987000001', '2001-03-20');

//IF NOT EXISTS (SELECT 1 FROM dbo.tblKhach WHERE Makhach = N'KH02')
//    INSERT INTO dbo.tblKhach (Makhach, TenKhach, DiaChi, DienThoai, NgaySinh)
//    VALUES (N'KH02', N'Tran Thi Lan', N'Nam Dinh', N'098765544', '1999-08-10');


///* Hàng hóa */
//IF NOT EXISTS (SELECT 1 FROM dbo.tblHang WHERE Mahang = N'H02')
//    INSERT INTO dbo.tblHang
//        (Mahang, TenHang, MaChatLieu, SoLuong, DonGiaNhap, DonGiaBan, Anh, GhiChu)
//    VALUES
//        (N'H02', N'Hoa lan', N'CLN', 25, 90000, 130000, N'H02.jpg', NULL);

//IF NOT EXISTS (SELECT 1 FROM dbo.tblHang WHERE Mahang = N'H03')
//    INSERT INTO dbo.tblHang
//        (Mahang, TenHang, MaChatLieu, SoLuong, DonGiaNhap, DonGiaBan, Anh, GhiChu)
//    VALUES
//        (N'H03', N'Hoa ban hong', N'CLN', 15, 100000, 150000, N'H03.jpg', NULL);

//IF NOT EXISTS (SELECT 1 FROM dbo.tblHang WHERE Mahang = N'H04')
//    INSERT INTO dbo.tblHang
//        (Mahang, TenHang, MaChatLieu, SoLuong, DonGiaNhap, DonGiaBan, Anh, GhiChu)
//    VALUES
//        (N'H04', N'Hang go', N'CLG', 19, 80000, 120000, N'H04.jpg', NULL);


///* Hóa đơn mẫu */
//IF NOT EXISTS
//(
//    SELECT 1 FROM dbo.tblHDBan
//    WHERE MaHDBan = N'HĐB_061020260001'
//)
//    INSERT INTO dbo.tblHDBan (MaHDBan, MaNhanVien, NgayBan, MaKhach, TongTien)
//    VALUES (N'HĐB_061020260001', N'NV01', '2026-10-06', N'KH02', N'1374000');


///* Chi tiết hóa đơn
//   Thành tiền = số lượng * đơn giá bán * (100 - giảm giá) / 100
//*/
//IF NOT EXISTS
//(
//    SELECT 1 FROM dbo.tblChiTietHDBan
//    WHERE MaHDBan = N'HĐB_061020260001' AND MaHang = N'H02'
//)
//    INSERT INTO dbo.tblChiTietHDBan (MaHDBan, MaHang, SoLuong, GiamGia, ThanhTien)
//    VALUES (N'HĐB_061020260001', N'H02', 5, N'10', N'585000');

//IF NOT EXISTS
//(
//    SELECT 1 FROM dbo.tblChiTietHDBan
//    WHERE MaHDBan = N'HĐB_061020260001' AND MaHang = N'H03'
//)
//    INSERT INTO dbo.tblChiTietHDBan (MaHDBan, MaHang, SoLuong, GiamGia, ThanhTien)
//    VALUES (N'HĐB_061020260001', N'H03', 5, N'10', N'675000');

//IF NOT EXISTS
//(
//    SELECT 1 FROM dbo.tblChiTietHDBan
//    WHERE MaHDBan = N'HĐB_061020260001' AND MaHang = N'H04'
//)
//    INSERT INTO dbo.tblChiTietHDBan (MaHDBan, MaHang, SoLuong, GiamGia, ThanhTien)
//    VALUES (N'HĐB_061020260001', N'H04', 1, N'5', N'114000');


///* Xem thử dữ liệu hóa đơn cùng tên nhân viên, khách và mặt hàng */
//SELECT
//    hd.MaHDBan,
//    hd.NgayBan,
//    nv.Manhanvien,
//    nv.Tennhanvien,
//    kh.Makhach,
//    kh.TenKhach,
//    kh.DienThoai,
//    hang.Mahang,
//    hang.TenHang,
//    hang.DonGiaBan,
//    ct.SoLuong,
//    ct.GiamGia,
//    ct.ThanhTien,
//    hd.TongTien
//FROM dbo.tblHDBan AS hd
//LEFT JOIN dbo.tblNhanVien AS nv
//    ON hd.MaNhanVien = nv.Manhanvien
//LEFT JOIN dbo.tblKhach AS kh
//    ON hd.MaKhach = kh.Makhach
//LEFT JOIN dbo.tblChiTietHDBan AS ct
//    ON hd.MaHDBan = ct.MaHDBan
//LEFT JOIN dbo.tblHang AS hang
//    ON ct.MaHang = hang.Mahang
//WHERE hd.MaHDBan = N'HĐB_061020260001';