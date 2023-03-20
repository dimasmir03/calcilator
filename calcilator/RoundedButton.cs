using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcilator
{
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
