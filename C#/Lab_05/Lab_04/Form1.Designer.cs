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
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.LblInput = new System.Windows.Forms.Label();
            this.TxtOutput = new System.Windows.Forms.TextBox();
            this.LblOutput = new System.Windows.Forms.Label();
            this.LblSum = new System.Windows.Forms.Label();
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
            this.MnuStripAbout.Size = new System.Drawing.Size(107, 22);
            this.MnuStripAbout.Text = "About";
            this.MnuStripAbout.Click += new System.EventHandler(this.MnuStripAbout_Click);
            // 
            // MnuStripExit
            // 
            this.MnuStripExit.Name = "MnuStripExit";
            this.MnuStripExit.Size = new System.Drawing.Size(107, 22);
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
            // TxtInput
            // 
            this.TxtInput.Location = new System.Drawing.Point(119, 59);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(100, 20);
            this.TxtInput.TabIndex = 2;
            this.TxtInput.Text = "<none>";
            this.TxtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtInput.Leave += new System.EventHandler(this.TxtInput_Leave);
            // 
            // LblInput
            // 
            this.LblInput.AutoSize = true;
            this.LblInput.Location = new System.Drawing.Point(56, 62);
            this.LblInput.Name = "LblInput";
            this.LblInput.Size = new System.Drawing.Size(36, 13);
            this.LblInput.TabIndex = 3;
            this.LblInput.Text = "Input";
            // 
            // TxtOutput
            // 
            this.TxtOutput.Location = new System.Drawing.Point(119, 123);
            this.TxtOutput.Name = "TxtOutput";
            this.TxtOutput.Size = new System.Drawing.Size(100, 20);
            this.TxtOutput.TabIndex = 2;
            this.TxtOutput.Text = "<none>";
            this.TxtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Location = new System.Drawing.Point(56, 123);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(41, 13);
            this.LblOutput.TabIndex = 3;
            this.LblOutput.Text = "Ouput";
            // 
            // LblSum
            // 
            this.LblSum.AutoSize = true;
            this.LblSum.Location = new System.Drawing.Point(56, 181);
            this.LblSum.Name = "LblSum";
            this.LblSum.Size = new System.Drawing.Size(31, 13);
            this.LblSum.TabIndex = 3;
            this.LblSum.Text = "Sum";
            // 
            // FrmMenuStrip1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 261);
            this.Controls.Add(this.LblSum);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.LblInput);
            this.Controls.Add(this.TxtOutput);
            this.Controls.Add(this.TxtInput);
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
        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.Label LblInput;
        private System.Windows.Forms.TextBox TxtOutput;
        private System.Windows.Forms.Label LblOutput;
        private System.Windows.Forms.Label LblSum;
    }
}

