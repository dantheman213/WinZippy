using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinZippy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length >= 3)
            {
                // expecting a command
                // e.g. app.exe --compress C:\example
                MessageBox.Show(String.Join(" ", args));
                if (args[1] == "--compress")
                {

                }
       
                ShowUi();
            }
            else if (args.Length >= 2)
            {
                // expecting a file
                // e.g. app.exe C:\example.zip
                MessageBox.Show(String.Join(" ", args));
                ShowUi();
            }
            else
            {
                // unknown command
                MessageBox.Show("Unexpected Input.");
            }
        }

        private static void ShowUi()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrameProgress());
        }
    }
}
