
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.View = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cellColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rowHeightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnWeightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headerFontSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headerColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Close = new System.Windows.Forms.ToolStripMenuItem();
            this.Form1_Button_Close = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DataInput = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Label4_PosNum = new System.Windows.Forms.Label();
            this.Label3_StepX = new System.Windows.Forms.Label();
            this.Label2_LastX = new System.Windows.Forms.Label();
            this.Label1_FirstX = new System.Windows.Forms.Label();
            this.Header_DataInput = new System.Windows.Forms.Label();
            this.IntervalDataTable = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Label2_MinFunValue = new System.Windows.Forms.Label();
            this.Label1_MaxFunValue = new System.Windows.Forms.Label();
            this.Header_TableFuncValues = new System.Windows.Forms.Label();
            this.GraphFuncInterval = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.DataInput.SuspendLayout();
            this.IntervalDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GraphFuncInterval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.View,
            this.Close});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(37, 20);
            this.File.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // View
            // 
            this.View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styleToolStripMenuItem,
            this.graphToolStripMenuItem});
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(44, 20);
            this.View.Text = "View";
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textColorToolStripMenuItem,
            this.cellColorToolStripMenuItem,
            this.rowHeightToolStripMenuItem,
            this.columnWeightToolStripMenuItem,
            this.headerFontSettingsToolStripMenuItem,
            this.headerColorToolStripMenuItem});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.styleToolStripMenuItem.Text = "Style";
            // 
            // textColorToolStripMenuItem
            // 
            this.textColorToolStripMenuItem.Name = "textColorToolStripMenuItem";
            this.textColorToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.textColorToolStripMenuItem.Text = "Text Color";
            this.textColorToolStripMenuItem.Click += new System.EventHandler(this.textColorToolStripMenuItem_Click);
            // 
            // cellColorToolStripMenuItem
            // 
            this.cellColorToolStripMenuItem.Name = "cellColorToolStripMenuItem";
            this.cellColorToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cellColorToolStripMenuItem.Text = "Cell Color";
            this.cellColorToolStripMenuItem.Click += new System.EventHandler(this.cellColorToolStripMenuItem_Click);
            // 
            // rowHeightToolStripMenuItem
            // 
            this.rowHeightToolStripMenuItem.Name = "rowHeightToolStripMenuItem";
            this.rowHeightToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.rowHeightToolStripMenuItem.Text = "Row height";
            this.rowHeightToolStripMenuItem.Click += new System.EventHandler(this.rowHeightToolStripMenuItem_Click);
            // 
            // columnWeightToolStripMenuItem
            // 
            this.columnWeightToolStripMenuItem.Name = "columnWeightToolStripMenuItem";
            this.columnWeightToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.columnWeightToolStripMenuItem.Text = "Column weight";
            // 
            // headerFontSettingsToolStripMenuItem
            // 
            this.headerFontSettingsToolStripMenuItem.Name = "headerFontSettingsToolStripMenuItem";
            this.headerFontSettingsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.headerFontSettingsToolStripMenuItem.Text = "Header Font Settings";
            this.headerFontSettingsToolStripMenuItem.Click += new System.EventHandler(this.headerFontSettingsToolStripMenuItem_Click);
            // 
            // headerColorToolStripMenuItem
            // 
            this.headerColorToolStripMenuItem.Name = "headerColorToolStripMenuItem";
            this.headerColorToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.headerColorToolStripMenuItem.Text = "Header Color";
            this.headerColorToolStripMenuItem.Click += new System.EventHandler(this.headerColorToolStripMenuItem_Click);
            // 
            // graphToolStripMenuItem
            // 
            this.graphToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.colorBackgroundToolStripMenuItem});
            this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            this.graphToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.graphToolStripMenuItem.Text = "Graph";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // colorBackgroundToolStripMenuItem
            // 
            this.colorBackgroundToolStripMenuItem.Name = "colorBackgroundToolStripMenuItem";
            this.colorBackgroundToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorBackgroundToolStripMenuItem.Text = "Color background";
            this.colorBackgroundToolStripMenuItem.Click += new System.EventHandler(this.colorBackgroundToolStripMenuItem_Click);
            // 
            // Close
            // 
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(48, 20);
            this.Close.Text = "Close";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Form1_Button_Close
            // 
            this.Form1_Button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Form1_Button_Close.Location = new System.Drawing.Point(0, 414);
            this.Form1_Button_Close.Name = "Form1_Button_Close";
            this.Form1_Button_Close.Size = new System.Drawing.Size(800, 37);
            this.Form1_Button_Close.TabIndex = 1;
            this.Form1_Button_Close.Text = "Exit";
            this.Form1_Button_Close.UseVisualStyleBackColor = true;
            this.Form1_Button_Close.Click += new System.EventHandler(this.Form1_Button_Close_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DataInput);
            this.tabControl1.Controls.Add(this.IntervalDataTable);
            this.tabControl1.Controls.Add(this.GraphFuncInterval);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 385);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // DataInput
            // 
            this.DataInput.Controls.Add(this.textBox4);
            this.DataInput.Controls.Add(this.textBox3);
            this.DataInput.Controls.Add(this.textBox2);
            this.DataInput.Controls.Add(this.textBox1);
            this.DataInput.Controls.Add(this.Label4_PosNum);
            this.DataInput.Controls.Add(this.Label3_StepX);
            this.DataInput.Controls.Add(this.Label2_LastX);
            this.DataInput.Controls.Add(this.Label1_FirstX);
            this.DataInput.Controls.Add(this.Header_DataInput);
            this.DataInput.Location = new System.Drawing.Point(4, 22);
            this.DataInput.Name = "DataInput";
            this.DataInput.Padding = new System.Windows.Forms.Padding(3);
            this.DataInput.Size = new System.Drawing.Size(792, 359);
            this.DataInput.TabIndex = 0;
            this.DataInput.Text = "Data input";
            this.DataInput.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(260, 211);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(260, 173);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(260, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(260, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // Label4_PosNum
            // 
            this.Label4_PosNum.AutoSize = true;
            this.Label4_PosNum.Location = new System.Drawing.Point(120, 214);
            this.Label4_PosNum.Name = "Label4_PosNum";
            this.Label4_PosNum.Size = new System.Drawing.Size(104, 13);
            this.Label4_PosNum.TabIndex = 9;
            this.Label4_PosNum.Text = "Enter positive num A";
            // 
            // Label3_StepX
            // 
            this.Label3_StepX.AutoSize = true;
            this.Label3_StepX.Location = new System.Drawing.Point(120, 176);
            this.Label3_StepX.Name = "Label3_StepX";
            this.Label3_StepX.Size = new System.Drawing.Size(71, 13);
            this.Label3_StepX.TabIndex = 8;
            this.Label3_StepX.Text = "Enter step Xh";
            // 
            // Label2_LastX
            // 
            this.Label2_LastX.AutoSize = true;
            this.Label2_LastX.Location = new System.Drawing.Point(120, 136);
            this.Label2_LastX.Name = "Label2_LastX";
            this.Label2_LastX.Size = new System.Drawing.Size(67, 13);
            this.Label2_LastX.TabIndex = 7;
            this.Label2_LastX.Text = "Enter last Xk";
            // 
            // Label1_FirstX
            // 
            this.Label1_FirstX.AutoSize = true;
            this.Label1_FirstX.Location = new System.Drawing.Point(120, 96);
            this.Label1_FirstX.Name = "Label1_FirstX";
            this.Label1_FirstX.Size = new System.Drawing.Size(67, 13);
            this.Label1_FirstX.TabIndex = 6;
            this.Label1_FirstX.Text = "Enter first Xn";
            // 
            // Header_DataInput
            // 
            this.Header_DataInput.AutoSize = true;
            this.Header_DataInput.Location = new System.Drawing.Point(338, 29);
            this.Header_DataInput.Name = "Header_DataInput";
            this.Header_DataInput.Size = new System.Drawing.Size(92, 13);
            this.Header_DataInput.TabIndex = 5;
            this.Header_DataInput.Text = "Interval data input";
            // 
            // IntervalDataTable
            // 
            this.IntervalDataTable.Controls.Add(this.dataGridView1);
            this.IntervalDataTable.Controls.Add(this.textBox6);
            this.IntervalDataTable.Controls.Add(this.textBox5);
            this.IntervalDataTable.Controls.Add(this.Label2_MinFunValue);
            this.IntervalDataTable.Controls.Add(this.Label1_MaxFunValue);
            this.IntervalDataTable.Controls.Add(this.Header_TableFuncValues);
            this.IntervalDataTable.Location = new System.Drawing.Point(4, 22);
            this.IntervalDataTable.Name = "IntervalDataTable";
            this.IntervalDataTable.Padding = new System.Windows.Forms.Padding(3);
            this.IntervalDataTable.Size = new System.Drawing.Size(792, 359);
            this.IntervalDataTable.TabIndex = 1;
            this.IntervalDataTable.Text = "Interval data table";
            this.IntervalDataTable.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(479, 311);
            this.dataGridView1.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(495, 116);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(495, 236);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 3;
            // 
            // Label2_MinFunValue
            // 
            this.Label2_MinFunValue.AutoSize = true;
            this.Label2_MinFunValue.Location = new System.Drawing.Point(492, 220);
            this.Label2_MinFunValue.Name = "Label2_MinFunValue";
            this.Label2_MinFunValue.Size = new System.Drawing.Size(107, 13);
            this.Label2_MinFunValue.TabIndex = 2;
            this.Label2_MinFunValue.Text = "Min value of the func";
            // 
            // Label1_MaxFunValue
            // 
            this.Label1_MaxFunValue.AutoSize = true;
            this.Label1_MaxFunValue.Location = new System.Drawing.Point(492, 100);
            this.Label1_MaxFunValue.Name = "Label1_MaxFunValue";
            this.Label1_MaxFunValue.Size = new System.Drawing.Size(110, 13);
            this.Label1_MaxFunValue.TabIndex = 1;
            this.Label1_MaxFunValue.Text = "Max value of the func";
            // 
            // Header_TableFuncValues
            // 
            this.Header_TableFuncValues.AutoSize = true;
            this.Header_TableFuncValues.Location = new System.Drawing.Point(319, 13);
            this.Header_TableFuncValues.Name = "Header_TableFuncValues";
            this.Header_TableFuncValues.Size = new System.Drawing.Size(215, 13);
            this.Header_TableFuncValues.TabIndex = 0;
            this.Header_TableFuncValues.Text = "Table of the func values on interval [Xn; Xk]";
            // 
            // GraphFuncInterval
            // 
            this.GraphFuncInterval.Controls.Add(this.chart1);
            this.GraphFuncInterval.Location = new System.Drawing.Point(4, 22);
            this.GraphFuncInterval.Name = "GraphFuncInterval";
            this.GraphFuncInterval.Padding = new System.Windows.Forms.Padding(3);
            this.GraphFuncInterval.Size = new System.Drawing.Size(792, 359);
            this.GraphFuncInterval.TabIndex = 2;
            this.GraphFuncInterval.Text = "Graph of the func on interval";
            this.GraphFuncInterval.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea14.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.chart1.Legends.Add(legend14);
            this.chart1.Location = new System.Drawing.Point(8, 25);
            this.chart1.Name = "chart1";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series14.IsVisibleInLegend = false;
            series14.Legend = "Legend1";
            series14.Name = "Series1";
            series14.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series14.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series14);
            this.chart1.Size = new System.Drawing.Size(776, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Form1_Button_Close);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "by Dashinmu & H1eb";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.DataInput.ResumeLayout(false);
            this.DataInput.PerformLayout();
            this.IntervalDataTable.ResumeLayout(false);
            this.IntervalDataTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GraphFuncInterval.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem View;
        private System.Windows.Forms.ToolStripMenuItem Close;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cellColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rowHeightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem columnWeightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headerFontSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headerColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorBackgroundToolStripMenuItem;
        private System.Windows.Forms.Button Form1_Button_Close;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DataInput;
        private System.Windows.Forms.TabPage IntervalDataTable;
        private System.Windows.Forms.TabPage GraphFuncInterval;
        private System.Windows.Forms.Label Label4_PosNum;
        private System.Windows.Forms.Label Label3_StepX;
        private System.Windows.Forms.Label Label2_LastX;
        private System.Windows.Forms.Label Label1_FirstX;
        private System.Windows.Forms.Label Header_DataInput;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label Label2_MinFunValue;
        private System.Windows.Forms.Label Label1_MaxFunValue;
        private System.Windows.Forms.Label Header_TableFuncValues;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

