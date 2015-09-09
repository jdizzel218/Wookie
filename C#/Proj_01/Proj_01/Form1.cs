



///Pseudo-Code
/// 1. Take input of 2 (floating point) numbers from the user. -resolved.
/// 2. Do some math on those numbers (+, -, /, *) - resolved.
/// 3. Output the resultant number to a textbox. -resolved
/// 4. Have a button that will clear all three textboxes - resolved.
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
    /// <summary>
    /// Purpose: Entry point into program.
    /// </summary>
    public partial class FrmMain : Form
    {
        // init variables
        private double _rightOp;
        private double _leftOp;
        private double _result;

        /// <summary>
        /// Purpose: To initialize the main form.
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        }

        //The Clear and Exit buttons//
        /// <summary>
        /// Purpose: To exit out of the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e) //This closes the program
        {
            Close();
        }
        /// <summary>
        /// Purpose: to clear the textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            //Clears the screen.
            TxtBoxLeftOpt.Text = "0.0";
            TxtBoxRightOp.Text = "0.0";
            TxtBoxResult.Text = "0.0";

            //Resets the operand values.
            _leftOp = 0;
            _rightOp = 0;
            _result = 0;
        }

        //End Clear and Exit buttons//

        //Operator buttons Start//
        /// <summary>
        /// Purpose: To add the left and right operands.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPlus_Click(object sender, EventArgs e) //This purpose is to add the leftOp and the rightOp together.
        {
            _leftOp = Convert.ToDouble(TxtBoxLeftOpt.Text);
            _rightOp = Convert.ToDouble(TxtBoxRightOp.Text);
            _result = _leftOp + _rightOp;
            TxtBoxResult.Text = (_result).ToString();
          
        }
        /// <summary>
        /// Purspose: To minus the left and right operands.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BtnMinus_Click(object sender, EventArgs e) //this is suppose to minue the leftOp and rightOp and return a string for _result.
        {
            _leftOp = Convert.ToDouble(TxtBoxLeftOpt.Text);
            _rightOp = Convert.ToDouble(TxtBoxRightOp.Text);
            _result = _leftOp - _rightOp;
            TxtBoxResult.Text = (_result).ToString();
        }
        /// <summary>
        /// Purpose: To multiply the left and right operands.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMul_Click(object sender, EventArgs e)
        {
            _leftOp = Convert.ToDouble(TxtBoxLeftOpt.Text);
            _rightOp = Convert.ToDouble(TxtBoxRightOp.Text);
            _result = _leftOp * _rightOp;
            TxtBoxResult.Text = (_result).ToString();
        }
        /// <summary>
        /// Purpose: To take the left operand and right operand and divide them.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDiv_Click(object sender, EventArgs e)
        {
            _leftOp = Convert.ToDouble(TxtBoxLeftOpt.Text);
            _rightOp = Convert.ToDouble(TxtBoxRightOp.Text);
            _result = _leftOp / _rightOp;
            TxtBoxResult.Text = (_result).ToString();
        }
        //Operator buttons End//

    }// End Main
} //End namespace Proj_01 
