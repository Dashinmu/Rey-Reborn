using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        //Листинг 9
        public int h;
        public int m;


        public Form2()
        {
            InitializeComponent();
        }

        //Листинг 10
        private void Form2_Button_Ok_Click(object sender, EventArgs e)
        {
            h = Convert.ToInt32(textBox1.Text);
            m = Convert.ToInt32(textBox1.Text);
            this.Hide();

        }
        
        //Листинг 11
        private void Form2_Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
