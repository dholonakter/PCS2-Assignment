using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignmnet_1._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnConvertEuroToDollar_Click(object sender, EventArgs e)
        {
            decimal euro = Convert.ToDecimal(tbEuro.Text);
            decimal exchangeRate = nrUpDownExchangeRate.Value;

            decimal dollar = euro * exchangeRate;

            tbdollar.Text = dollar.ToString();

        }

        private void btnConvertDollarToEuro_Click(object sender, EventArgs e)
        {
            decimal dollar = Convert.ToDecimal(tbdollar.Text);
            decimal exchangeRate = nrUpDownExchangeRate.Value;

            decimal euro = dollar / exchangeRate;

            tbEuro.Text = euro.ToString();
        }

        private void btnMadeBy_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            label5.Visible = false;

        }
    }
}
