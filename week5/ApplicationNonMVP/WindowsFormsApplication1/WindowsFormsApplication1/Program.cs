using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new KeyGenerator());
            KeyGenerator f1 = new KeyGenerator();
            KeyGenPresenter kgp = new KeyGenPresenter(f1);
            Application.Run(f1);
        }
    }
}
