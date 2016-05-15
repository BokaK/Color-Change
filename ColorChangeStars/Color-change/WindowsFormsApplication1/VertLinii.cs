using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class VertLinii : Shape
    {
        public int count { get; set; }
        public VertLinii(float x, float y, int c) : base(x, y)
        {
            count = c;
        }


        public override void Draw(Graphics g)
        {
            Pen p1 = new Pen(Color.Firebrick, 3);
            Pen p2 = new Pen(Color.IndianRed, 3);
            Pen p3 = new Pen(Color.RosyBrown, 3);
            Pen p4 = new Pen(Color.MistyRose, 3);
            Pen p5 = new Pen(Color.Black, 3);
            if (count % 4 == 0)
            {
                g.DrawLine(p1, X + 20, Y, X + 20, Y - 60);
                g.DrawLine(p2, X + 50, Y, X  + 50 , Y - 60);
                g.DrawLine(p3, X + 80, Y, X + 80, Y - 60);
                g.DrawLine(p4, X + 110, Y, X + 110, Y - 60);
                g.DrawLine(p1, X + 140, Y, X + 140, Y - 60);
                g.DrawLine(p2, X + 170, Y, X + 170, Y - 60);
                g.DrawLine(p3, X + 200, Y, X + 200, Y - 60);
                X += 10;
                // g.DrawLine(p5, X + 190, Y, X + 190, Y - 60);
            }
            if (count % 4 == 1)
            {

                g.DrawLine(p1, X + 20, Y, X + 20, Y - 60);
                g.DrawLine(p2, X + 50, Y, X + 50, Y - 60);
                g.DrawLine(p3, X + 80, Y, X + 80, Y - 60);
                g.DrawLine(p4, X + 110, Y, X + 110, Y - 60);
                g.DrawLine(p1, X + 140, Y, X + 140, Y - 60);
                g.DrawLine(p2, X + 170, Y, X + 170, Y - 60);
                g.DrawLine(p3, X + 200, Y, X + 200, Y - 60);
                X += 10;
            }
           
            if (count % 4 == 2)
            {
                g.DrawLine(p1, X + 20, Y, X + 20, Y - 60);
                g.DrawLine(p2, X + 50, Y, X + 50, Y - 60);
                g.DrawLine(p3, X + 80, Y, X + 80, Y - 60);
                g.DrawLine(p4, X + 110, Y, X + 110, Y - 60);
                g.DrawLine(p1, X + 140, Y, X + 140, Y - 60);
                g.DrawLine(p2, X + 170, Y, X + 170, Y - 60);
                g.DrawLine(p3, X + 200, Y, X + 200, Y - 60);
                X += 10;
            }
            if (count % 4 == 3)
            {
                g.DrawLine(p1, X + 20, Y, X + 20, Y - 60);
                g.DrawLine(p2, X + 50, Y, X + 50, Y - 60);
                g.DrawLine(p3, X + 80, Y, X + 80, Y - 60);
                g.DrawLine(p4, X + 110, Y, X + 110, Y - 60);
                g.DrawLine(p1, X + 140, Y, X + 140, Y - 60);
                g.DrawLine(p2, X + 170, Y, X + 170, Y - 60);
                g.DrawLine(p3, X + 200, Y, X + 200, Y - 60);
                X += 10;
            }
            p1.Dispose();
            p2.Dispose();
            p3.Dispose();
            p4.Dispose();
        }
    }
}
