using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using calcilator.Classes;

namespace calcilator
{
    public partial class Form1 : Form
    {
        public string n1, V;
        public bool can = false;
        public Form1()
        {
            InitializeComponent();
            initMethod();
        }

        private void initMethod()
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Regex.IsMatch(Controls[i].Name, @"button[0-9]$"))
                    Controls[i].Click += new EventHandler(button13_Click);
                if (Regex.IsMatch(Controls[i].Name, @"button[11-14]"))
                    Controls[i].Click += new EventHandler(button11_Click);
                if (Controls[i].Name.Contains("button10"))
                    Controls[i].Click += new EventHandler(button10_Click);
                if (Controls[i].Name.Contains("button16"))
                    Controls[i].Click += new EventHandler(button16_Click);
                if (Controls[i].Name.Contains("button17"))
                    Controls[i].Click += new EventHandler(button17_Click);
                if (Controls[i].Name.Contains("buttonPow"))
                    Controls[i].Click += new EventHandler(bPow_Click);
                if (Controls[i].Name.Contains("buttonSqrt"))
                    Controls[i].Click += new EventHandler(bSqrt_Click);

                Controls[i].Click += new EventHandler(button_clicked);
            }
        }

        private void button_clicked(object sender, EventArgs e)
        {
            RoundedButton button_clicked = (RoundedButton)sender;
            lName.Text = RoundedButton.setLabelName(button_clicked.Name);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                label1.Text = "";
            }
            RoundedButton B = (RoundedButton)sender;
            textBox1.Text += B.Text;
            label1.Text += B.Text;
            Console.WriteLine("13click");
            can = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
            can = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double n11, n22;
            try
            {
                n11 = Convert.ToDouble(n1);
                n22 = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception)
            {
                return;
            }
            switch (V)
            {
                case "+":
                    textBox1.Text = Calculator.add(n11, n22).ToString();
                    break;
                case "-":
                    textBox1.Text = Calculator.sub(n11, n22).ToString();
                    break;
                case "/":
                    textBox1.Text = Calculator.div(n11, n22).ToString();
                    break;
                case "*":
                    textBox1.Text = Calculator.mult(n11, n22).ToString();
                    break;
            }
            V = "";
            label1.Text = textBox1.Text;
            Console.WriteLine("10click");
            //label1.Text += "=" + textBox1.Text;
            can = false;
        }

        private void bSqrt_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;

            textBox1.Text = Calculator.sqrt(Convert.ToDouble(textBox1.Text)).ToString();
            label1.Text = textBox1.Text;
            Console.WriteLine("sqrtclick");

        }
        private void bPow_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;


            textBox1.Text = Calculator.pow(Convert.ToDouble(textBox1.Text)).ToString();
            label1.Text = textBox1.Text;
            Console.WriteLine("powclick");
        }
        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
            }
            catch (Exception)
            {
                return;
            }
            if (textBox1.Text == "") return;
            Button B = (Button)sender;
            textBox1.Text += B.Text;
            label1.Text += B.Text;
            Console.WriteLine("17click");
        }



        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;
            if (can)
                button10_Click(sender, e);
            can = true;
            n1 = textBox1.Text;
            Button B = (Button)sender;
            V = B.Text;
            Console.WriteLine( label1.Text += V);
            Console.WriteLine("11click");
            textBox1.Clear();
        }
    }
}
