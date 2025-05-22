namespace D7
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            textBox1.Text += button.Text;
        }
        double old = 0.0;
        string lastOp = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(".")) textBox1.Text += ".";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (!String.IsNullOrEmpty(textBox1.Text)) old = double.Parse(textBox1.Text);
            lastOp = button.Text;
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                double newN = double.Parse(textBox1.Text);
                double res = 0;
                switch (lastOp)
                {
                    case "*":
                        res = old * newN;
                        break;
                    case "/":
                        res = old / newN;
                        break;
                    case "-":
                        res = old - newN;
                        break;
                    case "+":
                        res = old + newN;
                        break;
                    default:
                        break;
                }
                textBox1.Text = res.ToString();
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("you can not divide by zero", "Exception");
                old = 0.0;
                textBox1.Text = "";
            }
        }
    }
}
