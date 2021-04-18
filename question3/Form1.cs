using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace question3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string savannahCC;
            ///check if the credit card is savannah's or not
            if (radioButton1.Checked)
            {
                savannahCC = "yes";
            }
            else if(radioButton2.Checked)
            {
                savannahCC = "no";
            }
            else
            {
                savannahCC = "none";
                label6.Text = "Please select one of the buttons";
            }

            ///check the price of the order and credit card type to determin if the shipping is free or not
            if(savannahCC == "yes" && Convert.ToInt32(textBox2.Text) >= 100)
            {
                //the shipping is free
                label4.Text = "You qualified for free shipping!, shipping cost is $0";
            }
            else
            {
                label4.Text = "Shipping Cost: $9";
            }
            label5.Text = "Your Credit Card Number is " + textBox1.Text;
        }
    }
}
