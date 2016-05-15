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
        public int countCross { get; set; }
        public int clock { get; set; }
        public Form3()
        {
            InitializeComponent();
            DoubleBuffered = true;
            scene = new Scene(3);
            clock = 40;
            count = 0;
            countCross = 0;
            scene.AddCircles(120, 500, count);
            scene.AddCross(120, 440, countCross);
            scene.balls.Add(new BallsForChange(142, 110));
            scene.balls.Add(new BallsForChange(141, 220));
            scene.balls.Add(new BallsForChange(141, 340));
            scene.balls.Add(new BallsForChange(141, 460));
            timer1.Start();
            timer1.Interval = 1000;
            timerForCross.Start();
            timerForCross.Interval = 250;
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
            scene.AddCross(120, 440, countCross);
            Invalidate();


            Clock();
        }
        private void Clock()
        {

            clock--;
            label1.Text = String.Format("00:{0:00}", clock);
            if (clock <= 10)
            {
                label1.ForeColor = Color.Black;
            }
            if (clock == 0)
            {

                MessageBox.Show("GAME OVER!");
                timer1.Stop();
                DialogResult = System.Windows.Forms.DialogResult.Cancel;

            }
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

        private void timerForCross_Tick(object sender, EventArgs e)
        {
            countCross++;
            scene.Shapes.Clear();
            scene.AddCircles(120, 500, count);
            scene.AddCross(120, 440, countCross);
            Invalidate();
        }
    }
}
