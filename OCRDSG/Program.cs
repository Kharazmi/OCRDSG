using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OCRDSG
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
            Application.Run(new FormParent());
        }

        public static string title = "OCR Dataset Generator";
        public static string version = "0.3 alpha 2";
        public static string[] steps = { "Welcome", "Basic", "Font", "Paper", "Layout", "Noise", "Output", "Finish" };
        public static OCRDataset dataset;

        public static object activeWorkersLock = new object();
        public static int activeWorkersCount;
    }
}
