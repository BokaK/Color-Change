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
        public Ball()
        {
            X = 145;
            Y = 600;
            Random random = new Random();
           count = random.Next(0, 3);
            
        }
        public void Draw(Graphics g)
        {
          
            if (count == 0)
            {
                SolidBrush b = new SolidBrush(Color.Red);
                Pen p = new Pen(Color.Red, 3);
                g.DrawEllipse(p, X, Y, 10, 10);
                g.FillEllipse(b, X, Y, 10, 10);
            }
            if (count == 1)
            {
                SolidBrush b = new SolidBrush(Color.Yellow);
                Pen p = new Pen(Color.Yellow, 3);
                g.DrawEllipse(p, X, Y, 10, 10);
                g.FillEllipse(b, X, Y, 10, 10);
            }
            if (count == 2)
            {
                SolidBrush b = new SolidBrush(Color.Green);
                Pen p = new Pen(Color.Green, 3);
                g.DrawEllipse(p, X, Y, 10, 10);
                g.FillEllipse(b, X, Y, 10, 10);
            }
            if (count == 3)
            {
                SolidBrush b = new SolidBrush(Color.Blue);
                Pen p = new Pen(Color.Blue, 3);
                g.DrawEllipse(p, X, Y, 10, 10);
                g.FillEllipse(b, X, Y, 10, 10);
            }
           
        }
    }
}
