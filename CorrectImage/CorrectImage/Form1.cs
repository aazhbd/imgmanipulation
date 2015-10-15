using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CorrectImage
{
    public partial class Form1 : Form
    {
        int x;
        Image img;
        Graphics draw;

        public Form1()
        {
            InitializeComponent();
            x = 0;
            draw = this.CreateGraphics();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            string str = of.FileName;
            if (str.Length == 0) return;
            img = Image.FromFile(str);
            x = 1;
            pictureBox1.Image = img;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                OpenFileDialog of = new OpenFileDialog();
                of.ShowDialog();
                string str = of.FileName;
                if (str.Length == 0) return;
                img = Image.FromFile(str);
            }
            int h, w;
            h = Convert.ToInt32(textBox2.Text);
            w = Convert.ToInt32(textBox1.Text);
            if (h > 300 || w > 360)
            {
                MessageBox.Show("Dimentions Too large");
                return;
            }
            draw.Clear(this.BackColor);
            draw.DrawImage(img, 310, 40, w, h);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A Test program to change the image size, Zakir");
        }
    }
}