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
            X2 = -10;        
            X =x;
        }
        public override void Draw(Graphics g)
        {
           
            Pen p1 = new Pen(Color.Firebrick, 3);
            Pen p2 = new Pen(Color.IndianRed, 3);
            Pen p3 = new Pen(Color.RosyBrown, 3);
            Pen p4 = new Pen(Color.MistyRose, 3);
            
            if (count % 4 == 0)
            {
                    g.DrawLine(p1, X, Y, X + 65, Y);                 
                    g.DrawLine(p2, X+65, Y, X + 130, Y);                 
                    g.DrawLine(p3, X+130, Y, X + 195, Y);                 
                    g.DrawLine(p4, X+195, Y, X + 260, Y);                   
                    g.DrawLine(p1, X+260, Y, X + 300, Y);

                    g.DrawLine(p3, X2, Y - 58, X2 + 65, Y - 58);
                    g.DrawLine(p4, X2+65, Y - 58, X2 + 130, Y - 58);
                    g.DrawLine(p1, X2+130, Y - 58, X2 + 195, Y - 58);
                    g.DrawLine(p2, X2+195, Y - 58, X2 + 260, Y - 58);
                    g.DrawLine(p3, X2+260, Y - 58, X2 + 300, Y - 58);


            }
            if (count % 4 == 1)
            {

                g.DrawLine(p2, X, Y, X + 65, Y);
                g.DrawLine(p3, X + 65, Y, X + 130, Y);
                g.DrawLine(p4, X + 130, Y, X + 195, Y);
                g.DrawLine(p1, X + 195, Y, X + 260, Y);
                g.DrawLine(p2, X + 260, Y, X + 300, Y);


                g.DrawLine(p4, X2, Y - 58, X2 + 65, Y - 58);
                g.DrawLine(p1, X2 + 65, Y - 58, X2 + 130, Y - 58);
                g.DrawLine(p2, X2 + 130, Y - 58, X2 + 195, Y - 58);
                g.DrawLine(p3, X2 + 195, Y - 58, X2 + 260, Y - 58);
                g.DrawLine(p4, X2 + 260, Y - 58, X2 + 300, Y - 58);



            }
            if (count % 4 == 2)
            {
               
                    g.DrawLine(p3, X, Y, X + 65, Y);
                    g.DrawLine(p4, X+65, Y, X + 130, Y);
                    g.DrawLine(p1, X+130, Y, X + 195, Y);
                    g.DrawLine(p2, X+195, Y, X + 260, Y);
                    g.DrawLine(p3, X+260, Y, X + 300, Y);

                g.DrawLine(p1, X2, Y - 58, X2 + 65, Y - 58);
                g.DrawLine(p2, X2 + 65, Y - 58, X2 + 130, Y - 58);
                g.DrawLine(p3, X2 + 130, Y - 58, X2 + 195, Y - 58);
                g.DrawLine(p4, X2 + 195, Y - 58, X2 + 260, Y - 58);
                g.DrawLine(p1, X2 + 260, Y - 58, X2 + 300, Y - 58);



            }
            if (count % 4 == 3)
            {

                g.DrawLine(p4, X, Y, X + 65, Y);
                g.DrawLine(p1, X + 65, Y, X + 130, Y);
                g.DrawLine(p2, X + 130, Y, X + 195, Y);
                g.DrawLine(p3, X + 195, Y, X + 260, Y);
                g.DrawLine(p4, X + 260, Y, X + 300, Y);


                g.DrawLine(p2, X2, Y - 58, X2 + 65, Y - 58);
                g.DrawLine(p3, X2 + 65, Y - 58, X2 + 130, Y - 58);
                g.DrawLine(p4, X2 + 130, Y - 58, X2 + 195, Y - 58);
                g.DrawLine(p1, X2 + 195, Y - 58, X2 + 260, Y - 58);
                g.DrawLine(p2, X2 + 260, Y - 58, X2 + 300, Y - 58);


            }

            p1.Dispose();
            p2.Dispose();
            p3.Dispose();
            p4.Dispose();
            
        }

    }
}
