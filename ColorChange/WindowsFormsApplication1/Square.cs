﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Square : Shape
    {
        public int count { get; set; }
        public Square(float x, float y, int c)
            : base(x, y)
        {
            count = c;
        }
        public override void Draw(Graphics g)
        {
           
            Pen p1 = new Pen(Color.Red, 3);
            Pen p2 = new Pen(Color.Yellow, 3);
            Pen p3 = new Pen(Color.Green, 3);
            Pen p4 = new Pen(Color.Blue, 3);
            if (count % 4 == 0)
            {

               

                    //g.DrawRectangle(p, X - Width / 2, Y - Width / 2, Width, Height);
                    g.DrawLine(p1, X, Y, X + 40, Y);
                    g.DrawLine(p2, X + 40, Y, X + 40, Y - 40);
                    g.DrawLine(p3, X, Y - 40, X + 40, Y - 40);
                    g.DrawLine(p4, X, Y, X, Y - 40);

                

            }
            if (count % 4 == 1)
            {

                

                    //g.DrawRectangle(p, X - Width / 2, Y - Width / 2, Width, Height);
                    g.DrawLine(p2, X, Y, X + 40, Y);
                    g.DrawLine(p3, X + 40, Y, X + 40, Y - 40);
                    g.DrawLine(p4, X, Y - 40, X + 40, Y - 40);
                    g.DrawLine(p1, X, Y, X, Y - 40);

                

            }
            if (count % 4 == 2)
            {

                
                    g.DrawLine(p3, X, Y, X + 40, Y);
                    g.DrawLine(p4, X + 40, Y, X + 40, Y - 40);
                    g.DrawLine(p1, X, Y - 40, X + 40, Y - 40);
                    g.DrawLine(p2, X, Y, X, Y - 40);

                

            }
            if (count % 4 == 3)
            {

                    g.DrawLine(p4, X, Y, X + 40, Y);
                    g.DrawLine(p1, X + 40, Y, X + 40, Y - 40);
                    g.DrawLine(p2, X, Y - 40, X + 40, Y - 40);
                    g.DrawLine(p3, X, Y, X, Y - 40);

                

            }

            p1.Dispose();
            p2.Dispose();
            p3.Dispose();
            p4.Dispose();
            
        }

    }
}
