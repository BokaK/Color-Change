using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Ball_Easy : Shape
    {
        public int X { set; get; }
        public int Y { set; get; }
        public int count { set; get;}
        public Ball_Easy (int x, int y, int c)
            :base(x,y)
        {
            X = x;
            Y = y;
            count = c;
        }
        public override void Draw(Graphics g)
        {
            Pen p1 = new Pen(Color.Firebrick);
            Pen p2 = new Pen(Color.IndianRed);
            Pen p3 = new Pen(Color.RosyBrown);
            Pen p4 = new Pen(Color.MistyRose);
            Brush b1 = new SolidBrush(Color.Firebrick);
            Brush b2 = new SolidBrush(Color.IndianRed);
            Brush b3 = new SolidBrush(Color.RosyBrown);
            Brush b4 = new SolidBrush(Color.MistyRose);
            Pen p = new Pen(Color.Transparent);
            
            if (count % 2 == 0)
            {
                g.DrawEllipse(p, X, Y, 60, 60);
            }
            if (count % 2 == 1)
            {
                Random r = new Random();
                int broj = r.Next(1, 4);
                if (broj == 1)
                {
                    g.DrawEllipse(p1, X, Y, 60, 60);
                    g.FillEllipse(b1, X, Y, 60, 60);
                }
                if (broj == 2)
                {
                    g.DrawEllipse(p2, X, Y, 60, 60);
                    g.FillEllipse(b2, X, Y, 60, 60);
                }
                if (broj == 3)
                {
                    g.DrawEllipse(p3, X, Y, 60, 60);
                    g.FillEllipse(b3, X, Y, 60, 60);
                }
                if (broj == 4)
                {
                    g.DrawEllipse(p4, X, Y, 60, 60);
                    g.FillEllipse(b4, X, Y, 60, 60);
                }
            }
            b4.Dispose();
            p1.Dispose();
            b3.Dispose();
            b2.Dispose();
            b1.Dispose();
            p4.Dispose();
            p3.Dispose();
            p2.Dispose();
            p.Dispose();

        }
    }
}
