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

            if(count%16==0)
             {
                 g.DrawLine(p1, X + 15, Y - 15, X + 85, Y - 15);
                 g.DrawLine(p2, X + 85, Y - 15, X + 85, Y - 85);
                 g.DrawLine(p3, X + 85, Y - 85, X + 15, Y - 85);
                 g.DrawLine(p4, X + 15, Y - 85, X + 15, Y - 15);
             }
             if(count%16==1)
             {
                 g.DrawLine(p1, X + 30, Y - 5, X + 95, Y - 30);
                 g.DrawLine(p2, X + 95, Y - 30, X + 70, Y - 95);
                 g.DrawLine(p3, X + 70, Y - 95, X + 5, Y - 70);
                 g.DrawLine(p4, X + 5, Y - 70, X + 30, Y - 5);
             }
             if(count%16==2)
             {
                 g.DrawLine(p1, X + 50, Y, X + 100, Y - 50);
                 g.DrawLine(p2, X + 100, Y - 50, X + 50, Y - 100);
                 g.DrawLine(p3, X + 50, Y - 100, X, Y - 50);
                 g.DrawLine(p4, X, Y - 50, X + 50, Y);
             }
             if(count%16==3)
             {
                 g.DrawLine(p1, X + 70, Y - 5, X + 95, Y - 70);
                 g.DrawLine(p2, X + 95, Y - 70, X + 30, Y - 95);
                 g.DrawLine(p3, X + 30, Y - 95, X + 5, Y - 30);
                 g.DrawLine(p4, X + 5, Y - 30, X + 70, Y - 5);
                                 
             }
             if(count%16==4)
             {                 
                 g.DrawLine(p1, X + 85, Y - 15, X + 85, Y - 85);
                 g.DrawLine(p2, X + 85, Y - 85, X + 15, Y - 85);
                 g.DrawLine(p3, X + 15, Y - 85, X + 15, Y - 15);
                 g.DrawLine(p4, X + 15, Y - 15, X + 85, Y - 15);
             }
             if(count%16==5)
             {               
                 g.DrawLine(p1, X + 95, Y - 30, X + 70, Y - 95);
                 g.DrawLine(p2, X + 70, Y - 95, X + 5, Y - 70);
                 g.DrawLine(p3, X + 5, Y - 70, X + 30, Y - 5);
                 g.DrawLine(p4, X + 30, Y - 5, X + 95, Y - 30);
             }
             if(count%16==6)
             {
                 g.DrawLine(p1, X + 100, Y - 50, X + 50, Y - 100);
                 g.DrawLine(p2, X + 50, Y - 100, X, Y - 50);
                 g.DrawLine(p3, X, Y - 50, X + 50, Y);
                 g.DrawLine(p4, X + 50, Y, X + 100, Y - 50);
             }
             if(count%16==7)
             {
                g.DrawLine(p1, X + 95, Y - 70, X + 30, Y - 95);
                g.DrawLine(p2, X + 30, Y - 95, X + 5, Y - 30);
                g.DrawLine(p3, X + 5, Y - 30, X + 70, Y - 5);
                g.DrawLine(p4, X + 70, Y - 5, X + 95, Y - 70);
                
            }
             if(count%16==8)
             {                                  
                 g.DrawLine(p1, X + 85, Y - 85, X + 15, Y - 85);
                 g.DrawLine(p2, X + 15, Y - 85, X + 15, Y - 15);
                 g.DrawLine(p3, X + 15, Y - 15, X + 85, Y - 15);
                 g.DrawLine(p4, X + 85, Y - 15, X + 85, Y - 85);
             }
             if(count%16==9)
             {                               
                 g.DrawLine(p1, X + 70, Y - 95, X + 5, Y - 70);
                 g.DrawLine(p2, X + 5, Y - 70, X + 30, Y - 5);
                 g.DrawLine(p3, X + 30, Y - 5, X + 95, Y - 30);
                 g.DrawLine(p4, X + 95, Y - 30, X + 70, Y - 95);
             }
             if(count%16==10)
             {                
                 g.DrawLine(p1, X + 50, Y - 100, X, Y - 50);
                 g.DrawLine(p2, X, Y - 50, X + 50, Y);
                 g.DrawLine(p3, X + 50, Y, X + 100, Y - 50);
                 g.DrawLine(p4, X + 100, Y - 50, X + 50, Y - 100);
             }
             if(count%16==11)
             {
                g.DrawLine(p1, X + 30, Y - 95, X + 5, Y - 30);
                g.DrawLine(p2, X + 5, Y - 30, X + 70, Y - 5);
                g.DrawLine(p3, X + 70, Y - 5, X + 95, Y - 70);
                g.DrawLine(p4, X + 95, Y - 70, X + 30, Y - 95);
               
            }
             if(count%16==12)
             {                                                  
                 g.DrawLine(p1, X + 15, Y - 85, X + 15, Y - 15);
                 g.DrawLine(p2, X + 15, Y - 15, X + 85, Y - 15);
                 g.DrawLine(p3, X + 85, Y - 15, X + 85, Y - 85);
                 g.DrawLine(p4, X + 85, Y - 85, X + 15, Y - 85);
             }
             if(count%16==13)
             {                                                
                 g.DrawLine(p1, X + 5, Y - 70, X + 30, Y - 5);
                 g.DrawLine(p2, X + 30, Y - 5, X + 95, Y - 30);
                 g.DrawLine(p3, X + 95, Y - 30, X + 70, Y - 95);
                 g.DrawLine(p4, X + 70, Y - 95, X + 5, Y - 70);
             }
             if(count%16==14)
             {                                 
                 g.DrawLine(p1, X, Y - 50, X + 50, Y);
                 g.DrawLine(p2, X + 50, Y, X + 100, Y - 50);
                 g.DrawLine(p3, X + 100, Y - 50, X + 50, Y - 100);
                 g.DrawLine(p4, X + 50, Y - 100, X, Y - 50);
             }
             if(count%16==15)
             {
                g.DrawLine(p1, X + 5, Y - 30, X + 70, Y - 5);
                g.DrawLine(p2, X + 70, Y - 5, X + 95, Y - 70);
                g.DrawLine(p3, X + 95, Y - 70, X + 30, Y - 95);
                g.DrawLine(p4, X + 30, Y - 95, X + 5, Y - 30);
                
            }

    
            p1.Dispose();
            p2.Dispose();
            p3.Dispose();
            p4.Dispose();
        }
    }
}
   
