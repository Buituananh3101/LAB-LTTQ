using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_LTTQ.Classes
{
    internal class DataProcessing
    {
        //----------------------------------------------------------------------------------------------------
        string strConnect = "Data Source=localhost\\SQLEXPRESS; Database=QuanLyBanHang; Integrated Security=true"; // Khai báo server name, database name, user name, password
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
            DataTable tblNhanVien = new DataTable();
            dataAdapter.Fill(tblNhanVien);                                             // Đổ dữ liệu 

            closeConnect();

            return tblNhanVien;
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
