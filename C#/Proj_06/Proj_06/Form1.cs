using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_06
{
    public partial class FrmMain : Form
    {
        const double STN_SHIP_A = 3.00;
        const double STN_SHIP_B = 1.45;
        const double EXP_SHIP_A = 4.00;
        const double EXP_SHIP_B = 2.50;
        const double SAME_SHIP_A = 5.50;
        const double SAME_SHIP_B = 3.00;

        const double STN_SHIP_SUR = 2.50;
        const double EXP_SHIP_SUR = 5.00;
        const double SAME_SHIP_SUR = 8.00;

        int NumItems;
        /// <summary>
        /// Purpose: Main Entry point of program
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Purpose: Calculates the shipping and outputs it to user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCalc_Click(object sender, EventArgs e)
        {
            Shipping ship = new Shipping();
            string shipMethod = CBoxShipMethod.Text;
            string category = CBoxCategory.Text;
            
            if(int.TryParse(TxtNumItems.Text, out NumItems))
            {
                ship.NumItems = NumItems;

                switch (shipMethod)
                {
                    case "Standard":
                        if (category == "A")
                        {
                            ship.Category = STN_SHIP_A;
                            string total = ship.CalcShipping().ToString();

                            MessageBox.Show(total, "Total");
                        }
                        else
                        {
                            ship.Category = STN_SHIP_B;
                            
                        }
                        break;

                    case "Express":

                        if (category == "A")
                        {
                            ship.Category = EXP_SHIP_A;
                        }
                        else
                        {
                            ship.Category = EXP_SHIP_B;
                        }
                        break;

                    case "Same-Day":
                        if (category == "A")
                        {
                            ship.Category = SAME_SHIP_A;
                        }
                        else
                        {
                            ship.Category = SAME_SHIP_B;
                        }
                        break;

                        
                }
            }
           
            
            
        }
    }
}
