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
        public int clock { set; get; }

        public Form1()
        {
            clock = 30;
            DoubleBuffered = true;
            InitializeComponent();
            scene = new Scene(1);
            scene.AddSquare_Ball(105, 72, count);
            scene.AddTriangle(117, 200, count);
            scene.AddBall_Easy(118, 260, count);
            scene.AddSquare(120, 440, count);
            scene.AddLines1(120, 560, count);
            count = 0;
            Invalidate();
            scene.balls[0] = new BallsForChange(142, 110,0);
            scene.balls[1] = new BallsForChange(141, 220,0);
            scene.balls[2] = new BallsForChange(141, 340,0);
            scene.balls[3] = new BallsForChange(141, 460,0);
            timer1.Start();
            timer1.Interval=1000;
            timerGame.Start();
            timerGame.Interval = 1000;
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

            scene.AddSquare_Ball(105, 72, count);
            scene.AddTriangle(117, 200, count);
            scene.AddBall_Easy(118, 260, count);
            scene.AddSquare(120, 440, count);
            scene.AddLines1(120, 560, count);
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scene.ball.Y -= 30;

           check(scene.ball.Y, scene.ball.count, count);
            
        }

        public void check(int y, int countBall, int c)
        {
          /*if (y < 570 && y >= 540)
            {
                if((c % 4 == 0 && countBall == 3) || (c % 4 == 1 && countBall == 4) || (c % 4 == 2 && countBall == 1) || (c % 4 == 3 && countBall == 2))
                {
                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show("Game over!");
                    DialogResult = System.Windows.Forms.DialogResult.Cancel;
                } 
            }
            */
       
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            clock--;
            label1.Text = String.Format("00:{0:00}", clock);
            if (clock == 0)
            {
                timer1.Stop();
                MessageBox.Show("GAME OVER!");
                DialogResult = System.Windows.Forms.DialogResult.Cancel;

            }
        }
    }
}
