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
            scene = new Scene(1);
            scene.AddShape(120, 80, count);
            scene.AddShape(120, 200, count);
            scene.AddShape(120, 320, count);
            scene.AddShape(120, 440, count);
            scene.AddShape(120, 560, count);
            count = 0;
            Invalidate();
            scene.balls[0] = new BallsForChange(141, 100);
            scene.balls[1] = new BallsForChange(141, 220);
            scene.balls[2] = new BallsForChange(141, 340);
            scene.balls[3] = new BallsForChange(141, 460);
            timer1.Start();
            timer1.Interval=1000;
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
            scene.Shapes.Clear();

            scene.AddShape(120, 80, count);
            scene.AddShape(120, 200, count);
            scene.AddShape(120, 320, count);
            scene.AddShape(120, 440, count);
            scene.AddShape(120, 560, count);
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scene.ball.Y -= 30;

            check(scene.ball.Y, scene.ball.count, count);
        }

        public void check(int y, int countBall, int c)
        {
            if (y < 560 && y > 530)
            {
                if((c % 4 == 0 && countBall == 0) || (c % 4 == 1 && countBall == 1) || (c % 4 == 2 && countBall == 2) || (c % 4 == 3 && countBall == 3))
                {

                }
                else
                {
                    MessageBox.Show("Game over!");
                    this.Close();
                } 
            }
            else if (y < 500 && y > 470)
            {
                if ((c % 4 == 2 && countBall == 0) || (c % 4 == 3 && countBall == 1) || (c % 4 == 0 && countBall == 2) || (c % 4 == 1 && countBall == 3))
                {

                }
                else
                {
                    MessageBox.Show("Game over!");
                    this.Close();
                }
            }

        }
    }
}
