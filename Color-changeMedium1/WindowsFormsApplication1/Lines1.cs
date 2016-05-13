using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Lines1 : Shape
    {
        public int X2 { get; set; }
        public int count { get; set; }
        public Lines1(float x, float y, int c)
            : base(x, y)
        {
            count = c;
            X2 = 0;        
            X =0;
        }
        public override void Draw(Graphics g)
        {
           
            Pen p1 = new Pen(Color.Firebrick, 3);
            Pen p2 = new Pen(Color.IndianRed, 3);
            Pen p3 = new Pen(Color.RosyBrown, 3);
            Pen p4 = new Pen(Color.MistyRose, 3);
            
            if (count % 4 == 0)
            {
                while (X < 640)
                {
                    g.DrawLine(p1, X, Y, X + 65, Y);
                    X += 65;
                    g.DrawLine(p2, X, Y, X + 65, Y);
                    X += 65;
                    g.DrawLine(p3, X, Y, X + 65, Y);
                    X += 65;
                    g.DrawLine(p4, X, Y, X + 65, Y);
                    X += 65;


                    g.DrawLine(p1, X2, Y - 58, X2 + 65, Y - 58);
                    X2 += 65;
                    g.DrawLine(p2, X2, Y - 58, X2 + 65, Y - 58);
                    X2 += 65;
                    g.DrawLine(p3, X2, Y - 58, X2 + 65, Y - 58);
                    X2 += 65;
                    g.DrawLine(p4, X2, Y - 58, X2 + 65, Y - 58);
                    X2 += 65;
                }

            }
            if (count % 4 == 1)
            {

                while (X < 640)
                {
                    g.DrawLine(p2, X, Y, X + 65, Y);
                    X += 65;
                    g.DrawLine(p3, X, Y, X + 65, Y);
                    X += 65;
                    g.DrawLine(p4, X, Y, X + 65, Y);
                    X += 65;
                    g.DrawLine(p1, X, Y, X + 65, Y);
                    X += 65;


                    g.DrawLine(p2, X2, Y - 58, X2 + 65, Y - 58);
                    X2 += 65;
                    g.DrawLine(p3, X2, Y - 58, X2 + 65, Y - 58);
                    X2 += 65;
                    g.DrawLine(p4, X2, Y - 58, X2 + 65, Y - 58);
                    X2 += 65;
                    g.DrawLine(p1, X2, Y - 58, X2 + 65, Y - 58);
                    X2 += 65;
                }


            }
            if (count % 4 == 2)
            {
                while (X < 640)
                {
                    g.DrawLine(p3, X, Y, X + 65, Y);
                    X += 65;
                    g.DrawLine(p4, X, Y, X + 65, Y);
                    X += 65;
                    g.DrawLine(p1, X, Y, X + 65, Y);
                    X += 65;
                    g.DrawLine(p2, X, Y, X + 65, Y);
                    X += 65;

                    g.DrawLine(p3, X2, Y - 58, X2 + 65, Y - 58);
                    X2 += 65;
                    g.DrawLine(p4, X2, Y - 58, X2 + 65, Y - 58);
                    X2 += 65;
                    g.DrawLine(p1, X2, Y - 58, X2 + 65, Y - 58);
                    X2 += 65;
                    g.DrawLine(p2, X2, Y - 58, X2 + 65, Y - 58);
                    X2 += 65;
                }


            }
            if (count % 4 == 3)
            {
                while (X < 640)
                {
                    g.DrawLine(p4, X, Y, X + 65, Y);
                    X += 65;
                    g.DrawLine(p1, X, Y, X + 65, Y);
                    X += 65;
                    g.DrawLine(p2, X, Y, X + 65, Y);
                    X += 65;
                    g.DrawLine(p3, X, Y, X + 65, Y);
                    X += 65;


                    g.DrawLine(p4, X2, Y - 58, X2 + 65, Y-58);
                    X2 += 65;
                    g.DrawLine(p1, X2, Y - 58, X2 + 65, Y - 58);
                    X2 += 65;
                    g.DrawLine(p2, X2, Y - 58, X2 + 65, Y - 58);
                    X2 += 65;
                    g.DrawLine(p3, X2, Y - 58, X2 + 65, Y - 58);
                    X2 += 65;
                }

            }

            p1.Dispose();
            p2.Dispose();
            p3.Dispose();
            p4.Dispose();
            
        }

    }
}
