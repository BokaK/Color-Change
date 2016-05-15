using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class DiamondBallsCircle : Shape
    {
        public int count { get; set; }
        public DiamondBallsCircle(float x, float y, int c) : base(x,y)
        {
            count = c;
        }
        public override void Draw(Graphics g)
        {
            Brush b1 = new SolidBrush(Color.Firebrick);
            Brush b2 = new SolidBrush(Color.IndianRed);
            Brush b3 = new SolidBrush(Color.RosyBrown);
            Brush b4 = new SolidBrush(Color.MistyRose);
            Pen p1 = new Pen(Color.Firebrick, 3);
            Pen p2 = new Pen(Color.IndianRed, 3);
            Pen p3 = new Pen(Color.RosyBrown, 3);
            Pen p4 = new Pen(Color.MistyRose, 3);
            if (count % 4 == 0)
            {
                g.FillEllipse(b1, X, Y, 15, 15);
                g.FillEllipse(b2, X + 15, Y - 15, 15, 15);
                g.FillEllipse(b3, X + 30, Y - 30, 15, 15);
                g.FillEllipse(b4, X + 45, Y - 45, 15, 15);
                g.FillEllipse(b1, X + 60, Y - 60, 15, 15);
                g.FillEllipse(b2, X + 45, Y - 75, 15, 15);
                g.FillEllipse(b3, X + 30, Y - 90, 15, 15);
                g.FillEllipse(b4, X + 15, Y - 105, 15, 15);
                g.FillEllipse(b1, X, Y - 120, 15, 15);
                g.FillEllipse(b2, X - 15, Y - 105, 15, 15);
                g.FillEllipse(b3, X - 30, Y - 90, 15, 15);
                g.FillEllipse(b4, X - 45, Y - 75, 15, 15);
                g.FillEllipse(b1, X - 60, Y - 60, 15, 15);
                g.FillEllipse(b2, X - 45, Y - 45, 15, 15);
                g.FillEllipse(b3, X - 30, Y - 30, 15, 15);
                g.FillEllipse(b4, X - 15, Y - 15, 15, 15);

                g.DrawArc(p1, X - (float)22.5, Y - (float)82.5, 60, 60, 45, 90);
                g.DrawArc(p2, X - (float)22.5, Y - (float)82.5, 60, 60, 135, 90);
                g.DrawArc(p3, X - (float)22.5, Y - (float)82.5, 60, 60, 225, 90);
                g.DrawArc(p4, X - (float)22.5, Y - (float)82.5, 60, 60, 315, 90);

            }
            if(count % 4 == 1)
            {
                g.FillEllipse(b2, X, Y, 15, 15);
                g.FillEllipse(b3, X + 15, Y - 15, 15, 15);
                g.FillEllipse(b4, X + 30, Y - 30, 15, 15);
                g.FillEllipse(b1, X + 45, Y - 45, 15, 15);
                g.FillEllipse(b2, X + 60, Y - 60, 15, 15);
                g.FillEllipse(b3, X + 45, Y - 75, 15, 15);
                g.FillEllipse(b4, X + 30, Y - 90, 15, 15);
                g.FillEllipse(b1, X + 15, Y - 105, 15, 15);
                g.FillEllipse(b2, X, Y - 120, 15, 15);
                g.FillEllipse(b3, X - 15, Y - 105, 15, 15);
                g.FillEllipse(b4, X - 30, Y - 90, 15, 15);
                g.FillEllipse(b1, X - 45, Y - 75, 15, 15);
                g.FillEllipse(b2, X - 60, Y - 60, 15, 15);
                g.FillEllipse(b3, X - 45, Y - 45, 15, 15);
                g.FillEllipse(b4, X - 30, Y - 30, 15, 15);
                g.FillEllipse(b1, X - 15, Y - 15, 15, 15);

                g.DrawArc(p2, X - (float)22.5, Y - (float)82.5, 60, 60, 45, 90);
                g.DrawArc(p3, X - (float)22.5, Y - (float)82.5, 60, 60, 135, 90);
                g.DrawArc(p4, X - (float)22.5, Y - (float)82.5, 60, 60, 225, 90);
                g.DrawArc(p1, X - (float)22.5, Y - (float)82.5, 60, 60, 315, 90);
            }
            if(count % 4 == 2)
            {
                g.FillEllipse(b3, X, Y, 15, 15);
                g.FillEllipse(b4, X + 15, Y - 15, 15, 15);
                g.FillEllipse(b1, X + 30, Y - 30, 15, 15);
                g.FillEllipse(b2, X + 45, Y - 45, 15, 15);
                g.FillEllipse(b3, X + 60, Y - 60, 15, 15);
                g.FillEllipse(b4, X + 45, Y - 75, 15, 15);
                g.FillEllipse(b1, X + 30, Y - 90, 15, 15);
                g.FillEllipse(b2, X + 15, Y - 105, 15, 15);
                g.FillEllipse(b3, X, Y - 120, 15, 15);
                g.FillEllipse(b4, X - 15, Y - 105, 15, 15);
                g.FillEllipse(b1, X - 30, Y - 90, 15, 15);
                g.FillEllipse(b2, X - 45, Y - 75, 15, 15);
                g.FillEllipse(b3, X - 60, Y - 60, 15, 15);
                g.FillEllipse(b4, X - 45, Y - 45, 15, 15);
                g.FillEllipse(b1, X - 30, Y - 30, 15, 15);
                g.FillEllipse(b2, X - 15, Y - 15, 15, 15);

                g.DrawArc(p3, X - (float)22.5, Y - (float)82.5, 60, 60, 45, 90);
                g.DrawArc(p4, X - (float)22.5, Y - (float)82.5, 60, 60, 135, 90);
                g.DrawArc(p1, X - (float)22.5, Y - (float)82.5, 60, 60, 225, 90);
                g.DrawArc(p2, X - (float)22.5, Y - (float)82.5, 60, 60, 315, 90);
            }
            if(count % 4 == 3)
            {
                g.FillEllipse(b4, X, Y, 15, 15);
                g.FillEllipse(b1, X + 15, Y - 15, 15, 15);
                g.FillEllipse(b2, X + 30, Y - 30, 15, 15);
                g.FillEllipse(b3, X + 45, Y - 45, 15, 15);
                g.FillEllipse(b4, X + 60, Y - 60, 15, 15);
                g.FillEllipse(b1, X + 45, Y - 75, 15, 15);
                g.FillEllipse(b2, X + 30, Y - 90, 15, 15);
                g.FillEllipse(b3, X + 15, Y - 105, 15, 15);
                g.FillEllipse(b4, X, Y - 120, 15, 15);
                g.FillEllipse(b1, X - 15, Y - 105, 15, 15);
                g.FillEllipse(b2, X - 30, Y - 90, 15, 15);
                g.FillEllipse(b3, X - 45, Y - 75, 15, 15);
                g.FillEllipse(b4, X - 60, Y - 60, 15, 15);
                g.FillEllipse(b1, X - 45, Y - 45, 15, 15);
                g.FillEllipse(b2, X - 30, Y - 30, 15, 15);
                g.FillEllipse(b3, X - 15, Y - 15, 15, 15);

                g.DrawArc(p4, X - (float)22.5, Y - (float)82.5, 60, 60, 45, 90);
                g.DrawArc(p1, X - (float)22.5, Y - (float)82.5, 60, 60, 135, 90);
                g.DrawArc(p2, X - (float)22.5, Y - (float)82.5, 60, 60, 225, 90);
                g.DrawArc(p3, X - (float)22.5, Y - (float)82.5, 60, 60, 315, 90);
            }

            b4.Dispose();
            p1.Dispose();
            b3.Dispose();
            b2.Dispose();
            b1.Dispose();
            p4.Dispose();
            p3.Dispose();
            p2.Dispose();

        }
    }
}
