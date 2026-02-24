using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (listBoxOp.Text == "+")
            {
                //not safe for "3a"
                int num1 = Convert.ToInt32(textBoxNum1.Text);
                int num2 = Convert.ToInt32(textBoxNum2.Text);
                int result = num1 + num2;

                textBoxNumResult.Text = Convert.ToString(result);
            }
            else if (listBoxOp.Text == "-")
            {
                //not safe for "3a"
                int num1 = Int32.Parse(textBoxNum1.Text);
                int num2 = Int32.Parse(textBoxNum2.Text);
                int result = num1 - num2;

                textBoxNumResult.Text = result.ToString();
            }
            else if (listBoxOp.Text == "*")
            {
                int num1, num2;

                //safe for "3a"
                if (Int32.TryParse(textBoxNum1.Text, out num1) &&
                    Int32.TryParse(textBoxNum2.Text, out num2))
                {
                    int result = num1 * num2;
                    textBoxNumResult.Text = result.ToString();
                }
                else
                {
                    textBoxNumResult.Text = "FormatException";
                }
            }
        }
    }
}
