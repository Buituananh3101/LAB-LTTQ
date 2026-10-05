using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_LTTQ.classes
{
    internal class DataProcessing
    {
        //----------------------------------------------------------------------------------------------------
        string strConnect = "Data Source=localhost\\SQLEXPRESS; Database=BanHang; Integrated Security=true"; // Khai báo server name, database name, user name, password
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















// Data test code


//INSERT INTO tblMatHang(MaSP, TenSP, NgaySX, NgayHH, DonVi, DonGia, GhiChu) 
//VALUES
//('SP001', N'Bánh quy bơ', '2025-01-10', '2026-01-10', N'Hộp', 45000, N'Hàng nhập khẩu'),
//('SP002', N'Bánh gạo ngọt', '2025-02-15', '2025-08-15', N'Gói', 32000, N''),
//('SP003', N'Bánh xốp phô mai', '2025-03-01', '2025-09-01', N'Hộp', 25000, N'Bán chạy'),
//('SP004', N'Bánh mì sandwich', '2026-10-01', '2026-10-08', N'Bịch', 18000, N'Giao mới mỗi ngày'),
//('SP005', N'Bánh bông lan', '2026-09-25', '2026-10-25', N'Cái', 12000, N''),
//('SP006', N'Kẹo dẻo trái cây', '2025-05-12', '2026-05-12', N'Gói', 15000, N'Khuyến mãi mua 2 tặng 1'),
//('SP007', N'Kẹo sô cô la', '2025-11-20', '2026-11-20', N'Hộp', 65000, N'Tránh để nơi nắng nóng'),
//('SP008', N'Kẹo cao su bạc hà', '2026-01-05', '2027-01-05', N'Hũ', 22000, N''),
//('SP009', N'Kẹo mút dâu tây', '2026-02-14', '2027-02-14', N'Cây', 2000, N''),
//('SP010', N'Snack khoai tây', '2026-04-10', '2026-10-10', N'Gói', 11000, N'Vị rong biển'),
//('SP011', N'Nước tinh khiết', '2026-01-01', '2027-01-01', N'Chai', 5000, N'500ml'),
//('SP012', N'Nước khoáng có ga', '2026-03-15', '2027-03-15', N'Chai', 7000, N''),
//('SP013', N'Nước ngọt Coca Cola', '2026-05-20', '2027-05-20', N'Lon', 10000, N'Ướp lạnh'),
//('SP014', N'Nước ngọt Pepsi', '2026-05-22', '2027-05-22', N'Lon', 10000, N'Ướp lạnh'),
//('SP015', N'Nước ngọt 7Up', '2026-06-01', '2027-06-01', N'Lon', 10000, N'Ướp lạnh'),
//('SP016', N'Nước tăng lực Redbull', '2026-07-10', '2027-07-10', N'Lon', 12000, N''),
//('SP017', N'Nước tăng lực Sting', '2026-08-15', '2027-02-15', N'Chai', 10000, N'Hương dâu tây'),
//('SP018', N'Trà xanh không độ', '2026-09-05', '2027-09-05', N'Chai', 9000, N''),
//('SP019', N'Trà ô long', '2026-09-12', '2027-09-12', N'Chai', 11000, N''),
//('SP020', N'Cà phê đen đá', '2026-10-01', '2027-10-01', N'Lon', 14000, N''),
//('SP021', N'Sữa đặc có đường', '2026-01-20', '2027-01-20', N'Lon', 21000, N'Nguyên kem'),
//('SP022', N'Sữa tươi tiệt trùng', '2026-08-01', '2027-02-01', N'Hộp', 7000, N'Ít đường'),
//('SP023', N'Sữa chua nha đam', '2026-09-20', '2026-11-20', N'Lốc', 28000, N'Cần bảo quản lạnh'),
//('SP024', N'Sữa đậu nành', '2026-08-10', '2027-02-10', N'Hộp', 5000, N''),
//('SP025', N'Phô mai bò cười', '2026-05-01', '2026-11-01', N'Hộp', 35000, N''),
//('SP026', N'Bơ thực vật', '2026-06-15', '2027-06-15', N'Hũ', 20000, N''),
//('SP027', N'Dầu ăn đậu nành', '2026-01-10', '2028-01-10', N'Chai', 45000, N'1 lít'),
//('SP028', N'Nước mắm cốt', '2025-10-10', '2027-10-10', N'Chai', 55000, N'40 độ đạm'),
//('SP029', N'Nước tương', '2026-02-28', '2027-02-28', N'Chai', 18000, N''),
//('SP030', N'Tương ớt chua cay', '2026-04-15', '2027-04-15', N'Chai', 15000, N''),
//('SP031', N'Tương cà', '2026-05-20', '2027-05-20', N'Chai', 16000, N''),
//('SP032', N'Đường cát trắng', '2026-01-01', '2028-01-01', N'Gói', 22000, N'1 kg'),
//('SP033', N'Muối I-ốt', '2025-12-01', '2028-12-01', N'Gói', 6000, N'500g'),
//('SP034', N'Bột ngọt', '2026-03-10', '2029-03-10', N'Gói', 32000, N''),
//('SP035', N'Hạt nêm thịt thăn', '2026-06-15', '2028-06-15', N'Gói', 38000, N''),
//('SP036', N'Hạt tiêu xay', '2026-07-20', '2028-07-20', N'Lọ', 25000, N''),
//('SP037', N'Giấm gạo', '2026-02-10', '2027-02-10', N'Chai', 12000, N''),
//('SP038', N'Mì tôm chua cay', '2026-08-01', '2027-02-01', N'Gói', 4000, N'Thùng 30 gói giá ưu đãi'),
//('SP039', N'Phở bò gói', '2026-08-15', '2027-02-15', N'Gói', 6500, N''),
//('SP040', N'Hủ tiếu Nam Vang', '2026-09-01', '2027-03-01', N'Gói', 7000, N''),
//('SP041', N'Cháo thịt bằm', '2026-09-10', '2027-03-10', N'Gói', 5000, N''),
//('SP042', N'Gạo tẻ thơm', '2026-10-01', '2027-04-01', N'Bao', 180000, N'Bao 10kg'),
//('SP043', N'Gạo nếp cái hoa vàng', '2026-09-15', '2027-03-15', N'Gói', 35000, N'Gói 1kg'),
//('SP044', N'Miến dong', '2026-05-10', '2027-05-10', N'Gói', 42000, N''),
//('SP045', N'Bún khô', '2026-06-20', '2027-06-20', N'Gói', 25000, N''),
//('SP046', N'Xúc xích heo', '2026-08-05', '2026-11-05', N'Gói', 35000, N'Gói 4 cây'),
//('SP047', N'Xúc xích bò', '2026-08-12', '2026-11-12', N'Gói', 40000, N'Gói 4 cây'),
//('SP048', N'Lạp xưởng Mai Quế Lộ', '2026-01-15', '2027-01-15', N'Gói', 95000, N'Đặc sản'),
//('SP049', N'Cá mòi hộp', '2025-10-20', '2028-10-20', N'Hộp', 18000, N'Sốt cà chua'),
//('SP050', N'Thịt heo hầm', '2026-02-25', '2029-02-25', N'Hộp', 35000, N'');