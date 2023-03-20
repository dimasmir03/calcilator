using System;
using System.Windows.Forms;

namespace calcilator
{
    public partial class Form1 : Form
    {
        public string n1,V;
        public bool can=false;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0"){ textBox1.Clear();
                                       label1.Text = ""; }
            Button B = (Button)sender;
            textBox1.Text += B.Text;
            label1.Text += B.Text;
            can = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text="";
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
            switch (V){
                case "+":
                    textBox1.Text = Calculator.add( n11 , n22).ToString();
                    break;
                case "-":
                    textBox1.Text = Calculator.sub(n11 ,n22).ToString();
                    break;
                case "/":
                    textBox1.Text = Calculator.div(n11 ,n22).ToString();
                    break;
                case "*":
                    textBox1.Text = Calculator.mult(n11 , n22).ToString();
                    break;
            }
            V = "";
            label1.Text= textBox1.Text;
            //label1.Text += "=" + textBox1.Text;
            can = false;
        }

        private void bSqrt_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;
            
            textBox1.Text = Calculator.sqrt(Convert.ToDouble(textBox1.Text)).ToString();
            label1.Text = textBox1.Text;

        }
        private void bPow_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;
            
            
            textBox1.Text = Calculator.pow(Convert.ToDouble(textBox1.Text)).ToString();
            label1.Text = textBox1.Text;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
            }catch(Exception)
            {
                return;
            }
            if (textBox1.Text == "") return;
            Button B = (Button)sender;
            textBox1.Text += B.Text;
            label1.Text += B.Text;
        }

        

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;
            if (can)
            {
                button10_Click(sender, e);
            }
            can = true;
            n1 = textBox1.Text;
            Button B = (Button)sender;
            V = B.Text;
            label1.Text += V;
            textBox1.Clear();
        }
    }

    
}
