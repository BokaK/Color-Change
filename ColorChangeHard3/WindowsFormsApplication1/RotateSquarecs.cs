using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class RotateSquarecs : Shape
    {
        public int count { get; set; }
        public RotateSquarecs(float x, float y, int c) : base(x, y)
        {
            count = c;
        }

        public override void Draw(Graphics g)
        {
            Pen p1 = new Pen(Color.Firebrick, 3);
            Pen p2 = new Pen(Color.IndianRed, 3);
            Pen p3 = new Pen(Color.RosyBrown, 3);
            Pen p4 = new Pen(Color.MistyRose, 3);
            if (count % 8 == 0)
           {
                g.DrawLine(p1, X, Y - 30, X + 30, Y ); // -
               g.DrawLine(p2, X + 30, Y, X + 60, Y - 30);
               g.DrawLine(p3, X + 60, Y -30, X + 30, Y - 60);
                g.DrawLine(p4, X + 30, Y - 60, X, Y - 30);
              }
            if (count % 8 == 1)
               {
                g.DrawLine(p2, X, Y, X + 60, Y); // -
                g.DrawLine(p3, X + 60, Y, X + 60, Y - 60);
                 g.DrawLine(p4, X + 60, Y - 60, X, Y - 60);
                  g.DrawLine(p1, X, Y - 60, X, Y);
                }
               if (count % 8 == 2)
              {
                 g.DrawLine(p2, X, Y - 30, X + 30, Y ); // -
            g.DrawLine(p3, X + 30, Y, X + 60, Y - 30);
            g.DrawLine(p4, X + 60, Y - 30, X + 30, Y - 60);
            g.DrawLine(p1, X + 30, Y - 60, X, Y - 30);
               }
                if (count % 8 == 3)
               {
           g.DrawLine(p3, X, Y, X + 60, Y); // -
                g.DrawLine(p4, X + 60, Y, X + 60, Y - 60);
               g.DrawLine(p1, X + 60, Y - 60, X, Y - 60);
                 g.DrawLine(p2, X, Y - 60, X, Y);
                }
            if (count % 8 == 4)
            {
              g.DrawLine(p3, X, Y - 30, X + 30, Y); // -
               g.DrawLine(p4, X + 30, Y, X + 60, Y - 30);
                g.DrawLine(p1, X + 60, Y - 30, X + 30, Y - 60);
              g.DrawLine(p2, X + 30, Y - 60, X, Y - 30);
            }
            if (count % 8 == 5)
           {
                g.DrawLine(p4, X, Y, X + 60, Y); // -
                g.DrawLine(p1, X + 60, Y, X + 60, Y - 60);
              g.DrawLine(p2, X + 60, Y - 60, X, Y - 60);
               g.DrawLine(p3, X, Y - 60, X, Y);
            }
            if (count % 8 == 6)
            {
                g.DrawLine(p4, X, Y - 30, X + 30, Y); // -
               g.DrawLine(p1, X + 30, Y, X + 60, Y - 30);
                g.DrawLine(p2, X + 60, Y - 30, X + 30, Y - 60);
                g.DrawLine(p3, X + 30, Y - 60, X, Y - 30);
            }
            if (count % 8 == 7)
           {
                g.DrawLine(p1, X, Y, X + 60, Y); // -
               g.DrawLine(p2, X + 60, Y, X + 60, Y - 60);
               g.DrawLine(p3, X + 60, Y - 60, X, Y - 60);
               g.DrawLine(p4, X, Y - 60, X, Y);
            }
            p1.Dispose();
            p2.Dispose();
            p3.Dispose();
            p4.Dispose();
        }
    }
}
   
