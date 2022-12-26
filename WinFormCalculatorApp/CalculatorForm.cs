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
            lblCalculator.Text = "0";
            result = 0;
            calculationCounter = 0;
        }

        private void CalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (lblCalculator.Text.Contains(",") || lblCalculator.Text != "0")
                lblCalculator.Text += "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (lblCalculator.Text == "0")
                lblCalculator.Text = "1";
            else
                lblCalculator.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (lblCalculator.Text == "0")
                lblCalculator.Text = "2";
            else
                lblCalculator.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (lblCalculator.Text == "0")
                lblCalculator.Text = "3";
            else
                lblCalculator.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (lblCalculator.Text == "0")
                lblCalculator.Text = "4";
            else
                lblCalculator.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (lblCalculator.Text == "0")
                lblCalculator.Text = "5";
            else
                lblCalculator.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (lblCalculator.Text == "0")
                lblCalculator.Text = "6";
            else
                lblCalculator.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (lblCalculator.Text == "0")
                lblCalculator.Text = "7";
            else
                lblCalculator.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (lblCalculator.Text == "0")
                lblCalculator.Text = "8";
            else
                lblCalculator.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (lblCalculator.Text == "0")
                lblCalculator.Text = "9";
            else
                lblCalculator.Text += "9";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblCalculator.Text = "0";
            result = 0;
            calculationCounter = 0;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
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

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!lblCalculator.Text.Contains(","))
                lblCalculator.Text += ",";
        }

        private void btnValueInvertion_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(lblCalculator.Text);
            lblCalculator.Text = (number * (-1)).ToString();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(lblCalculator.Text);
            if (calculationCounter == 0 && number != 0)
                result = number;
            else
                result += number;
            calculationCounter++;
            lblCalculator.Text = "0";
        }

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(lblCalculator.Text);
            if (calculationCounter == 0 && number != 0)
                result = number;
            else
                result -= number;
            calculationCounter++;
            lblCalculator.Text = "0";
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(lblCalculator.Text);
            if (calculationCounter != 0 && number == 0)
                MessageBox.Show("The zero cannot multiply by zero. Please try a different value.");
            else if (calculationCounter == 0 && number != 0)
                result = number;
            else
                result *= number;

            calculationCounter++;
            lblCalculator.Text = "0";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(lblCalculator.Text);
            if (calculationCounter != 0 && number == 0)
                MessageBox.Show("The dividend cannot be zero. Please try a different value.");
            else if (calculationCounter == 0 && number != 0)
                result = number;
            else
                result /= number;

            calculationCounter++;
            lblCalculator.Text = "0";
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(lblCalculator.Text);
            if (calculationCounter != 0 && number == 0)
                MessageBox.Show("The zero cannot have a square root. Please try a different value.");
            else if (calculationCounter == 0 && number != 0)
                result = number;
            else
                result = Math.Sqrt(number);

            calculationCounter++;
            lblCalculator.Text = "0";
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(lblCalculator.Text);
            if (calculationCounter != 0 && number == 0)
                MessageBox.Show("The zero cannot have a power of two. Please try a different value.");
            else if (calculationCounter == 0 && number != 0)
                result = number;
            else
                result = Math.Pow(number, 2);

            calculationCounter++;
            lblCalculator.Text = "0";
        }

        private void btnInvertion_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(lblCalculator.Text);
            if (calculationCounter != 0 && number == 0)
                MessageBox.Show("The dividend cannot be zero. Please try a different value.");
            else if (calculationCounter == 0 && number != 0)
                result = number;
            else
                result = 1 / number;

            calculationCounter++;
            lblCalculator.Text = "0";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            lblCalculator.Text = result.ToString();
        }
    }
}
