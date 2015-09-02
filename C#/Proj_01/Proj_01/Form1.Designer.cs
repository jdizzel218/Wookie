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
            this.TxtBoxLeftOp = new System.Windows.Forms.TextBox();
            this.LblLeftOp = new System.Windows.Forms.Label();
            this.TxtBoxRightOp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.BtnMul = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.TxtBoxResult = new System.Windows.Forms.TextBox();
            this.LblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtBoxLeftOp
            // 
            this.TxtBoxLeftOp.Location = new System.Drawing.Point(53, 176);
            this.TxtBoxLeftOp.Name = "TxtBoxLeftOp";
            this.TxtBoxLeftOp.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxLeftOp.TabIndex = 0;
            this.TxtBoxLeftOp.Text = "0.0";
            this.TxtBoxLeftOp.TextChanged += new System.EventHandler(this.TxtBoxLeftOp_TextChanged);
            // 
            // LblLeftOp
            // 
            this.LblLeftOp.AutoSize = true;
            this.LblLeftOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLeftOp.Location = new System.Drawing.Point(50, 160);
            this.LblLeftOp.Name = "LblLeftOp";
            this.LblLeftOp.Size = new System.Drawing.Size(81, 13);
            this.LblLeftOp.TabIndex = 1;
            this.LblLeftOp.Text = "Left Operand";
            // 
            // TxtBoxRightOp
            // 
            this.TxtBoxRightOp.Location = new System.Drawing.Point(276, 176);
            this.TxtBoxRightOp.Name = "TxtBoxRightOp";
            this.TxtBoxRightOp.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxRightOp.TabIndex = 0;
            this.TxtBoxRightOp.Text = "0.0";
            this.TxtBoxRightOp.TextChanged += new System.EventHandler(this.TxtBoxRightOp_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Right Operand";
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(467, 160);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(467, 129);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.Location = new System.Drawing.Point(160, 176);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(22, 23);
            this.BtnPlus.TabIndex = 4;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // BtnMinus
            // 
            this.BtnMinus.Location = new System.Drawing.Point(188, 176);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(22, 23);
            this.BtnMinus.TabIndex = 4;
            this.BtnMinus.Text = "-";
            this.BtnMinus.UseVisualStyleBackColor = true;
            this.BtnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // BtnMul
            // 
            this.BtnMul.Location = new System.Drawing.Point(216, 176);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Size = new System.Drawing.Size(22, 23);
            this.BtnMul.TabIndex = 4;
            this.BtnMul.Text = "*";
            this.BtnMul.UseVisualStyleBackColor = true;
            this.BtnMul.Click += new System.EventHandler(this.BtnMul_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.Location = new System.Drawing.Point(244, 176);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(22, 23);
            this.BtnDiv.TabIndex = 4;
            this.BtnDiv.Text = "/";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // TxtBoxResult
            // 
            this.TxtBoxResult.Location = new System.Drawing.Point(442, 213);
            this.TxtBoxResult.Name = "TxtBoxResult";
            this.TxtBoxResult.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxResult.TabIndex = 0;
            this.TxtBoxResult.Text = "0.0";
            this.TxtBoxResult.TextChanged += new System.EventHandler(this.TxtBoxResult_TextChanged);
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResult.Location = new System.Drawing.Point(439, 197);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(43, 13);
            this.LblResult.TabIndex = 1;
            this.LblResult.Text = "Result";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 253);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.BtnMul);
            this.Controls.Add(this.BtnMinus);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBoxResult);
            this.Controls.Add(this.LblLeftOp);
            this.Controls.Add(this.TxtBoxRightOp);
            this.Controls.Add(this.TxtBoxLeftOp);
            this.Name = "FrmMain";
            this.Text = "Quackulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBoxLeftOp;
        private System.Windows.Forms.Label LblLeftOp;
        private System.Windows.Forms.TextBox TxtBoxRightOp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.TextBox TxtBoxResult;
        private System.Windows.Forms.Label LblResult;
    }
}

