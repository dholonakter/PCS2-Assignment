using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void resultBtn_Click(object sender, EventArgs e)
        {
            int a, b, result;
            a = Convert.ToInt32(tbA.Text);
            b = Convert.ToInt32(tbB.Text);
            if ((a!=0) && (b!=0))
            {
                result = a / b;
                tbIntDiv.Text = result.ToString();
                result = a % b;
                tbRemainder.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("please write the whole number except 0 ");
            }
        }
    }
}
