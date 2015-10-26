namespace Lab_06
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
            this.LblTurns = new System.Windows.Forms.Label();
            this.TxtTurns = new System.Windows.Forms.TextBox();
            this.LblWheelDiameter = new System.Windows.Forms.Label();
            this.TxtWheelDiameter = new System.Windows.Forms.TextBox();
            this.MnuStrip = new System.Windows.Forms.MenuStrip();
            this.MnuStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStripExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStripAboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnClear = new System.Windows.Forms.Button();
            this.LblInches = new System.Windows.Forms.Label();
            this.MnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTurns
            // 
            this.LblTurns.AutoSize = true;
            this.LblTurns.Location = new System.Drawing.Point(21, 115);
            this.LblTurns.Name = "LblTurns";
            this.LblTurns.Size = new System.Drawing.Size(74, 13);
            this.LblTurns.TabIndex = 1;
            this.LblTurns.Text = "Turns per Mile";
            // 
            // TxtTurns
            // 
            this.TxtTurns.Enabled = false;
            this.TxtTurns.Location = new System.Drawing.Point(119, 112);
            this.TxtTurns.Name = "TxtTurns";
            this.TxtTurns.Size = new System.Drawing.Size(100, 20);
            this.TxtTurns.TabIndex = 2;
            this.TxtTurns.TabStop = false;
            // 
            // LblWheelDiameter
            // 
            this.LblWheelDiameter.AutoSize = true;
            this.LblWheelDiameter.Location = new System.Drawing.Point(12, 78);
            this.LblWheelDiameter.Name = "LblWheelDiameter";
            this.LblWheelDiameter.Size = new System.Drawing.Size(83, 13);
            this.LblWheelDiameter.TabIndex = 1;
            this.LblWheelDiameter.Text = "Wheel Diameter";
            // 
            // TxtWheelDiameter
            // 
            this.TxtWheelDiameter.Location = new System.Drawing.Point(119, 75);
            this.TxtWheelDiameter.Name = "TxtWheelDiameter";
            this.TxtWheelDiameter.Size = new System.Drawing.Size(100, 20);
            this.TxtWheelDiameter.TabIndex = 1;
            this.TxtWheelDiameter.TabStop = false;
            this.TxtWheelDiameter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtWheelDiameter_KeyDown);
            // 
            // MnuStrip
            // 
            this.MnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuStripExit});
            this.MnuStrip.Location = new System.Drawing.Point(0, 0);
            this.MnuStrip.Name = "MnuStrip";
            this.MnuStrip.Size = new System.Drawing.Size(284, 24);
            this.MnuStrip.TabIndex = 3;
            this.MnuStrip.Text = "menuStrip1";
            // 
            // MnuStripExit
            // 
            this.MnuStripExit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuStripExitItem,
            this.MnuStripAboutItem});
            this.MnuStripExit.Name = "MnuStripExit";
            this.MnuStripExit.Size = new System.Drawing.Size(37, 20);
            this.MnuStripExit.Text = "Exit";
            // 
            // MnuStripExitItem
            // 
            this.MnuStripExitItem.Name = "MnuStripExitItem";
            this.MnuStripExitItem.Size = new System.Drawing.Size(140, 22);
            this.MnuStripExitItem.Text = "Exit (alt + f4)";
            this.MnuStripExitItem.Click += new System.EventHandler(this.MnuStripExitItem_Click);
            // 
            // MnuStripAboutItem
            // 
            this.MnuStripAboutItem.Name = "MnuStripAboutItem";
            this.MnuStripAboutItem.Size = new System.Drawing.Size(140, 22);
            this.MnuStripAboutItem.Text = "About";
            this.MnuStripAboutItem.Click += new System.EventHandler(this.MnuStripAboutItem_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(134, 138);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.TabStop = false;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // LblInches
            // 
            this.LblInches.AutoSize = true;
            this.LblInches.Location = new System.Drawing.Point(225, 82);
            this.LblInches.Name = "LblInches";
            this.LblInches.Size = new System.Drawing.Size(18, 13);
            this.LblInches.TabIndex = 1;
            this.LblInches.Text = "in.";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.TxtWheelDiameter);
            this.Controls.Add(this.TxtTurns);
            this.Controls.Add(this.LblInches);
            this.Controls.Add(this.LblWheelDiameter);
            this.Controls.Add(this.LblTurns);
            this.Controls.Add(this.MnuStrip);
            this.MainMenuStrip = this.MnuStrip;
            this.Name = "FrmMain";
            this.Text = "Lab_07";
            this.MnuStrip.ResumeLayout(false);
            this.MnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblTurns;
        private System.Windows.Forms.TextBox TxtTurns;
        private System.Windows.Forms.Label LblWheelDiameter;
        private System.Windows.Forms.TextBox TxtWheelDiameter;
        private System.Windows.Forms.MenuStrip MnuStrip;
        private System.Windows.Forms.ToolStripMenuItem MnuStripExit;
        private System.Windows.Forms.ToolStripMenuItem MnuStripExitItem;
        private System.Windows.Forms.ToolStripMenuItem MnuStripAboutItem;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label LblInches;
    }
}

