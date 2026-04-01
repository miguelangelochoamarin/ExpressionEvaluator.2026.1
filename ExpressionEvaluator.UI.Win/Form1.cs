using ExpressionEvaluator.Core;

namespace ExpressionEvaluator.UI.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void buttonOpenparentesis_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "(";
        }
        private void buttonCloseParentesis_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ")";
        }
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "*";
        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "/";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "-";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.TextLength - 1);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
        }

        private void buttonPow_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "^";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            var res = Evaluator.Evaluate(txtDisplay.Text);
            txtDisplay.Text += $"= {res}";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }
    }
}
