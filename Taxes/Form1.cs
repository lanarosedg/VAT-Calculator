using System;
using System.Windows.Forms;

namespace Taxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class VATCalculator
        {
            private const double vatRate = 0.12;
            public double Amount { get; set; }

            public double CalculateVAT()
            {
                return Amount * vatRate;
            }

            public double CalculateTotal()
            {
                return Amount + CalculateVAT();
            }
        }

        public class FastFoodVAT : VATCalculator
        {

        }

        public class GasolineVAT : VATCalculator
        {

        }

        private void fastFoodVATButton_Click(object sender, EventArgs e)
        {
            FastFoodVAT fastFood = new FastFoodVAT();

            if (double.TryParse(priceTextBox.Text, out double amount))
            {
                fastFood.Amount = amount;
                fastFoodTotalAmount.Text = "Total amount: Php" + fastFood.CalculateTotal().ToString("F2");
            }
            else
            {
                MessageBox.Show("Please enter a valid price for Fast Food.");
            }
        }

        private void gasolineVATButton_Click(object sender, EventArgs e)
        {
            GasolineVAT gasoline = new GasolineVAT();

            if (double.TryParse(gasolineTextBox.Text, out double amount))
            {
                gasoline.Amount = amount;
                gasolineTotalAmount.Text = "Total amount: Php" + gasoline.CalculateTotal().ToString("F2");
            }
            else
            {
                MessageBox.Show("Please enter a valid price for Gasoline.");
            }
        }
    }
}
