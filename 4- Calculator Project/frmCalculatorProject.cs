using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Project
{
    public partial class frmCalculatorProject : Form
    {
        public frmCalculatorProject()
        {
            InitializeComponent();
        }

        private enum enOperation { enPlus, enSubtract, enMultiply, enDivide, enPower };
        private enOperation CurrentOperation;
        
        private double FirstNumber = 0;
        private double SecondNumber = 0;
        private bool OperationPressed = false;
        private bool HasOperation = false;
        private bool IsNewNumber = false;

        private void GetResult()
        {
            if (!string.IsNullOrWhiteSpace(txtExpression.Text))
                SecondNumber = Convert.ToDouble(txtExpression.Text);
            
            double Result = 0;

            switch (CurrentOperation)
            {
                case enOperation.enPlus:
                    Result = FirstNumber + SecondNumber;
                    break;

                case enOperation.enSubtract:
                    Result = FirstNumber - SecondNumber;
                    break;

                case enOperation.enMultiply:
                    Result = FirstNumber * SecondNumber;
                    break;

                case enOperation.enDivide:

                    if (SecondNumber == 0)
                    {
                        MessageBox.Show("Cannot divide by zero");
                        return;
                    }

                    Result = FirstNumber / SecondNumber;
                    break;

                case enOperation.enPower:
                    Result = Math.Pow(FirstNumber, SecondNumber);
                    break;
            }

            txtExpression.Text = Result.ToString();
            FirstNumber = Result;
        }

        private void button_Click(object sender, EventArgs e)
        {
            //if (!HasOperation && IsNewNumber)
            //{
            //    lblFullExpression.Text = "";
            //}

            Button num = (Button)sender;

            if (txtExpression.Text == "" || IsNewNumber)
            {
                txtExpression.Text = num.Text;
                IsNewNumber = false;
            }
            else
            {
                txtExpression.Text += num.Text;
            }

            OperationPressed = false;
        }

        private string GetOperationSymbol()
        {
            switch (CurrentOperation)
            {
                case enOperation.enPlus:
                    return "+";

                case enOperation.enSubtract:
                    return "-";

                case enOperation.enMultiply:
                    return "×";

                case enOperation.enDivide:
                    return "÷";

                case enOperation.enPower:
                    return "^";
            }

            return "";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (!HasOperation)
                return;

            if (IsNewNumber)
                return; //there is no SecondNumber

            lblFullExpression.Text =
            FirstNumber.ToString()
            + " " +
            GetOperationSymbol()
            + " " +
            txtExpression.Text
            + " =";

            GetResult();

            HasOperation = false;
        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExpression.Text))
                return;

            Button operation = (Button)sender;

            // If there is a pervious operation, calculate it first
            if (HasOperation && !OperationPressed)
            {
                GetResult();
            }

            if (!string.IsNullOrWhiteSpace(txtExpression.Text))
            {
                FirstNumber = Convert.ToDouble(txtExpression.Text);
                lblFullExpression.Text = FirstNumber.ToString() + " " + operation.Text;
            }

            switch (operation.Text)
            {
                case "+":
                    CurrentOperation = enOperation.enPlus;
                    break;

                case "-":
                    CurrentOperation = enOperation.enSubtract;
                    break;

                case "×":
                    CurrentOperation = enOperation.enMultiply;
                    break;

                case "÷":
                    CurrentOperation = enOperation.enDivide;
                    break;

                case "^":
                    CurrentOperation = enOperation.enPower;
                    break;
            }

            HasOperation = true;
            OperationPressed = true;
            IsNewNumber = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtExpression.Clear();
            lblFullExpression.Text = "";

            FirstNumber = 0;
            SecondNumber = 0;
            HasOperation = false;
            OperationPressed = false;
            IsNewNumber = false;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            //if (txtExpression.Text == "0")
            //    return;

            if (txtExpression.Text.Length > 0)
            {
                txtExpression.Text = txtExpression.Text.Remove(txtExpression.Text.Length - 1);
            }
            //else
            //{
            //    txtExpression.Text = "0";
            //}
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (txtExpression.Text == "0")
                return;

            if (txtExpression.Text.StartsWith("-"))
            {
                txtExpression.Text = txtExpression.Text.Substring(1);
            }
            else
            {
                txtExpression.Text = "-" + txtExpression.Text;
            }
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (txtExpression.Text.Contains("."))
                return;


            if (txtExpression.Text == "" || IsNewNumber)
            {
                txtExpression.Text = "0.";
                IsNewNumber = false;
            }
            else
            {
                txtExpression.Text += ".";
            }
        }

        private void frmCalculatorProject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                btnBackspace.PerformClick();
            }
        }
    
    }
}
