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
                g.DrawLine(p1, X + 40, Y, X + 40, Y - 60);
                g.DrawLine(p2, X + 70, Y, X  + 70 , Y - 60);
                g.DrawLine(p3, X + 100, Y, X + 100, Y - 60);
                g.DrawLine(p4, X + 130, Y, X + 130, Y - 60);
                g.DrawLine(p1, X + 160, Y, X + 160, Y - 60);
                g.DrawLine(p2, X + 190, Y, X + 190, Y - 60);
                g.DrawLine(p3, X + 220, Y, X + 220, Y - 60);
                g.DrawLine(p5, X + 190, Y, X + 190, Y - 60);
            }
            if (count % 4 == 1)
            {
                
                g.DrawLine(p2, X + 70, Y, X + 70, Y - 60);
                g.DrawLine(p3, X + 100, Y, X + 100, Y - 60);
                g.DrawLine(p4, X + 130, Y, X + 130, Y - 60);
                g.DrawLine(p1, X + 160, Y, X + 160, Y - 60);
                g.DrawLine(p2, X + 190, Y, X + 190, Y - 60);
                g.DrawLine(p3, X + 220, Y, X + 220, Y - 60);
                g.DrawLine(p4, X + 250, Y, X + 250, Y - 60);
                g.DrawLine(p5, X + 140, Y, X + 140, Y - 60);
            }
            if (count % 4 == 2)
            {
                g.DrawLine(p1, X + 40, Y, X + 40, Y - 60);
                g.DrawLine(p2, X + 70, Y, X + 70, Y - 60);
                g.DrawLine(p3, X + 100, Y, X + 100, Y - 60);
                g.DrawLine(p4, X + 130, Y, X + 130, Y - 60);
                g.DrawLine(p1, X + 160, Y, X + 160, Y - 60);
                g.DrawLine(p2, X + 190, Y, X + 190, Y - 60);
                g.DrawLine(p3, X + 220, Y, X + 220, Y - 60);
                g.DrawLine(p5, X + 80, Y, X + 80, Y - 60);
            }
            if (count % 4 == 3)
            {
                g.DrawLine(p2, X + 70, Y, X + 70, Y - 60);
                g.DrawLine(p3, X + 100, Y, X + 100, Y - 60);
                g.DrawLine(p4, X + 130, Y, X + 130, Y - 60);
                g.DrawLine(p1, X + 160, Y, X + 160, Y - 60);
                g.DrawLine(p2, X + 190, Y, X + 190, Y - 60);
                g.DrawLine(p3, X + 220, Y, X + 220, Y - 60);
                g.DrawLine(p4, X + 250, Y, X + 250, Y - 60);
                g.DrawLine(p5, X + 40, Y, X + 40, Y - 60);
            }
            p1.Dispose();
            p2.Dispose();
            p3.Dispose();
            p4.Dispose();
        }
    }
}
