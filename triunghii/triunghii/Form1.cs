using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triunghii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Point Middle(Point x, Point y)
        {
            Point mid = new Point();
            mid.X = (x.X + y.X) / 2;
            mid.Y = (x.Y + y.Y) / 2;
            return mid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics grp = Graphics.FromImage(bmp);

            grp.Clear(Color.White);

            Point[] points = new Point[4];

            points[0].X = int.Parse(textBox1.Text);
            points[0].Y = int.Parse(textBox2.Text);
            points[1].X = int.Parse(textBox3.Text);
            points[1].Y = int.Parse(textBox4.Text);
            points[2].X = int.Parse(textBox5.Text);
            points[2].Y = int.Parse(textBox6.Text);
            points[3].X = int.Parse(textBox7.Text);
            points[3].Y = int.Parse(textBox8.Text);

            grp.DrawPolygon(Pens.Black, points);

            grp.DrawLine(Pens.Green, points[0], points[2]); 
            grp.DrawLine(Pens.Red, points[1], points[3]);
            grp.DrawLine(Pens.Yellow, Middle(points[1], points[0]), Middle(points[2], points[3]));
            grp.DrawLine(Pens.Cyan, Middle(points[1], points[2]), Middle(points[0], points[3]));

            pictureBox1.Image = bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
