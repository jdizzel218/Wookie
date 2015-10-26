namespace Lab_11
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
            this.TxtSideOne = new System.Windows.Forms.TextBox();
            this.LblSideOne = new System.Windows.Forms.Label();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.TxtHypotenuse = new System.Windows.Forms.TextBox();
            this.LblHypotenuse = new System.Windows.Forms.Label();
            this.TxtSideTwo = new System.Windows.Forms.TextBox();
            this.LblSideTwo = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.MnuStrip = new System.Windows.Forms.MenuStrip();
            this.MnuStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStripExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStripAboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtSideOne
            // 
            this.TxtSideOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSideOne.Location = new System.Drawing.Point(53, 36);
            this.TxtSideOne.Name = "TxtSideOne";
            this.TxtSideOne.Size = new System.Drawing.Size(100, 20);
            this.TxtSideOne.TabIndex = 0;
            this.TxtSideOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblSideOne
            // 
            this.LblSideOne.AutoSize = true;
            this.LblSideOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSideOne.Location = new System.Drawing.Point(12, 36);
            this.LblSideOne.Name = "LblSideOne";
            this.LblSideOne.Size = new System.Drawing.Size(18, 13);
            this.LblSideOne.TabIndex = 1;
            this.LblSideOne.Text = "a:";
            // 
            // BtnCalc
            // 
            this.BtnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalc.Location = new System.Drawing.Point(67, 114);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(75, 23);
            this.BtnCalc.TabIndex = 2;
            this.BtnCalc.Text = "Calculate";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // TxtHypotenuse
            // 
            this.TxtHypotenuse.Enabled = false;
            this.TxtHypotenuse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHypotenuse.Location = new System.Drawing.Point(53, 88);
            this.TxtHypotenuse.Name = "TxtHypotenuse";
            this.TxtHypotenuse.Size = new System.Drawing.Size(100, 20);
            this.TxtHypotenuse.TabIndex = 0;
            this.TxtHypotenuse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblHypotenuse
            // 
            this.LblHypotenuse.AutoSize = true;
            this.LblHypotenuse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHypotenuse.Location = new System.Drawing.Point(12, 88);
            this.LblHypotenuse.Name = "LblHypotenuse";
            this.LblHypotenuse.Size = new System.Drawing.Size(18, 13);
            this.LblHypotenuse.TabIndex = 1;
            this.LblHypotenuse.Text = "c:";
            // 
            // TxtSideTwo
            // 
            this.TxtSideTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSideTwo.Location = new System.Drawing.Point(53, 62);
            this.TxtSideTwo.Name = "TxtSideTwo";
            this.TxtSideTwo.Size = new System.Drawing.Size(100, 20);
            this.TxtSideTwo.TabIndex = 0;
            this.TxtSideTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblSideTwo
            // 
            this.LblSideTwo.AutoSize = true;
            this.LblSideTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSideTwo.Location = new System.Drawing.Point(12, 62);
            this.LblSideTwo.Name = "LblSideTwo";
            this.LblSideTwo.Size = new System.Drawing.Size(18, 13);
            this.LblSideTwo.TabIndex = 1;
            this.LblSideTwo.Text = "b:";
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(67, 156);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
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
            this.MnuStripExitItem.Size = new System.Drawing.Size(152, 22);
            this.MnuStripExitItem.Text = "Exit";
            this.MnuStripExitItem.Click += new System.EventHandler(this.MnuStripExitItem_Click);
            // 
            // MnuStripAboutItem
            // 
            this.MnuStripAboutItem.Name = "MnuStripAboutItem";
            this.MnuStripAboutItem.Size = new System.Drawing.Size(152, 22);
            this.MnuStripAboutItem.Text = "About";
            this.MnuStripAboutItem.Click += new System.EventHandler(this.MnuStripAboutItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.LblSideTwo);
            this.Controls.Add(this.LblHypotenuse);
            this.Controls.Add(this.LblSideOne);
            this.Controls.Add(this.TxtSideTwo);
            this.Controls.Add(this.TxtHypotenuse);
            this.Controls.Add(this.TxtSideOne);
            this.Controls.Add(this.MnuStrip);
            this.MainMenuStrip = this.MnuStrip;
            this.Name = "FrmMain";
            this.Text = "Lab_11";
            this.MnuStrip.ResumeLayout(false);
            this.MnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSideOne;
        private System.Windows.Forms.Label LblSideOne;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.TextBox TxtHypotenuse;
        private System.Windows.Forms.Label LblHypotenuse;
        private System.Windows.Forms.TextBox TxtSideTwo;
        private System.Windows.Forms.Label LblSideTwo;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.MenuStrip MnuStrip;
        private System.Windows.Forms.ToolStripMenuItem MnuStripExit;
        private System.Windows.Forms.ToolStripMenuItem MnuStripExitItem;
        private System.Windows.Forms.ToolStripMenuItem MnuStripAboutItem;
    }
}

