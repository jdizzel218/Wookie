namespace Proj_05
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
            this.BtnClear = new System.Windows.Forms.Button();
            this.LblNumItems = new System.Windows.Forms.Label();
            this.TxtNumItems = new System.Windows.Forms.TextBox();
            this.BtnBuy = new System.Windows.Forms.Button();
            this.LblUnitPrice = new System.Windows.Forms.Label();
            this.TxtUnitPrice = new System.Windows.Forms.TextBox();
            this.Mnu = new System.Windows.Forms.MenuStrip();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuInstructions = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnExit = new System.Windows.Forms.Button();
            this.Mnu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(97, 172);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // LblNumItems
            // 
            this.LblNumItems.AutoSize = true;
            this.LblNumItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumItems.Location = new System.Drawing.Point(28, 65);
            this.LblNumItems.Name = "LblNumItems";
            this.LblNumItems.Size = new System.Drawing.Size(103, 13);
            this.LblNumItems.TabIndex = 1;
            this.LblNumItems.Text = "Number of Items:";
            // 
            // TxtNumItems
            // 
            this.TxtNumItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumItems.Location = new System.Drawing.Point(137, 65);
            this.TxtNumItems.Name = "TxtNumItems";
            this.TxtNumItems.Size = new System.Drawing.Size(100, 20);
            this.TxtNumItems.TabIndex = 0;
            this.TxtNumItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnBuy
            // 
            this.BtnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuy.Location = new System.Drawing.Point(97, 143);
            this.BtnBuy.Name = "BtnBuy";
            this.BtnBuy.Size = new System.Drawing.Size(75, 23);
            this.BtnBuy.TabIndex = 2;
            this.BtnBuy.Text = "Buy";
            this.BtnBuy.UseVisualStyleBackColor = true;
            this.BtnBuy.Click += new System.EventHandler(this.BtnBuy_Click);
            // 
            // LblUnitPrice
            // 
            this.LblUnitPrice.AutoSize = true;
            this.LblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUnitPrice.Location = new System.Drawing.Point(60, 91);
            this.LblUnitPrice.Name = "LblUnitPrice";
            this.LblUnitPrice.Size = new System.Drawing.Size(71, 13);
            this.LblUnitPrice.TabIndex = 1;
            this.LblUnitPrice.Text = "Unit Price: ";
            // 
            // TxtUnitPrice
            // 
            this.TxtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUnitPrice.Location = new System.Drawing.Point(137, 88);
            this.TxtUnitPrice.Name = "TxtUnitPrice";
            this.TxtUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.TxtUnitPrice.TabIndex = 1;
            this.TxtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtUnitPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtUnitPrice_KeyDown);
            // 
            // Mnu
            // 
            this.Mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuExit,
            this.MnuInstructions});
            this.Mnu.Location = new System.Drawing.Point(0, 0);
            this.Mnu.Name = "Mnu";
            this.Mnu.Size = new System.Drawing.Size(284, 24);
            this.Mnu.TabIndex = 3;
            this.Mnu.Text = "menuStrip1";
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
            // MnuInstructions
            // 
            this.MnuInstructions.Name = "MnuInstructions";
            this.MnuInstructions.Size = new System.Drawing.Size(81, 20);
            this.MnuInstructions.Text = "Instructions";
            this.MnuInstructions.Click += new System.EventHandler(this.MnuInstructions_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(97, 201);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TxtUnitPrice);
            this.Controls.Add(this.LblUnitPrice);
            this.Controls.Add(this.TxtNumItems);
            this.Controls.Add(this.LblNumItems);
            this.Controls.Add(this.BtnBuy);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.Mnu);
            this.MainMenuStrip = this.Mnu;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Invoice";
            this.Mnu.ResumeLayout(false);
            this.Mnu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label LblNumItems;
        private System.Windows.Forms.TextBox TxtNumItems;
        private System.Windows.Forms.Button BtnBuy;
        private System.Windows.Forms.Label LblUnitPrice;
        private System.Windows.Forms.TextBox TxtUnitPrice;
        private System.Windows.Forms.MenuStrip Mnu;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.ToolStripMenuItem MnuExitItem;
        private System.Windows.Forms.ToolStripMenuItem MnuAboutItem;
        private System.Windows.Forms.ToolStripMenuItem MnuInstructions;
        private System.Windows.Forms.Button BtnExit;
    }
}

