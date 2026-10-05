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

//CREATE DATABASE BanHang;
//GO

//USE BanHang;
//GO

//CREATE TABLE tblMatHang (
//    MaSP nchar(5) PRIMARY KEY,
//    TenSP nvarchar(30),
//    NgaySX Date,
//    NgayHH Date,
//    DonVi nvarchar(10),
//    DonGia Float,
//    GhiChu nvarchar(200)
//);