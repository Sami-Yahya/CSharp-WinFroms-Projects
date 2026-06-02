using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmall.Checked) 
            {
                lblSize.Text = "Small";
                return;
            }

            if (rbMedium.Checked)
            {
                lblSize.Text = "Medium";
                return;
            }

            if (rbLarge.Checked)
            {
                lblSize.Text = "Large";
                return;
            }
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rbThin.Checked)
            {
                lblCrustType.Text = "Thin Crust";
                return;
            }

            if (rbThick.Checked)
            {
                lblCrustType.Text = "Thick Crust";
                return;
            }
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();
            string sToppings = "";

            if (chkExtraCheese.Checked)
            {
                sToppings = "Extra Cheese";
            }

            if (chkOnion.Checked)
            {
                sToppings += ", Onion";
            }

            if (chkMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }

            if (chkOlives.Checked)
            {
                sToppings += ", Olives";
            }

            if (chkTomatoes.Checked)
            {
                sToppings += ", Tomatoes";
            }

            if (chkGreenPeppers.Checked)
            {
                sToppings += ", Green Peppers";
            }

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if (sToppings == "")
                sToppings = "No Toppings";

            lblToppings.Text = sToppings;
        }

        void UpdateWhereToEat()
        {
            UpdateTotalPrice();

            if (rbEatIn.Checked)
            {
                lblEatPlace.Text = "Eat In.";
                return;
            }

            if (rbTakeOut.Checked)
            {
                lblEatPlace.Text = "Take Out.";
                return;
            }
        }

        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);

            else if (rbMedium.Checked)
                return Convert.ToSingle(rbMedium.Tag);

            else
                return Convert.ToSingle(rbLarge.Tag);
        }

        float CalculateToppingsPrice()
        {
            float ToppingsTotalPrice = 0;

            if (chkExtraCheese.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkExtraCheese.Tag);
            }

            if (chkOnion.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOnion.Tag);
            }

            if (chkMushrooms.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkOlives.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkTomatoes.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkTomatoes.Tag);
            }

            if (chkGreenPeppers.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkGreenPeppers.Tag);
            }

            return ToppingsTotalPrice;
        }

        float GetSelectedCrustPrice()
        {
            if (rbThin.Checked)
                return Convert.ToSingle(rbThin.Tag);

            else
                return Convert.ToSingle(rbThick.Tag);
        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrustPrice();
        }

        void UpdateTotalPrice()
        {
            float Quantity = Convert.ToSingle(numericQuantity.Value) * CalculateTotalPrice();
            lblTotalPrice.Text = $"$ {Quantity:F2}" ;
        }

        void ResetForm()
        {
            //reset Groups
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbCrust.Enabled = true;
            gbEatPlace.Enabled = true;
            gbQuantity.Enabled = true;

            //reset Size
            rbMedium.Checked = true;

            //reset Toppings.
            chkExtraCheese.Checked = false;
            chkOnion.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkTomatoes.Checked = false;
            chkGreenPeppers.Checked = false;

            //reset CrustType
            rbThin.Checked = true;

            //reset Quantity
            numericQuantity.Enabled = true;
            numericQuantity.Value = 1;

            //reset Where to Eat
            rbEatIn.Checked = true;

            //Reset Order Button
            btnOrder.Enabled = true;
        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }

        private void rbSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void chkToppings_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rbCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbWhereToEat_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to order?", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Your order placed successfully :-)", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gbSize.Enabled = false;
                gbCrust.Enabled = false;
                gbToppings.Enabled = false;
                gbEatPlace.Enabled = false;
                numericQuantity.Enabled = false;
                btnOrder.Enabled = false;
            }
            else
            {
                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void numericQuantity_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            lblQuantity.Text = numericQuantity.Value.ToString();
        }

    }
}
