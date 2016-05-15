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
        public int X { set; get; }
        public Scene scene { get; set; }
        public int count { get; set; }
        public int brojac { get; set; }
        public int clock { set; get; }
        public int countIks { get; set; }
        public Image star { get; set; }
        public List<BallsForChange> balls { get; set; }
        public Random random { get; set; }
        public Medium()
        {
            InitializeComponent();
            X = 0;
            clock = 40;
            scene = new Scene(1);
            scene.AddLinii(120, 560, 0);
            star = Resources.star;
            balls = new List<BallsForChange>();
            random = new Random();
            balls.Add(new BallsForChange(142, 110));
            balls.Add(new BallsForChange(141, 220));
            balls.Add(new BallsForChange(141, 340));
            balls.Add(new BallsForChange(141, 460));
            count = 0;
            brojac = 0;
            countIks = 0;
            scene.AddIks(120, 80, countIks);
            scene.AddVertLinii(0, 200, count);
            scene.AddLinii(120, 440, count);
            scene.AddLinii(120, 560, count);
            scene.AddRotateSquare(120, 320, brojac);
            Invalidate();
            timer1Medium.Start();
            timer1Medium.Interval = 1000;
            timer1.Start();
            timer1.Interval = 250;
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
            scene.AddIks(120, 80, countIks);
            if (X > 250)
            {
                X = 0;
            }
            else
            X += 20;
            scene.AddVertLinii(X, 200, count);
            scene.AddLinii(120, 440, count);
            scene.AddLinii(120, 560, count);
            Invalidate();
            brojac++;
            scene.AddRotateSquare(120, 320, brojac);
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
                MessageBox.Show("GAME OVER!");
                
                DialogResult = System.Windows.Forms.DialogResult.Cancel;

            }
        }


        private void Medium_MouseClick(object sender, MouseEventArgs e)
        {
            scene.ball.Y -= 30;
           // check(scene.ball.Y, scene.ball.count, count);
        }
        public void check(int y, int countBall, int c)
        {
            if (y < 570 && y > 540)
            {
                if ((c % 4 == 0 && countBall == 0) || (c % 4 == 2 && countBall == 1) )
                {

                }
                else
                {
                    timer1Medium.Stop();
                    timer1.Stop();
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
                    timer1Medium.Stop();
                    timer1.Stop();
                    MessageBox.Show("Game over!");
                    this.Close();
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countIks++;
            scene.Shapes.Clear();
            scene.AddIks(120, 80, countIks);
            if (X > 250)
            {
                X = 0;
            }
            else
                X += 20;
            scene.AddVertLinii(X, 200, count);
            scene.AddLinii(120, 440, count);
            scene.AddLinii(120, 560, count);
            Invalidate();
            scene.AddRotateSquare(120, 320, brojac);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public void DrawStars(Graphics g, int y)
        {
            if (y < 80)
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
            if (y < 110 && y >= 80)
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
    }
}
