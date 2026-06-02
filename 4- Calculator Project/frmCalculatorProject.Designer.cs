namespace Calculator_Project
{
    partial class frmCalculatorProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculatorProject));
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.txtExpression = new System.Windows.Forms.TextBox();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.lblFullExpression = new System.Windows.Forms.Label();
            this.btnPower = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Tahoma", 14F);
            this.button0.Location = new System.Drawing.Point(156, 577);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(120, 80);
            this.button0.TabIndex = 0;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Font = new System.Drawing.Font("Tahoma", 14F);
            this.buttonDot.Location = new System.Drawing.Point(300, 577);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(120, 80);
            this.buttonDot.TabIndex = 10;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonEqual.Font = new System.Drawing.Font("Tahoma", 14F);
            this.buttonEqual.ForeColor = System.Drawing.Color.White;
            this.buttonEqual.Location = new System.Drawing.Point(444, 577);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(120, 80);
            this.buttonEqual.TabIndex = 12;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonPlus.Font = new System.Drawing.Font("Tahoma", 14F);
            this.buttonPlus.ForeColor = System.Drawing.Color.White;
            this.buttonPlus.Location = new System.Drawing.Point(444, 473);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(120, 80);
            this.buttonPlus.TabIndex = 13;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.button3.Location = new System.Drawing.Point(300, 473);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 80);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.button2.Location = new System.Drawing.Point(156, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 80);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.button1.Location = new System.Drawing.Point(12, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 80);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonSubtract.Font = new System.Drawing.Font("Tahoma", 14F);
            this.buttonSubtract.ForeColor = System.Drawing.Color.White;
            this.buttonSubtract.Location = new System.Drawing.Point(444, 368);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(120, 80);
            this.buttonSubtract.TabIndex = 14;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = false;
            this.buttonSubtract.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Tahoma", 14F);
            this.button6.Location = new System.Drawing.Point(300, 368);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 80);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 14F);
            this.button5.Location = new System.Drawing.Point(156, 368);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 80);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 14F);
            this.button4.Location = new System.Drawing.Point(12, 368);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 80);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonMultiply.Font = new System.Drawing.Font("Tahoma", 14F);
            this.buttonMultiply.ForeColor = System.Drawing.Color.White;
            this.buttonMultiply.Location = new System.Drawing.Point(444, 265);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(120, 80);
            this.buttonMultiply.TabIndex = 15;
            this.buttonMultiply.Text = "×";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Tahoma", 14F);
            this.button9.Location = new System.Drawing.Point(300, 265);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 80);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Tahoma", 14F);
            this.button8.Location = new System.Drawing.Point(156, 265);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 80);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Tahoma", 14F);
            this.button7.Location = new System.Drawing.Point(12, 265);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 80);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // txtExpression
            // 
            this.txtExpression.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExpression.Cursor = System.Windows.Forms.Cursors.No;
            this.txtExpression.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtExpression.Location = new System.Drawing.Point(73, 63);
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.ReadOnly = true;
            this.txtExpression.Size = new System.Drawing.Size(408, 41);
            this.txtExpression.TabIndex = 20;
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonDivide.Font = new System.Drawing.Font("Tahoma", 14F);
            this.buttonDivide.ForeColor = System.Drawing.Color.White;
            this.buttonDivide.Location = new System.Drawing.Point(444, 163);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(120, 80);
            this.buttonDivide.TabIndex = 16;
            this.buttonDivide.Text = "÷";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(12, 163);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 80);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnBackspace.ForeColor = System.Drawing.Color.Black;
            this.btnBackspace.Image = global::Calculator_Project.Properties.Resources.backspace_64_64;
            this.btnBackspace.Location = new System.Drawing.Point(156, 163);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(120, 80);
            this.btnBackspace.TabIndex = 18;
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnPlusMinus.Location = new System.Drawing.Point(12, 577);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(120, 80);
            this.btnPlusMinus.TabIndex = 11;
            this.btnPlusMinus.Text = "+/-";
            this.btnPlusMinus.UseVisualStyleBackColor = true;
            this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_Click);
            // 
            // lblFullExpression
            // 
            this.lblFullExpression.AutoSize = true;
            this.lblFullExpression.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblFullExpression.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFullExpression.Location = new System.Drawing.Point(12, 9);
            this.lblFullExpression.Name = "lblFullExpression";
            this.lblFullExpression.Size = new System.Drawing.Size(0, 24);
            this.lblFullExpression.TabIndex = 21;
            // 
            // btnPower
            // 
            this.btnPower.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPower.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnPower.ForeColor = System.Drawing.Color.White;
            this.btnPower.Location = new System.Drawing.Point(300, 163);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(120, 80);
            this.btnPower.TabIndex = 17;
            this.btnPower.Text = "^";
            this.btnPower.UseVisualStyleBackColor = false;
            this.btnPower.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // frmCalculatorProject
            // 
            this.AcceptButton = this.buttonEqual;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 669);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.lblFullExpression);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.txtExpression);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.button0);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmCalculatorProject";
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCalculatorProject_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtExpression;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Label lblFullExpression;
        private System.Windows.Forms.Button btnPower;
    }
}

