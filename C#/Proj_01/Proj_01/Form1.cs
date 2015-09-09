///Pseudo-Code
/// 1. Take input of 2 floating point numbers from the user.
/// 2. Do some math on those numbers (+, -, /, *)
/// 3. Output the resultant number to a textbox.
/// 4. Have a button that will clear all three textboxes
/// 5. Have an exit button. - resolved.






using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_01
{
    public partial class FrmMain : Form
    {
        // init variables
        static double _rightOp;
        static double _leftOp;
        static double _result;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e) //This closes the program
        {
            Close();
        }


        private void BtnPlus_Click(object sender, EventArgs e) //This purpose is to add the leftOp and the rightOp together.
        {
            
            _result = _rightOp + _leftOp;
            _result.ToString();
        }


        private void BtnMinus_Click(object sender, EventArgs e) //this is suppose to minue the leftOp and rightOp and return a string for _result.
        {
            _result = _rightOp - _leftOp;
            _result.ToString();
        }


        private void TxtBoxLeftOpt_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
            {

                _leftOp = Convert.ToDouble(TxtBoxLeftOpt.Text);
            }
        }

        private void TxtBoxRightOp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _rightOp = Convert.ToDouble(TxtBoxRightOp.Text);
            }
        }

        private void TxtBoxResult_Click(object sender, EventArgs e)
        {
            TxtBoxResult.Text = Convert.ToString(_result);
        }
    }
}
