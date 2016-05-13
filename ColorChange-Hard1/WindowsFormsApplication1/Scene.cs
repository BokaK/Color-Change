﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
     public class Scene
    {
        public List<Shape> Shapes;
        public Ball ball { set; get; }
        public BallsForChange [] balls { get; set; }

        public Scene(int flag)
        {
            Shapes = new List<Shape>();
            ball = new Ball(flag);
            balls = new BallsForChange[4];
        }

        public void AddShape(float x, float y, int c)
        {

            Shape s = null;
           
            s = new Square(x, y, c);
           
            Shapes.Add(s);

        }

        public void AddCircles(float x, float y, int c)
        {
            Shape s = null;
            s = new TwoCircles(x, y, c);
            Shapes.Add(s);
        }

        

        public void Draw(Graphics g)
        {
            foreach (Shape s in Shapes)
            {
                s.Draw(g);
            }
            ball.Draw(g);
            foreach(BallsForChange b in balls)
            {
                b.Draw(g);
            }

        }

    }
}
