using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RotateImage
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            string str = of.FileName;
            if (str.Length == 0) return;
            img = Image.FromFile(str);
            x = 1;
            pictureBox1.Image = img;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                OpenFileDialog of = new OpenFileDialog();
                of.ShowDialog();
                string str = of.FileName;
                if (str.Length == 0) return;
                img = Image.FromFile(str);
                x = 1;
                pictureBox1.Image = img;
            }

            img.RotateFlip(RotateFlipType.Rotate90FlipNone);

            pictureBox2.Image = img;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                OpenFileDialog of = new OpenFileDialog();
                of.ShowDialog();
                string str = of.FileName;
                if (str.Length == 0) return;
                img = Image.FromFile(str);
                x = 1;
                pictureBox1.Image = img;
            }

            img.RotateFlip(RotateFlipType.RotateNoneFlipXY);

            pictureBox2.Image = img;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A Test program to Rotate and Flip the Image, Zakir");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}