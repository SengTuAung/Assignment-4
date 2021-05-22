using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KrustyKrabLog
{
    static class Program
    {
        /// <summary>
        /////4-27-2021 Saung NEW 5L :  Constructor The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
