﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using XLuSharpLibrary.DbAccess;

namespace BHair
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //DbConfig.DbConnection = @"Data Source=localhost;Initial Catalog=BHairDB;User ID=sa;Password=sa123";
            //DbConfig.DbType = DBType.SQLServer;
            Application.Run(new frmMain());
        }
    }
}
