using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace App
{




    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var p = new Process();
            p.StartInfo.FileName = "C:\\Users\\L\\source\\repos\\Project6\\x64\\Release\\Project6.exe";
           
            p.Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            p.CloseMainWindow();
        }
    }
}
