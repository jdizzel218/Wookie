﻿/*

Project: Virus Generator

Goals/TODO: 
1. Make a gui program that will take some user input and output a customlly made virus.
2. Viruses can be ran through Veil to further obfustecate the signature
3. Can Generate .exe, .bat files (soon will support many formats)

Logic:
1. take some user input about what kind of virus they want to generate
2. Write out those specifications to a file.
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

namespace VirusGenerator
{
    public partial class Troy : Form
    {
        
        string _outputFolder;
        string file_name;
        string fileExt;
        public Troy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string formatSelected = CBoxFor.Text;
            if (formatSelected == ".exe")
            {
                fileExt = ".exe";
            }
            else
            {
                fileExt = ".bat";
            }
            

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Troy \nVirusGenerator v1.0 \n2015");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
