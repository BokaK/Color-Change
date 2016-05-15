using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Scene scene { get; set; }
        public int count { get; set; }
        public int clock { set; get; }
        public Image star { get; set; }
        public List<BallsForChange> balls { get; set; }
        public Random random { get; set; }
        public int countEnd {set;get;}
        public Graphics graph { get; set; }
        public Brush b { get; set; }
        public int flagWin { get; set; }
        public int flag { get; set; }
        public Form1()
        {
            InitializeComponent();
            graph = CreateGraphics();
            poeni.Text = "Points: 0";
            flagWin = 0;
            flag = 0;
            b = new SolidBrush(Color.RosyBrown);
            countEnd = 20;
            clock = 45;
            DoubleBuffered = true;          
            scene = new Scene(1);
            count = 0;
            scene.AddSquare_Ball(100, 80, count);
            scene.AddTriangle(110, 200, count);
            scene.AddBall_Easy(112, 260, count);
            scene.AddSquare(112, 440, count);
            scene.AddLines1(0, 560, count);
            star = Resources.star;
            balls = new List<BallsForChange>();
            random = new Random();
            Invalidate();
            balls.Add(new BallsForChange(135, 110));
            balls.Add(new BallsForChange(135, 220));
            balls.Add(new BallsForChange(135, 340));
            balls.Add(new BallsForChange(135, 460));
            timer1.Start();
            timer1.Interval=1000;
            endGame.Hide();
            wonGame.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.DimGray);
            CheckColor(e.Graphics, scene.ball.Y);
            scene.Draw(e.Graphics);
            DrawStars(e.Graphics, scene.ball.Y);
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
           scene.Shapes.Clear();
           scene.AddLines1(0, 560, count);
           Clock();
            scene.AddSquare_Ball(100, 80, count);
            scene.AddTriangle(110, 200, count);
            scene.AddBall_Easy(112, 260, count);
            scene.AddSquare(112, 440, count);
            if (scene.ball.Y < 60 && scene.ball.Y >= 0)
            {
                flagWin = 1;
                timer1.Stop();
                timer2.Start();
                timer2.Interval = 50;
                poeni.Hide();
            }

            Invalidate();
        }
        private void Clock ()
        {

            clock--;
            label2.Text = String.Format("00:{0:00}", clock);
            if (clock <= 10)
            {
                label2.ForeColor = Color.Firebrick;
            }
            if (clock == 0)
            {
                timer1.Stop();

                timer2.Start();
                timer2.Interval = 50;
                

            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (scene.ball.Y <= 150 && scene.ball.Y > 120)
            {
                scene.ball.Y -= 45;
            }
            else if (scene.ball.Y <= 105 && scene.ball.Y > 80)
            {
                scene.ball.Y -= 57;
            }
            else
            {
                scene.ball.Y -= 30;
            }
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
                    timer2.Start();
                    timer2.Interval = 50;
                } 
            }
            if (y < 510 && y >= 480)
            {
                if ((c % 4 == 0 && countBall == 0) || (c % 4 == 1 && countBall == 1) || (c % 4 == 2 && countBall == 2) || (c % 4 == 3 && countBall == 3))
                {
                }
                else
                {
                    timer1.Stop();

                    timer2.Start();
                    timer2.Interval = 50;
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

                    timer2.Start();
                    timer2.Interval = 50;
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

                    timer2.Start();
                    timer2.Interval = 50;
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

                    timer2.Start();
                    timer2.Interval = 50;
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

                    timer2.Start();
                    timer2.Interval = 50;
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

                    timer2.Start();
                    timer2.Interval = 50;
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

                    timer2.Start();
                    timer2.Interval = 50;

                }
            }
            if (y < 105 && y >= 48)
            {
                if ((c%4==0 && countBall == 2) || (c % 4 == 1 && countBall == 3) || (c % 4 == 2 && countBall == 0) || (c % 4 == 3 && countBall == 1))
                {
                    
                   
                }
                else
                {
                    timer1.Stop();

                    timer2.Start();
                    timer2.Interval = 50;
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
            if (flagWin == 1)
            {
                countEnd += 10;
                graph.FillEllipse(b, 135 - countEnd / 2, 320 - countEnd / 2, countEnd, countEnd);
                if (countEnd > 800)
                {
                    timer2.Stop();
                    
                    wonGame.Show();
                    countEnd = 0;
                    flag = 1;
                    timer2.Start();
                }
            }
            else if (flag ==1)
            {
                countEnd++;
                if(countEnd==30)
                {
                    this.Close();
                }
            }
            else
            {
                countEnd += 10;
                graph.FillEllipse(b, 135 - countEnd / 2, 320 - countEnd / 2, countEnd, countEnd);

                if (countEnd > 800)
                {
                    timer2.Stop();
                    endGame.Show();
                    countEnd = 0;
                    flag = 1;
                    timer2.Start();
                }
            }
        }
        public void DrawStars(Graphics g, int y)
        {
            if (y <= 50)
            {
                poeni.Text = "Points: 5";
            }
            else if (y < 160)
            {
                g.DrawImageUnscaled(star, 135, 45);
                poeni.Text = "Points: 4";
            }
            else if (y < 275)
            {
                g.DrawImageUnscaled(star, 135, 165);
                g.DrawImageUnscaled(star, 135, 45);
                poeni.Text = "Points: 3";
            }
            else if (y < 400)
            {
                g.DrawImageUnscaled(star, 135, 280);
                g.DrawImageUnscaled(star, 135, 165);
                g.DrawImageUnscaled(star, 135, 45);
                poeni.Text = "Points: 2";
            }
            else if (y < 520)
            {
                g.DrawImageUnscaled(star, 135, 403);
                g.DrawImageUnscaled(star, 135, 280);
                g.DrawImageUnscaled(star, 135, 165);
                g.DrawImageUnscaled(star, 135, 45);
                poeni.Text = "Points: 1";

            }
            else if (y > 530)
            {
                g.DrawImageUnscaled(star, 135, 523);
                g.DrawImageUnscaled(star, 135, 403);
                g.DrawImageUnscaled(star, 135, 280);
                g.DrawImageUnscaled(star, 135, 165);
                g.DrawImageUnscaled(star, 135, 45);
            }

        }

        private void wonGame_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
