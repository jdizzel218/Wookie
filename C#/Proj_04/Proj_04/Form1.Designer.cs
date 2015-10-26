namespace Proj_04
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
            this.BtnCalc = new System.Windows.Forms.Button();
            this.LblSide1 = new System.Windows.Forms.Label();
            this.TxtSideA = new System.Windows.Forms.TextBox();
            this.MnuStrip = new System.Windows.Forms.MenuStrip();
            this.MnuStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStripExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStripAboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStripInstructions = new System.Windows.Forms.ToolStripMenuItem();
            this.LblSideB = new System.Windows.Forms.Label();
            this.TxtSideB = new System.Windows.Forms.TextBox();
            this.LblAngleC = new System.Windows.Forms.Label();
            this.TxtAngleC = new System.Windows.Forms.TextBox();
            this.LblSideC = new System.Windows.Forms.Label();
            this.TxtSideC = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.MnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCalc
            // 
            this.BtnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalc.Location = new System.Drawing.Point(94, 146);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(75, 23);
            this.BtnCalc.TabIndex = 0;
            this.BtnCalc.Text = "Calculate";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // LblSide1
            // 
            this.LblSide1.AutoSize = true;
            this.LblSide1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSide1.Location = new System.Drawing.Point(30, 37);
            this.LblSide1.Name = "LblSide1";
            this.LblSide1.Size = new System.Drawing.Size(48, 13);
            this.LblSide1.TabIndex = 1;
            this.LblSide1.Text = "Side A:";
            // 
            // TxtSideA
            // 
            this.TxtSideA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSideA.Location = new System.Drawing.Point(83, 34);
            this.TxtSideA.Name = "TxtSideA";
            this.TxtSideA.Size = new System.Drawing.Size(100, 20);
            this.TxtSideA.TabIndex = 2;
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
            // MnuStripInstructions
            // 
            this.MnuStripInstructions.Name = "MnuStripInstructions";
            this.MnuStripInstructions.Size = new System.Drawing.Size(81, 20);
            this.MnuStripInstructions.Text = "Instructions";
            this.MnuStripInstructions.Click += new System.EventHandler(this.MnuStripInstructions_Click);
            // 
            // LblSideB
            // 
            this.LblSideB.AutoSize = true;
            this.LblSideB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSideB.Location = new System.Drawing.Point(30, 74);
            this.LblSideB.Name = "LblSideB";
            this.LblSideB.Size = new System.Drawing.Size(48, 13);
            this.LblSideB.TabIndex = 1;
            this.LblSideB.Text = "Side B:";
            // 
            // TxtSideB
            // 
            this.TxtSideB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSideB.Location = new System.Drawing.Point(83, 67);
            this.TxtSideB.Name = "TxtSideB";
            this.TxtSideB.Size = new System.Drawing.Size(100, 20);
            this.TxtSideB.TabIndex = 2;
            // 
            // LblAngleC
            // 
            this.LblAngleC.AutoSize = true;
            this.LblAngleC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAngleC.Location = new System.Drawing.Point(30, 112);
            this.LblAngleC.Name = "LblAngleC";
            this.LblAngleC.Size = new System.Drawing.Size(55, 13);
            this.LblAngleC.TabIndex = 1;
            this.LblAngleC.Text = "Angle C:";
            // 
            // TxtAngleC
            // 
            this.TxtAngleC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAngleC.Location = new System.Drawing.Point(83, 105);
            this.TxtAngleC.Name = "TxtAngleC";
            this.TxtAngleC.Size = new System.Drawing.Size(100, 20);
            this.TxtAngleC.TabIndex = 2;
            // 
            // LblSideC
            // 
            this.LblSideC.AutoSize = true;
            this.LblSideC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSideC.Location = new System.Drawing.Point(30, 199);
            this.LblSideC.Name = "LblSideC";
            this.LblSideC.Size = new System.Drawing.Size(48, 13);
            this.LblSideC.TabIndex = 1;
            this.LblSideC.Text = "Side C:";
            // 
            // TxtSideC
            // 
            this.TxtSideC.Enabled = false;
            this.TxtSideC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSideC.Location = new System.Drawing.Point(83, 192);
            this.TxtSideC.Name = "TxtSideC";
            this.TxtSideC.Size = new System.Drawing.Size(100, 20);
            this.TxtSideC.TabIndex = 2;
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(158, 226);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(33, 226);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 0;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TxtSideC);
            this.Controls.Add(this.LblSideC);
            this.Controls.Add(this.TxtAngleC);
            this.Controls.Add(this.LblAngleC);
            this.Controls.Add(this.TxtSideB);
            this.Controls.Add(this.LblSideB);
            this.Controls.Add(this.TxtSideA);
            this.Controls.Add(this.LblSide1);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.MnuStrip);
            this.MainMenuStrip = this.MnuStrip;
            this.Name = "FrmMain";
            this.Text = "Triangle Calculator";
            this.MnuStrip.ResumeLayout(false);
            this.MnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Label LblSide1;
        private System.Windows.Forms.TextBox TxtSideA;
        private System.Windows.Forms.MenuStrip MnuStrip;
        private System.Windows.Forms.ToolStripMenuItem MnuStripExit;
        private System.Windows.Forms.ToolStripMenuItem MnuStripExitItem;
        private System.Windows.Forms.ToolStripMenuItem MnuStripAboutItem;
        private System.Windows.Forms.ToolStripMenuItem MnuStripInstructions;
        private System.Windows.Forms.Label LblSideB;
        private System.Windows.Forms.TextBox TxtSideB;
        private System.Windows.Forms.Label LblAngleC;
        private System.Windows.Forms.TextBox TxtAngleC;
        private System.Windows.Forms.Label LblSideC;
        private System.Windows.Forms.TextBox TxtSideC;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnClear;
    }
}

