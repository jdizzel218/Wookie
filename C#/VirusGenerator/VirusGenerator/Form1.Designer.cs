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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGen
            // 
            this.BtnGen.Location = new System.Drawing.Point(603, 400);
            this.BtnGen.Name = "BtnGen";
            this.BtnGen.Size = new System.Drawing.Size(157, 44);
            this.BtnGen.TabIndex = 0;
            this.BtnGen.Text = "Generate";
            this.BtnGen.UseVisualStyleBackColor = true;
            this.BtnGen.Click += new System.EventHandler(this.button1_Click);
            // 
            // CBoxFor
            // 
            this.CBoxFor.FormattingEnabled = true;
            this.CBoxFor.Items.AddRange(new object[] {
            ".exe",
            ".bat"});
            this.CBoxFor.Location = new System.Drawing.Point(639, 59);
            this.CBoxFor.Name = "CBoxFor";
            this.CBoxFor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CBoxFor.Size = new System.Drawing.Size(121, 21);
            this.CBoxFor.TabIndex = 1;
            this.CBoxFor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnFormat
            // 
            this.BtnFormat.AutoSize = true;
            this.BtnFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFormat.Location = new System.Drawing.Point(635, 32);
            this.BtnFormat.Name = "BtnFormat";
            this.BtnFormat.Size = new System.Drawing.Size(69, 24);
            this.BtnFormat.TabIndex = 2;
            this.BtnFormat.Text = "Format";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 479);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(772, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // Troy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 501);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BtnFormat);
            this.Controls.Add(this.CBoxFor);
            this.Controls.Add(this.BtnGen);
            this.Name = "Troy";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Troy";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGen;
        private System.Windows.Forms.ComboBox CBoxFor;
        private System.Windows.Forms.Label BtnFormat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}

