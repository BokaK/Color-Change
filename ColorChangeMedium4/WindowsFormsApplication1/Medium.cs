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
    public partial class Medium : Form
    {

        public Scene scene { get; set; }
        public int count { get; set; }
        public int brojac { get; set; }
        public int clock { set; get; }
        public int countIks { get; set; }
        public Image star { get; set; }
        public List<BallsForChange> balls { get; set; }
        public Random random { get; set; }
        public int flagWin { get; set; }
        public int countEnd { get; set; }
        public Graphics graph { get; set; }
        public Brush b { get; set; }
        public Medium()
        {
            InitializeComponent();
            flagWin = 0;
            graph = CreateGraphics();
            b = new SolidBrush(Color.IndianRed);
            clock = 40;
            countEnd = 0;
            scene = new Scene(1);
            scene.AddLinii(120, 560, 0);
            star = Resources.star;
            balls = new List<BallsForChange>();
            random = new Random();
            balls.Add(new BallsForChange(135, 170));          
            balls.Add(new BallsForChange(135, 300));
            balls.Add(new BallsForChange(135, 460));
            count = 0;
            brojac = 0;
            countIks = 0;
            scene.AddIks(100, 130, countIks);
            scene.AddVertLinii(0, 270, countIks);          
            scene.AddLinii(0, 560, count);
            scene.AddRotateSquare(90, 440, countIks);
            Invalidate();
            timer1Medium.Start();
            timer1Medium.Interval = 1000;
            timer1.Start();
            timer1.Interval = 250;
            endGame.Hide();
            wonGame.Hide();
            DoubleBuffered = true;
        }

        private void Medium_Load(object sender, EventArgs e)
        {

        }

        private void Medium_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.DimGray);
            Graphics g = e.Graphics;
            DrawStars(g, scene.ball.Y);
            CheckColor(g, scene.ball.Y);
            scene.Draw(e.Graphics);
        }

        private void timer1Medium_Tick(object sender, EventArgs e)
        {
            count++;
            scene.Shapes.Clear();
            scene.AddIks(100, 130, countIks);
            scene.AddVertLinii(0, 270, countIks);           
            scene.AddLinii(0, 560, count);
            scene.AddRotateSquare(90, 440, countIks);
            Invalidate();
            brojac++;
            if (scene.ball.Y < 20 && scene.ball.Y >= 0)
            {
                flagWin = 1;
                timer1Medium.Stop();
                timer1.Stop();
                timer2.Start();
                timer2.Interval = 50;
            }
            Clock();

        }
        private void Clock()
        {

            clock--;
            label1.Text = String.Format("00:{0:00}", clock);
            if (clock <= 10)
            {
                label1.ForeColor = Color.Red;
            }
            if (clock == 0)
            {
                timer1Medium.Stop();
                timer1.Stop();
                timer2.Start();
                timer2.Interval = 50;

               

            }
        }


        private void Medium_MouseClick(object sender, MouseEventArgs e)
        {
            if(scene.ball.Y<460 && scene.ball.Y>=440)
            {
                scene.ball.Y -= 50;
            }
            else if (scene.ball.Y <400 && scene.ball.Y >= 350)
            {
                scene.ball.Y -= 50;
            }
            else if (scene.ball.Y < 300 && scene.ball.Y >= 250)
            {
                scene.ball.Y -= 100;
            }
            else if (scene.ball.Y < 150 && scene.ball.Y >= 100)
            {
                scene.ball.Y -= 80;
            }
            else if (scene.ball.Y < 100)
            {
                scene.ball.Y -= 40;
            }
            else {
                scene.ball.Y -= 30;
            }
           
           check(scene.ball.Y, scene.ball.count, count, countIks);
        }
        public void check(int y, int countBall, int c, int c2)
        {
             if (y < 570 && y >= 540)
             {
                 if ((c % 4 == 0 && countBall == 1) || (c % 4 == 2 && countBall == 1) || c % 4 == 1 || c % 4 == 3)
                 {

                 }
                 else
                 {
                     timer1Medium.Stop();
                     timer1.Stop();
                     timer2.Start();
                     timer2.Interval = 50;
                 }
             }
             else if (y < 500 && y > 470)
             {
                 if ((c % 4 == 1 && countBall == 3) || (c % 4 == 3 && countBall == 3) || c % 4 == 0 || c % 4 == 2)
                 {

                 }
                 else
                 {
                     timer1Medium.Stop();
                     timer1.Stop();
                     timer2.Start();
                     timer2.Interval = 50;
                 }
             }
             else if (y < 440 && y >= 390)
             {
                 if ((c % 4 == 1 && countBall == 3) || (c % 4 == 3 && countBall == 1) || (c % 4 == 0 && countBall == 0) || (c % 4 == 2 && countBall == 2))
                 {

                 }
                 else
                 {
                     timer1Medium.Stop();
                     timer1.Stop();
                     timer2.Start();
                     timer2.Interval = 50;
                 }
             }
             else if (y < 350 && y >= 300)
             {
                 if ((c % 4 == 1 && countBall == 1) || (c % 4 == 3 && countBall == 3) || (c % 4 == 0 && countBall == 2) || (c % 4 == 2 && countBall == 0))
                 {

                 }
                 else
                 {
                     timer1Medium.Stop();
                     timer1.Stop();
                     timer2.Start();
                     timer2.Interval = 50;
                 }
             }
             else if (y < 210 && y >= 170)
             {
                 if ((c2 % 14 == 0 && countBall == 3) || c2 % 14 == 1 || (c2 % 14 == 2 && countBall == 2) || c2 % 14 == 3 || (c2 % 14 == 4 && countBall == 1) || c2 % 14 == 5 || (c2 % 14 == 6 && countBall == 0) || c2 % 14 == 7 || (c2 % 14 == 8 && countBall == 2) || c2 % 14 == 9 || (c2 % 14 == 10 && countBall == 1) || c2 % 14 == 11 || (c2 % 14 == 12 && countBall == 0) || c2 % 14 == 13)
                 {

                 }
                 else
                 {
                     timer1Medium.Stop();
                     timer1.Stop();
                     timer2.Start();
                     timer2.Interval = 50;
                 }
             }
            else if (y < 150 && y >= 120)
            {
                if (((c2 % 16 == 0 || c2 % 16 == 1 || c2 % 16 == 2 || c2 % 16 == 3) && countBall == 0) || ((c2 % 16 == 4 || c2 % 16 == 5 || c2 % 16 == 6 || c2 % 16 == 7) && countBall == 1) || ((c2 % 16 == 8 || c2 % 16 == 9 || c2 % 16 == 10 || c2 % 16 == 11) && countBall == 2) || ((c2 % 16 == 12 || c2 % 16 == 13 || c2 % 16 == 14 || c2 % 16 == 15) && countBall == 3))
                {

                }
                else
                {
                    timer1Medium.Stop();
                    timer1.Stop();
                    timer2.Start();
                    timer2.Interval = 50;
                }
            }
            
            else if (y < 100 && y > 20)
            {
                if ((c2 % 16 == 0 && countBall == 0) || (c2 % 16 == 4 && countBall == 3) || (c2 % 16 == 8 && countBall == 2) || (c2 % 16 == 12 && countBall == 1))
                {

                }
                else
                {
                    timer1Medium.Stop();
                    timer1.Stop();
                    timer2.Start();
                    timer2.Interval = 50;
                }
            }
            
            else if (y < 20 && y >= 0)
            {
                if (((c2 % 16 == 0 || c2 % 16 == 1 || c2 % 16 == 2 || c2 % 16 == 3) && countBall == 2) || ((c2 % 16 == 4 || c2 % 16 == 5 || c2 % 16 == 6 || c2 % 16 == 7) && countBall == 3) || ((c2 % 16 == 8 || c2 % 16 == 9 || c2 % 16 == 10 || c2 % 16 == 11) && countBall == 0) || ((c2 % 16 == 12 || c2 % 16 == 13 || c2 % 16 == 14 || c2 % 16 == 15) && countBall == 1))
                {

                }
                else
                {
                    timer1Medium.Stop();
                    timer1.Stop();
                    timer2.Start();
                    timer2.Interval = 50;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countIks++;
            scene.Shapes.Clear();
            scene.AddIks(100, 130, countIks);
            scene.AddVertLinii(0, 270, countIks);
            
            scene.AddLinii(0, 560, count);
            scene.AddRotateSquare(90, 440, countIks);
            Invalidate();
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public void DrawStars(Graphics g, int y)
        {
            if (y < 80)
            {

            }
            else if (y < 200)
            {
                g.DrawImageUnscaled(star, 135, 90);
            }
            else if (y < 380)
            {
                g.DrawImageUnscaled(star, 135, 235);
                g.DrawImageUnscaled(star, 135, 90);
            }
            else if (y < 520)
            {
                g.DrawImageUnscaled(star, 135, 385);
                g.DrawImageUnscaled(star, 135, 235);
                g.DrawImageUnscaled(star, 135, 90);
            }
            else if (y > 530)
            {
                g.DrawImageUnscaled(star, 135, 525);
                g.DrawImageUnscaled(star, 135, 385);
                g.DrawImageUnscaled(star, 135, 235);
                g.DrawImageUnscaled(star, 135, 90);
            }

        }

        public void CheckColor(Graphics g, int y)
        {

            if (y < 480 && y >= 450)
            {
                if (balls.Count == 3)
                {
                    scene.ball.count = random.Next(4);
                    balls.RemoveAt(2);
                }

            }
            if (y < 310 && y >= 280)
            {
                if (balls.Count == 2)
                {
                    scene.ball.count = random.Next(4);
                    balls.RemoveAt(1);
                }
            }
            
            if (y < 180 && y >= 150)
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
                }
            }
        }
    }
}
