using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw2
{
    public partial class Form1 : Form
    {
        Graphics gr;
        Pen p;
        Random rand;
     
        public Form1()
        {
            InitializeComponent();
           
        }
        void DrawCircle(int x, int y, int radius)
        {
            gr.DrawEllipse(p, x, y, radius, radius);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer1.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gr = pictureBox1.CreateGraphics();
            p = new Pen(Color.Black, 3);
            rand = new Random();
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            var radius = rand.Next(pictureBox1.Height/2);
            var x = rand.Next(pictureBox1.Width);   
            var y = rand.Next(pictureBox1.Height);
            DrawCircle(x, y, radius);
        }
    }
}
