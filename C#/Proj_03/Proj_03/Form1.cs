/*

File/Project Prolog
Name: Matthew Cranford
CS 1400 Section 001
Project: Project 03, Good Guy Delivery
Date: 10/7/2015 2:25 PM

I declare that the following code was written by me or provided 
by the instructor for this project. I understand that copying source
code from any other source constitutes cheating, and that I will receive
a zero on this project if I am found in violation of this policy.
--------------------------------------------------------------------------


Pseudo-Code:
1. Get a departure time and arrival time in a 24 hour format and store them in an int variable.
2. Convert the depart time and arrival time to total mins by dividing the number by 100 multiplying it by 60 and adding that to the the remainder (i.e. totMin = ((departTime / 100 ) * 60) + (departTime % 100)
3. Find the total travel time in minutes by arrivalTime - departTime
4. Find the ext travel time by taking total travel time and multiplying it by .25 (they expect it to be delayed by 25%)
5. Find the extended travel time from departing to arrival by taking the departTimeMin + total travel time.
6. Output those numbers in a 24 hour format i.e HH:MM.
7. Keep the user from inputing errors, like strings, or negative numbers, etc.

*/




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_03
{
    public partial class FrmMain : Form
    {
        //Constants, intial variables.
        const int HUN_PART = 100; //To help find the total minutes in a 24 format number.
        const int MINS_IN_HOUR = 60;
        const double LONGER_DELIV_TIME = .25;
        const int HOURS_IN_DAY = 2400;

        int departTime;
        int arrivalTime;
        int departTotalMin;
        int arrivalTotalMin;
        int travelTimeMin;
        int travelTime;
        int extTravelTime;

        /// <summary>
        /// Purpose: The main entry point into the program.
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Purpose: Clears all the textboxes when clicked, and resets all variables.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtArrivalTime.Text = ""; //Clear all the textboxes.
            TxtDepartureTime.Text = "";
            TxtExtArrivalTime.Text = "";
            TxtTravelTime.Text = "";

            departTime      = 0; //Resets all variables.
            arrivalTime     = 0;
            departTotalMin  = 0;
            arrivalTotalMin = 0;
            travelTimeMin   = 0;
            travelTime      = 0;
            extTravelTime   = 0;



        }
        /// <summary>
        /// Purpose: Does all the math and displays it out to a textbox when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicDeliveryBox_Click(object sender, EventArgs e)
        {
            //Where the magic happens

            if (int.TryParse(TxtDepartureTime.Text, out departTime))
                if (int.TryParse(TxtArrivalTime.Text, out arrivalTime)) //checks to see if the input the user gave is valid and can be parsed into a int.
                {
                    if(departTime <= HOURS_IN_DAY) //This makes sure that user doesn't put in a time greater than 2400 (there are only 2400 hours in a day)
                        if(arrivalTime <= HOURS_IN_DAY)
                            if (arrivalTime >= departTime) //this ensure that the user can't put in an arrival time earlier then when the depart (impossible unless they learn to time travel)
                            {
                                arrivalTime = Math.Abs(arrivalTime); //This will make sure that even if the user inputs a negative number it will stay positive.
                                departTime = Math.Abs(departTime);

                                MessageBox.Show("If you input a negative number, it will automatically be converted to a postive for you. You're welcome.", "Notice");

                                departTotalMin = ((departTime / HUN_PART) * MINS_IN_HOUR) + (departTime % HUN_PART); //Calculates the total mins from the Depart time textbox
                                arrivalTotalMin = ((arrivalTime / HUN_PART) * MINS_IN_HOUR) + (arrivalTime % HUN_PART); //Calculates the total mins from the Arrival time textbox

                                travelTimeMin = arrivalTotalMin - departTotalMin; //Finds the total travel time in minutes.

                                travelTime = ((int)(travelTimeMin * LONGER_DELIV_TIME)) + travelTimeMin; //Find the extended travel time in minutes (multiplies it by the expected 25% longer travel time.)

                                extTravelTime = departTotalMin + travelTime; //Calculates the extended travel time from departure to arrival in mins.


                                TxtTravelTime.Text = $"{travelTime / MINS_IN_HOUR:D2}:{travelTime % MINS_IN_HOUR:D2}"; //Displays the expected travel time in mins.
                                TxtExtArrivalTime.Text = $"{extTravelTime / MINS_IN_HOUR:D2}:{extTravelTime % MINS_IN_HOUR:D2}"; //Displays expected (delayed) travel time in mins
                            }
                            else
                            {
                                MessageBox.Show("Unless you have learned to time travel, it's impossible for you to arrive before you departed. Please enter a valid arrival time.", "Notice");
                            }
                            
                        
                        else
                        {
                            MessageBox.Show("There are only 24:00 hours in a day. Please type a time less than 2400", "Notice");
                        }
                    else
                    {
                        MessageBox.Show("There are only 24:00 hours in a day. Please type a time less than 2400", "Notice");
                    }
                }

          else
            MessageBox.Show("Please Enter a valid time in 24 hour format: HHMM with no decimals.", "Notice");
            

        }

        /// <summary>
        /// Purpose: Closes the application when clicked.
        /// </summary>
        /// <param name="sender">Not Used</param>
        /// <param name="e">Not Used</param>
        private void MnuStripExitItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Purpose: Display an about box when clicked.
        /// </summary>
        /// <param name="sender">Not Used</param>
        /// <param name="e">Not Used</param>
        private void MnuStripAboutItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matthew Cranford \nCS1400 Section 1 \nProject 3");
        }

        /// <summary>
        /// Purpose: Closes the application when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Purpose: Allows the user to press enter or tab and get directly to the next textbox.
        /// </summary>
        /// <param name="sender">Not used.</param>
        /// <param name="e">the Enter Key.</param>
        private void TxtDepartureTime_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TxtArrivalTime.Focus();
            }

            if (e.KeyCode.Equals(Keys.Tab))
            {
                TxtArrivalTime.Focus();
            }
        }

        /// <summary>
        /// Purpose: If the user presses enter or tab in this textbox, its the same as if the user clicked the picture to calculate the time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtArrivalTime_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                PicDeliveryBox_Click(sender, e);
            }

            if (e.KeyCode.Equals(Keys.Tab))
            {
                PicDeliveryBox_Click(sender, e);
            }
        }

        /// <summary>
        /// Purpose: Instructs the User on how to use the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuStripInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter a departure time in a millitary time format: HH:MM.\nDo the same for the arrival time.\nPress Enter or click the picture.\nWatch the magic happen. \nNote: if you input a negative number it will be converted to a positive for you.", "Instructions");
        }
    }
}
