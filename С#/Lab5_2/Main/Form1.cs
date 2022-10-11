using Owners;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Auto;
//using Marks;
//using Owners;
//using Person;

namespace Main
{
    public partial class Form1 : Form
    {
        string[] marks = Enum.GetNames(typeof(Marks.Marks.Mark));

        public List<Owners.Owners> ownersList = new List<Owners.Owners>()
        {
            new Owners.Owners("Daniil", "Matyushin", 21, "15.08.2022", "01.10.2019", Marks.Marks.Mark.Kia),
            new Owners.Owners("Ivan", "Skolotyan", 21, "15.08.2021", "01.10.2019", Marks.Marks.Mark.Lada)
        };
        public Form1()
        {
            InitializeComponent();

            for (byte i = 0; i < marks.Length; i++)
            {
                comboBox1.Items.Add(marks[i]);
            }

            foreach(var owner in ownersList)
            {
                richTextBox1.Text += owner.Print() + "\n";
            }    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
