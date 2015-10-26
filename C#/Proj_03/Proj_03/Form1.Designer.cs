namespace Proj_03
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
            this.LblDepartTime = new System.Windows.Forms.Label();
            this.TxtDepartureTime = new System.Windows.Forms.TextBox();
            this.LblArrivalTime = new System.Windows.Forms.Label();
            this.TxtArrivalTime = new System.Windows.Forms.TextBox();
            this.LblTravelTime = new System.Windows.Forms.Label();
            this.TxtTravelTime = new System.Windows.Forms.TextBox();
            this.LblExtArrivalTime = new System.Windows.Forms.Label();
            this.TxtExtArrivalTime = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.MnuStrip = new System.Windows.Forms.MenuStrip();
            this.MnuStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStripExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStripAboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStripInstructions = new System.Windows.Forms.ToolStripMenuItem();
            this.PBDelivery = new System.Windows.Forms.PictureBox();
            this.MnuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBDelivery)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(274, 146);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 5;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // LblDepartTime
            // 
            this.LblDepartTime.AutoSize = true;
            this.LblDepartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDepartTime.Location = new System.Drawing.Point(45, 91);
            this.LblDepartTime.Name = "LblDepartTime";
            this.LblDepartTime.Size = new System.Drawing.Size(98, 13);
            this.LblDepartTime.TabIndex = 1;
            this.LblDepartTime.Text = "Departure Time:";
            // 
            // TxtDepartureTime
            // 
            this.TxtDepartureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDepartureTime.Location = new System.Drawing.Point(149, 88);
            this.TxtDepartureTime.Name = "TxtDepartureTime";
            this.TxtDepartureTime.Size = new System.Drawing.Size(100, 20);
            this.TxtDepartureTime.TabIndex = 1;
            this.TxtDepartureTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtDepartureTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDepartureTime_KeyDown);
            // 
            // LblArrivalTime
            // 
            this.LblArrivalTime.AutoSize = true;
            this.LblArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArrivalTime.Location = new System.Drawing.Point(63, 122);
            this.LblArrivalTime.Name = "LblArrivalTime";
            this.LblArrivalTime.Size = new System.Drawing.Size(78, 13);
            this.LblArrivalTime.TabIndex = 1;
            this.LblArrivalTime.Text = "Arrival Time:";
            // 
            // TxtArrivalTime
            // 
            this.TxtArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtArrivalTime.Location = new System.Drawing.Point(149, 119);
            this.TxtArrivalTime.Name = "TxtArrivalTime";
            this.TxtArrivalTime.Size = new System.Drawing.Size(100, 20);
            this.TxtArrivalTime.TabIndex = 2;
            this.TxtArrivalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtArrivalTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtArrivalTime_KeyDown);
            // 
            // LblTravelTime
            // 
            this.LblTravelTime.AutoSize = true;
            this.LblTravelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTravelTime.Location = new System.Drawing.Point(61, 156);
            this.LblTravelTime.Name = "LblTravelTime";
            this.LblTravelTime.Size = new System.Drawing.Size(82, 13);
            this.LblTravelTime.TabIndex = 1;
            this.LblTravelTime.Text = "Travel Time: ";
            // 
            // TxtTravelTime
            // 
            this.TxtTravelTime.Enabled = false;
            this.TxtTravelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTravelTime.Location = new System.Drawing.Point(149, 153);
            this.TxtTravelTime.Name = "TxtTravelTime";
            this.TxtTravelTime.Size = new System.Drawing.Size(100, 20);
            this.TxtTravelTime.TabIndex = 3;
            this.TxtTravelTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblExtArrivalTime
            // 
            this.LblExtArrivalTime.AutoSize = true;
            this.LblExtArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExtArrivalTime.Location = new System.Drawing.Point(6, 181);
            this.LblExtArrivalTime.Name = "LblExtArrivalTime";
            this.LblExtArrivalTime.Size = new System.Drawing.Size(139, 13);
            this.LblExtArrivalTime.TabIndex = 1;
            this.LblExtArrivalTime.Text = "Extended Arrival Time: ";
            // 
            // TxtExtArrivalTime
            // 
            this.TxtExtArrivalTime.Enabled = false;
            this.TxtExtArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtExtArrivalTime.Location = new System.Drawing.Point(149, 178);
            this.TxtExtArrivalTime.Name = "TxtExtArrivalTime";
            this.TxtExtArrivalTime.Size = new System.Drawing.Size(100, 20);
            this.TxtExtArrivalTime.TabIndex = 4;
            this.TxtExtArrivalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(274, 175);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // MnuStrip
            // 
            this.MnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuStripExit,
            this.MnuStripInstructions});
            this.MnuStrip.Location = new System.Drawing.Point(0, 0);
            this.MnuStrip.Name = "MnuStrip";
            this.MnuStrip.Size = new System.Drawing.Size(409, 24);
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
            // PBDelivery
            // 
            this.PBDelivery.Image = global::Proj_03.Properties.Resources._6Tp6REnyc;
            this.PBDelivery.Location = new System.Drawing.Point(12, 204);
            this.PBDelivery.Name = "PBDelivery";
            this.PBDelivery.Size = new System.Drawing.Size(383, 331);
            this.PBDelivery.TabIndex = 4;
            this.PBDelivery.TabStop = false;
            this.PBDelivery.Click += new System.EventHandler(this.PicDeliveryBox_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 547);
            this.Controls.Add(this.PBDelivery);
            this.Controls.Add(this.TxtExtArrivalTime);
            this.Controls.Add(this.TxtTravelTime);
            this.Controls.Add(this.TxtArrivalTime);
            this.Controls.Add(this.LblExtArrivalTime);
            this.Controls.Add(this.LblTravelTime);
            this.Controls.Add(this.TxtDepartureTime);
            this.Controls.Add(this.LblArrivalTime);
            this.Controls.Add(this.LblDepartTime);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.MnuStrip);
            this.MainMenuStrip = this.MnuStrip;
            this.Name = "FrmMain";
            this.Text = "Project 03";
            this.MnuStrip.ResumeLayout(false);
            this.MnuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBDelivery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Label LblDepartTime;
        private System.Windows.Forms.TextBox TxtDepartureTime;
        private System.Windows.Forms.Label LblArrivalTime;
        private System.Windows.Forms.TextBox TxtArrivalTime;
        private System.Windows.Forms.Label LblTravelTime;
        private System.Windows.Forms.TextBox TxtTravelTime;
        private System.Windows.Forms.Label LblExtArrivalTime;
        private System.Windows.Forms.TextBox TxtExtArrivalTime;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.MenuStrip MnuStrip;
        private System.Windows.Forms.ToolStripMenuItem MnuStripExit;
        private System.Windows.Forms.ToolStripMenuItem MnuStripExitItem;
        private System.Windows.Forms.ToolStripMenuItem MnuStripAboutItem;
        private System.Windows.Forms.ToolStripMenuItem MnuStripInstructions;
        private System.Windows.Forms.PictureBox PBDelivery;
    }
}

