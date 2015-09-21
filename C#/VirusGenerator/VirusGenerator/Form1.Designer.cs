namespace VirusGenerator
{
    partial class Troy
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
            this.BtnGen = new System.Windows.Forms.Button();
            this.CBoxFor = new System.Windows.Forms.ComboBox();
            this.BtnFormat = new System.Windows.Forms.Label();
            this.StaStrip = new System.Windows.Forms.StatusStrip();
            this.ToolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.MnuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStripHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStripHowToItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblDes = new System.Windows.Forms.Label();
            this.TxtBoxDes = new System.Windows.Forms.TextBox();
            this.LblAttack = new System.Windows.Forms.Label();
            this.CBoxAttack = new System.Windows.Forms.ComboBox();
            this.LblFileName = new System.Windows.Forms.Label();
            this.TxtBoxFileName = new System.Windows.Forms.TextBox();
            this.LblWarning = new System.Windows.Forms.Label();
            this.LblCategory = new System.Windows.Forms.Label();
            this.CBoxCategory = new System.Windows.Forms.ComboBox();
            this.BtnFolderSelect = new System.Windows.Forms.Button();
            this.StaStrip.SuspendLayout();
            this.MnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGen
            // 
            this.BtnGen.Location = new System.Drawing.Point(300, 211);
            this.BtnGen.Name = "BtnGen";
            this.BtnGen.Size = new System.Drawing.Size(157, 44);
            this.BtnGen.TabIndex = 0;
            this.BtnGen.Text = "Generate";
            this.BtnGen.UseVisualStyleBackColor = true;
            this.BtnGen.Click += new System.EventHandler(this.BtnGen_Click);
            // 
            // CBoxFor
            // 
            this.CBoxFor.FormattingEnabled = true;
            this.CBoxFor.Items.AddRange(new object[] {
            ".bat",
            ".ps1"});
            this.CBoxFor.Location = new System.Drawing.Point(300, 184);
            this.CBoxFor.Name = "CBoxFor";
            this.CBoxFor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CBoxFor.Size = new System.Drawing.Size(121, 21);
            this.CBoxFor.TabIndex = 1;
            this.CBoxFor.SelectedIndexChanged += new System.EventHandler(this.CBoxFor_SelectedIndexChanged);
            // 
            // BtnFormat
            // 
            this.BtnFormat.AutoSize = true;
            this.BtnFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFormat.Location = new System.Drawing.Point(297, 168);
            this.BtnFormat.Name = "BtnFormat";
            this.BtnFormat.Size = new System.Drawing.Size(45, 13);
            this.BtnFormat.TabIndex = 2;
            this.BtnFormat.Text = "Format";
            // 
            // StaStrip
            // 
            this.StaStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip});
            this.StaStrip.Location = new System.Drawing.Point(0, 264);
            this.StaStrip.Name = "StaStrip";
            this.StaStrip.Size = new System.Drawing.Size(468, 22);
            this.StaStrip.TabIndex = 4;
            this.StaStrip.Text = "statusStrip1";
            // 
            // ToolStrip
            // 
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(0, 17);
            // 
            // MnuStrip
            // 
            this.MnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.MnuStripHelp});
            this.MnuStrip.Location = new System.Drawing.Point(0, 0);
            this.MnuStrip.Name = "MnuStrip";
            this.MnuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MnuStrip.Size = new System.Drawing.Size(468, 24);
            this.MnuStrip.TabIndex = 5;
            this.MnuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.closeToolStripMenuItem.Text = "Close Program (alt + f4)";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.versionToolStripMenuItem.Text = "Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // MnuStripHelp
            // 
            this.MnuStripHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuStripHowToItem});
            this.MnuStripHelp.Name = "MnuStripHelp";
            this.MnuStripHelp.Size = new System.Drawing.Size(44, 20);
            this.MnuStripHelp.Text = "Help";
            // 
            // MnuStripHowToItem
            // 
            this.MnuStripHowToItem.Name = "MnuStripHowToItem";
            this.MnuStripHowToItem.Size = new System.Drawing.Size(138, 22);
            this.MnuStripHowToItem.Text = "How To Use";
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(12, 232);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblDes
            // 
            this.LblDes.AutoSize = true;
            this.LblDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDes.Location = new System.Drawing.Point(9, 179);
            this.LblDes.Name = "LblDes";
            this.LblDes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblDes.Size = new System.Drawing.Size(71, 13);
            this.LblDes.TabIndex = 7;
            this.LblDes.Text = "Destination";
            // 
            // TxtBoxDes
            // 
            this.TxtBoxDes.Location = new System.Drawing.Point(12, 195);
            this.TxtBoxDes.Name = "TxtBoxDes";
            this.TxtBoxDes.Size = new System.Drawing.Size(170, 20);
            this.TxtBoxDes.TabIndex = 8;
            this.TxtBoxDes.Text = "C:\\Users\\Public\\";
            // 
            // LblAttack
            // 
            this.LblAttack.AutoSize = true;
            this.LblAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAttack.Location = new System.Drawing.Point(9, 136);
            this.LblAttack.Name = "LblAttack";
            this.LblAttack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblAttack.Size = new System.Drawing.Size(44, 13);
            this.LblAttack.TabIndex = 7;
            this.LblAttack.Text = "Attack";
            // 
            // CBoxAttack
            // 
            this.CBoxAttack.FormattingEnabled = true;
            this.CBoxAttack.Items.AddRange(new object[] {
            "Infinite Loop Attack",
            "Folder Bomb Attack",
            "Nyan Cat Bomb Attack",
            "Keylogger"});
            this.CBoxAttack.Location = new System.Drawing.Point(12, 152);
            this.CBoxAttack.Name = "CBoxAttack";
            this.CBoxAttack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CBoxAttack.Size = new System.Drawing.Size(170, 21);
            this.CBoxAttack.TabIndex = 1;
            this.CBoxAttack.SelectedIndexChanged += new System.EventHandler(this.CBoxAttack_SelectedIndexChanged);
            // 
            // LblFileName
            // 
            this.LblFileName.AutoSize = true;
            this.LblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFileName.Location = new System.Drawing.Point(9, 97);
            this.LblFileName.Name = "LblFileName";
            this.LblFileName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblFileName.Size = new System.Drawing.Size(63, 13);
            this.LblFileName.TabIndex = 7;
            this.LblFileName.Text = "File Name";
            // 
            // TxtBoxFileName
            // 
            this.TxtBoxFileName.Location = new System.Drawing.Point(12, 113);
            this.TxtBoxFileName.Name = "TxtBoxFileName";
            this.TxtBoxFileName.Size = new System.Drawing.Size(170, 20);
            this.TxtBoxFileName.TabIndex = 8;
            this.TxtBoxFileName.TextChanged += new System.EventHandler(this.TxtBoxFileName_TextChanged);
            // 
            // LblWarning
            // 
            this.LblWarning.AutoSize = true;
            this.LblWarning.Location = new System.Drawing.Point(188, 113);
            this.LblWarning.Name = "LblWarning";
            this.LblWarning.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblWarning.Size = new System.Drawing.Size(198, 13);
            this.LblWarning.TabIndex = 7;
            this.LblWarning.Text = "<- Don\'t include the format i.e (.exe, .bat)";
            // 
            // LblCategory
            // 
            this.LblCategory.AutoSize = true;
            this.LblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategory.Location = new System.Drawing.Point(9, 55);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblCategory.Size = new System.Drawing.Size(57, 13);
            this.LblCategory.TabIndex = 7;
            this.LblCategory.Text = "Category";
            // 
            // CBoxCategory
            // 
            this.CBoxCategory.FormattingEnabled = true;
            this.CBoxCategory.Items.AddRange(new object[] {
            "Destructive",
            "Espionage",
            "Recon",
            "Control"});
            this.CBoxCategory.Location = new System.Drawing.Point(12, 71);
            this.CBoxCategory.Name = "CBoxCategory";
            this.CBoxCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CBoxCategory.Size = new System.Drawing.Size(170, 21);
            this.CBoxCategory.TabIndex = 1;
            this.CBoxCategory.SelectedIndexChanged += new System.EventHandler(this.CBoxCategory_SelectedIndexChanged);
            // 
            // BtnFolderSelect
            // 
            this.BtnFolderSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFolderSelect.Location = new System.Drawing.Point(191, 193);
            this.BtnFolderSelect.Name = "BtnFolderSelect";
            this.BtnFolderSelect.Size = new System.Drawing.Size(23, 23);
            this.BtnFolderSelect.TabIndex = 9;
            this.BtnFolderSelect.Text = "...";
            this.BtnFolderSelect.UseVisualStyleBackColor = true;
            this.BtnFolderSelect.Click += new System.EventHandler(this.BtnFolderSelect_Click);
            // 
            // Troy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 286);
            this.Controls.Add(this.BtnFolderSelect);
            this.Controls.Add(this.TxtBoxFileName);
            this.Controls.Add(this.TxtBoxDes);
            this.Controls.Add(this.LblAttack);
            this.Controls.Add(this.LblWarning);
            this.Controls.Add(this.LblCategory);
            this.Controls.Add(this.LblFileName);
            this.Controls.Add(this.LblDes);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.StaStrip);
            this.Controls.Add(this.MnuStrip);
            this.Controls.Add(this.BtnFormat);
            this.Controls.Add(this.CBoxCategory);
            this.Controls.Add(this.CBoxAttack);
            this.Controls.Add(this.CBoxFor);
            this.Controls.Add(this.BtnGen);
            this.MainMenuStrip = this.MnuStrip;
            this.Name = "Troy";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Troy";
            this.StaStrip.ResumeLayout(false);
            this.StaStrip.PerformLayout();
            this.MnuStrip.ResumeLayout(false);
            this.MnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGen;
        private System.Windows.Forms.ComboBox CBoxFor;
        private System.Windows.Forms.Label BtnFormat;
        private System.Windows.Forms.StatusStrip StaStrip;
        private System.Windows.Forms.MenuStrip MnuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblDes;
        private System.Windows.Forms.TextBox TxtBoxDes;
        private System.Windows.Forms.Label LblAttack;
        private System.Windows.Forms.ComboBox CBoxAttack;
        private System.Windows.Forms.Label LblFileName;
        private System.Windows.Forms.TextBox TxtBoxFileName;
        private System.Windows.Forms.Label LblWarning;
        private System.Windows.Forms.ToolStripStatusLabel ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem MnuStripHelp;
        private System.Windows.Forms.ToolStripMenuItem MnuStripHowToItem;
        private System.Windows.Forms.Label LblCategory;
        private System.Windows.Forms.ComboBox CBoxCategory;
        private System.Windows.Forms.Button BtnFolderSelect;
    }
}

