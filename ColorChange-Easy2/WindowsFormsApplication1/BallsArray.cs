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
        public BallsForChange (int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Draw (Graphics g)
        {
            Pen pen1 = new Pen(Color.Red,3);
            Pen pen2 = new Pen(Color.Yellow,3);
            Pen pen3 = new Pen(Color.Green,3);
            Pen pen4 = new Pen(Color.Blue,3);
            g.DrawEllipse(pen1,X, Y, 14, 14);
            g.DrawEllipse(pen2, X + 2, Y + 2, 10, 10);
            g.DrawEllipse(pen3, X + 4, Y + 4, 6, 6);
            g.DrawEllipse(pen4, X + 6, Y + 6, 2, 2);
           
        }

    }
}
