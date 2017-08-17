using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2017_FinalExam_300934575
{
    /*
 * Name: Jaydeep Lakhwani
 * Date: 17th August, 2017
 * StudentID: 300934575
 * Description: This is the SplashForm class.
 * Version - 0.1 : Splash Form created.
 */
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// This is the event handler for the tick event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            PickHighestCardForm pickHighestCardForm = new PickHighestCardForm();
            pickHighestCardForm.Show();
            this.Hide();
            SplashFormTimer.Enabled = false; //turn timer off
        }
    }
}
