using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_LTTQ.Classes
{
    internal class DataProcessing
    {
        //----------------------------------------------------------------------------------------------------
        string strConnect = "Data Source=localhost\\SQLEXPRESS; Database=QuanLyBanHangDoLuuNiem; Integrated Security=true"; // Khai báo server name, database name, user name, password
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

    //https://lmsutceduvn-my.sharepoint.com/:v:/g/personal/huongnt_utc_edu_vn/EY1RhuzUaU9FiZZyNqrQOZIB_xEjFcr3jqFNlfyZGHNUQA // Video 1
    //https://lmsutceduvn-my.sharepoint.com/:v:/g/personal/huongnt_utc_edu_vn/EXLk7Z9rmQBOjewy4RYD68kBWik7LOLb4pDF0oFME_rjSQ // Video 2
    //https://lmsutceduvn-my.sharepoint.com/:v:/g/personal/huongnt_utc_edu_vn/ERQ4ELl9QcxKjHMb2BRvRTABg6vHk9wZcqYtSpkvFJXqSg // Video 3
    //https://lmsutceduvn-my.sharepoint.com/:v:/g/personal/huongnt_utc_edu_vn/EYlZUwuzGVdChRz9WFTGV8IBYr2dCWkursv5_-H7YrNlkw // Video 4