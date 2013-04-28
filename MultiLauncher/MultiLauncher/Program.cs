using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace MultiLauncher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
#if !DEBUG
            if (args.Length < 1 || !args[0].Equals("updated"))
            {
                Process p = new Process();
                p.StartInfo = new ProcessStartInfo("MultiLauncher Patcher.exe");
                p.Start();
                return;
            }
#endif
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLauncher());
        }
    }
}
