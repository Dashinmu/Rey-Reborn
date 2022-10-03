using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Листинг 3
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Листинг 2
        double xn, xk, xh, x, y, a, ymax = 0, ymin = 0, yt = 0;
        int i, k, j, h, m;

        //Листинг 4, все элементы закрытия приложения
        private void Form1_Button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Листинг 5, this part is AAAAAA
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Series plot1 = chart1.Series[0];
            plot1.Points.Clear();
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != "") && (textBox4.Text != ""))
            {
                xn = Convert.ToDouble(textBox1.Text);
                xk = Convert.ToDouble(textBox2.Text);
                xh = Convert.ToDouble(textBox3.Text);
                a = Convert.ToDouble(textBox4.Text);
                if ((xn >= xk) || (xh > (xk - xn))) MessageBox.Show("Данные заполнены неверно", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    x = xn;
                    dataGridView1.Columns.Clear();
                    dataGridView1.ColumnCount = 2;
                    int p = (int)Math.Ceiling((xk - xn) / xh + 1);
                    dataGridView1.Rows.Add(p);
                    dataGridView1.Rows[0].Cells[0].Value = Convert.ToString("x");
                    dataGridView1.Rows[0].Cells[1].Value = Convert.ToString("y");
                    i = 1; x = xn; ymax = -1.8e307; ymin = 1.8e307;
                    while (x < xk)
                    {
                        if (x <= 0)
                        {
                            y = Math.Pow(Math.Abs(x), 5.0) * ( 1.0 / Math.Tan(Math.Abs(2.0 * x)) );
                            //y = (Math.Pow((3 * x - 1), 2)) / (Math.Pow(x, 5) + 2 * x + 1);
                        }
                        else
                            if (x <= a)
                        {
                            y = Math.Log(Math.Pow(x, 2.0) + 1.0);
                            //y = Math.Log(Math.Sqrt(x + 5), 2);
                        }
                        else
                                if (x > a)
                        {
                            y = Math.Exp(-2.0 * x) - Math.Pow(Math.Abs(x + 1.0), 1.0 / 3.0);
                            //y = Math.Pow((1 + x * x), (double)1 / 5);
                        }
                        plot1.Points.AddXY(x, y);
                        dataGridView1.Rows[i].Cells[0].Value = Convert.ToString(x);
                        yt = Math.Ceiling(y * 100) / 100;
                        dataGridView1.Rows[i].Cells[1].Value = Convert.ToString(yt);
                        if (y > ymax) ymax = Math.Ceiling(y * 100) / 100;
                        if (y < ymin) ymin = Math.Ceiling(y * 100) / 100;
                        x = x + xh;
                        i++;
                    }
                    textBox6.Text = Convert.ToString(ymax);
                    textBox5.Text = Convert.ToString(ymin);
                }
            }
            else MessageBox.Show("Заполни данные!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //Листинг 6
        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) dataGridView1.DefaultCellStyle.ForeColor = colorDialog1.Color;
        }

        //Листинг 7
        private void cellColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) dataGridView1.DefaultCellStyle.BackColor = colorDialog1.Color;
        }

        //Листинг 8
        private void rowHeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.textBox1.Text = Convert.ToString(dataGridView1.Rows[0].Height);
            f.ShowDialog();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                row.Height = f.h;
            }
        }

        //Листинг 14
        private void headerColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) Header_TableFuncValues.ForeColor = colorDialog1.Color;
        }

        //Листинг 13
        private void headerFontSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) Header_TableFuncValues.Font = fontDialog1.Font;
        }

        //Листинг 15
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Series plot1 = chart1.Series[0];
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) plot1.Color = colorDialog1.Color;
        }

        //Листинг 16
        private void colorBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Series plot1 = chart1.Series[0];
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) chart1.BackColor = colorDialog1.Color;
        }

        //Листинг 17
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog1.FileName);
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    sw.WriteLine(dataGridView1.Rows[i].Cells[0].Value.ToString() + " | " + dataGridView1.Rows[i].Cells[1].Value.ToString());
                sw.Close();
            }

        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
