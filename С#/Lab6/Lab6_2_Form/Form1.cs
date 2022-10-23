using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainShared;

namespace Lab6_2_Form
{
    public partial class Form1 : Form
    {

        SharedClass.RectangleD func1 = SharedClass.SquareRectangle;
        SharedClass.RectangleD func2 = SharedClass.PerimeterRectangle;

        int x, y, res_square, res_perimeter;

        private void button1_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            res_square = func1(x, y);
            res_perimeter = func2(x, y);
            textBox3.Text = res_square + " & " + res_perimeter;
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
