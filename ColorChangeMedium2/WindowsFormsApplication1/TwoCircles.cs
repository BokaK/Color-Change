using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class TwoCircles : Shape
    {
        public int count { get; set; }
        public TwoCircles(float x, float y, int c) : base(x,y)
        {
            count = c;
        }


        public override void Draw(Graphics g)
        {
            Pen p1 = new Pen(Color.Firebrick, 3);
            Pen p2 = new Pen(Color.RosyBrown, 3);
            Pen p3 = new Pen(Color.IndianRed, 3);
            Pen p4 = new Pen(Color.MistyRose, 3);

            if(count%4==0)
            {
                g.DrawArc(p1, X - 5, Y - 5, 70, 70, 45, 90);
                g.DrawArc(p1, X, Y, 60, 60, 45, 90);
                g.DrawArc(p2, X - 5, Y - 5, 70, 70, 135, 90);
                g.DrawArc(p2, X, Y, 60, 60, 135, 90);
                g.DrawArc(p3, X - 5, Y - 5, 70, 70, 225, 90);
                g.DrawArc(p3, X, Y, 60, 60, 225, 90);
                g.DrawArc(p4, X - 5, Y - 5, 70, 70, 315, 90);
                g.DrawArc(p4, X, Y, 60, 60, 315, 90);
            }
            if(count%4==1)
            {
                g.DrawArc(p2, X - 5, Y - 5, 70, 70, 45, 90);
                g.DrawArc(p4, X, Y, 60, 60, 45, 90);
                g.DrawArc(p3, X - 5, Y - 5, 70, 70, 135, 90);
                g.DrawArc(p1, X, Y, 60, 60, 135, 90);
                g.DrawArc(p4, X - 5, Y - 5, 70, 70, 225, 90);
                g.DrawArc(p2, X, Y, 60, 60, 225, 90);
                g.DrawArc(p1, X - 5, Y - 5, 70, 70, 315, 90);
                g.DrawArc(p3, X, Y, 60, 60, 315, 90);
            }
            if(count%4==2)
            {
                g.DrawArc(p3, X - 5, Y - 5, 70, 70, 45, 90);
                g.DrawArc(p3, X, Y, 60, 60, 45, 90);
                g.DrawArc(p4, X - 5, Y - 5, 70, 70, 135, 90);
                g.DrawArc(p4, X, Y, 60, 60, 135, 90);
                g.DrawArc(p1, X - 5, Y - 5, 70, 70, 225, 90);
                g.DrawArc(p1, X, Y, 60, 60, 225, 90);
                g.DrawArc(p2, X - 5, Y - 5, 70, 70, 315, 90);
                g.DrawArc(p2, X, Y, 60, 60, 315, 90);
            }
            if(count%4==3)
            {
                g.DrawArc(p4, X - 5, Y - 5, 70, 70, 45, 90);
                g.DrawArc(p2, X, Y, 60, 60, 45, 90);
                g.DrawArc(p1, X - 5, Y - 5, 70, 70, 135, 90);
                g.DrawArc(p3, X, Y, 60, 60, 135, 90);
                g.DrawArc(p2, X - 5, Y - 5, 70, 70, 225, 90);
                g.DrawArc(p4, X, Y, 60, 60, 225, 90);
                g.DrawArc(p3, X - 5, Y - 5, 70, 70, 315, 90);
                g.DrawArc(p1, X, Y, 60, 60, 315, 90);
            }

            p1.Dispose();
            p2.Dispose();
            p3.Dispose();
            p4.Dispose();
        }

    }
}
