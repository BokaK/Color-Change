using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class BallsForChange
    {
        int X { set; get; }
        int Y { set; get; }
        public int Remove { set; get; }
        public BallsForChange (int x, int y,int r)
        {
            X = x;
            Y = y;
            Remove = r;
        }
        public void Draw (Graphics g)
        {
            if (Remove == 0)
            {
                Pen p1 = new Pen(Color.Firebrick, 3);
                Pen p2 = new Pen(Color.IndianRed, 3);
                Pen p3 = new Pen(Color.RosyBrown, 3);
                Pen p4 = new Pen(Color.MistyRose, 3);

                g.DrawEllipse(p4, X, Y, 14, 14);
                g.DrawEllipse(p3, X + 2, Y + 2, 10, 10);
                g.DrawEllipse(p2, X + 4, Y + 4, 6, 6);
                g.DrawEllipse(p1, X + 6, Y + 6, 2, 2);
            }
            if (Remove == 1)
            {
                Pen p1 = new Pen(Color.Black);
                g.DrawEllipse(p1, X, Y, 14, 14);
            }
           
        }


    }
}
