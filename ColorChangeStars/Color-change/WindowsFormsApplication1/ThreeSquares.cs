﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ThreeSquares : Shape
    {
        public int count { get; set; }
        public ThreeSquares(float x, float y, int c):base(x,y)
        {
            count = c;
        }
        public override void Draw(Graphics g)
        {
            Pen p1 = new Pen(Color.Firebrick, 3);
            Pen p2 = new Pen(Color.IndianRed, 3);
            Pen p3 = new Pen(Color.RosyBrown, 3);
            Pen p4 = new Pen(Color.MistyRose, 3);

            if (count % 4 == 0)
            {
                // maliot kvadrat
                g.DrawLine(p1, X + 10, Y - 10, X + 50, Y - 10);
                g.DrawLine(p2, X + 10, Y - 10, X + 10, Y - 50);
                g.DrawLine(p3, X + 10, Y - 50, X + 50, Y - 50);
                g.DrawLine(p4, X + 50, Y - 10, X + 50, Y - 50);

                // sredniot kvadrat
                g.DrawLine(p1, X, Y, X + 60, Y);
                g.DrawLine(p2, X, Y, X, Y - 60);
                g.DrawLine(p3, X, Y - 60, X + 60, Y - 60);
                g.DrawLine(p4, X + 60, Y, X + 60, Y - 60);

                // golemiot kvadrat
                g.DrawLine(p1, X - 10, Y + 10, X + 70, Y + 10);
                g.DrawLine(p2, X - 10, Y + 10, X - 10, Y - 70);
                g.DrawLine(p3, X - 10, Y - 70, X + 70, Y - 70);
                g.DrawLine(p4, X + 70, Y - 70, X + 70, Y + 10);             
            }
            if (count % 4 == 1)
            {
                // maliot kvadrat
                g.DrawLine(p2, X + 10, Y - 10, X + 50, Y - 10);
                g.DrawLine(p3, X + 10, Y - 10, X + 10, Y - 50);
                g.DrawLine(p4, X + 10, Y - 50, X + 50, Y - 50);
                g.DrawLine(p1, X + 50, Y - 10, X + 50, Y - 50);

                // sredniot kvadrat
                g.DrawLine(p4, X, Y, X + 60, Y);
                g.DrawLine(p1, X, Y, X, Y - 60);
                g.DrawLine(p2, X, Y - 60, X + 60, Y - 60);
                g.DrawLine(p3, X + 60, Y, X + 60, Y - 60);

                // golemiot kvadrat
                g.DrawLine(p2, X - 10, Y + 10, X + 70, Y + 10);
                g.DrawLine(p3, X - 10, Y + 10, X - 10, Y - 70);
                g.DrawLine(p4, X - 10, Y - 70, X + 70, Y - 70);
                g.DrawLine(p1, X + 70, Y - 70, X + 70, Y + 10);
            }
            if (count % 4 == 2)
            {
                // maliot kvadrat
                g.DrawLine(p3, X + 10, Y - 10, X + 50, Y - 10);
                g.DrawLine(p4, X + 10, Y - 10, X + 10, Y - 50);
                g.DrawLine(p1, X + 10, Y - 50, X + 50, Y - 50);
                g.DrawLine(p2, X + 50, Y - 10, X + 50, Y - 50);

                // sredniot kvadrat
                g.DrawLine(p3, X, Y, X + 60, Y);
                g.DrawLine(p4, X, Y, X, Y - 60);
                g.DrawLine(p1, X, Y - 60, X + 60, Y - 60);
                g.DrawLine(p2, X + 60, Y, X + 60, Y - 60);

                // golemiot kvadrat
                g.DrawLine(p3, X - 10, Y + 10, X + 70, Y + 10);
                g.DrawLine(p4, X - 10, Y + 10, X - 10, Y - 70);
                g.DrawLine(p1, X - 10, Y - 70, X + 70, Y - 70);
                g.DrawLine(p2, X + 70, Y - 70, X + 70, Y + 10);
            }
            if (count % 4 == 3)
            {
                // maliot kvadrat
                g.DrawLine(p4, X + 10, Y - 10, X + 50, Y - 10);
                g.DrawLine(p1, X + 10, Y - 10, X + 10, Y - 50);
                g.DrawLine(p2, X + 10, Y - 50, X + 50, Y - 50);
                g.DrawLine(p3, X + 50, Y - 10, X + 50, Y - 50);

                // sredniot kvadrat
                g.DrawLine(p2, X, Y, X + 60, Y);
                g.DrawLine(p3, X, Y, X, Y - 60);
                g.DrawLine(p4, X, Y - 60, X + 60, Y - 60);
                g.DrawLine(p1, X + 60, Y, X + 60, Y - 60);

                // golemiot kvadrat
                g.DrawLine(p4, X - 10, Y + 10, X + 70, Y + 10);
                g.DrawLine(p1, X - 10, Y + 10, X - 10, Y - 70);
                g.DrawLine(p2, X - 10, Y - 70, X + 70, Y - 70);
                g.DrawLine(p3, X + 70, Y - 70, X + 70, Y + 10);
            }


            p1.Dispose();           
            p4.Dispose();
            p3.Dispose();
            p2.Dispose();
        }
    }
}
