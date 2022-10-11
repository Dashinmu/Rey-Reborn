using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        string[] name = Enum.GetNames(typeof(Grub));
        Cat cat1 = new Cat();

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < name.Length; i++)
            { comboBox1.Items.Add(name[i]); }
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 500;
            progressBar1.Value = 5;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Grub grub_value = (Grub)Enum.Parse(typeof(Grub), comboBox1.Text);
            cat1.satiation = ((byte)grub_value);
            label1.Text = "КОТЯРА ПОКА ЕЩЁ НЕ НАЕЛСЯ.";
            if (progressBar1.Value + cat1.satiation < 500)
            {
                progressBar1.Value += cat1.satiation;
            } else if (progressBar1.Value + cat1.satiation >= 500)
            {
                progressBar1.Value = 500;
                label1.Text = "КОТЯРА НАЖРАЛСЯ!";
            }
            if (progressBar1.Value + cat1.satiation > 600)
            {
                progressBar1.Value = 210;
                label1.Text = "КОТЯРА ОБОСРАЛСЯ";
            }
        }
    }
}
