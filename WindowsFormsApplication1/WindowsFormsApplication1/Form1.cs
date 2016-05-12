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


        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
            scene.AddShape(100, 100, 0);
            count = 0;
            Invalidate();
            timer1.Start();
            timer1.Interval=1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            scene.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            
            
            scene.AddShape(100, 100, count);
            Invalidate();
        }
    }
}
