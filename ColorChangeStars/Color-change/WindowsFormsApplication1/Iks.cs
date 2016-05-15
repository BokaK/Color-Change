using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Iks : Shape
    {
        public int count { get; set; }
        public Iks(float x, float y , int c) : base(x, y)
        {
            count = c;
        }
        public override void Draw(Graphics g)
        {
            Pen p1 = new Pen(Color.Firebrick, 3);
            Pen p2 = new Pen(Color.RosyBrown, 3);
            Pen p3 = new Pen(Color.IndianRed, 3);
            Pen p4 = new Pen(Color.MistyRose, 3);

            if (count % 16 == 0)
            {
                g.DrawLine(p1, X + 30, Y - 30, X + 60, Y - 30);
                g.DrawLine(p2, X + 60, Y, X + 60, Y - 30);
                g.DrawLine(p3, X + 90, Y - 30, X + 60, Y - 30);
                g.DrawLine(p4, X + 60, Y - 60, X + 60, Y - 30);

               
            }
            if (count % 16 == 1)
            {
                g.DrawLine(p1, X + 33, Y - 18, X + 60, Y - 30);
                g.DrawLine(p2, X + 72, Y - 3, X + 60, Y - 30);
                g.DrawLine(p3, X + 87, Y - 42, X + 60, Y - 30);
                g.DrawLine(p4, X + 48, Y - 57, X + 60, Y - 30);

               
            }
            if (count % 16 == 2)
            {
                g.DrawLine(p1, X + 39, Y - 9, X + 60, Y - 30);
                g.DrawLine(p2, X + 81, Y - 9, X + 60, Y - 30);
                g.DrawLine(p3, X + 81, Y - 51, X + 60, Y - 30);
                g.DrawLine(p4, X + 39, Y - 51, X + 60, Y - 30);

                
            }
            if (count % 16 == 3)
            {
                g.DrawLine(p1, X + 48, Y - 3, X + 60, Y - 30);
                g.DrawLine(p2, X + 87, Y - 18, X + 60, Y - 30);
                g.DrawLine(p3, X + 72, Y - 57, X + 60, Y - 30);
                g.DrawLine(p4, X + 33, Y - 47, X + 60, Y - 30);

                
            }
            if (count % 16 == 4)
            {

                g.DrawLine(p1, X + 60, Y, X + 60, Y - 30);
                g.DrawLine(p2, X + 90, Y - 30, X + 60, Y - 30);
                g.DrawLine(p3, X + 60, Y - 60, X + 60, Y - 30);
                g.DrawLine(p4, X + 30, Y - 30, X + 60, Y - 30);


            }
            if (count % 16 == 5)
            {

                g.DrawLine(p1, X + 72, Y - 3, X + 60, Y - 30);
                g.DrawLine(p2, X + 87, Y - 42, X + 60, Y - 30);
                g.DrawLine(p3, X + 48, Y - 57, X + 60, Y - 30);
                g.DrawLine(p4, X + 33, Y - 18, X + 60, Y - 30);


            }
            if (count % 16 == 6)
            {

                g.DrawLine(p1, X + 81, Y - 9, X + 60, Y - 30);
                g.DrawLine(p2, X + 81, Y - 51, X + 60, Y - 30);
                g.DrawLine(p3, X + 39, Y - 51, X + 60, Y - 30);
                g.DrawLine(p4, X + 39, Y - 9, X + 60, Y - 30);


            }
            if (count % 16 == 7)
            {

                g.DrawLine(p1, X + 87, Y - 18, X + 60, Y - 30);
                g.DrawLine(p2, X + 72, Y - 57, X + 60, Y - 30);
                g.DrawLine(p3, X + 33, Y - 47, X + 60, Y - 30);
                g.DrawLine(p4, X + 48, Y - 3, X + 60, Y - 30);

            
            }
            if (count % 16 == 8)
            {
                g.DrawLine(p1, X + 90, Y - 30, X + 60, Y - 30);
                g.DrawLine(p2, X + 60, Y - 60, X + 60, Y - 30);
                g.DrawLine(p3, X + 30, Y - 30, X + 60, Y - 30);
                g.DrawLine(p4, X + 60, Y, X + 60, Y - 30);

            }
            if (count % 16 == 9)
            {

                g.DrawLine(p1, X + 87, Y - 42, X + 60, Y - 30);
                g.DrawLine(p2, X + 48, Y - 57, X + 60, Y - 30);
                g.DrawLine(p3, X + 33, Y - 18, X + 60, Y - 30);
                g.DrawLine(p4, X + 72, Y - 3, X + 60, Y - 30);


            }
            if (count % 16 == 10)
            {

                g.DrawLine(p1, X + 81, Y - 51, X + 60, Y - 30);
                g.DrawLine(p2, X + 39, Y - 51, X + 60, Y - 30);
                g.DrawLine(p3, X + 39, Y - 9, X + 60, Y - 30);
                g.DrawLine(p4, X + 81, Y - 9, X + 60, Y - 30);

            
            }
            if (count % 16 == 11)
            {

                g.DrawLine(p1, X + 72, Y - 57, X + 60, Y - 30);
                g.DrawLine(p2, X + 33, Y - 47, X + 60, Y - 30);
                g.DrawLine(p3, X + 48, Y - 3, X + 60, Y - 30);
                g.DrawLine(p4, X + 87, Y - 18, X + 60, Y - 30);


            }
            if (count % 16 == 12)
            {

                g.DrawLine(p1, X + 60, Y - 60, X + 60, Y - 30);
                g.DrawLine(p2, X + 30, Y - 30, X + 60, Y - 30);
                g.DrawLine(p3, X + 60, Y, X + 60, Y - 30);
                g.DrawLine(p4, X + 90, Y - 30, X + 60, Y - 30);

             
            }
            if (count % 16 == 13)
            {

                g.DrawLine(p1, X + 48, Y - 57, X + 60, Y - 30);
                g.DrawLine(p2, X + 33, Y - 18, X + 60, Y - 30);
                g.DrawLine(p3, X + 72, Y - 3, X + 60, Y - 30);
                g.DrawLine(p4, X + 87, Y - 42, X + 60, Y - 30);

               
            }
            if (count % 16 == 14)
            {


                g.DrawLine(p1, X + 39, Y - 51, X + 60, Y - 30);
                g.DrawLine(p2, X + 39, Y - 9, X + 60, Y - 30);
                g.DrawLine(p3, X + 81, Y - 9, X + 60, Y - 30);
                g.DrawLine(p4, X + 81, Y - 51, X + 60, Y - 30);

               
            }
            if (count % 16 == 15)
            {


                g.DrawLine(p1, X + 33, Y - 47, X + 60, Y - 30);
                g.DrawLine(p2, X + 48, Y - 3, X + 60, Y - 30);
                g.DrawLine(p3, X + 87, Y - 18, X + 60, Y - 30);
                g.DrawLine(p4, X + 72, Y - 57, X + 60, Y - 30);

              
            }

            p1.Dispose();
            p2.Dispose();
            p3.Dispose();
            p4.Dispose();
        }
    }
    
 }

