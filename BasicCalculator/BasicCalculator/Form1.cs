using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void add_Click(object sender, EventArgs e)
        {
            operation("add");
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            operation("subtract");
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            operation("multiply");
        }

        private void divide_Click(object sender, EventArgs e)
        {
            operation("divide");
        }
        private void operation(string sender)
        {
            if (string.IsNullOrEmpty(textBoxInput1.Text) || 
                string.IsNullOrEmpty(textBoxInput2.Text ) || 
                !textBoxInput1.Text.All(Char.IsDigit) || 
                !textBoxInput2.Text.All(Char.IsDigit)) {
                textBoxOutput.Text = "Not a valid Input";
            } else {
                double number1 = double.Parse(textBoxInput1.Text);
                double number2 = double.Parse(textBoxInput2.Text);
                double result = 0;
                switch (sender) {
                    case "add":
                        result = number1 + number2;
                        textBoxOutput.Text = result.ToString("0.00");
                        break;

                    case "subtract":
                        result = number1 - number2;
                        textBoxOutput.Text = result.ToString("0.00");
                        break;

                    case "multiply":
                        result = number1 * number2;
                        textBoxOutput.Text = result.ToString("0.00");
                        break;

                    case "divide":
                        if (number2 == 0) {
                            textBoxOutput.Text = "Not a valid Input";
                        } else {
                            result = number1 / number2;
                            textBoxOutput.Text = result.ToString("0.00");
                        }
                        break;
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBoxInput1.Text = "";
            textBoxInput2.Text = "";
            textBoxOutput.Text = "";
        }
    }
}
