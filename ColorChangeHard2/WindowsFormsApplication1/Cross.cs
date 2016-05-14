using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Cross : Shape
    {
        public int count { get; set; }
        public Cross(float x, float y, int c) : base (x, y)
        {
            count = c; 
        }
        public override void Draw(Graphics g)
        {
            Pen p1 = new Pen(Color.Firebrick, 3);
            Pen p2 = new Pen(Color.RosyBrown, 3);
            Pen p3 = new Pen(Color.IndianRed, 3);
            Pen p4 = new Pen(Color.MistyRose, 3);

            if(count % 16 == 0)
            {
                g.DrawLine(p1, X + 30, Y - 30, X + 60, Y - 30);
                g.DrawLine(p2, X + 60, Y, X + 60, Y - 30);
                g.DrawLine(p3, X + 90, Y - 30, X + 60, Y - 30);
                g.DrawLine(p4, X + 60, Y - 60, X + 60, Y - 30);

                g.DrawLine(p1, X + 25, Y - 30, X - 5, Y - 30);
                g.DrawLine(p2, X - 5, Y, X - 5, Y - 30);
                g.DrawLine(p3, X - 35, Y - 30, X - 5, Y - 30);
                g.DrawLine(p4, X - 5, Y - 60, X - 5, Y - 30);
            }
            if (count % 16 == 1)
            {
                g.DrawLine(p1, X + 33, Y - 18, X + 60, Y - 30);
                g.DrawLine(p2, X + 72, Y - 3, X + 60, Y - 30);
                g.DrawLine(p3, X + 87, Y - 42, X + 60, Y - 30);
                g.DrawLine(p4, X + 48, Y - 57, X + 60, Y - 30);

                g.DrawLine(p1, X + 22, Y - 18, X - 5, Y - 30);
                g.DrawLine(p2, X - 17, Y - 3, X - 5, Y - 30);
                g.DrawLine(p3, X - 32, Y - 47, X - 5, Y - 30);
                g.DrawLine(p4, X + 7, Y - 57, X - 5, Y - 30);
            }
            if (count % 16 == 2)
            {
                g.DrawLine(p1, X + 39, Y - 9, X + 60, Y - 30);
                g.DrawLine(p2, X + 81, Y - 9, X + 60, Y - 30);
                g.DrawLine(p3, X + 81, Y - 51, X + 60, Y - 30);
                g.DrawLine(p4, X + 39, Y - 51, X + 60, Y - 30);

                g.DrawLine(p1, X + 16, Y - 9, X - 5, Y - 30);
                g.DrawLine(p2, X - 26, Y - 9, X - 5, Y - 30);
                g.DrawLine(p3, X - 26, Y - 51, X - 5, Y - 30);
                g.DrawLine(p4, X + 16, Y - 51, X - 5, Y - 30);
            }
            if (count % 16 == 3)
            {
                g.DrawLine(p1, X + 48, Y - 3, X + 60, Y - 30);
                g.DrawLine(p2, X + 87, Y - 18, X + 60, Y - 30);
                g.DrawLine(p3, X + 72, Y - 57, X + 60, Y - 30);
                g.DrawLine(p4, X + 33, Y - 47, X + 60, Y - 30);
               
                g.DrawLine(p1, X + 7, Y - 3, X - 5, Y - 30);
                g.DrawLine(p2, X - 32, Y - 18, X - 5, Y - 30);
                g.DrawLine(p3, X - 17, Y - 57, X - 5, Y - 30);
                g.DrawLine(p4, X + 22, Y - 42, X - 5, Y - 30);
            }
            if (count % 16 == 4)
            {
                
                g.DrawLine(p1, X + 60, Y, X + 60, Y - 30);
                g.DrawLine(p2, X + 90, Y - 30, X + 60, Y - 30);
                g.DrawLine(p3, X + 60, Y - 60, X + 60, Y - 30);
                g.DrawLine(p4, X + 30, Y - 30, X + 60, Y - 30);

               
                g.DrawLine(p1, X - 5, Y, X - 5, Y - 30);
                g.DrawLine(p2, X - 35, Y - 30, X - 5, Y - 30);
                g.DrawLine(p3, X - 5, Y - 60, X - 5, Y - 30);
                g.DrawLine(p4, X + 25, Y - 30, X - 5, Y - 30);
            }
            if (count % 16 == 5)
            {
                
                g.DrawLine(p1, X + 72, Y - 3, X + 60, Y - 30);
                g.DrawLine(p2, X + 87, Y - 42, X + 60, Y - 30);
                g.DrawLine(p3, X + 48, Y - 57, X + 60, Y - 30);
                g.DrawLine(p4, X + 33, Y - 18, X + 60, Y - 30);

               
                g.DrawLine(p1, X - 17, Y - 3, X - 5, Y - 30);
                g.DrawLine(p2, X - 32, Y - 47, X - 5, Y - 30);
                g.DrawLine(p3, X + 7, Y - 57, X - 5, Y - 30);
                g.DrawLine(p4, X + 22, Y - 18, X - 5, Y - 30);
            }
            if (count % 16 == 6)
            {
                
                g.DrawLine(p1, X + 81, Y - 9, X + 60, Y - 30);
                g.DrawLine(p2, X + 81, Y - 51, X + 60, Y - 30);
                g.DrawLine(p3, X + 39, Y - 51, X + 60, Y - 30);
                g.DrawLine(p4, X + 39, Y - 9, X + 60, Y - 30);

               
                g.DrawLine(p1, X - 26, Y - 9, X - 5, Y - 30);
                g.DrawLine(p2, X - 26, Y - 51, X - 5, Y - 30);
                g.DrawLine(p3, X + 16, Y - 51, X - 5, Y - 30);
                g.DrawLine(p4, X + 16, Y - 9, X - 5, Y - 30);
            }
            if (count % 16 == 7)
            {
                
                g.DrawLine(p1, X + 87, Y - 18, X + 60, Y - 30);
                g.DrawLine(p2, X + 72, Y - 57, X + 60, Y - 30);
                g.DrawLine(p3, X + 33, Y - 47, X + 60, Y - 30);
                g.DrawLine(p4, X + 48, Y - 3, X + 60, Y - 30);
               
                g.DrawLine(p1, X - 32, Y - 18, X - 5, Y - 30);
                g.DrawLine(p2, X - 17, Y - 57, X - 5, Y - 30);
                g.DrawLine(p3, X + 22, Y - 42, X - 5, Y - 30);
                g.DrawLine(p4, X + 7, Y - 3, X - 5, Y - 30);
            }
            if (count % 16 == 8)
            {
                g.DrawLine(p1, X + 90, Y - 30, X + 60, Y - 30);
                g.DrawLine(p2, X + 60, Y - 60, X + 60, Y - 30);
                g.DrawLine(p3, X + 30, Y - 30, X + 60, Y - 30);
                g.DrawLine(p4, X + 60, Y, X + 60, Y - 30);
                
                g.DrawLine(p1, X - 35, Y - 30, X - 5, Y - 30);
                g.DrawLine(p2, X - 5, Y - 60, X - 5, Y - 30);
                g.DrawLine(p3, X + 25, Y - 30, X - 5, Y - 30);
                g.DrawLine(p4, X - 5, Y, X - 5, Y - 30);
            }
            if (count % 16 == 9)
            {
                
                g.DrawLine(p1, X + 87, Y - 42, X + 60, Y - 30);
                g.DrawLine(p2, X + 48, Y - 57, X + 60, Y - 30);
                g.DrawLine(p3, X + 33, Y - 18, X + 60, Y - 30);
                g.DrawLine(p4, X + 72, Y - 3, X + 60, Y - 30);

                
                g.DrawLine(p1, X - 32, Y - 47, X - 5, Y - 30);
                g.DrawLine(p2, X + 7, Y - 57, X - 5, Y - 30);
                g.DrawLine(p3, X + 22, Y - 18, X - 5, Y - 30);
                g.DrawLine(p4, X - 17, Y - 3, X - 5, Y - 30);
            }
            if (count % 16 == 10)
            {
                
                g.DrawLine(p1, X + 81, Y - 51, X + 60, Y - 30);
                g.DrawLine(p2, X + 39, Y - 51, X + 60, Y - 30);
                g.DrawLine(p3, X + 39, Y - 9, X + 60, Y - 30);
                g.DrawLine(p4, X + 81, Y - 9, X + 60, Y - 30);
                
                g.DrawLine(p1, X - 26, Y - 51, X - 5, Y - 30);
                g.DrawLine(p2, X + 16, Y - 51, X - 5, Y - 30);
                g.DrawLine(p3, X + 16, Y - 9, X - 5, Y - 30);
                g.DrawLine(p4, X - 26, Y - 9, X - 5, Y - 30);
            }
            if (count % 16 == 11)
            {
                
                g.DrawLine(p1, X + 72, Y - 57, X + 60, Y - 30);
                g.DrawLine(p2, X + 33, Y - 47, X + 60, Y - 30);
                g.DrawLine(p3, X + 48, Y - 3, X + 60, Y - 30);
                g.DrawLine(p4, X + 87, Y - 18, X + 60, Y - 30);

                
                g.DrawLine(p1, X - 17, Y - 57, X - 5, Y - 30);
                g.DrawLine(p2, X + 22, Y - 42, X - 5, Y - 30);
                g.DrawLine(p3, X + 7, Y - 3, X - 5, Y - 30);
                g.DrawLine(p4, X - 32, Y - 18, X - 5, Y - 30);
            }
            if (count % 16 == 12)
            {
               
                g.DrawLine(p1, X + 60, Y - 60, X + 60, Y - 30);
                g.DrawLine(p2, X + 30, Y - 30, X + 60, Y - 30);
                g.DrawLine(p3, X + 60, Y, X + 60, Y - 30);
                g.DrawLine(p4, X + 90, Y - 30, X + 60, Y - 30);
                
                g.DrawLine(p1, X - 5, Y - 60, X - 5, Y - 30);
                g.DrawLine(p2, X + 25, Y - 30, X - 5, Y - 30);
                g.DrawLine(p3, X - 5, Y, X - 5, Y - 30);
                g.DrawLine(p4, X - 35, Y - 30, X - 5, Y - 30);
            }
            if (count % 16 == 13)
            {

                g.DrawLine(p1, X + 48, Y - 57, X + 60, Y - 30);
                g.DrawLine(p2, X + 33, Y - 18, X + 60, Y - 30);
                g.DrawLine(p3, X + 72, Y - 3, X + 60, Y - 30);
                g.DrawLine(p4, X + 87, Y - 42, X + 60, Y - 30);
                
                g.DrawLine(p1, X + 7, Y - 57, X - 5, Y - 30);
                g.DrawLine(p2, X + 22, Y - 18, X - 5, Y - 30);
                g.DrawLine(p3, X - 17, Y - 3, X - 5, Y - 30);
                g.DrawLine(p4, X - 32, Y - 47, X - 5, Y - 30);
            }
            if (count % 16 == 14)
            {

                
                g.DrawLine(p1, X + 39, Y - 51, X + 60, Y - 30);
                g.DrawLine(p2, X + 39, Y - 9, X + 60, Y - 30);
                g.DrawLine(p3, X + 81, Y - 9, X + 60, Y - 30);
                g.DrawLine(p4, X + 81, Y - 51, X + 60, Y - 30);
                
                g.DrawLine(p1, X + 16, Y - 51, X - 5, Y - 30);
                g.DrawLine(p2, X + 16, Y - 9, X - 5, Y - 30);
                g.DrawLine(p3, X - 26, Y - 9, X - 5, Y - 30);
                g.DrawLine(p4, X - 26, Y - 51, X - 5, Y - 30);
            }
            if (count % 16 == 15)
            {

               
                g.DrawLine(p1, X + 33, Y - 47, X + 60, Y - 30);
                g.DrawLine(p2, X + 48, Y - 3, X + 60, Y - 30);
                g.DrawLine(p3, X + 87, Y - 18, X + 60, Y - 30);
                g.DrawLine(p4, X + 72, Y - 57, X + 60, Y - 30);
                
                g.DrawLine(p1, X + 22, Y - 42, X - 5, Y - 30);
                g.DrawLine(p2, X + 7, Y - 3, X - 5, Y - 30);
                g.DrawLine(p3, X - 32, Y - 18, X - 5, Y - 30);
                g.DrawLine(p4, X - 17, Y - 57, X - 5, Y - 30);
            }

        }

        public void MoveCross()
        {

        }
    }
}
