using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageTest
{
    public partial class Form1 : Form
    {
        Bitmap img;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            string str = of.FileName;
            if (str.Length == 0) return;
            img = (Bitmap) Image.FromFile(str);
            pictureBox1.Image = img;
        }
    }
}