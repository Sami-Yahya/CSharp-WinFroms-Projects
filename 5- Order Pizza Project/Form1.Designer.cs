namespace Pizza_Project
{
    partial class Form1
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
            this.lblHeadLine = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.gbEatPlace = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEatPlace = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lable6 = new System.Windows.Forms.Label();
            this.lable4 = new System.Windows.Forms.Label();
            this.lable3 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.gbQuantity = new System.Windows.Forms.GroupBox();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.gbSize.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbEatPlace.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            this.gbQuantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadLine
            // 
            this.lblHeadLine.AutoSize = true;
            this.lblHeadLine.Font = new System.Drawing.Font("Headline R", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblHeadLine.ForeColor = System.Drawing.Color.Red;
            this.lblHeadLine.Location = new System.Drawing.Point(244, 42);
            this.lblHeadLine.Name = "lblHeadLine";
            this.lblHeadLine.Size = new System.Drawing.Size(601, 55);
            this.lblHeadLine.TabIndex = 0;
            this.lblHeadLine.Text = "MAKE YOUR PIZZA";
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Location = new System.Drawing.Point(27, 135);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(179, 178);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(28, 128);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(65, 23);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "20";
            this.rbLarge.Text = "Larg";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbSize_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Checked = true;
            this.rbMedium.Location = new System.Drawing.Point(28, 87);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(90, 23);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "15";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbSize_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(28, 46);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(73, 23);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.Tag = "10";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSize_CheckedChanged);
            // 
            // gbCrust
            // 
            this.gbCrust.Controls.Add(this.rbThick);
            this.gbCrust.Controls.Add(this.rbThin);
            this.gbCrust.Location = new System.Drawing.Point(27, 349);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(179, 144);
            this.gbCrust.TabIndex = 2;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust Type";
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Location = new System.Drawing.Point(28, 87);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(114, 23);
            this.rbThick.TabIndex = 1;
            this.rbThick.TabStop = true;
            this.rbThick.Tag = "5";
            this.rbThick.Text = "Thick Crust";
            this.rbThick.UseVisualStyleBackColor = true;
            this.rbThick.CheckedChanged += new System.EventHandler(this.rbCrust_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Checked = true;
            this.rbThin.Location = new System.Drawing.Point(28, 46);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(108, 23);
            this.rbThin.TabIndex = 0;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "0";
            this.rbThin.Text = "Thin Crust";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbCrust_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chkGreenPeppers);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkExtraCheese);
            this.gbToppings.Location = new System.Drawing.Point(289, 135);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(349, 178);
            this.gbToppings.TabIndex = 3;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(191, 129);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(138, 23);
            this.chkGreenPeppers.TabIndex = 5;
            this.chkGreenPeppers.Tag = "2";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(191, 88);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(78, 23);
            this.chkOlives.TabIndex = 4;
            this.chkOlives.Tag = "2";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(191, 47);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(78, 23);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Tag = "2";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(27, 128);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(105, 23);
            this.chkTomatoes.TabIndex = 2;
            this.chkTomatoes.Tag = "2";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(27, 88);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(117, 23);
            this.chkMushrooms.TabIndex = 1;
            this.chkMushrooms.Tag = "2";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Location = new System.Drawing.Point(27, 46);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(126, 23);
            this.chkExtraCheese.TabIndex = 0;
            this.chkExtraCheese.Tag = "2";
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // gbEatPlace
            // 
            this.gbEatPlace.Controls.Add(this.rbTakeOut);
            this.gbEatPlace.Controls.Add(this.rbEatIn);
            this.gbEatPlace.Location = new System.Drawing.Point(289, 349);
            this.gbEatPlace.Name = "gbEatPlace";
            this.gbEatPlace.Size = new System.Drawing.Size(153, 116);
            this.gbEatPlace.TabIndex = 4;
            this.gbEatPlace.TabStop = false;
            this.gbEatPlace.Text = "Where to eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(18, 75);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(96, 23);
            this.rbTakeOut.TabIndex = 1;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbWhereToEat_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Checked = true;
            this.rbEatIn.Location = new System.Drawing.Point(18, 37);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(74, 23);
            this.rbEatIn.TabIndex = 0;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat in";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbWhereToEat_CheckedChanged);
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.Controls.Add(this.lblQuantity);
            this.gbOrderSummary.Controls.Add(this.label2);
            this.gbOrderSummary.Controls.Add(this.lblEatPlace);
            this.gbOrderSummary.Controls.Add(this.lblCrustType);
            this.gbOrderSummary.Controls.Add(this.lblToppings);
            this.gbOrderSummary.Controls.Add(this.lblSize);
            this.gbOrderSummary.Controls.Add(this.lblTotalPrice);
            this.gbOrderSummary.Controls.Add(this.lable6);
            this.gbOrderSummary.Controls.Add(this.lable4);
            this.gbOrderSummary.Controls.Add(this.lable3);
            this.gbOrderSummary.Controls.Add(this.lable2);
            this.gbOrderSummary.Controls.Add(this.label1);
            this.gbOrderSummary.Location = new System.Drawing.Point(721, 135);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(325, 391);
            this.gbOrderSummary.TabIndex = 5;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(174, 267);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(18, 19);
            this.lblQuantity.TabIndex = 11;
            this.lblQuantity.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quantity:";
            // 
            // lblEatPlace
            // 
            this.lblEatPlace.AutoSize = true;
            this.lblEatPlace.Location = new System.Drawing.Point(174, 224);
            this.lblEatPlace.Name = "lblEatPlace";
            this.lblEatPlace.Size = new System.Drawing.Size(49, 19);
            this.lblEatPlace.TabIndex = 9;
            this.lblEatPlace.Text = "Eat in";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Location = new System.Drawing.Point(155, 176);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(83, 19);
            this.lblCrustType.TabIndex = 8;
            this.lblCrustType.Text = "Thin Crust";
            // 
            // lblToppings
            // 
            this.lblToppings.Location = new System.Drawing.Point(35, 119);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(251, 48);
            this.lblToppings.TabIndex = 7;
            this.lblToppings.Text = "No Toppings";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(88, 46);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(65, 19);
            this.lblSize.TabIndex = 6;
            this.lblSize.Text = "Medium";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Green;
            this.lblTotalPrice.Location = new System.Drawing.Point(174, 311);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(93, 55);
            this.lblTotalPrice.TabIndex = 5;
            this.lblTotalPrice.Text = "$ 0";
            // 
            // lable6
            // 
            this.lable6.AutoSize = true;
            this.lable6.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable6.Location = new System.Drawing.Point(31, 311);
            this.lable6.Name = "lable6";
            this.lable6.Size = new System.Drawing.Size(104, 19);
            this.lable6.TabIndex = 4;
            this.lable6.Text = "Total Price:";
            // 
            // lable4
            // 
            this.lable4.AutoSize = true;
            this.lable4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable4.Location = new System.Drawing.Point(31, 224);
            this.lable4.Name = "lable4";
            this.lable4.Size = new System.Drawing.Size(122, 19);
            this.lable4.TabIndex = 3;
            this.lable4.Text = "Where to eat:";
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable3.Location = new System.Drawing.Point(31, 176);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(103, 19);
            this.lable3.TabIndex = 2;
            this.lable3.Text = "Crust Type:";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable2.Location = new System.Drawing.Point(31, 91);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(89, 19);
            this.lable2.TabIndex = 1;
            this.lable2.Text = "Toppings:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size:";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(495, 509);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(143, 49);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(289, 509);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(143, 49);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.Text = "Order Pizza";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // gbQuantity
            // 
            this.gbQuantity.Controls.Add(this.numericQuantity);
            this.gbQuantity.Location = new System.Drawing.Point(485, 349);
            this.gbQuantity.Name = "gbQuantity";
            this.gbQuantity.Size = new System.Drawing.Size(153, 116);
            this.gbQuantity.TabIndex = 8;
            this.gbQuantity.TabStop = false;
            this.gbQuantity.Text = "How many pizza do you want?";
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(27, 64);
            this.numericQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(100, 27);
            this.numericQuantity.TabIndex = 0;
            this.numericQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuantity.ValueChanged += new System.EventHandler(this.numericQuantity_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 599);
            this.Controls.Add(this.gbQuantity);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.gbEatPlace);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.lblHeadLine);
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbEatPlace.ResumeLayout(false);
            this.gbEatPlace.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.gbQuantity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeadLine;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.GroupBox gbEatPlace;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable6;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblEatPlace;
        private System.Windows.Forms.Label lable4;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbQuantity;
        private System.Windows.Forms.NumericUpDown numericQuantity;
    }
}

