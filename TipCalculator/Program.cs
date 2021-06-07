using System;
using System.Windows.Forms;

namespace TipCalculator
{
    // The class containing Main() functions that runs first when the code is executed.
    // START
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// A TIP CALCULATION APPLICATION.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Calls an instance of class Form.
            Application.Run(new Form1());
        }
    } // END
}

