namespace Lab_17
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
            this.RBtnSameDay = new System.Windows.Forms.RadioButton();
            this.RBtnExpress = new System.Windows.Forms.RadioButton();
            this.RBtnStandard = new System.Windows.Forms.RadioButton();
            this.LblShip = new System.Windows.Forms.Label();
            this.GBoxShipping = new System.Windows.Forms.GroupBox();
            this.GBoxShipping.SuspendLayout();
            this.SuspendLayout();
            // 
            // RBtnSameDay
            // 
            this.RBtnSameDay.AutoSize = true;
            this.RBtnSameDay.Location = new System.Drawing.Point(6, 32);
            this.RBtnSameDay.Name = "RBtnSameDay";
            this.RBtnSameDay.Size = new System.Drawing.Size(74, 17);
            this.RBtnSameDay.TabIndex = 0;
            this.RBtnSameDay.Text = "Same-Day";
            this.RBtnSameDay.UseVisualStyleBackColor = true;
            this.RBtnSameDay.CheckedChanged += new System.EventHandler(this.RBtnSameDay_CheckedChanged);
            // 
            // RBtnExpress
            // 
            this.RBtnExpress.AutoSize = true;
            this.RBtnExpress.Checked = true;
            this.RBtnExpress.Location = new System.Drawing.Point(6, 55);
            this.RBtnExpress.Name = "RBtnExpress";
            this.RBtnExpress.Size = new System.Drawing.Size(62, 17);
            this.RBtnExpress.TabIndex = 0;
            this.RBtnExpress.TabStop = true;
            this.RBtnExpress.Text = "Express";
            this.RBtnExpress.UseVisualStyleBackColor = true;
            this.RBtnExpress.CheckedChanged += new System.EventHandler(this.RBtnExpress_CheckedChanged);
            // 
            // RBtnStandard
            // 
            this.RBtnStandard.AutoSize = true;
            this.RBtnStandard.Location = new System.Drawing.Point(6, 77);
            this.RBtnStandard.Name = "RBtnStandard";
            this.RBtnStandard.Size = new System.Drawing.Size(68, 17);
            this.RBtnStandard.TabIndex = 0;
            this.RBtnStandard.Text = "Standard";
            this.RBtnStandard.UseVisualStyleBackColor = true;
            this.RBtnStandard.CheckedChanged += new System.EventHandler(this.RBtnStandard_CheckedChanged);
            // 
            // LblShip
            // 
            this.LblShip.AutoSize = true;
            this.LblShip.Location = new System.Drawing.Point(6, 16);
            this.LblShip.Name = "LblShip";
            this.LblShip.Size = new System.Drawing.Size(139, 13);
            this.LblShip.TabIndex = 1;
            this.LblShip.Text = "How would you like to ship?";
            // 
            // GBoxShipping
            // 
            this.GBoxShipping.Controls.Add(this.RBtnExpress);
            this.GBoxShipping.Controls.Add(this.LblShip);
            this.GBoxShipping.Controls.Add(this.RBtnSameDay);
            this.GBoxShipping.Controls.Add(this.RBtnStandard);
            this.GBoxShipping.Location = new System.Drawing.Point(12, 15);
            this.GBoxShipping.Name = "GBoxShipping";
            this.GBoxShipping.Size = new System.Drawing.Size(145, 100);
            this.GBoxShipping.TabIndex = 2;
            this.GBoxShipping.TabStop = false;
            this.GBoxShipping.Text = "Shipping Method";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.GBoxShipping);
            this.Name = "FrmMain";
            this.Text = "CS 1400 Lab 17";
            this.GBoxShipping.ResumeLayout(false);
            this.GBoxShipping.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton RBtnSameDay;
        private System.Windows.Forms.RadioButton RBtnExpress;
        private System.Windows.Forms.RadioButton RBtnStandard;
        private System.Windows.Forms.Label LblShip;
        private System.Windows.Forms.GroupBox GBoxShipping;
    }
}

