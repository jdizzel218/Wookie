// Project Prolog
// Name: Matthew L. Cranford
// CS 1400 Section 001
// Date: 9/1/2015 2:13 PM
//
// I declare that the following code was written by me or provided
// by the instructure for this project. I understand that copying source
// code from any other source consitutes cheating and that I will recieve
// a zero on this project if I am found in violation of this policy.





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_02
{
    public partial class FrmMain : Form
    {
        /// <summary>
        /// Purpose: FrmMain() default Constructor method
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }//End Class FrmMain
}//End namespace Lab_02
