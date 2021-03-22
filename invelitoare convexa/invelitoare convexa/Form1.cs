using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace invelitoare_convexa
{
    public partial class Form1 : Form
    {
        Graphics G;//panoul de desenare
        Pen P;//creionul
        SolidBrush SB;//pensula
        int xv, yv;//coordonatele anterioare pt linie si dreptunghi
        List<Point> L;//lista de puncte pentru poligon

        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            G = pictureBox1.CreateGraphics();//asociez G cu pictureboxul
            P = new Pen(Color.Black);//creez un creion cu negru
            SB = new SolidBrush(Color.Black);//creez o pensula cu negru
            L = new List<Point>();//creez lista de puncte
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Point[] V = new Point[L.Count];//creez vectorul de puncte
            for (int i = 0; i < L.Count; i++)//copiez punctele
                V[i] = L[i];



            G.DrawPolygon(P, V);
            L.Clear();//golesc lista

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

            G = pictureBox1.CreateGraphics();
            P = new Pen(Color.Black);

            int x = MousePosition.X;
            int y= MousePosition.Y;
            x = x - this.Left;
            y = y - this.Top;
            x = x - pictureBox1.Left;
            y = y - pictureBox1.Top;
            x = x - 8;
            y = y - 31;
            G.DrawEllipse(P, x, y, 2, 2);
            L.Add(new Point(x, y));//adaug punctul in lista
        }
    }
}
