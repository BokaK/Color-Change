using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Triangle :Shape
    {
        public int X { set; get; }
        public int Y { set; get; }
        public int count { set; get; }
        public int flag { set; get; }
        public Triangle (int x, int y, int c, int f)
            :base(x,y)
        {
            X = x;
            Y = y;
            count = c;
            flag = f;
        }
        public override void Draw(Graphics g)
        {
            Pen p1 = new Pen(Color.Firebrick,3);
            Pen p2 = new Pen(Color.IndianRed,3);
            Pen p3 = new Pen(Color.RosyBrown,3);
            Pen p4 = new Pen(Color.MistyRose,3);
            Pen p = new Pen(Color.Transparent);
            if (flag == 0)
            {
                if (count % 4 == 0)
                {
                    g.DrawLine(p1, X, Y, X + 32, Y - 64);
                    g.DrawLine(p2, X + 32, Y - 64, X + 64, Y);
                    g.DrawLine(p3, X, Y, X + 64, Y);
                }
                if (count % 4 == 1)
                {
                    g.DrawLine(p3, X, Y, X + 32, Y - 64);
                    g.DrawLine(p1, X + 32, Y - 64, X + 64, Y);
                    g.DrawLine(p2, X, Y, X + 64, Y);
                }
                if (count % 4 == 2)
                {
                    g.DrawLine(p2, X, Y, X + 32, Y - 64);
                    g.DrawLine(p3, X + 32, Y - 64, X + 64, Y);
                    g.DrawLine(p1, X, Y, X + 64, Y);
                }
                if (count % 4 == 3)
                {
                    g.DrawLine(p1, X, Y, X , Y - 64);
                    g.DrawLine(p2, X + 64, Y - 64, X + 64, Y);
                    g.DrawLine(p3, X, Y, X + 64, Y);

                }
            }
            if (flag == 1)
            {
                if (count % 4 == 0)
                {
                    g.DrawLine(p2, X, Y, X + 32, Y - 64);
                    g.DrawLine(p1, X + 32, Y - 64, X + 64, Y);
                    g.DrawLine(p3, X, Y, X + 64, Y);
                }
                if (count % 4 == 1)
                {
                    g.DrawLine(p3, X, Y, X + 32, Y - 64);
                    g.DrawLine(p2, X + 32, Y - 64, X + 64, Y);
                    g.DrawLine(p1, X, Y, X + 64, Y);
                }
                if (count % 4 == 2)
                {
                    g.DrawLine(p1, X, Y, X + 32, Y - 64);
                    g.DrawLine(p3, X + 32, Y - 64, X + 64, Y);
                    g.DrawLine(p2, X, Y, X + 64, Y);
                }
                if (count % 4 == 3)
                {
                    g.DrawLine(p1, X, Y, X, Y - 64);
                    g.DrawLine(p2, X + 64, Y - 64, X + 64, Y);
                    g.DrawLine(p3, X, Y, X + 64, Y);

                }
            }
            if (flag == 2)
            {
                if (count % 4 == 0)
                {
                    g.DrawLine(p3, X, Y, X + 32, Y - 64);
                    g.DrawLine(p4, X + 32, Y - 64, X + 64, Y);
                    g.DrawLine(p2, X, Y, X + 64, Y);
                }
                if (count % 4 == 1)
                {
                    g.DrawLine(p2, X, Y, X + 32, Y - 64);
                    g.DrawLine(p3, X + 32, Y - 64, X + 64, Y);
                    g.DrawLine(p4, X, Y, X + 64, Y);
                }
                if (count % 4 == 2)
                {
                    g.DrawLine(p4, X, Y, X + 32, Y - 64);
                    g.DrawLine(p2, X + 32, Y - 64, X + 64, Y);
                    g.DrawLine(p3, X, Y, X + 64, Y);
                }
                if (count % 4 == 3)
                {
                    g.DrawLine(p4, X, Y, X, Y - 64);
                    g.DrawLine(p2, X + 64, Y - 64, X + 64, Y);
                    g.DrawLine(p3, X, Y, X + 64, Y);

                }

            }
            if (flag == 3)
            {
                if (count % 4 == 0)
                {
                    g.DrawLine(p4, X, Y, X + 32, Y - 64);
                    g.DrawLine(p1, X + 32, Y - 64, X + 64, Y);
                    g.DrawLine(p3, X, Y, X + 64, Y);
                }
                if (count % 4 == 1)
                {
                    g.DrawLine(p3, X, Y, X + 32, Y - 64);
                    g.DrawLine(p4, X + 32, Y - 64, X + 64, Y);
                    g.DrawLine(p1, X, Y, X + 64, Y);
                }
                if (count % 4 == 2)
                {
                    g.DrawLine(p1, X, Y, X + 32, Y - 64);
                    g.DrawLine(p3, X + 32, Y - 64, X + 64, Y);
                    g.DrawLine(p4, X, Y, X + 64, Y);
                }
                if (count % 4 == 3)
                {
                    g.DrawLine(p1, X, Y, X, Y - 64);
                    g.DrawLine(p4, X + 64, Y - 64, X + 64, Y);
                    g.DrawLine(p3, X, Y, X + 64, Y);

                }

            }


            p1.Dispose();
            p4.Dispose();
            p3.Dispose();
            p2.Dispose();
        }
    }
}
