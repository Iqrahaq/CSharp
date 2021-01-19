using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPDesigns
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
            Application.Run(new Form1());

            StringBuilder sb = new StringBuilder("Hello World");

            ObjectPool<String> op = new ObjectPool<String>(4, 5, sb.ToString());

            op.CheckOut();
            op.CheckIn("Again");

        }
    }
}
