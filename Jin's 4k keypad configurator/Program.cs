using System;
using System.Windows.Forms;

namespace Jin_s_4k_keypad_configurator
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new keypad());
        }
    }
}
