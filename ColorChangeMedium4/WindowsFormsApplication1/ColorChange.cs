﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            Medium m = new Medium();
            m.ShowDialog();
            if (m.DialogResult == System.Windows.Forms.DialogResult.Cancel)
            {
                m.Close();
            }
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            Form1 tmp = new Form1();
            tmp.ShowDialog();
          if( tmp.DialogResult == System.Windows.Forms.DialogResult.Cancel)
            {
                tmp.Close();
            }
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            Form3 tmp = new Form3();
            tmp.ShowDialog();
            if (tmp.DialogResult == System.Windows.Forms.DialogResult.Cancel)
            {
                tmp.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
