namespace Proj_02
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
            this.MnuStrip = new System.Windows.Forms.MenuStrip();
            this.MnuStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStripExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStripAboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblNumberPirates = new System.Windows.Forms.Label();
            this.TxtNumberPirates = new System.Windows.Forms.TextBox();
            this.LblTotalGold = new System.Windows.Forms.Label();
            this.TxtTotalGold = new System.Windows.Forms.TextBox();
            this.BtnSplitGold = new System.Windows.Forms.Button();
            this.LblJackShare = new System.Windows.Forms.Label();
            this.TxtCapnShare = new System.Windows.Forms.TextBox();
            this.LblFirstMate = new System.Windows.Forms.Label();
            this.TxtFirstMateShare = new System.Windows.Forms.TextBox();
            this.LblCrewShare = new System.Windows.Forms.Label();
            this.TxtCrewShare = new System.Windows.Forms.TextBox();
            this.LblPbaShare = new System.Windows.Forms.Label();
            this.TxtPbaShare = new System.Windows.Forms.TextBox();
            this.BtnDone = new System.Windows.Forms.Button();
            this.LblAudit = new System.Windows.Forms.Label();
            this.TxtAuditor = new System.Windows.Forms.TextBox();
            this.MnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuStrip
            // 
            this.MnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuStripExit});
            this.MnuStrip.Location = new System.Drawing.Point(0, 0);
            this.MnuStrip.Name = "MnuStrip";
            this.MnuStrip.Size = new System.Drawing.Size(284, 24);
            this.MnuStrip.TabIndex = 0;
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
            // LblNumberPirates
            // 
            this.LblNumberPirates.AutoSize = true;
            this.LblNumberPirates.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumberPirates.Location = new System.Drawing.Point(43, 61);
            this.LblNumberPirates.Name = "LblNumberPirates";
            this.LblNumberPirates.Size = new System.Drawing.Size(93, 13);
            this.LblNumberPirates.TabIndex = 1;
            this.LblNumberPirates.Text = "Crew Members:";
            // 
            // TxtNumberPirates
            // 
            this.TxtNumberPirates.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumberPirates.Location = new System.Drawing.Point(152, 58);
            this.TxtNumberPirates.Name = "TxtNumberPirates";
            this.TxtNumberPirates.Size = new System.Drawing.Size(100, 20);
            this.TxtNumberPirates.TabIndex = 1;
            this.TxtNumberPirates.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNumberPirates_KeyDown);
            // 
            // LblTotalGold
            // 
            this.LblTotalGold.AutoSize = true;
            this.LblTotalGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalGold.Location = new System.Drawing.Point(64, 95);
            this.LblTotalGold.Name = "LblTotalGold";
            this.LblTotalGold.Size = new System.Drawing.Size(70, 13);
            this.LblTotalGold.TabIndex = 1;
            this.LblTotalGold.Text = "Total Gold:";
            // 
            // TxtTotalGold
            // 
            this.TxtTotalGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalGold.Location = new System.Drawing.Point(152, 92);
            this.TxtTotalGold.Name = "TxtTotalGold";
            this.TxtTotalGold.Size = new System.Drawing.Size(100, 20);
            this.TxtTotalGold.TabIndex = 2;
            this.TxtTotalGold.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtTotalGold_KeyDown);
            // 
            // BtnSplitGold
            // 
            this.BtnSplitGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSplitGold.Location = new System.Drawing.Point(72, 129);
            this.BtnSplitGold.Name = "BtnSplitGold";
            this.BtnSplitGold.Size = new System.Drawing.Size(116, 23);
            this.BtnSplitGold.TabIndex = 3;
            this.BtnSplitGold.Text = "Split the Gold!";
            this.BtnSplitGold.UseVisualStyleBackColor = true;
            this.BtnSplitGold.Click += new System.EventHandler(this.BtnSplitGold_Click);
            // 
            // LblJackShare
            // 
            this.LblJackShare.AutoSize = true;
            this.LblJackShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblJackShare.Location = new System.Drawing.Point(52, 186);
            this.LblJackShare.Name = "LblJackShare";
            this.LblJackShare.Size = new System.Drawing.Size(84, 13);
            this.LblJackShare.TabIndex = 1;
            this.LblJackShare.Text = "Jack\'s Share:";
            // 
            // TxtCapnShare
            // 
            this.TxtCapnShare.Enabled = false;
            this.TxtCapnShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCapnShare.Location = new System.Drawing.Point(152, 186);
            this.TxtCapnShare.Name = "TxtCapnShare";
            this.TxtCapnShare.Size = new System.Drawing.Size(100, 20);
            this.TxtCapnShare.TabIndex = 4;
            // 
            // LblFirstMate
            // 
            this.LblFirstMate.AutoSize = true;
            this.LblFirstMate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFirstMate.Location = new System.Drawing.Point(23, 220);
            this.LblFirstMate.Name = "LblFirstMate";
            this.LblFirstMate.Size = new System.Drawing.Size(113, 13);
            this.LblFirstMate.TabIndex = 1;
            this.LblFirstMate.Text = "First Mate\'s Share:";
            // 
            // TxtFirstMateShare
            // 
            this.TxtFirstMateShare.Enabled = false;
            this.TxtFirstMateShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFirstMateShare.Location = new System.Drawing.Point(152, 217);
            this.TxtFirstMateShare.Name = "TxtFirstMateShare";
            this.TxtFirstMateShare.Size = new System.Drawing.Size(100, 20);
            this.TxtFirstMateShare.TabIndex = 5;
            // 
            // LblCrewShare
            // 
            this.LblCrewShare.AutoSize = true;
            this.LblCrewShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCrewShare.Location = new System.Drawing.Point(51, 251);
            this.LblCrewShare.Name = "LblCrewShare";
            this.LblCrewShare.Size = new System.Drawing.Size(85, 13);
            this.LblCrewShare.TabIndex = 1;
            this.LblCrewShare.Text = "Crew\'s Share:";
            // 
            // TxtCrewShare
            // 
            this.TxtCrewShare.Enabled = false;
            this.TxtCrewShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCrewShare.Location = new System.Drawing.Point(152, 248);
            this.TxtCrewShare.Name = "TxtCrewShare";
            this.TxtCrewShare.Size = new System.Drawing.Size(100, 20);
            this.TxtCrewShare.TabIndex = 6;
            // 
            // LblPbaShare
            // 
            this.LblPbaShare.AutoSize = true;
            this.LblPbaShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPbaShare.Location = new System.Drawing.Point(55, 282);
            this.LblPbaShare.Name = "LblPbaShare";
            this.LblPbaShare.Size = new System.Drawing.Size(81, 13);
            this.LblPbaShare.TabIndex = 1;
            this.LblPbaShare.Text = "PBA\'s Share:";
            // 
            // TxtPbaShare
            // 
            this.TxtPbaShare.Enabled = false;
            this.TxtPbaShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPbaShare.Location = new System.Drawing.Point(152, 279);
            this.TxtPbaShare.Name = "TxtPbaShare";
            this.TxtPbaShare.Size = new System.Drawing.Size(100, 20);
            this.TxtPbaShare.TabIndex = 7;
            // 
            // BtnDone
            // 
            this.BtnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDone.Location = new System.Drawing.Point(72, 371);
            this.BtnDone.Name = "BtnDone";
            this.BtnDone.Size = new System.Drawing.Size(116, 23);
            this.BtnDone.TabIndex = 8;
            this.BtnDone.Text = "Done";
            this.BtnDone.UseVisualStyleBackColor = true;
            this.BtnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // LblAudit
            // 
            this.LblAudit.AutoSize = true;
            this.LblAudit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAudit.Location = new System.Drawing.Point(83, 321);
            this.LblAudit.Name = "LblAudit";
            this.LblAudit.Size = new System.Drawing.Size(51, 13);
            this.LblAudit.TabIndex = 1;
            this.LblAudit.Text = "Auditor:";
            // 
            // TxtAuditor
            // 
            this.TxtAuditor.Enabled = false;
            this.TxtAuditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAuditor.Location = new System.Drawing.Point(152, 318);
            this.TxtAuditor.Name = "TxtAuditor";
            this.TxtAuditor.Size = new System.Drawing.Size(100, 20);
            this.TxtAuditor.TabIndex = 7;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 439);
            this.Controls.Add(this.BtnDone);
            this.Controls.Add(this.BtnSplitGold);
            this.Controls.Add(this.TxtAuditor);
            this.Controls.Add(this.TxtPbaShare);
            this.Controls.Add(this.TxtFirstMateShare);
            this.Controls.Add(this.LblAudit);
            this.Controls.Add(this.TxtTotalGold);
            this.Controls.Add(this.LblPbaShare);
            this.Controls.Add(this.TxtCrewShare);
            this.Controls.Add(this.LblFirstMate);
            this.Controls.Add(this.TxtCapnShare);
            this.Controls.Add(this.LblCrewShare);
            this.Controls.Add(this.LblTotalGold);
            this.Controls.Add(this.LblJackShare);
            this.Controls.Add(this.TxtNumberPirates);
            this.Controls.Add(this.LblNumberPirates);
            this.Controls.Add(this.MnuStrip);
            this.MainMenuStrip = this.MnuStrip;
            this.Name = "FrmMain";
            this.Text = "Project 02";
            this.MnuStrip.ResumeLayout(false);
            this.MnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuStrip;
        private System.Windows.Forms.ToolStripMenuItem MnuStripExit;
        private System.Windows.Forms.ToolStripMenuItem MnuStripExitItem;
        private System.Windows.Forms.ToolStripMenuItem MnuStripAboutItem;
        private System.Windows.Forms.Label LblNumberPirates;
        private System.Windows.Forms.TextBox TxtNumberPirates;
        private System.Windows.Forms.Label LblTotalGold;
        private System.Windows.Forms.TextBox TxtTotalGold;
        private System.Windows.Forms.Button BtnSplitGold;
        private System.Windows.Forms.Label LblJackShare;
        private System.Windows.Forms.TextBox TxtCapnShare;
        private System.Windows.Forms.Label LblFirstMate;
        private System.Windows.Forms.TextBox TxtFirstMateShare;
        private System.Windows.Forms.Label LblCrewShare;
        private System.Windows.Forms.TextBox TxtCrewShare;
        private System.Windows.Forms.Label LblPbaShare;
        private System.Windows.Forms.TextBox TxtPbaShare;
        private System.Windows.Forms.Button BtnDone;
        private System.Windows.Forms.Label LblAudit;
        private System.Windows.Forms.TextBox TxtAuditor;
    }
}

