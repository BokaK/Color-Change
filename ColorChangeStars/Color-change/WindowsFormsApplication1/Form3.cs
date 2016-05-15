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
    public partial class Form3 : Form
    {
        public Scene scene { get; set; }
        public int count { get; set; }
        public int countCross { get; set; }
        public int clock { get; set; }
        public Image star { get; set; }
        public List<BallsForChange> balls { get; set; }
        public Random random { get; set; }
        public Graphics graph { get; set; }
        public Brush b { get; set; }
        public int countEnd { get; set; }
        public Form3()
        {
            InitializeComponent();
            graph = CreateGraphics();
            b = new SolidBrush(Color.Firebrick);
            DoubleBuffered = true;
            scene = new Scene(3);
            clock = 5;
            count = 0;
            countEnd = 20;
            countCross = 0;
            scene.ball.X = 137;
            scene.AddCircles(112, 500, count);
            scene.AddCross(115, 440, countCross);
            scene.AddDiamond(135, 150, count);
            scene.AddThreeSquares(112, 300, count);
            balls = new List<BallsForChange>();
            random = new Random();
            balls.Add(new BallsForChange(135, 190));
            balls.Add(new BallsForChange(135, 340));
            balls.Add(new BallsForChange(135, 460));
            timer1.Start();
            timer1.Interval = 1000;
            timerForCross.Start();
            timerForCross.Interval = 250;
            star = Resources.star;
            endGame.Hide();
            Invalidate();
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.DimGray);
            Graphics g = e.Graphics;
            DrawStars(g,scene.ball.Y);
            CheckColor(g, scene.ball.Y);
            scene.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            scene.Shapes.Clear();
            scene.AddCircles(112, 500, count);
            scene.AddCross(115, 440, countCross);
            scene.AddDiamond(135, 150, count);
            scene.AddThreeSquares(112, 300, count);
            Invalidate();


            Clock();
        }
        private void Clock()
        {

            clock--;
            label1.Text = String.Format("00:{0:00}", clock);
            if (clock <= 10)
            {
                label1.ForeColor = Color.Firebrick;
            }
            if (clock == 0)
            {
                timer1.Stop();
                timerForCross.Stop();
                
                timer2.Start();
                timer2.Interval = 50;
               


            }
        }
        private void Form3_MouseClick(object sender, MouseEventArgs e)
        {
            if(scene.ball.Y < 340 && scene.ball.Y > 300)
            {
                scene.ball.Y -= 60;
            }
            else if (scene.ball.Y < 280 && scene.ball.Y > 250)
            {
                scene.ball.Y -= 60;
            }
            else if (scene.ball.Y < 190 && scene.ball.Y > 150)
            {
                scene.ball.Y -= 45;
            }
            else if(scene.ball.Y < 80 && scene.ball.Y > 60)
            {
                scene.ball.Y -= 22;
            }
            else if(scene.ball.Y < 60)
            {
                scene.ball.Y -= 40;
            }
            else
            {
                scene.ball.Y -= 30;
            }
           
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
                    timer1.Stop();
                    timerForCross.Stop();
                    timer2.Start();
                    timer2.Interval = 50;
                }
            }
            else if (y < 500 && y > 470)
            {
                if ((c % 4 == 2 && countBall == 0) || (c % 4 == 0 && countBall == 1))
                {

                }
                else
                {
                    timer1.Stop();
                    timerForCross.Stop();
                    timer2.Start();
                    timer2.Interval = 50;
                }
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void timerForCross_Tick(object sender, EventArgs e)
        {
            countCross++;
            scene.Shapes.Clear();
            scene.AddCircles(112, 500, count);
            scene.AddCross(115, 440, countCross);
            scene.AddDiamond(135, 150, count);
            scene.AddThreeSquares(112, 300, count);
            Invalidate();
        }

        public void DrawStars(Graphics g, int y)
        {      
            if(y < 80)
            {

            }
            else if (y < 260)
            {
                g.DrawImageUnscaled(star, 135, 90);
            }
            else if (y < 400)
            {
                g.DrawImageUnscaled(star, 135, 265);
                g.DrawImageUnscaled(star, 135, 90);
            }
            else if (y < 520)
            {
                g.DrawImageUnscaled(star, 135, 405);
                g.DrawImageUnscaled(star, 135, 265);
                g.DrawImageUnscaled(star, 135, 90);
            }
            else if (y > 530)
            {
                g.DrawImageUnscaled(star, 135, 525);
                g.DrawImageUnscaled(star, 135, 405);
                g.DrawImageUnscaled(star, 135, 265);
                g.DrawImageUnscaled(star, 135, 90);
            }

        }

        public void CheckColor(Graphics g, int y)
        {
            
            if(y<480 && y>=450)
            {                
                if(balls.Count==3)
                {
                    scene.ball.count = random.Next(4);
                    balls.RemoveAt(2);
                }
                
            }
            if(y<360 && y>=330)
            {
                if (balls.Count == 2)
                {
                    scene.ball.count = random.Next(4);
                    balls.RemoveAt(1);
                }
            }
            if(y<210 && y>=180)
            {
                if (balls.Count == 1)
                {
                    scene.ball.count = random.Next(4);
                    balls.RemoveAt(0);
                }
            }
            
            if(balls.Count != 0)
            {
                foreach (BallsForChange b in balls)
                {
                    b.Draw(g);
                }
            }
           


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            countEnd += 10;
            graph.FillEllipse(b, 135-countEnd/2, 320-countEnd/2, countEnd, countEnd);
           
            if (countEnd>800)
            {
                timer2.Stop();
                endGame.Show();
            }
        }
    }
}
