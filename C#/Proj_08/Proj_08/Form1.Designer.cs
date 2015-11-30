namespace Proj_08
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblDiceRoll = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.MnuDiceGame = new System.Windows.Forms.MenuStrip();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuInstruc = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnRoll = new System.Windows.Forms.Button();
            this.PBoxRightDie = new System.Windows.Forms.PictureBox();
            this.PBoxLeftDie = new System.Windows.Forms.PictureBox();
            this.MnuDiceGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxRightDie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLeftDie)).BeginInit();
            this.SuspendLayout();
            // 
            // LblDiceRoll
            // 
            this.LblDiceRoll.AutoSize = true;
            this.LblDiceRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDiceRoll.Location = new System.Drawing.Point(105, 153);
            this.LblDiceRoll.Name = "LblDiceRoll";
            this.LblDiceRoll.Size = new System.Drawing.Size(0, 13);
            this.LblDiceRoll.TabIndex = 1;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(96, 212);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // MnuDiceGame
            // 
            this.MnuDiceGame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuExit,
            this.MnuInstruc});
            this.MnuDiceGame.Location = new System.Drawing.Point(0, 0);
            this.MnuDiceGame.Name = "MnuDiceGame";
            this.MnuDiceGame.Size = new System.Drawing.Size(284, 24);
            this.MnuDiceGame.TabIndex = 3;
            this.MnuDiceGame.Text = "MnuDiceGame";
            // 
            // MnuExit
            // 
            this.MnuExit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuExitItem,
            this.MnuAboutItem});
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(37, 20);
            this.MnuExit.Text = "Exit";
            // 
            // MnuExitItem
            // 
            this.MnuExitItem.Name = "MnuExitItem";
            this.MnuExitItem.Size = new System.Drawing.Size(107, 22);
            this.MnuExitItem.Text = "Exit";
            this.MnuExitItem.Click += new System.EventHandler(this.MnuExitItem_Click);
            // 
            // MnuAboutItem
            // 
            this.MnuAboutItem.Name = "MnuAboutItem";
            this.MnuAboutItem.Size = new System.Drawing.Size(152, 22);
            this.MnuAboutItem.Text = "About";
            this.MnuAboutItem.Click += new System.EventHandler(this.MnuAboutItem_Click);
            // 
            // MnuInstruc
            // 
            this.MnuInstruc.Name = "MnuInstruc";
            this.MnuInstruc.Size = new System.Drawing.Size(81, 20);
            this.MnuInstruc.Text = "Instructions";
            this.MnuInstruc.Click += new System.EventHandler(this.MnuInstruc_Click);
            // 
            // BtnRoll
            // 
            this.BtnRoll.Location = new System.Drawing.Point(96, 183);
            this.BtnRoll.Name = "BtnRoll";
            this.BtnRoll.Size = new System.Drawing.Size(75, 23);
            this.BtnRoll.TabIndex = 2;
            this.BtnRoll.Text = "Roll \'Em";
            this.BtnRoll.UseVisualStyleBackColor = true;
            this.BtnRoll.Click += new System.EventHandler(this.BtnRoll_Click);
            // 
            // PBoxRightDie
            // 
            this.PBoxRightDie.Image = global::Proj_08.Properties.Resources.blank;
            this.PBoxRightDie.Location = new System.Drawing.Point(148, 47);
            this.PBoxRightDie.Name = "PBoxRightDie";
            this.PBoxRightDie.Size = new System.Drawing.Size(87, 82);
            this.PBoxRightDie.TabIndex = 0;
            this.PBoxRightDie.TabStop = false;
            // 
            // PBoxLeftDie
            // 
            this.PBoxLeftDie.Image = global::Proj_08.Properties.Resources.blank;
            this.PBoxLeftDie.Location = new System.Drawing.Point(32, 47);
            this.PBoxLeftDie.Name = "PBoxLeftDie";
            this.PBoxLeftDie.Size = new System.Drawing.Size(87, 82);
            this.PBoxLeftDie.TabIndex = 0;
            this.PBoxLeftDie.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnRoll);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LblDiceRoll);
            this.Controls.Add(this.PBoxRightDie);
            this.Controls.Add(this.PBoxLeftDie);
            this.Controls.Add(this.MnuDiceGame);
            this.MainMenuStrip = this.MnuDiceGame;
            this.Name = "FrmMain";
            this.Text = "Dice Game";
            this.MnuDiceGame.ResumeLayout(false);
            this.MnuDiceGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxRightDie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxLeftDie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBoxLeftDie;
        private System.Windows.Forms.Label LblDiceRoll;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.MenuStrip MnuDiceGame;
        private System.Windows.Forms.Button BtnRoll;
        private System.Windows.Forms.PictureBox PBoxRightDie;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.ToolStripMenuItem MnuExitItem;
        private System.Windows.Forms.ToolStripMenuItem MnuAboutItem;
        private System.Windows.Forms.ToolStripMenuItem MnuInstruc;
    }
}

