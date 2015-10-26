using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_12
{
    public partial class FrmTokenMachine : Form
    {
        public FrmTokenMachine()
        {
            InitializeComponent();
        }

        private void FrmTokenMachine_Load(object sender, EventArgs e)
        {

        }


      
    }//End class FrmTokenMachine


    class TokenMachine
    {
        private int _tokens;
        public int Tokens
        {
            set
            {
                if (value >= 0)
                    _tokens = value;
                else
                    _tokens = 0;
            }
            get
            {
                if (_tokens <= 0)
                    return _tokens;
                else
                    return _tokens;
            }
        }
    }
}// End namespace lab_12
