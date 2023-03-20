using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            Button B = (Button)sender;
            textBox1.Text += B.Text;
            label1.Text += B.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text="";
            can = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            switch (V){
                case "+":
                    textBox1.Text = (Convert.ToDouble(n1) + Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (Convert.ToDouble(n1) - Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (Convert.ToDouble(n1) / Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (Convert.ToDouble(n1) * Convert.ToDouble(textBox1.Text)).ToString();
                    break;
            }
            V = "";
            label1.Text= textBox1.Text;
            //label1.Text += "=" + textBox1.Text;
            can = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
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

    public class RoundedButton : Button
    {
        public Color BorderColor { get; set; }
        public float BorderWidth { get; set; }

        public RoundedButton()
        {
            BorderColor = BackColor;
            BorderWidth = 6f;
        }
        #region Overrides of Control

        protected override void OnPaint(PaintEventArgs pevent)
        {
            using (var gp = new GraphicsPath())
            {
                RectangleF rf = new RectangleF(new PointF(0, 0), new SizeF(Height, Height));
                gp.AddArc(rf, 90, 180);
                gp.AddLine(new PointF(Height / 2f, 0), new PointF(Width - Height / 2f, 0));
                // rf.Offset(Width - Height, 0);
                gp.AddArc(rf, -90, 180);
                gp.CloseAllFigures();
                Region = new Region(gp);
                base.OnPaint(pevent);
                using (var pen = new Pen(BorderColor, BorderWidth))
                {
                    pevent.Graphics.DrawPath(pen, gp);
                }
            }
        }
        #endregion
    }
}
