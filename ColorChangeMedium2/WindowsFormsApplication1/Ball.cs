using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Ball
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int count { get; set; }
        public Ball(int flag)
        {
            X = 145;
            Y = 600;
            Random random = new Random();
            if (flag == 1)
            {
                count = random.Next(0, 3);
            }
            if (flag == 2)
            { }
            if(flag==3)
            {
                count = random.Next(0, 2);
            }

                 
        }
        public void Draw(Graphics g)
        {
          
            if (count == 0)
            {
                SolidBrush b = new SolidBrush(Color.Firebrick);
                Pen p = new Pen(Color.Firebrick, 3);
                g.DrawEllipse(p, X, Y, 10, 10);
                g.FillEllipse(b, X, Y, 10, 10);
            }
            if (count == 1)
            {
                SolidBrush b = new SolidBrush(Color.IndianRed);
                Pen p = new Pen(Color.IndianRed, 3);
                g.DrawEllipse(p, X, Y, 10, 10);
                g.FillEllipse(b, X, Y, 10, 10);
            }
            if (count == 2)
            {
                SolidBrush b = new SolidBrush(Color.RosyBrown);
                Pen p = new Pen(Color.RosyBrown, 3);
                g.DrawEllipse(p, X, Y, 10, 10);
                g.FillEllipse(b, X, Y, 10, 10);
            }
            if (count == 3)
            {
                SolidBrush b = new SolidBrush(Color.MistyRose);
                Pen p = new Pen(Color.MistyRose, 3);
                g.DrawEllipse(p, X, Y, 10, 10);
                g.FillEllipse(b, X, Y, 10, 10);
            }
           
        }
    }
}
