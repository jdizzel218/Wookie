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
        double _rightOp;
        double _leftOp;
        double _result;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBoxResult_TextChanged(object sender, EventArgs e)
        {
            
            //this.Text = _result;
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            
            _result = _rightOp + _leftOp;
        }

        private void TxtBoxLeftOpt_TextChanged(object sender, EventArgs e)
        {
            double _result = Convert.ToDouble(TextBox.Text);
        }
    }
}
