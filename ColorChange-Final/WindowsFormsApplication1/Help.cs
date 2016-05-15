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
    public partial class Help : Form
    {
        public Image image { get; set; }
        public Image image1 { get; set; }
        public Help()
        {
            InitializeComponent();
            image = Resources.aaaa;
            image1 = Resources.ball;
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Help_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(image, 40,170);
            e.Graphics.DrawImageUnscaled(image1, 40, 50);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
