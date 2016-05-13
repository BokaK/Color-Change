﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public abstract class Shape
    {
        public float X { get; set; }
        public float Y { get; set; }
      

        public Shape(float x, float y)
        {
            X = x;
            Y = y;
            
        }

        public abstract void Draw(Graphics g);

    }
}
