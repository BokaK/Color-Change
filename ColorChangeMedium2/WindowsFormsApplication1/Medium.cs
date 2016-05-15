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
        public Scene scene { get; set; }
        public int count { get; set; }
        public int brojac { get; set; }
        public Medium()
        {
            InitializeComponent();
            scene = new Scene(1);
            scene.AddLinii(120, 560, 0);
            scene.balls[0] = new BallsForChange(141, 100, 0);
            scene.balls[1] = new BallsForChange(141, 220, 0);
            scene.balls[2] = new BallsForChange(141, 340, 0);
            scene.balls[3] = new BallsForChange(141, 460, 0);
            count = 0;
            brojac = 0;
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
            scene.AddVertLinii(0, 200, count);
            scene.AddLinii(120, 440, count);
            scene.AddLinii(120, 560, count);
            Invalidate();
            brojac++;
            scene.AddRotateSquare(120, 320, brojac);
          

        }

        private void Medium_MouseClick(object sender, MouseEventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
