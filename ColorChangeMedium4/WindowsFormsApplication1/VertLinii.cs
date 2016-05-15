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
            if (count % 14 == 0)
            {
                g.DrawLine(p1, X + 20, Y, X + 20, Y - 60);
                g.DrawLine(p2, X + 60, Y, X  + 60 , Y - 60);
                g.DrawLine(p3, X + 100, Y, X + 100, Y - 60);
                g.DrawLine(p4, X + 140, Y, X + 140, Y - 60);
                g.DrawLine(p1, X + 180, Y, X + 180, Y - 60);
                g.DrawLine(p2, X + 220, Y, X + 220, Y - 60);
                g.DrawLine(p3, X + 260, Y, X + 260, Y - 60);
               
            }
            if (count % 14 == 1)
            {

                g.DrawLine(p1, X + 40, Y, X + 40, Y - 60);
                g.DrawLine(p2, X + 80, Y, X + 80, Y - 60);
                g.DrawLine(p3, X + 120, Y, X + 120, Y - 60);
                g.DrawLine(p4, X + 160, Y, X + 160, Y - 60);
                g.DrawLine(p1, X + 200, Y, X + 200, Y - 60);
                g.DrawLine(p2, X + 240, Y, X + 240, Y - 60);
                g.DrawLine(p3, X + 280, Y, X + 280, Y - 60);

            }
           
            if (count % 14 == 2)
            {
                g.DrawLine(p3, X + 20, Y, X + 20, Y - 60);
                g.DrawLine(p1, X + 60, Y, X + 60, Y - 60);
                g.DrawLine(p2, X + 100, Y, X + 100, Y - 60);
                g.DrawLine(p3, X + 140, Y, X + 140, Y - 60);
                g.DrawLine(p4, X + 180, Y, X + 180, Y - 60);
                g.DrawLine(p1, X + 220, Y, X + 220, Y - 60);
                g.DrawLine(p2, X + 260, Y, X + 260, Y - 60);

            }
            if (count % 14 == 3)
            {
                g.DrawLine(p3, X + 40, Y, X + 40, Y - 60);
                g.DrawLine(p1, X + 80, Y, X + 80, Y - 60);
                g.DrawLine(p2, X + 120, Y, X + 120, Y - 60);
                g.DrawLine(p3, X + 160, Y, X + 160, Y - 60);
                g.DrawLine(p4, X + 200, Y, X + 200, Y - 60);
                g.DrawLine(p1, X + 240, Y, X + 240, Y - 60);
                g.DrawLine(p2, X + 280, Y, X + 280, Y - 60);

            }
            if (count % 14 == 4)
            {
                g.DrawLine(p2, X + 20, Y, X + 20, Y - 60);
                g.DrawLine(p3, X + 60, Y, X + 60, Y - 60);
                g.DrawLine(p1, X + 100, Y, X + 100, Y - 60);
                g.DrawLine(p2, X + 140, Y, X + 140, Y - 60);
                g.DrawLine(p3, X + 180, Y, X + 180, Y - 60);
                g.DrawLine(p4, X + 220, Y, X + 220, Y - 60);
                g.DrawLine(p1, X + 260, Y, X + 260, Y - 60);

            }
            if (count % 14 == 5)
            {
                g.DrawLine(p2, X + 40, Y, X + 40, Y - 60);
                g.DrawLine(p3, X + 80, Y, X + 80, Y - 60);
                g.DrawLine(p1, X + 120, Y, X + 120, Y - 60);
                g.DrawLine(p2, X + 160, Y, X + 160, Y - 60);
                g.DrawLine(p3, X + 200, Y, X + 200, Y - 60);
                g.DrawLine(p4, X + 240, Y, X + 240, Y - 60);
                g.DrawLine(p1, X + 280, Y, X + 280, Y - 60);

            }
            if (count % 14 == 6)
            {
                g.DrawLine(p1, X + 20, Y, X + 20, Y - 60);
                g.DrawLine(p2, X + 60, Y, X + 60, Y - 60);
                g.DrawLine(p3, X + 100, Y, X + 100, Y - 60);
                g.DrawLine(p1, X + 140, Y, X + 140, Y - 60);
                g.DrawLine(p2, X + 180, Y, X + 180, Y - 60);
                g.DrawLine(p3, X + 220, Y, X + 220, Y - 60);
                g.DrawLine(p4, X + 260, Y, X + 260, Y - 60);

            }
            if (count % 14 == 7)
            {
                g.DrawLine(p1, X + 40, Y, X + 40, Y - 60);
                g.DrawLine(p2, X + 80, Y, X + 80, Y - 60);
                g.DrawLine(p3, X + 120, Y, X + 120, Y - 60);
                g.DrawLine(p1, X + 160, Y, X + 160, Y - 60);
                g.DrawLine(p2, X + 200, Y, X + 200, Y - 60);
                g.DrawLine(p3, X + 240, Y, X + 240, Y - 60);
                g.DrawLine(p4, X + 280, Y, X + 280, Y - 60);

            }
            if (count % 14 == 8)
            {
                g.DrawLine(p4, X + 20, Y, X + 20, Y - 60);
                g.DrawLine(p1, X + 60, Y, X + 60, Y - 60);
                g.DrawLine(p2, X + 100, Y, X + 100, Y - 60);
                g.DrawLine(p3, X + 140, Y, X + 140, Y - 60);
                g.DrawLine(p1, X + 180, Y, X + 180, Y - 60);
                g.DrawLine(p2, X + 220, Y, X + 220, Y - 60);
                g.DrawLine(p3, X + 260, Y, X + 260, Y - 60);

            }
            if (count % 14 == 9)
            {
                g.DrawLine(p4, X + 40, Y, X + 40, Y - 60);
                g.DrawLine(p1, X + 80, Y, X + 80, Y - 60);
                g.DrawLine(p2, X + 120, Y, X + 120, Y - 60);
                g.DrawLine(p3, X + 160, Y, X + 160, Y - 60);
                g.DrawLine(p1, X + 200, Y, X + 200, Y - 60);
                g.DrawLine(p2, X + 240, Y, X + 240, Y - 60);
                g.DrawLine(p3, X + 280, Y, X + 280, Y - 60);

            }
            if (count % 14 == 10)
            {
                g.DrawLine(p3, X + 20, Y, X + 20, Y - 60);
                g.DrawLine(p4, X + 60, Y, X + 60, Y - 60);
                g.DrawLine(p1, X + 100, Y, X + 100, Y - 60);
                g.DrawLine(p2, X + 140, Y, X + 140, Y - 60);
                g.DrawLine(p3, X + 180, Y, X + 180, Y - 60);
                g.DrawLine(p1, X + 220, Y, X + 220, Y - 60);
                g.DrawLine(p2, X + 260, Y, X + 260, Y - 60);

            }
            if (count % 14 == 11)
            {
                g.DrawLine(p3, X + 40, Y, X + 40, Y - 60);
                g.DrawLine(p4, X + 80, Y, X + 80, Y - 60);
                g.DrawLine(p1, X + 120, Y, X + 120, Y - 60);
                g.DrawLine(p2, X + 160, Y, X + 160, Y - 60);
                g.DrawLine(p3, X + 200, Y, X + 200, Y - 60);
                g.DrawLine(p1, X + 240, Y, X + 240, Y - 60);
                g.DrawLine(p2, X + 280, Y, X + 280, Y - 60);

            }
            if (count % 14 == 12)
            {
                g.DrawLine(p2, X + 20, Y, X + 20, Y - 60);
                g.DrawLine(p3, X + 60, Y, X + 60, Y - 60);
                g.DrawLine(p4, X + 100, Y, X + 100, Y - 60);
                g.DrawLine(p1, X + 140, Y, X + 140, Y - 60);
                g.DrawLine(p2, X + 180, Y, X + 180, Y - 60);
                g.DrawLine(p3, X + 220, Y, X + 220, Y - 60);
                g.DrawLine(p1, X + 260, Y, X + 260, Y - 60);

            }
            if (count % 14 == 13)
            {
                g.DrawLine(p2, X + 40, Y, X + 40, Y - 60);
                g.DrawLine(p3, X + 80, Y, X + 80, Y - 60);
                g.DrawLine(p4, X + 120, Y, X + 120, Y - 60);
                g.DrawLine(p1, X + 160, Y, X + 160, Y - 60);
                g.DrawLine(p2, X + 200, Y, X + 200, Y - 60);
                g.DrawLine(p3, X + 240, Y, X + 240, Y - 60);
                g.DrawLine(p1, X + 280, Y, X + 280, Y - 60);

            }

            p1.Dispose();
            p2.Dispose();
            p3.Dispose();
            p4.Dispose();
        }
    }
}
