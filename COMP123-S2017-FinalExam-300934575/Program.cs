using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Jaydeep Lakhwani
 * Date: 17th August, 2017
 * StudentID: 300934575
 * Description: This is the driver class for pickHighestCard class.
 * Version 0.1 : It runs the SplashForm.
 */

namespace COMP123_S2017_FinalExam_300934575
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
        }
    }
}
