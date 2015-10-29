namespace Lab_14
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
            this.BtrnCalc = new System.Windows.Forms.Button();
            this.TxtSideA = new System.Windows.Forms.TextBox();
            this.LblSideA = new System.Windows.Forms.Label();
            this.TxtSideB = new System.Windows.Forms.TextBox();
            this.LblSideB = new System.Windows.Forms.Label();
            this.TxtHypotenuse = new System.Windows.Forms.TextBox();
            this.LblHypontenuse = new System.Windows.Forms.Label();
            this.TxtArea = new System.Windows.Forms.TextBox();
            this.LblArea = new System.Windows.Forms.Label();
            this.MnuStrip = new System.Windows.Forms.MenuStrip();
            this.MnuStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStripInstructions = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStripExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStripAboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnExit = new System.Windows.Forms.Button();
            this.MnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtrnCalc
            // 
            this.BtrnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtrnCalc.Location = new System.Drawing.Point(106, 188);
            this.BtrnCalc.Name = "BtrnCalc";
            this.BtrnCalc.Size = new System.Drawing.Size(75, 23);
            this.BtrnCalc.TabIndex = 0;
            this.BtrnCalc.Text = "Calculate";
            this.BtrnCalc.UseVisualStyleBackColor = true;
            this.BtrnCalc.Click += new System.EventHandler(this.BtrnCalc_Click);
            // 
            // TxtSideA
            // 
            this.TxtSideA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSideA.Location = new System.Drawing.Point(120, 72);
            this.TxtSideA.Name = "TxtSideA";
            this.TxtSideA.Size = new System.Drawing.Size(100, 20);
            this.TxtSideA.TabIndex = 1;
            this.TxtSideA.Text = "0.0";
            this.TxtSideA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblSideA
            // 
            this.LblSideA.AutoSize = true;
            this.LblSideA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSideA.Location = new System.Drawing.Point(66, 75);
            this.LblSideA.Name = "LblSideA";
            this.LblSideA.Size = new System.Drawing.Size(48, 13);
            this.LblSideA.TabIndex = 2;
            this.LblSideA.Text = "Side A:";
            // 
            // TxtSideB
            // 
            this.TxtSideB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSideB.Location = new System.Drawing.Point(120, 98);
            this.TxtSideB.Name = "TxtSideB";
            this.TxtSideB.Size = new System.Drawing.Size(100, 20);
            this.TxtSideB.TabIndex = 1;
            this.TxtSideB.Text = "0.0";
            this.TxtSideB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblSideB
            // 
            this.LblSideB.AutoSize = true;
            this.LblSideB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSideB.Location = new System.Drawing.Point(66, 101);
            this.LblSideB.Name = "LblSideB";
            this.LblSideB.Size = new System.Drawing.Size(52, 13);
            this.LblSideB.TabIndex = 2;
            this.LblSideB.Text = "Side B: ";
            // 
            // TxtHypotenuse
            // 
            this.TxtHypotenuse.Enabled = false;
            this.TxtHypotenuse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHypotenuse.Location = new System.Drawing.Point(120, 125);
            this.TxtHypotenuse.Name = "TxtHypotenuse";
            this.TxtHypotenuse.Size = new System.Drawing.Size(100, 20);
            this.TxtHypotenuse.TabIndex = 1;
            this.TxtHypotenuse.Text = "0.0";
            this.TxtHypotenuse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblHypontenuse
            // 
            this.LblHypontenuse.AutoSize = true;
            this.LblHypontenuse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHypontenuse.Location = new System.Drawing.Point(40, 128);
            this.LblHypontenuse.Name = "LblHypontenuse";
            this.LblHypontenuse.Size = new System.Drawing.Size(78, 13);
            this.LblHypontenuse.TabIndex = 2;
            this.LblHypontenuse.Text = "Hypotenuse:";
            // 
            // TxtArea
            // 
            this.TxtArea.Enabled = false;
            this.TxtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtArea.Location = new System.Drawing.Point(120, 151);
            this.TxtArea.Name = "TxtArea";
            this.TxtArea.Size = new System.Drawing.Size(100, 20);
            this.TxtArea.TabIndex = 1;
            this.TxtArea.Text = "0.0";
            this.TxtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblArea
            // 
            this.LblArea.AutoSize = true;
            this.LblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArea.Location = new System.Drawing.Point(75, 154);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(37, 13);
            this.LblArea.TabIndex = 2;
            this.LblArea.Text = "Area:";
            // 
            // MnuStrip
            // 
            this.MnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuStripExit,
            this.MnuStripInstructions});
            this.MnuStrip.Location = new System.Drawing.Point(0, 0);
            this.MnuStrip.Name = "MnuStrip";
            this.MnuStrip.Size = new System.Drawing.Size(284, 24);
            this.MnuStrip.TabIndex = 3;
            this.MnuStrip.Text = "MnuStrip";
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
            // MnuStripInstructions
            // 
            this.MnuStripInstructions.Name = "MnuStripInstructions";
            this.MnuStripInstructions.Size = new System.Drawing.Size(81, 20);
            this.MnuStripInstructions.Text = "Instructions";
            this.MnuStripInstructions.Click += new System.EventHandler(this.MnuStripInstructions_Click);
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
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(106, 217);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LblArea);
            this.Controls.Add(this.LblHypontenuse);
            this.Controls.Add(this.LblSideB);
            this.Controls.Add(this.TxtArea);
            this.Controls.Add(this.TxtHypotenuse);
            this.Controls.Add(this.LblSideA);
            this.Controls.Add(this.TxtSideB);
            this.Controls.Add(this.TxtSideA);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtrnCalc);
            this.Controls.Add(this.MnuStrip);
            this.MainMenuStrip = this.MnuStrip;
            this.Name = "FrmMain";
            this.Text = "Lab 15";
            this.MnuStrip.ResumeLayout(false);
            this.MnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtrnCalc;
        private System.Windows.Forms.TextBox TxtSideA;
        private System.Windows.Forms.Label LblSideA;
        private System.Windows.Forms.TextBox TxtSideB;
        private System.Windows.Forms.Label LblSideB;
        private System.Windows.Forms.TextBox TxtHypotenuse;
        private System.Windows.Forms.Label LblHypontenuse;
        private System.Windows.Forms.TextBox TxtArea;
        private System.Windows.Forms.Label LblArea;
        private System.Windows.Forms.MenuStrip MnuStrip;
        private System.Windows.Forms.ToolStripMenuItem MnuStripExit;
        private System.Windows.Forms.ToolStripMenuItem MnuStripExitItem;
        private System.Windows.Forms.ToolStripMenuItem MnuStripAboutItem;
        private System.Windows.Forms.ToolStripMenuItem MnuStripInstructions;
        private System.Windows.Forms.Button BtnExit;
    }
}

