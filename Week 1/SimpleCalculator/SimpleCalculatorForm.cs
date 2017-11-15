using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class SimpleCalculatorForm : Form
    {
        public SimpleCalculatorForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int number1, number2;
            number1 = Convert.ToInt32(tbFirstNumber.Text);
            number2 = Convert.ToInt32(tbSecondNumber.Text);
            int result;
            result = number1 + number2;
            tbresult.Text = result.ToString();
            
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {

            int number1, number2;
            number1 = Convert.ToInt32(tbFirstNumber.Text);
            number2 = Convert.ToInt32(tbSecondNumber.Text);
            int result;
            result = number1 - number2;
            tbresult.Text = result.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {

            int number1, number2;
            number1 = Convert.ToInt32(tbFirstNumber.Text);
            number2 = Convert.ToInt32(tbSecondNumber.Text);
            int result;
            result = number1 / number2;
            tbresult.Text = result.ToString();
        }

        private void btnMultpli_Click(object sender, EventArgs e)
        {

            int number1, number2;
            number1 = Convert.ToInt32(tbFirstNumber.Text);
            number2 = Convert.ToInt32(tbSecondNumber.Text);
            int result;
            result = number1 * number2;
            tbresult.Text = result.ToString();
        }
    }
}
