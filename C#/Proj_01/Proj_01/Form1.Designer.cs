namespace Proj_01
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
            this.MnuStripMain = new System.Windows.Forms.MenuStrip();
            this.MnuStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStripExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStripAboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtMealCost = new System.Windows.Forms.TextBox();
            this.LblMealCost = new System.Windows.Forms.Label();
            this.TxtPoor = new System.Windows.Forms.TextBox();
            this.LblPoor = new System.Windows.Forms.Label();
            this.TxtAverage = new System.Windows.Forms.TextBox();
            this.LblAverage = new System.Windows.Forms.Label();
            this.TxtExcellent = new System.Windows.Forms.TextBox();
            this.LblExcellent = new System.Windows.Forms.Label();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.MnuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuStripMain
            // 
            this.MnuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuStripExit});
            this.MnuStripMain.Location = new System.Drawing.Point(0, 0);
            this.MnuStripMain.Name = "MnuStripMain";
            this.MnuStripMain.Size = new System.Drawing.Size(284, 24);
            this.MnuStripMain.TabIndex = 0;
            this.MnuStripMain.Text = "menuStrip1";
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
            this.MnuStripExitItem.Size = new System.Drawing.Size(107, 22);
            this.MnuStripExitItem.Text = "Exit";
            this.MnuStripExitItem.Click += new System.EventHandler(this.MnuStripExitItem_Click);
            // 
            // MnuStripAboutItem
            // 
            this.MnuStripAboutItem.Name = "MnuStripAboutItem";
            this.MnuStripAboutItem.Size = new System.Drawing.Size(107, 22);
            this.MnuStripAboutItem.Text = "About";
            this.MnuStripAboutItem.Click += new System.EventHandler(this.MnuStripAboutItem_Click);
            // 
            // TxtMealCost
            // 
            this.TxtMealCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMealCost.Location = new System.Drawing.Point(124, 62);
            this.TxtMealCost.Name = "TxtMealCost";
            this.TxtMealCost.Size = new System.Drawing.Size(100, 20);
            this.TxtMealCost.TabIndex = 1;
            this.TxtMealCost.TabStop = false;
            this.TxtMealCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtMealCost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtMealCost_KeyDown);
            // 
            // LblMealCost
            // 
            this.LblMealCost.AutoSize = true;
            this.LblMealCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMealCost.Location = new System.Drawing.Point(49, 69);
            this.LblMealCost.Name = "LblMealCost";
            this.LblMealCost.Size = new System.Drawing.Size(67, 13);
            this.LblMealCost.TabIndex = 2;
            this.LblMealCost.Text = "Meal Cost:";
            // 
            // TxtPoor
            // 
            this.TxtPoor.Enabled = false;
            this.TxtPoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPoor.Location = new System.Drawing.Point(124, 95);
            this.TxtPoor.Name = "TxtPoor";
            this.TxtPoor.Size = new System.Drawing.Size(100, 20);
            this.TxtPoor.TabIndex = 2;
            this.TxtPoor.TabStop = false;
            this.TxtPoor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblPoor
            // 
            this.LblPoor.AutoSize = true;
            this.LblPoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPoor.Location = new System.Drawing.Point(49, 102);
            this.LblPoor.Name = "LblPoor";
            this.LblPoor.Size = new System.Drawing.Size(68, 13);
            this.LblPoor.TabIndex = 2;
            this.LblPoor.Text = "Poor(10%):";
            // 
            // TxtAverage
            // 
            this.TxtAverage.Enabled = false;
            this.TxtAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAverage.Location = new System.Drawing.Point(124, 133);
            this.TxtAverage.Name = "TxtAverage";
            this.TxtAverage.Size = new System.Drawing.Size(100, 20);
            this.TxtAverage.TabIndex = 3;
            this.TxtAverage.TabStop = false;
            this.TxtAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblAverage
            // 
            this.LblAverage.AutoSize = true;
            this.LblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAverage.Location = new System.Drawing.Point(28, 136);
            this.LblAverage.Name = "LblAverage";
            this.LblAverage.Size = new System.Drawing.Size(89, 13);
            this.LblAverage.TabIndex = 2;
            this.LblAverage.Text = "Average(15%):";
            // 
            // TxtExcellent
            // 
            this.TxtExcellent.Enabled = false;
            this.TxtExcellent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtExcellent.Location = new System.Drawing.Point(124, 164);
            this.TxtExcellent.Name = "TxtExcellent";
            this.TxtExcellent.Size = new System.Drawing.Size(100, 20);
            this.TxtExcellent.TabIndex = 4;
            this.TxtExcellent.TabStop = false;
            this.TxtExcellent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblExcellent
            // 
            this.LblExcellent.AutoSize = true;
            this.LblExcellent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExcellent.Location = new System.Drawing.Point(28, 167);
            this.LblExcellent.Name = "LblExcellent";
            this.LblExcellent.Size = new System.Drawing.Size(94, 13);
            this.LblExcellent.TabIndex = 2;
            this.LblExcellent.Text = "Excellent(20%):";
            // 
            // BtnCalc
            // 
            this.BtnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalc.Location = new System.Drawing.Point(86, 200);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(110, 36);
            this.BtnCalc.TabIndex = 5;
            this.BtnCalc.TabStop = false;
            this.BtnCalc.Text = "Calculate";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.LblExcellent);
            this.Controls.Add(this.TxtExcellent);
            this.Controls.Add(this.LblAverage);
            this.Controls.Add(this.TxtAverage);
            this.Controls.Add(this.LblPoor);
            this.Controls.Add(this.TxtPoor);
            this.Controls.Add(this.LblMealCost);
            this.Controls.Add(this.TxtMealCost);
            this.Controls.Add(this.MnuStripMain);
            this.MainMenuStrip = this.MnuStripMain;
            this.Name = "FrmMain";
            this.Text = "Tip Calculator";
            this.MnuStripMain.ResumeLayout(false);
            this.MnuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuStripMain;
        private System.Windows.Forms.ToolStripMenuItem MnuStripExit;
        private System.Windows.Forms.ToolStripMenuItem MnuStripExitItem;
        private System.Windows.Forms.ToolStripMenuItem MnuStripAboutItem;
        private System.Windows.Forms.TextBox TxtMealCost;
        private System.Windows.Forms.Label LblMealCost;
        private System.Windows.Forms.TextBox TxtPoor;
        private System.Windows.Forms.Label LblPoor;
        private System.Windows.Forms.TextBox TxtAverage;
        private System.Windows.Forms.Label LblAverage;
        private System.Windows.Forms.TextBox TxtExcellent;
        private System.Windows.Forms.Label LblExcellent;
        private System.Windows.Forms.Button BtnCalc;
    }
}

