﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RblDownload
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length > 0)
            {
                Form1 mainForm = new Form1();
                mainForm.LoadFilePath = args[0];
                Application.Run(mainForm);
            }
            else
            {
                Application.Run(new Form1());
            }
        }
    }
}
