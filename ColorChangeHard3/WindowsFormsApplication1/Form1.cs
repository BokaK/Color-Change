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
            clock = 40;
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
            scene.balls.Add(new BallsForChange(142, 110));
            scene.balls.Add(new BallsForChange(141, 220));
            scene.balls.Add(new BallsForChange(141, 340));
            scene.balls.Add(new BallsForChange(141, 460));
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
           scene.AddLines1(120, 560, count);
           Clock();
           scene.AddSquare_Ball(105, 72, count);
           scene.AddBall_Easy(118, 260, count);
           scene.AddSquare(120, 440, count);
           scene.AddTriangle(117, 200, count);

           
            Invalidate();
        }
        private void Clock ()
        {

            clock--;
            label2.Text = String.Format("00:{0:00}", clock);
            if (clock == 0)
            {

                MessageBox.Show("GAME OVER!");
                timer1.Stop();
                DialogResult = System.Windows.Forms.DialogResult.Cancel;

            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scene.ball.Y -= 30;

           check(scene.ball.Y, scene.ball.count, count);
            
        }

        public void check(int y, int countBall, int c)
        {
          if (y < 570 && y >= 540)
            {
                if((c % 4 == 2 && countBall == 0) || (c % 4 == 3 && countBall == 1) || (c % 4 == 0 && countBall == 2) || (c % 4 == 1 && countBall == 3))
                {
                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show("Game over!");
                    DialogResult = System.Windows.Forms.DialogResult.Cancel;
                } 
            }
            if (y < 510 && y >= 480)
            {
                if ((c % 4 == 1 && countBall == 0) || (c % 4 == 0 && countBall == 1) || (c % 4 == 3 && countBall == 2) || (c % 4 == 2 && countBall == 3))
                {
                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show("Game over!");
                    DialogResult = System.Windows.Forms.DialogResult.Cancel;
                }
            }
            if (y < 450 && y >= 420)
            {
                if ((c % 4 == 0 && countBall == 0) || (c % 4 == 2 && countBall == 2) || (c % 4 == 3 && countBall == 3) || (c % 4 == 1 && countBall == 1))
                {
                    
                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show("Game over!");
                    DialogResult = System.Windows.Forms.DialogResult.Cancel;
                }
            }
            if (y < 390 && y >= 360)
            {
                if ((c % 4 == 2 && countBall == 0) || (c % 4 == 3 && countBall == 1) || (c % 4 == 0 && countBall == 2) || (c % 4 == 1 && countBall == 3))
                {
                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show("Game over!");
                    DialogResult = System.Windows.Forms.DialogResult.Cancel;
                }
            }
            if (y < 330 && y >= 300)
            {
                if ((c % 2 == 0) || (countBall == scene.ball_easy.broj))
                {
                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show("Game over!");
                    DialogResult = System.Windows.Forms.DialogResult.Cancel;
                }
            }
            if (y < 270 && y >= 240)
            {
                if ((c % 2 ==0) || (countBall == scene.ball_easy.broj))
                {
                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show("Game over!");
                    DialogResult = System.Windows.Forms.DialogResult.Cancel;
                }
            }
            if (y < 210 && y >= 180)
            {
                    if ((countBall == 0 && c % 4 == 3) || (countBall == 0 && c % 4 == 2) || (countBall == 1 && c % 4 == 2) || (countBall == 1 && c % 4 == 3) || (countBall == 2 && c % 4 == 2) || (countBall == 2 && c % 4 == 3) || (countBall == 3 && c % 4 == 2) || (countBall == 3 && c % 4 == 3))
                    {

                    }
                    else
                    {
                        timer1.Stop();
                        MessageBox.Show("Game over!");
                        DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    }
   
            }
            if (y < 150 && y >= 120)
            {
                if (c % 4 == 3)
                {
                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show("Game over!");
                    DialogResult = System.Windows.Forms.DialogResult.Cancel;
                }
            }
            if (y < 80 && y >= 50)
            {
                if ((c%4==0 && countBall == 2) || (c % 4 == 1 && countBall == 3) || (c % 4 == 2 && countBall == 0) || (c % 4 == 3 && countBall == 1))
                {
                    scene.ball.Y -= 15;
                   
                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show("Game over!");
                    DialogResult = System.Windows.Forms.DialogResult.Cancel;
                }

            }

            // BallsForChange
            if (y < 480 && y >= 450)
            {
                
            }

        }

    }
}
