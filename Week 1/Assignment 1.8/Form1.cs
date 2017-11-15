using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1._8
{
    public partial class Form1 : Form
    {
        #region Private Field
        /// <summary>
        /// Unique number for each order
        /// </summary>
        private int _orderNumber;

        /// <summary>
        /// Amount of ordered dice
        /// </summary>
        private int _quantity;

        /// <summary>
        /// Full name of a customer
        /// </summary>
        private string _customerName;

        /// <summary>
        /// Shipping address of a customer
        /// </summary>
        private string _shippingAddress;

        /// <summary>
        /// Color of the dice
        /// </summary>
        private string _colorOfDice;

        #endregion

        #region Constuctor
        /// <summary>
        /// Default constuctor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Private Method
        private void chbxRed_Click(object sender, EventArgs e)
        {
            _orderNumber = Convert.ToInt32(tbxOrderNumber.Text);
            _customerName = tbxCustomerName.Text;
            _shippingAddress = tbxShipppingAddress.Text;
            _colorOfDice = "'red";
            tbxQuantityOfDice.ReadOnly = false;
        }
        private void tbxQuantityOfDice_DoubleClick(object sender, EventArgs e)
        {
            _quantity = Convert.ToInt32(tbxQuantityOfDice.Text);

            lblTax.Text = "0 euro";
            lblTotalCost.Text = "0 euro";
            lblShipping.Text = "0 euro";

            if(_quantity <= 20)
            {
                double taxAmount = (0.05 * 1.50);
                lblTax.Text =taxAmount + " euro";
                lblTotalCost.Text =(taxAmount+1.50)+" euro";
                lblShipping.Text = "1.50 euro";
            }
        }
        private void btnResetFields_Click(object sender, EventArgs e)
        {
            tbxOrderNumber.Text = _orderNumber.ToString();
            tbxCustomerName.Text = _customerName;
            tbxShipppingAddress.Text = _shippingAddress;

            if(_quantity.ToString() != tbxQuantityOfDice.Text)
            {
                int quantity = Convert.ToInt32(tbxQuantityOfDice.Text);

                lblTax.Text = "0 euro";
                lblTotalCost.Text = "0 euro";
                lblShipping.Text = "0 euro";

                if (quantity <= 20)
                {
                    double taxAmount = (0.05 * 1.50);
                    lblTax.Text = taxAmount + " euro";
                    lblTotalCost.Text = (taxAmount + 1.50) + " euro";
                    lblShipping.Text = "1.50 euro";
                }
                tbxQuantityOfDice.Text = quantity.ToString();
            }
            tbxQuantityOfDice.ReadOnly = true;
            chbxRed.Checked = false;
        }
        #endregion
    }
}
