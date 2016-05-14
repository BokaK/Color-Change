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
    public partial class Medium : Form
    {
        public int X { set; get; }
        public Scene scene { get; set; }
        public int count { get; set; }
        public int brojac { get; set; }
        public int clock { set; get; }
        public Medium()
        {
            InitializeComponent();
            X = 0;
            clock = 40;
            scene = new Scene(1);
            scene.AddLinii(120, 560, 0);
            scene.balls.Add(new BallsForChange(142, 110));
            scene.balls.Add(new BallsForChange(141, 220));
            scene.balls.Add(new BallsForChange(141, 340));
            scene.balls.Add(new BallsForChange(141, 460));
            count = 0;
            brojac = 0;
            scene.AddIks(120, 80, count);
            scene.AddVertLinii(0, 200, count);
            scene.AddLinii(120, 440, count);
            scene.AddLinii(120, 560, count);
            scene.AddRotateSquare(120, 320, brojac);
            Invalidate();
            timer1Medium.Start();
            timer1Medium.Interval = 1000;
           // timer1.Start();
           // timer1.Interval = 500;
        }

        private void Medium_Load(object sender, EventArgs e)
        {

        }

        private void Medium_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.DimGray);
            scene.Draw(e.Graphics);
        }

        private void timer1Medium_Tick(object sender, EventArgs e)
        {
            count++;
            scene.Shapes.Clear();
            scene.AddIks(120, 80, count);
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

                MessageBox.Show("GAME OVER!");
                timer1.Stop();
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

        private void timer1_Tick(object sender, EventArgs e)
        {

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
