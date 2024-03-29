﻿namespace Proj_06
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
            this.LblShipMethod = new System.Windows.Forms.Label();
            this.CBoxShipMethod = new System.Windows.Forms.ComboBox();
            this.RBtnSurchargeYes = new System.Windows.Forms.RadioButton();
            this.GBoxSurcharge = new System.Windows.Forms.GroupBox();
            this.RBtnSurchargeNo = new System.Windows.Forms.RadioButton();
            this.LblSurcharge = new System.Windows.Forms.Label();
            this.LblNumItems = new System.Windows.Forms.Label();
            this.LblCategory = new System.Windows.Forms.Label();
            this.CBoxCategory = new System.Windows.Forms.ComboBox();
            this.MnuStrip = new System.Windows.Forms.MenuStrip();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuInstruc = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtNumItems = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GBoxSurcharge.SuspendLayout();
            this.MnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCalc
            // 
            this.BtnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalc.Location = new System.Drawing.Point(47, 143);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(92, 40);
            this.BtnCalc.TabIndex = 0;
            this.BtnCalc.Text = "Calculate";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // LblShipMethod
            // 
            this.LblShipMethod.AutoSize = true;
            this.LblShipMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblShipMethod.Location = new System.Drawing.Point(28, 41);
            this.LblShipMethod.Name = "LblShipMethod";
            this.LblShipMethod.Size = new System.Drawing.Size(102, 13);
            this.LblShipMethod.TabIndex = 1;
            this.LblShipMethod.Text = "Shipping Method";
            // 
            // CBoxShipMethod
            // 
            this.CBoxShipMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxShipMethod.FormattingEnabled = true;
            this.CBoxShipMethod.Items.AddRange(new object[] {
            "Standard",
            "Express",
            "Same-Day"});
            this.CBoxShipMethod.Location = new System.Drawing.Point(31, 57);
            this.CBoxShipMethod.Name = "CBoxShipMethod";
            this.CBoxShipMethod.Size = new System.Drawing.Size(121, 21);
            this.CBoxShipMethod.TabIndex = 2;
            this.CBoxShipMethod.Text = "(Click to select)";
            // 
            // RBtnSurchargeYes
            // 
            this.RBtnSurchargeYes.AutoSize = true;
            this.RBtnSurchargeYes.Location = new System.Drawing.Point(6, 37);
            this.RBtnSurchargeYes.Name = "RBtnSurchargeYes";
            this.RBtnSurchargeYes.Size = new System.Drawing.Size(46, 17);
            this.RBtnSurchargeYes.TabIndex = 3;
            this.RBtnSurchargeYes.TabStop = true;
            this.RBtnSurchargeYes.Text = "Yes";
            this.RBtnSurchargeYes.UseVisualStyleBackColor = true;
            // 
            // GBoxSurcharge
            // 
            this.GBoxSurcharge.Controls.Add(this.RBtnSurchargeNo);
            this.GBoxSurcharge.Controls.Add(this.RBtnSurchargeYes);
            this.GBoxSurcharge.Controls.Add(this.LblSurcharge);
            this.GBoxSurcharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBoxSurcharge.Location = new System.Drawing.Point(178, 95);
            this.GBoxSurcharge.Name = "GBoxSurcharge";
            this.GBoxSurcharge.Size = new System.Drawing.Size(200, 100);
            this.GBoxSurcharge.TabIndex = 4;
            this.GBoxSurcharge.TabStop = false;
            this.GBoxSurcharge.Text = "Surcharge";
            // 
            // RBtnSurchargeNo
            // 
            this.RBtnSurchargeNo.AutoSize = true;
            this.RBtnSurchargeNo.Location = new System.Drawing.Point(6, 60);
            this.RBtnSurchargeNo.Name = "RBtnSurchargeNo";
            this.RBtnSurchargeNo.Size = new System.Drawing.Size(41, 17);
            this.RBtnSurchargeNo.TabIndex = 3;
            this.RBtnSurchargeNo.TabStop = true;
            this.RBtnSurchargeNo.Text = "No";
            this.RBtnSurchargeNo.UseVisualStyleBackColor = true;
            // 
            // LblSurcharge
            // 
            this.LblSurcharge.AutoSize = true;
            this.LblSurcharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSurcharge.Location = new System.Drawing.Point(47, 21);
            this.LblSurcharge.Name = "LblSurcharge";
            this.LblSurcharge.Size = new System.Drawing.Size(56, 13);
            this.LblSurcharge.TabIndex = 1;
            this.LblSurcharge.Text = "(HA or AL)";
            // 
            // LblNumItems
            // 
            this.LblNumItems.AutoSize = true;
            this.LblNumItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumItems.Location = new System.Drawing.Point(28, 95);
            this.LblNumItems.Name = "LblNumItems";
            this.LblNumItems.Size = new System.Drawing.Size(99, 13);
            this.LblNumItems.TabIndex = 1;
            this.LblNumItems.Text = "Number of Items";
            // 
            // LblCategory
            // 
            this.LblCategory.AutoSize = true;
            this.LblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategory.Location = new System.Drawing.Point(175, 41);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Size = new System.Drawing.Size(57, 13);
            this.LblCategory.TabIndex = 1;
            this.LblCategory.Text = "Category";
            // 
            // CBoxCategory
            // 
            this.CBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxCategory.FormattingEnabled = true;
            this.CBoxCategory.Items.AddRange(new object[] {
            "A - Per Item",
            "B - Per Pound"});
            this.CBoxCategory.Location = new System.Drawing.Point(178, 57);
            this.CBoxCategory.Name = "CBoxCategory";
            this.CBoxCategory.Size = new System.Drawing.Size(121, 21);
            this.CBoxCategory.TabIndex = 2;
            this.CBoxCategory.Text = "(Click to select)";
            // 
            // MnuStrip
            // 
            this.MnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuExit,
            this.MnuInstruc});
            this.MnuStrip.Location = new System.Drawing.Point(0, 0);
            this.MnuStrip.Name = "MnuStrip";
            this.MnuStrip.Size = new System.Drawing.Size(394, 24);
            this.MnuStrip.TabIndex = 5;
            this.MnuStrip.Text = "menuStrip1";
            // 
            // MnuExit
            // 
            this.MnuExit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuExitItem,
            this.MnuAboutItem});
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(37, 20);
            this.MnuExit.Text = "Exit";
            // 
            // MnuExitItem
            // 
            this.MnuExitItem.Name = "MnuExitItem";
            this.MnuExitItem.Size = new System.Drawing.Size(152, 22);
            this.MnuExitItem.Text = "Exit";
            this.MnuExitItem.Click += new System.EventHandler(this.MnuExitItem_Click);
            // 
            // MnuAboutItem
            // 
            this.MnuAboutItem.Name = "MnuAboutItem";
            this.MnuAboutItem.Size = new System.Drawing.Size(152, 22);
            this.MnuAboutItem.Text = "About";
            this.MnuAboutItem.Click += new System.EventHandler(this.MnuAboutItem_Click);
            // 
            // MnuInstruc
            // 
            this.MnuInstruc.Name = "MnuInstruc";
            this.MnuInstruc.Size = new System.Drawing.Size(81, 20);
            this.MnuInstruc.Text = "Instructions";
            this.MnuInstruc.Click += new System.EventHandler(this.MnuInstruc_Click);
            // 
            // TxtNumItems
            // 
            this.TxtNumItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumItems.Location = new System.Drawing.Point(31, 111);
            this.TxtNumItems.Name = "TxtNumItems";
            this.TxtNumItems.Size = new System.Drawing.Size(121, 20);
            this.TxtNumItems.TabIndex = 4;
            this.TxtNumItems.Text = "0";
            this.TxtNumItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(47, 189);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(92, 40);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 253);
            this.Controls.Add(this.TxtNumItems);
            this.Controls.Add(this.GBoxSurcharge);
            this.Controls.Add(this.CBoxCategory);
            this.Controls.Add(this.LblCategory);
            this.Controls.Add(this.LblNumItems);
            this.Controls.Add(this.CBoxShipMethod);
            this.Controls.Add(this.LblShipMethod);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.MnuStrip);
            this.MainMenuStrip = this.MnuStrip;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Red Fern Electronics";
            this.GBoxSurcharge.ResumeLayout(false);
            this.GBoxSurcharge.PerformLayout();
            this.MnuStrip.ResumeLayout(false);
            this.MnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Label LblShipMethod;
        private System.Windows.Forms.ComboBox CBoxShipMethod;
        private System.Windows.Forms.RadioButton RBtnSurchargeYes;
        private System.Windows.Forms.GroupBox GBoxSurcharge;
        private System.Windows.Forms.RadioButton RBtnSurchargeNo;
        private System.Windows.Forms.Label LblNumItems;
        private System.Windows.Forms.Label LblCategory;
        private System.Windows.Forms.ComboBox CBoxCategory;
        private System.Windows.Forms.MenuStrip MnuStrip;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.ToolStripMenuItem MnuExitItem;
        private System.Windows.Forms.ToolStripMenuItem MnuAboutItem;
        private System.Windows.Forms.ToolStripMenuItem MnuInstruc;
        private System.Windows.Forms.TextBox TxtNumItems;
        private System.Windows.Forms.Label LblSurcharge;
        private System.Windows.Forms.Button BtnExit;
    }
}

