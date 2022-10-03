using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLTest;

namespace WinFormAppNET
{
    public partial class Form1 : Form
    {
        CLTest.Point point = new CLTest.Point();
        CLTest.Figure square = new CLTest.Figure();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            point.PointRead(Convert.ToSingle(textBox1.Text), Convert.ToSingle(textBox2.Text)); //Init. point

            square.FigureRead(Convert.ToSingle(textBox3.Text), Convert.ToSingle(textBox4.Text), Convert.ToSingle(textBox5.Text)); //Init. square

            textBox6.Text = Convert.ToString(square.CheckPoint(point));

            //I LOVE PAINT(without T)
            Graphics graph = this.CreateGraphics();
            graph.Clear(BackColor);
            graph.FillEllipse(Brushes.Red, point.x, point.y, 3, 3); //PAINT POINT
            graph.DrawRectangle(Pens.Blue, square.point.x, square.point.y, square.a, square.a); //PAINT SQUARE
        }
    }
}
