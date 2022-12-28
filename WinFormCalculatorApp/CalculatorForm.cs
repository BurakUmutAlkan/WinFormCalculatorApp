using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCalculatorApp
{
    public partial class CalculatorForm : Form
    {
        double result;
        int calculationCounter;

        public CalculatorForm()
        {
            InitializeComponent();
            DoInitialAssignments();
        }

        private void CalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            PrintNumberOnCalculatorScreen("0");
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            PrintNumberOnCalculatorScreen("1");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            PrintNumberOnCalculatorScreen("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            PrintNumberOnCalculatorScreen("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            PrintNumberOnCalculatorScreen("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            PrintNumberOnCalculatorScreen("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            PrintNumberOnCalculatorScreen("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            PrintNumberOnCalculatorScreen("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            PrintNumberOnCalculatorScreen("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            PrintNumberOnCalculatorScreen("9");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DoInitialAssignments();
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            ExecuteBackspace();
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            PrintNumberOnCalculatorScreen(",");
        }

        private void btnValueInvertion_Click(object sender, EventArgs e)
        {
            ExecuteValueInvertion();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            ExecuteOperation("+");
        }

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            ExecuteOperation("-");
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            ExecuteOperation("*");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            ExecuteOperation("/");
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            ExecuteOperation("sqrt");   
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            ExecuteOperation("^2");
        }

        private void btnInvertion_Click(object sender, EventArgs e)
        {
            ExecuteOperation("1/");
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            lblCalculator.Text = result.ToString();
        }

        #region Methods

        private void PrintNumberOnCalculatorScreen(string value)
        {
            if (value == "0")
            {
                if (lblCalculator.Text.Contains(",") || lblCalculator.Text != "0")
                    lblCalculator.Text += value;
                else
                    return;
            }
            else if (value == ",")
            {
                if (!lblCalculator.Text.Contains(","))
                    lblCalculator.Text += value;
                else
                    return;
            }
            else
            {
                if (lblCalculator.Text == "0")
                    lblCalculator.Text = value;
                else
                    lblCalculator.Text += value;
            }
        }

        private void DoInitialAssignments()
        {
            lblCalculator.Text = "0";
            result = 0;
            calculationCounter = 0;
        }

        private void ExecuteBackspace()
        {
            string calculatorScreenText = lblCalculator.Text;
            double number = Convert.ToDouble(calculatorScreenText);

            if (number < 10 && number > -10 && !calculatorScreenText.Contains(","))
                lblCalculator.Text = "0";
            else if (calculatorScreenText.IndexOf(",") == calculatorScreenText.Length - 2)
                lblCalculator.Text = calculatorScreenText.Substring(0, calculatorScreenText.Length - 2);
            else
                lblCalculator.Text = calculatorScreenText.Substring(0, calculatorScreenText.Length - 1);
        }

        private void ExecuteValueInvertion()
        {
            double number = Convert.ToDouble(lblCalculator.Text);
            lblCalculator.Text = (number * (-1)).ToString();
        }

        private void ExecuteOperation(string operation)
        {
            double number = Convert.ToDouble(lblCalculator.Text);

            switch (operation)
            {
                case "+":
                    if (calculationCounter == 0 && number != 0)
                        result = number;
                    else
                        result += number;
                    break;
                case "-":
                    if (calculationCounter == 0 && number != 0)
                        result = number;
                    else
                        result -= number;
                    break;
                case "*":
                    if (calculationCounter != 0 && number == 0)
                        MessageBox.Show("The zero cannot multiply by zero. Please try a different value.");
                    else if (calculationCounter == 0 && number != 0)
                        result = number;
                    else
                        result *= number;
                    break;
                    case "/":
                    if (calculationCounter != 0 && number == 0)
                        MessageBox.Show("The dividend cannot be zero. Please try a different value.");
                    else if (calculationCounter == 0 && number != 0)
                        result = number;
                    else
                        result /= number;
                    break;
                case "sqrt":
                    if (calculationCounter != 0 && number == 0)
                        MessageBox.Show("The zero cannot have a square root. Please try a different value.");
                    else if (calculationCounter == 0 && number != 0)
                        result = number;
                    else
                        result = Math.Sqrt(number);
                    break;
                case "^2":
                    if (calculationCounter != 0 && number == 0)
                        MessageBox.Show("The zero cannot have a power of two. Please try a different value.");
                    else if (calculationCounter == 0 && number != 0)
                        result = number;
                    else
                        result = Math.Pow(number, 2);
                    break;
                case "1/":
                    if (calculationCounter != 0 && number == 0)
                        MessageBox.Show("The dividend cannot be zero. Please try a different value.");
                    else if (calculationCounter == 0 && number != 0)
                        result = number;
                    else
                        result = 1 / number;
                    break;
            }

            calculationCounter++;
            lblCalculator.Text = "0";
        }

        #endregion
    }
}
