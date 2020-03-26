using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace B20_Ex01_Ofir_307921320_Ilan_203442306
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
        }
    }
}
