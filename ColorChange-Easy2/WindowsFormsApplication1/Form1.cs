using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Scene scene { get; set; }
        public int count { get; set; }


        public Form1()
        {
            DoubleBuffered = true;
            InitializeComponent();
            scene = new Scene();
            scene.AddShape(120, 80, count);
            scene.AddShape(120, 194, count);
            scene.AddShape(120, 308, count);
            scene.AddShape(120, 422, count);
            count = 0;
            Invalidate();
            scene.balls[0] = new BallsForChange(141, 100);
            scene.balls[1] = new BallsForChange(141, 214);
            scene.balls[2] = new BallsForChange(141, 328);
            //timer1.Start();
            // timer1.Interval=1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.DimGray);
            scene.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            
            
            scene.AddShape(130, 550, count);
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           

            if (scene.ball.Y > 510 && scene.ball.Y < 525)
            {
              if (count%4 == 0 && scene.ball.count == 0)
                {
                    scene.ball.Y -= 23;
                }
                else if (count % 4 == 1 && scene.ball.count == 1)
                {
                    scene.ball.Y -= 23;
                }
                else if (count % 4 == 2 && scene.ball.count == 2)
                {
                    scene.ball.Y -= 23;
                }
                else if (count % 4 == 3 && scene.ball.count == 3)
                {
                    scene.ball.Y -= 23;
                }
              else
                {
                    MessageBox.Show("Game over");

                }

            }
            else
            {
                scene.ball.Y -= 23;
            }
        }
    }
}
