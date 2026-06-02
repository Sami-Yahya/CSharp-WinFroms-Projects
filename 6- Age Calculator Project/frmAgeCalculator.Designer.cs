namespace Age_Calculator_Project
{
    partial class frmAgeCalculator
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
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblYearLable = new System.Windows.Forms.Label();
            this.lblMonthLable = new System.Windows.Forms.Label();
            this.lblWeekLable = new System.Windows.Forms.Label();
            this.lblDayLable = new System.Windows.Forms.Label();
            this.lblHourLable = new System.Windows.Forms.Label();
            this.lblMinutesLable = new System.Windows.Forms.Label();
            this.lblSecondsLable = new System.Windows.Forms.Label();
            this.lblAgeLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CustomFormat = "";
            this.dtpBirthday.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dtpBirthday.Location = new System.Drawing.Point(217, 92);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(337, 36);
            this.dtpBirthday.TabIndex = 0;
            this.dtpBirthday.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(255, 32);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(261, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "أدخل تاريخ ميلادك:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(422, 165);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "عمرك بالسنوات:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(433, 212);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(164, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "عمرك بالشهور:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(423, 259);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(174, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "عمرك بالأسابيع:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(455, 306);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(142, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "عمرك بالأيام:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(419, 353);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(178, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "عمرك بالساعات:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(433, 400);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(164, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "عمرك بالدقائق:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(435, 447);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(162, 29);
            this.label8.TabIndex = 8;
            this.label8.Text = "عمرك بالثواني:";
            // 
            // lblYearLable
            // 
            this.lblYearLable.AutoSize = true;
            this.lblYearLable.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblYearLable.ForeColor = System.Drawing.Color.Yellow;
            this.lblYearLable.Location = new System.Drawing.Point(181, 165);
            this.lblYearLable.Name = "lblYearLable";
            this.lblYearLable.Size = new System.Drawing.Size(26, 29);
            this.lblYearLable.TabIndex = 9;
            this.lblYearLable.Text = "0";
            // 
            // lblMonthLable
            // 
            this.lblMonthLable.AutoSize = true;
            this.lblMonthLable.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblMonthLable.ForeColor = System.Drawing.Color.Yellow;
            this.lblMonthLable.Location = new System.Drawing.Point(181, 212);
            this.lblMonthLable.Name = "lblMonthLable";
            this.lblMonthLable.Size = new System.Drawing.Size(26, 29);
            this.lblMonthLable.TabIndex = 10;
            this.lblMonthLable.Text = "0";
            // 
            // lblWeekLable
            // 
            this.lblWeekLable.AutoSize = true;
            this.lblWeekLable.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblWeekLable.ForeColor = System.Drawing.Color.Yellow;
            this.lblWeekLable.Location = new System.Drawing.Point(181, 259);
            this.lblWeekLable.Name = "lblWeekLable";
            this.lblWeekLable.Size = new System.Drawing.Size(26, 29);
            this.lblWeekLable.TabIndex = 11;
            this.lblWeekLable.Text = "0";
            // 
            // lblDayLable
            // 
            this.lblDayLable.AutoSize = true;
            this.lblDayLable.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblDayLable.ForeColor = System.Drawing.Color.Yellow;
            this.lblDayLable.Location = new System.Drawing.Point(181, 306);
            this.lblDayLable.Name = "lblDayLable";
            this.lblDayLable.Size = new System.Drawing.Size(26, 29);
            this.lblDayLable.TabIndex = 12;
            this.lblDayLable.Text = "0";
            // 
            // lblHourLable
            // 
            this.lblHourLable.AutoSize = true;
            this.lblHourLable.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblHourLable.ForeColor = System.Drawing.Color.Yellow;
            this.lblHourLable.Location = new System.Drawing.Point(181, 353);
            this.lblHourLable.Name = "lblHourLable";
            this.lblHourLable.Size = new System.Drawing.Size(26, 29);
            this.lblHourLable.TabIndex = 13;
            this.lblHourLable.Text = "0";
            // 
            // lblMinutesLable
            // 
            this.lblMinutesLable.AutoSize = true;
            this.lblMinutesLable.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblMinutesLable.ForeColor = System.Drawing.Color.Yellow;
            this.lblMinutesLable.Location = new System.Drawing.Point(181, 400);
            this.lblMinutesLable.Name = "lblMinutesLable";
            this.lblMinutesLable.Size = new System.Drawing.Size(26, 29);
            this.lblMinutesLable.TabIndex = 14;
            this.lblMinutesLable.Text = "0";
            // 
            // lblSecondsLable
            // 
            this.lblSecondsLable.AutoSize = true;
            this.lblSecondsLable.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblSecondsLable.ForeColor = System.Drawing.Color.Yellow;
            this.lblSecondsLable.Location = new System.Drawing.Point(181, 447);
            this.lblSecondsLable.Name = "lblSecondsLable";
            this.lblSecondsLable.Size = new System.Drawing.Size(26, 29);
            this.lblSecondsLable.TabIndex = 15;
            this.lblSecondsLable.Text = "0";
            // 
            // lblAgeLine
            // 
            this.lblAgeLine.AutoSize = true;
            this.lblAgeLine.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblAgeLine.ForeColor = System.Drawing.Color.Yellow;
            this.lblAgeLine.Location = new System.Drawing.Point(213, 527);
            this.lblAgeLine.Name = "lblAgeLine";
            this.lblAgeLine.Size = new System.Drawing.Size(345, 29);
            this.lblAgeLine.TabIndex = 16;
            this.lblAgeLine.Text = "عمرك هو: 0 سنة، 0 شهر، 0 يوم";
            // 
            // frmAgeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(776, 603);
            this.Controls.Add(this.lblAgeLine);
            this.Controls.Add(this.lblSecondsLable);
            this.Controls.Add(this.lblMinutesLable);
            this.Controls.Add(this.lblHourLable);
            this.Controls.Add(this.lblDayLable);
            this.Controls.Add(this.lblWeekLable);
            this.Controls.Add(this.lblMonthLable);
            this.Controls.Add(this.lblYearLable);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpBirthday);
            this.Name = "frmAgeCalculator";
            this.Text = "Age Calculator";
            this.Load += new System.EventHandler(this.frmAgeCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblYearLable;
        private System.Windows.Forms.Label lblMonthLable;
        private System.Windows.Forms.Label lblWeekLable;
        private System.Windows.Forms.Label lblDayLable;
        private System.Windows.Forms.Label lblHourLable;
        private System.Windows.Forms.Label lblMinutesLable;
        private System.Windows.Forms.Label lblSecondsLable;
        private System.Windows.Forms.Label lblAgeLine;
    }
}

