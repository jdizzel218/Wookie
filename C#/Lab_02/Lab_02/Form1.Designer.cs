namespace Lab_02
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
            this.PBox = new System.Windows.Forms.PictureBox();
            this.LblFun = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PBox
            // 
            this.PBox.Image = global::Lab_02.Properties.Resources.thumbs;
            this.PBox.Location = new System.Drawing.Point(12, 132);
            this.PBox.Name = "PBox";
            this.PBox.Size = new System.Drawing.Size(207, 206);
            this.PBox.TabIndex = 0;
            this.PBox.TabStop = false;
            // 
            // LblFun
            // 
            this.LblFun.AutoSize = true;
            this.LblFun.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFun.Location = new System.Drawing.Point(12, 9);
            this.LblFun.Name = "LblFun";
            this.LblFun.Size = new System.Drawing.Size(374, 45);
            this.LblFun.TabIndex = 1;
            this.LblFun.Text = "Programming in C# is fun!";
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(267, 287);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 365);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LblFun);
            this.Controls.Add(this.PBox);
            this.Name = "FrmMain";
            this.Text = "MLC Lab 2";
            ((System.ComponentModel.ISupportInitialize)(this.PBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBox;
        private System.Windows.Forms.Label LblFun;
        private System.Windows.Forms.Button BtnExit;
    }
}

