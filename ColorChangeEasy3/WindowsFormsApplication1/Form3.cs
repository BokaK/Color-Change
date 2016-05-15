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
    public partial class Form3 : Form
    {
        public Scene scene { get; set; }
        public int count { get; set; }
        public Form3()
        {
            InitializeComponent();
            DoubleBuffered = true;
            scene = new Scene(3);
            count = 0;
            scene.AddCircles(120, 500, count);
            scene.balls[0] = new BallsForChange(141, 100,0);
            scene.balls[1] = new BallsForChange(141, 220,0);
            scene.balls[2] = new BallsForChange(141, 340,0);
            scene.balls[3] = new BallsForChange(141, 460,0);
            timer1.Start();
            timer1.Interval = 1000;
            Invalidate();
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.DimGray);
            scene.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            scene.Shapes.Clear();
            scene.AddCircles(120, 500, count);
            Invalidate();
        }

        private void Form3_MouseClick(object sender, MouseEventArgs e)
        {
            scene.ball.Y -= 30;
            check(scene.ball.Y, scene.ball.count, count);
        }

        public void check(int y, int countBall, int c)
        {
            if (y < 560 && y > 530)
            {
                if ((c % 4 == 0 && countBall == 0) || (c % 4 == 2 && countBall == 1) )
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
                if ((c % 4 == 2 && countBall == 0) || (c % 4 == 0 && countBall == 1))
                {

                }
                else
                {
                    MessageBox.Show("Game over!");
                    this.Close();
                }
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
