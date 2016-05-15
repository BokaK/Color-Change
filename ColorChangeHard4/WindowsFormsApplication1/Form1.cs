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
        public int count2{ get; set; }
        public int clock { set; get; }
        public Image star { get; set; }
        public List<BallsForChange> balls { get; set; }
        public Random random { get; set; }
        public Form1()
        {
            clock = 45;
            DoubleBuffered = true;
            InitializeComponent();
            scene = new Scene(1);
            count = 0;
            count2 = 0;
            scene.AddSquare_Ball(105, 72, count);
            scene.AddTriangle(117, 200, count);
            scene.AddBall_Easy(118, 260, count2);
            scene.AddSquare(120, 440, count);
            scene.AddLines1(0, 560, count);
           
            balls = new List<BallsForChange>();
            random = new Random();
            Invalidate();
            balls.Add(new BallsForChange(142, 110));
            balls.Add(new BallsForChange(141, 220));
            balls.Add(new BallsForChange(141, 340));
            balls.Add(new BallsForChange(141, 460));
            timer1.Start();
            timer1.Interval=1000;
            timer2.Start();
            timer2.Interval = 1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.DimGray);
            CheckColor(e.Graphics, scene.ball.Y);
            scene.Draw(e.Graphics);
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
           scene.Shapes.Clear();
           scene.AddLines1(0, 560, count);
           Clock();
           scene.AddSquare_Ball(105, 72, count);
           scene.AddBall_Easy(118, 260, count2);
           scene.AddSquare(120, 440, count);
           scene.AddTriangle(117, 200, count);

           
            Invalidate();
        }
        private void Clock ()
        {

            clock--;
            label2.Text = String.Format("00:{0:00}", clock);
            if (clock <= 10)
            {
                label2.ForeColor = Color.Red;
            }
            if (clock == 0)
            {
                timer1.Stop();
                MessageBox.Show("GAME OVER!");
                
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
                    timer2.Stop();
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
                    timer2.Stop();
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
                    timer2.Stop();
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
                    timer2.Stop();
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
                    timer2.Stop();
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
                    timer2.Stop();
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
                    timer2.Stop();
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
                    timer2.Stop();
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
                    timer2.Stop();
                    MessageBox.Show("Game over!");
                    DialogResult = System.Windows.Forms.DialogResult.Cancel;
                }

            }

           

        }

        public void CheckColor(Graphics g, int y)
        {

            if (y < 480 && y >= 450)
            {
                if (balls.Count == 4)
                {
                    scene.ball.count = random.Next(4);
                    balls.RemoveAt(3);
                }

            }
            if (y < 360 && y >= 330)
            {
                if (balls.Count == 3)
                {
                    scene.ball.count = random.Next(4);
                    balls.RemoveAt(2);
                }
            }
            if (y < 240 && y >= 210)
            {
                if (balls.Count == 2)
                {
                    scene.ball.count = random.Next(4);
                    balls.RemoveAt(1);
                }
            }
            if (y < 130 && y >= 100)
            {
                if (balls.Count == 1)
                {
                    scene.ball.count = random.Next(4);
               balls.RemoveAt(0);
                }
            }

            if (balls.Count != 0)
            {
                foreach (BallsForChange b in balls)
                {
                    b.Draw(g);
                }
            }



        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            count2++;
            scene.Shapes.Clear();
            scene.AddLines1(0, 560, count);
            scene.AddSquare_Ball(105, 72, count);
            scene.AddBall_Easy(118, 260, count2);
            scene.AddSquare(120, 440, count);
            scene.AddTriangle(117, 200, count);
        }
    }
}
