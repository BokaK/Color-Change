using System;
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

        public void AddSquare(float x, float y, int c)
        {

            Shape s = null;
           
            s = new Square(x, y, c);
           
            Shapes.Add(s);

        }
        public void AddRotateSquare(float x, float y, int c) {
            RotateSquarecs s = new RotateSquarecs(x, y, c);
            Shapes.Add(s);
        }
        public void AddIks(float x, float y , int c)
        {
            Iks i = new Iks(x, y, c);
            Shapes.Add(i);
        }
        public void AddLines1(float x, float y, int c)
        {

            Shape s = null;

            s = new Lines1(x, y, c);

            Shapes.Add(s);

        }
        public void AddSquare_Ball(int x, int y, int c)
        {

            Shape s = new Square_Ball(x,y,c);
            Shapes.Add(s);

        }
        public void AddVertLinii(float x, float y, int c) {
            Shape s = new VertLinii(x, y, c);
            Shapes.Add(s);
        }

        public void AddCircles(float x, float y, int c)
        {
            Shape s = null;
            s = new TwoCircles(x, y, c);
            Shapes.Add(s);
        }
        public void AddLinii(float x, float y, int c)
        {
            Linii l = new Linii(x, y , c);
            Shapes.Add(l);
        }
        public void AddBall_Easy(int x, int y, int c)
        {
            Shape s = new Ball_Easy(x, y, c);
            Shapes.Add(s);
        }
        public void AddTriangle(int x, int y, int c)
        {
            int flag = ball.count;
            Shape s = new Triangle(x, y, c, flag);
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
