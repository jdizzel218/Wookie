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
            this.TxtWhellDiameter = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStripExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStripAboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnClear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
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
            this.TxtTurns.Location = new System.Drawing.Point(119, 112);
            this.TxtTurns.Name = "TxtTurns";
            this.TxtTurns.Size = new System.Drawing.Size(100, 20);
            this.TxtTurns.TabIndex = 2;
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
            // TxtWhellDiameter
            // 
            this.TxtWhellDiameter.Location = new System.Drawing.Point(119, 75);
            this.TxtWhellDiameter.Name = "TxtWhellDiameter";
            this.TxtWhellDiameter.Size = new System.Drawing.Size(100, 20);
            this.TxtWhellDiameter.TabIndex = 2;
            this.TxtWhellDiameter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtWhellDiameter_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuStripExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
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
            this.MnuStripExitItem.Size = new System.Drawing.Size(152, 22);
            this.MnuStripExitItem.Text = "Exit (alt + f4)";
            // 
            // MnuStripAboutItem
            // 
            this.MnuStripAboutItem.Name = "MnuStripAboutItem";
            this.MnuStripAboutItem.Size = new System.Drawing.Size(152, 22);
            this.MnuStripAboutItem.Text = "About";
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(134, 138);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 4;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.TxtWhellDiameter);
            this.Controls.Add(this.TxtTurns);
            this.Controls.Add(this.LblWheelDiameter);
            this.Controls.Add(this.LblTurns);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Lab_06";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblTurns;
        private System.Windows.Forms.TextBox TxtTurns;
        private System.Windows.Forms.Label LblWheelDiameter;
        private System.Windows.Forms.TextBox TxtWhellDiameter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuStripExit;
        private System.Windows.Forms.ToolStripMenuItem MnuStripExitItem;
        private System.Windows.Forms.ToolStripMenuItem MnuStripAboutItem;
        private System.Windows.Forms.Button BtnClear;
    }
}

