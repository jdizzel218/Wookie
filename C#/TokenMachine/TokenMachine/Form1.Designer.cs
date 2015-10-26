namespace TokenMachine
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
            this.BtnGetToken = new System.Windows.Forms.Button();
            this.MnuStrip = new System.Windows.Forms.MenuStrip();
            this.MnuStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStripExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStripAboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStripInstructions = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtNumOfTokens = new System.Windows.Forms.TextBox();
            this.LblNumOfTokens = new System.Windows.Forms.Label();
            this.TxtNumOfQuarters = new System.Windows.Forms.TextBox();
            this.LblNumOfQuarters = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.TxtTokensDispensed = new System.Windows.Forms.TextBox();
            this.LblTokensDispensed = new System.Windows.Forms.Label();
            this.MnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGetToken
            // 
            this.BtnGetToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGetToken.Location = new System.Drawing.Point(103, 153);
            this.BtnGetToken.Name = "BtnGetToken";
            this.BtnGetToken.Size = new System.Drawing.Size(75, 23);
            this.BtnGetToken.TabIndex = 0;
            this.BtnGetToken.Text = "Get Token";
            this.BtnGetToken.UseVisualStyleBackColor = true;
            this.BtnGetToken.Click += new System.EventHandler(this.BtnGetToken_Click);
            // 
            // MnuStrip
            // 
            this.MnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuStripExit,
            this.MnuStripInstructions});
            this.MnuStrip.Location = new System.Drawing.Point(0, 0);
            this.MnuStrip.Name = "MnuStrip";
            this.MnuStrip.Size = new System.Drawing.Size(284, 24);
            this.MnuStrip.TabIndex = 1;
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
            // MnuStripInstructions
            // 
            this.MnuStripInstructions.Name = "MnuStripInstructions";
            this.MnuStripInstructions.Size = new System.Drawing.Size(81, 20);
            this.MnuStripInstructions.Text = "Instructions";
            this.MnuStripInstructions.Click += new System.EventHandler(this.MnuStripInstructions_Click);
            // 
            // TxtNumOfTokens
            // 
            this.TxtNumOfTokens.Enabled = false;
            this.TxtNumOfTokens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumOfTokens.Location = new System.Drawing.Point(144, 54);
            this.TxtNumOfTokens.Name = "TxtNumOfTokens";
            this.TxtNumOfTokens.Size = new System.Drawing.Size(100, 20);
            this.TxtNumOfTokens.TabIndex = 2;
            this.TxtNumOfTokens.Text = "100";
            this.TxtNumOfTokens.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblNumOfTokens
            // 
            this.LblNumOfTokens.AutoSize = true;
            this.LblNumOfTokens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumOfTokens.Location = new System.Drawing.Point(29, 57);
            this.LblNumOfTokens.Name = "LblNumOfTokens";
            this.LblNumOfTokens.Size = new System.Drawing.Size(115, 13);
            this.LblNumOfTokens.TabIndex = 3;
            this.LblNumOfTokens.Text = "Number of Tokens:";
            // 
            // TxtNumOfQuarters
            // 
            this.TxtNumOfQuarters.Enabled = false;
            this.TxtNumOfQuarters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumOfQuarters.Location = new System.Drawing.Point(144, 81);
            this.TxtNumOfQuarters.Name = "TxtNumOfQuarters";
            this.TxtNumOfQuarters.Size = new System.Drawing.Size(100, 20);
            this.TxtNumOfQuarters.TabIndex = 2;
            this.TxtNumOfQuarters.Text = "0";
            this.TxtNumOfQuarters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblNumOfQuarters
            // 
            this.LblNumOfQuarters.AutoSize = true;
            this.LblNumOfQuarters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumOfQuarters.Location = new System.Drawing.Point(23, 84);
            this.LblNumOfQuarters.Name = "LblNumOfQuarters";
            this.LblNumOfQuarters.Size = new System.Drawing.Size(121, 13);
            this.LblNumOfQuarters.TabIndex = 3;
            this.LblNumOfQuarters.Text = "Number of Quarters:";
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(103, 182);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 0;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(103, 211);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // TxtTokensDispensed
            // 
            this.TxtTokensDispensed.Enabled = false;
            this.TxtTokensDispensed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTokensDispensed.Location = new System.Drawing.Point(144, 111);
            this.TxtTokensDispensed.Name = "TxtTokensDispensed";
            this.TxtTokensDispensed.Size = new System.Drawing.Size(100, 20);
            this.TxtTokensDispensed.TabIndex = 2;
            this.TxtTokensDispensed.Text = "0";
            this.TxtTokensDispensed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblTokensDispensed
            // 
            this.LblTokensDispensed.AutoSize = true;
            this.LblTokensDispensed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTokensDispensed.Location = new System.Drawing.Point(23, 114);
            this.LblTokensDispensed.Name = "LblTokensDispensed";
            this.LblTokensDispensed.Size = new System.Drawing.Size(116, 13);
            this.LblTokensDispensed.TabIndex = 3;
            this.LblTokensDispensed.Text = "Tokens Dispensed:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LblTokensDispensed);
            this.Controls.Add(this.TxtTokensDispensed);
            this.Controls.Add(this.LblNumOfQuarters);
            this.Controls.Add(this.TxtNumOfQuarters);
            this.Controls.Add(this.LblNumOfTokens);
            this.Controls.Add(this.TxtNumOfTokens);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnGetToken);
            this.Controls.Add(this.MnuStrip);
            this.MainMenuStrip = this.MnuStrip;
            this.Name = "FrmMain";
            this.Text = "Token Machine Lab 12";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MnuStrip.ResumeLayout(false);
            this.MnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGetToken;
        private System.Windows.Forms.MenuStrip MnuStrip;
        private System.Windows.Forms.TextBox TxtNumOfTokens;
        private System.Windows.Forms.Label LblNumOfTokens;
        private System.Windows.Forms.ToolStripMenuItem MnuStripExit;
        private System.Windows.Forms.ToolStripMenuItem MnuStripExitItem;
        private System.Windows.Forms.ToolStripMenuItem MnuStripAboutItem;
        private System.Windows.Forms.ToolStripMenuItem MnuStripInstructions;
        private System.Windows.Forms.TextBox TxtNumOfQuarters;
        private System.Windows.Forms.Label LblNumOfQuarters;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox TxtTokensDispensed;
        private System.Windows.Forms.Label LblTokensDispensed;
    }
}

