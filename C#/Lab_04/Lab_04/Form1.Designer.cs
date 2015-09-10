namespace Lab_04
{
    partial class FrmMenuStrip1
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
            this.MnuMain = new System.Windows.Forms.MenuStrip();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStripAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnExit = new System.Windows.Forms.Button();
            this.MnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuMain
            // 
            this.MnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuExit});
            this.MnuMain.Location = new System.Drawing.Point(0, 0);
            this.MnuMain.Name = "MnuMain";
            this.MnuMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MnuMain.Size = new System.Drawing.Size(331, 24);
            this.MnuMain.TabIndex = 0;
            this.MnuMain.Text = "Main Menu";
            // 
            // MnuExit
            // 
            this.MnuExit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuStripAbout,
            this.MnuStripExit});
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(37, 20);
            this.MnuExit.Text = "Exit";
            // 
            // MnuStripAbout
            // 
            this.MnuStripAbout.Name = "MnuStripAbout";
            this.MnuStripAbout.Size = new System.Drawing.Size(152, 22);
            this.MnuStripAbout.Text = "About";
            this.MnuStripAbout.Click += new System.EventHandler(this.MnuStripAbout_Click);
            // 
            // MnuStripExit
            // 
            this.MnuStripExit.Name = "MnuStripExit";
            this.MnuStripExit.Size = new System.Drawing.Size(152, 22);
            this.MnuStripExit.Text = "Exit";
            this.MnuStripExit.Click += new System.EventHandler(this.MnuStripExit_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(132, 226);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(87, 23);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmMenuStrip1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 261);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.MnuMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MnuMain;
            this.Name = "FrmMenuStrip1";
            this.Text = "CS1400 Lab #4";
            this.MnuMain.ResumeLayout(false);
            this.MnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuMain;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.ToolStripMenuItem MnuStripAbout;
        private System.Windows.Forms.ToolStripMenuItem MnuStripExit;
        private System.Windows.Forms.Button BtnExit;
    }
}

