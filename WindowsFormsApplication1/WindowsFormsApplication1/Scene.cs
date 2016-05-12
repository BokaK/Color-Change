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

        public Scene()
        {
            Shapes = new List<Shape>();
        }

        public void AddShape(float x, float y, int c)
        {

            Shape s = null;
           
            s = new Square(x, y, c);
           
            Shapes.Add(s);
        }

        public void Draw(Graphics g)
        {
            foreach (Shape s in Shapes)
            {
                s.Draw(g);
            }
        }

    }
}
