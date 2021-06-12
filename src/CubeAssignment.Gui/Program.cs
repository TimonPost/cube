using System;
using System.Windows.Forms;

namespace CubeAssignment.Gui
{
    internal static class Program
    {
        public const float THETA_STEP_SIZE = 0.030f;
        public const float PHI_STEP_SIZE = 0.00000001f;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}