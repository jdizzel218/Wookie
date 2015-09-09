namespace Proj_01
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
            this.TxtBoxResult = new System.Windows.Forms.TextBox();
            this.LblResult = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.TxtBoxLeftOpt = new System.Windows.Forms.TextBox();
            this.LblLeftOp = new System.Windows.Forms.Label();
            this.TxtBoxRightOp = new System.Windows.Forms.TextBox();
            this.LblRightOp = new System.Windows.Forms.Label();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.BtnMul = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBoxResult
            // 
            this.TxtBoxResult.Location = new System.Drawing.Point(197, 178);
            this.TxtBoxResult.Name = "TxtBoxResult";
            this.TxtBoxResult.Size = new System.Drawing.Size(75, 20);
            this.TxtBoxResult.TabIndex = 1;
            this.TxtBoxResult.Text = "0.0";
            this.TxtBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResult.Location = new System.Drawing.Point(194, 162);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(43, 13);
            this.LblResult.TabIndex = 2;
            this.LblResult.Text = "Result";
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(12, 217);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(197, 217);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // TxtBoxLeftOpt
            // 
            this.TxtBoxLeftOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxLeftOpt.Location = new System.Drawing.Point(12, 25);
            this.TxtBoxLeftOpt.Name = "TxtBoxLeftOpt";
            this.TxtBoxLeftOpt.Size = new System.Drawing.Size(75, 35);
            this.TxtBoxLeftOpt.TabIndex = 1;
            this.TxtBoxLeftOpt.Text = "0.0";
            this.TxtBoxLeftOpt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblLeftOp
            // 
            this.LblLeftOp.AutoSize = true;
            this.LblLeftOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLeftOp.Location = new System.Drawing.Point(9, 9);
            this.LblLeftOp.Name = "LblLeftOp";
            this.LblLeftOp.Size = new System.Drawing.Size(81, 13);
            this.LblLeftOp.TabIndex = 2;
            this.LblLeftOp.Text = "Left Operand";
            // 
            // TxtBoxRightOp
            // 
            this.TxtBoxRightOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxRightOp.Location = new System.Drawing.Point(185, 25);
            this.TxtBoxRightOp.Name = "TxtBoxRightOp";
            this.TxtBoxRightOp.Size = new System.Drawing.Size(87, 35);
            this.TxtBoxRightOp.TabIndex = 1;
            this.TxtBoxRightOp.Text = "0.0";
            this.TxtBoxRightOp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblRightOp
            // 
            this.LblRightOp.AutoSize = true;
            this.LblRightOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRightOp.Location = new System.Drawing.Point(182, 9);
            this.LblRightOp.Name = "LblRightOp";
            this.LblRightOp.Size = new System.Drawing.Size(89, 13);
            this.LblRightOp.TabIndex = 2;
            this.LblRightOp.Text = "Right Operand";
            // 
            // BtnPlus
            // 
            this.BtnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlus.Location = new System.Drawing.Point(245, 66);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(27, 32);
            this.BtnPlus.TabIndex = 3;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // BtnMinus
            // 
            this.BtnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinus.Location = new System.Drawing.Point(244, 104);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(27, 26);
            this.BtnMinus.TabIndex = 3;
            this.BtnMinus.Text = "-";
            this.BtnMinus.UseVisualStyleBackColor = true;
            this.BtnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // BtnMul
            // 
            this.BtnMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMul.Location = new System.Drawing.Point(12, 75);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Size = new System.Drawing.Size(27, 23);
            this.BtnMul.TabIndex = 3;
            this.BtnMul.Text = "*";
            this.BtnMul.UseVisualStyleBackColor = true;
            this.BtnMul.Click += new System.EventHandler(this.BtnMul_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiv.Location = new System.Drawing.Point(12, 104);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(27, 36);
            this.BtnDiv.TabIndex = 3;
            this.BtnDiv.Text = "/";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.BtnMul);
            this.Controls.Add(this.BtnMinus);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LblRightOp);
            this.Controls.Add(this.TxtBoxRightOp);
            this.Controls.Add(this.LblLeftOp);
            this.Controls.Add(this.TxtBoxLeftOpt);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.TxtBoxResult);
            this.Name = "FrmMain";
            this.Text = "Quackulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBoxResult;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.TextBox TxtBoxLeftOpt;
        private System.Windows.Forms.Label LblLeftOp;
        private System.Windows.Forms.TextBox TxtBoxRightOp;
        private System.Windows.Forms.Label LblRightOp;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Button BtnDiv;
    }
}

