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
        private double _leftop  = 0.0;
        private double _rightop = 0.0;
        private double _result  = 0.0;
        
        public FrmMain() //constructor
        {
            InitializeComponent();
        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBoxLeftOp_TextChanged(object sender, EventArgs e)
        {

            _leftop = Convert.ToDouble(TxtBoxLeftOp.Text);
            _leftop = int.Parse(TxtBoxLeftOp.Text);
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
             _result = _leftop + _rightop;
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            _result = _leftop - _rightop;
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            _result = _leftop * _rightop;
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            _result = _leftop / _rightop;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            _leftop  = 0.0;
            _rightop = 0.0;
            _result  = 0.0;
        }

        private void TxtBoxResult_TextChanged(object sender, EventArgs e)
        {
            this.Text = Convert.ToString(_result);
        }

        private void TxtBoxRightOp_TextChanged(object sender, EventArgs e)
        {
            
            _rightop = Convert.ToDouble(TxtBoxRightOp.Text);
            _rightop = int.Parse(TxtBoxRightOp.Text);
            
        }

        
    }
}
