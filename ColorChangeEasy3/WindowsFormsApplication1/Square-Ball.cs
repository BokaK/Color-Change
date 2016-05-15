using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Square_Ball :Shape
    {
        public int X { set; get; }
        public int Y { set; get; }
        public int count { set; get; }
        public Square_Ball (int x, int y, int c)
            :base(x,y)
        {
            X = x;
            Y = y;
            count = c;
        }
        public override void Draw (Graphics g)
        {
            Pen p1 = new Pen(Color.Firebrick);
            Pen p2 = new Pen(Color.IndianRed);
            Pen p3 = new Pen(Color.RosyBrown);
            Pen p4 = new Pen(Color.MistyRose);
            Brush b1 = new SolidBrush(Color.Firebrick);
            Brush b2 = new SolidBrush(Color.IndianRed);
            Brush b3 = new SolidBrush(Color.RosyBrown);
            Brush b4 = new SolidBrush(Color.MistyRose);
            if (count % 4 == 0)
            {

                g.DrawEllipse(p1, X, Y, 15, 15);
                g.FillEllipse(b1, X, Y, 15, 15);
                g.DrawEllipse(p2, X + 18, Y, 15, 15);
                g.FillEllipse(b2, X + 18, Y, 15, 15);
                g.DrawEllipse(p3, X + 36, Y, 15, 15);
                g.FillEllipse(b3, X + 36, Y, 15, 15);
                g.DrawEllipse(p4, X + 54, Y, 15, 15);
                g.FillEllipse(b4, X + 54, Y, 15, 15);
                g.DrawEllipse(p1, X + 72, Y, 15, 15);
                g.FillEllipse(b1, X + 72, Y, 15, 15);

                g.DrawEllipse(p1, X, Y - 72, 15, 15);
                g.FillEllipse(b1, X, Y - 72, 15, 15);
                g.DrawEllipse(p4, X + 18, Y - 72, 15, 15);
                g.FillEllipse(b4, X + 18, Y - 72, 15, 15);
                g.DrawEllipse(p3, X + 36, Y - 72, 15, 15);
                g.FillEllipse(b3, X + 36, Y - 72, 15, 15);
                g.DrawEllipse(p2, X + 54, Y - 72, 15, 15);
                g.FillEllipse(b2, X + 54, Y - 72, 15, 15);
                g.DrawEllipse(p1, X + 72, Y - 72, 15, 15);
                g.FillEllipse(b1, X + 72, Y - 72, 15, 15);

                g.DrawEllipse(p4, X, Y - 18, 15, 15);
                g.FillEllipse(b4, X, Y - 18, 15, 15);
                g.DrawEllipse(p3, X, Y - 36, 15, 15);
                g.FillEllipse(b3, X, Y - 36, 15, 15);
                g.DrawEllipse(p2, X, Y - 54, 15, 15);
                g.FillEllipse(b2, X, Y - 54, 15, 15);

                g.DrawEllipse(p2, X + 72, Y - 18, 15, 15);
                g.FillEllipse(b2, X + 72, Y - 18, 15, 15);
                g.DrawEllipse(p3, X + 72, Y - 36, 15, 15);
                g.FillEllipse(b3, X + 72, Y - 36, 15, 15);
                g.DrawEllipse(p4, X + 72, Y - 54, 15, 15);
                g.FillEllipse(b4, X + 72, Y - 54, 15, 15);


            }
            if (count % 4 == 1)
            {

                g.DrawEllipse(p2, X, Y, 15, 15);
                g.FillEllipse(b2, X, Y, 15, 15);
                g.DrawEllipse(p3, X + 18, Y, 15, 15);
                g.FillEllipse(b3, X + 18, Y, 15, 15);
                g.DrawEllipse(p4, X + 36, Y, 15, 15);
                g.FillEllipse(b4, X + 36, Y, 15, 15);
                g.DrawEllipse(p1, X + 54, Y, 15, 15);
                g.FillEllipse(b1, X + 54, Y, 15, 15);
                g.DrawEllipse(p2, X + 72, Y, 15, 15);
                g.FillEllipse(b2, X + 72, Y, 15, 15);

                g.DrawEllipse(p2, X, Y - 72, 15, 15);
                g.FillEllipse(b2, X, Y - 72, 15, 15);
                g.DrawEllipse(p1, X + 18, Y - 72, 15, 15);
                g.FillEllipse(b1, X + 18, Y - 72, 15, 15);
                g.DrawEllipse(p4, X + 36, Y - 72, 15, 15);
                g.FillEllipse(b4, X + 36, Y - 72, 15, 15);
                g.DrawEllipse(p3, X + 54, Y - 72, 15, 15);
                g.FillEllipse(b3, X + 54, Y - 72, 15, 15);
                g.DrawEllipse(p2, X + 72, Y - 72, 15, 15);
                g.FillEllipse(b2, X + 72, Y - 72, 15, 15);

                g.DrawEllipse(p1, X, Y - 18, 15, 15);
                g.FillEllipse(b1, X, Y - 18, 15, 15);
                g.DrawEllipse(p4, X, Y - 36, 15, 15);
                g.FillEllipse(b4, X, Y - 36, 15, 15);
                g.DrawEllipse(p3, X, Y - 54, 15, 15);
                g.FillEllipse(b3, X, Y - 54, 15, 15);

                g.DrawEllipse(p3, X + 72, Y - 18, 15, 15);
                g.FillEllipse(b3, X + 72, Y - 18, 15, 15);
                g.DrawEllipse(p4, X + 72, Y - 36, 15, 15);
                g.FillEllipse(b4, X + 72, Y - 36, 15, 15);
                g.DrawEllipse(p1, X + 72, Y - 54, 15, 15);
                g.FillEllipse(b1, X + 72, Y - 54, 15, 15);

            }
            if (count % 4 == 2)
            {
                g.DrawEllipse(p3, X, Y, 15, 15);
                g.FillEllipse(b3, X, Y, 15, 15);
                g.DrawEllipse(p4, X + 18, Y, 15, 15);
                g.FillEllipse(b4, X + 18, Y, 15, 15);
                g.DrawEllipse(p1, X + 36, Y, 15, 15);
                g.FillEllipse(b1, X + 36, Y, 15, 15);
                g.DrawEllipse(p2, X + 54, Y, 15, 15);
                g.FillEllipse(b2, X + 54, Y, 15, 15);
                g.DrawEllipse(p3, X + 72, Y, 15, 15);
                g.FillEllipse(b3, X + 72, Y, 15, 15);

                g.DrawEllipse(p3, X, Y - 72, 15, 15);
                g.FillEllipse(b3, X, Y - 72, 15, 15);
                g.DrawEllipse(p2, X + 18, Y - 72, 15, 15);
                g.FillEllipse(b2, X + 18, Y - 72, 15, 15);
                g.DrawEllipse(p1, X + 36, Y - 72, 15, 15);
                g.FillEllipse(b1, X + 36, Y - 72, 15, 15);
                g.DrawEllipse(p4, X + 54, Y - 72, 15, 15);
                g.FillEllipse(b4, X + 54, Y - 72, 15, 15);
                g.DrawEllipse(p3, X + 72, Y - 72, 15, 15);
                g.FillEllipse(b3, X + 72, Y - 72, 15, 15);

                g.DrawEllipse(p2, X, Y - 18, 15, 15);
                g.FillEllipse(b2, X, Y - 18, 15, 15);
                g.DrawEllipse(p1, X, Y - 36, 15, 15);
                g.FillEllipse(b1, X, Y - 36, 15, 15);
                g.DrawEllipse(p4, X, Y - 54, 15, 15);
                g.FillEllipse(b4, X, Y - 54, 15, 15);

                g.DrawEllipse(p4, X + 72, Y - 18, 15, 15);
                g.FillEllipse(b4, X + 72, Y - 18, 15, 15);
                g.DrawEllipse(p1, X + 72, Y - 36, 15, 15);
                g.FillEllipse(b1, X + 72, Y - 36, 15, 15);
                g.DrawEllipse(p2, X + 72, Y - 54, 15, 15);
                g.FillEllipse(b2, X + 72, Y - 54, 15, 15);

            }
            if (count % 4 == 3)
            {

                g.DrawEllipse(p4, X, Y, 15, 15);
                g.FillEllipse(b4, X, Y, 15, 15);
                g.DrawEllipse(p1, X + 18, Y, 15, 15);
                g.FillEllipse(b1, X + 18, Y, 15, 15);
                g.DrawEllipse(p2, X + 36, Y, 15, 15);
                g.FillEllipse(b2, X + 36, Y, 15, 15);
                g.DrawEllipse(p3, X + 54, Y, 15, 15);
                g.FillEllipse(b3, X + 54, Y, 15, 15);
                g.DrawEllipse(p4, X + 72, Y, 15, 15);
                g.FillEllipse(b4, X + 72, Y, 15, 15);

                g.DrawEllipse(p4, X, Y - 72, 15, 15);
                g.FillEllipse(b4, X, Y - 72, 15, 15);
                g.DrawEllipse(p3, X + 18, Y - 72, 15, 15);
                g.FillEllipse(b3, X + 18, Y - 72, 15, 15);
                g.DrawEllipse(p2, X + 36, Y - 72, 15, 15);
                g.FillEllipse(b2, X + 36, Y - 72, 15, 15);
                g.DrawEllipse(p1, X + 54, Y - 72, 15, 15);
                g.FillEllipse(b1, X + 54, Y - 72, 15, 15);
                g.DrawEllipse(p4, X + 72, Y - 72, 15, 15);
                g.FillEllipse(b4, X + 72, Y - 72, 15, 15);

                g.DrawEllipse(p3, X, Y - 18, 15, 15);
                g.FillEllipse(b3, X, Y - 18, 15, 15);
                g.DrawEllipse(p2, X, Y - 36, 15, 15);
                g.FillEllipse(b2, X, Y - 36, 15, 15);
                g.DrawEllipse(p1, X, Y - 54, 15, 15);
                g.FillEllipse(b1, X, Y - 54, 15, 15);

                g.DrawEllipse(p1, X + 72, Y - 18, 15, 15);
                g.FillEllipse(b1, X + 72, Y - 18, 15, 15);
                g.DrawEllipse(p2, X + 72, Y - 36, 15, 15);
                g.FillEllipse(b2, X + 72, Y - 36, 15, 15);
                g.DrawEllipse(p3, X + 72, Y - 54, 15, 15);
                g.FillEllipse(b3, X + 72, Y - 54, 15, 15);
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
