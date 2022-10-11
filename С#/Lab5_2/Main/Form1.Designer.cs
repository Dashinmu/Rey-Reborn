namespace Main
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.dtReleaseBox = new System.Windows.Forms.TextBox();
            this.dtPurshaseBox = new System.Windows.Forms.TextBox();
            this.markBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(25, 48);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(260, 117);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(78, 313);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 4;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(184, 313);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameBox.TabIndex = 5;
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(290, 313);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(100, 20);
            this.ageBox.TabIndex = 6;
            // 
            // dtReleaseBox
            // 
            this.dtReleaseBox.Location = new System.Drawing.Point(502, 313);
            this.dtReleaseBox.Name = "dtReleaseBox";
            this.dtReleaseBox.Size = new System.Drawing.Size(100, 20);
            this.dtReleaseBox.TabIndex = 8;
            // 
            // dtPurshaseBox
            // 
            this.dtPurshaseBox.Location = new System.Drawing.Point(396, 313);
            this.dtPurshaseBox.Name = "dtPurshaseBox";
            this.dtPurshaseBox.Size = new System.Drawing.Size(100, 20);
            this.dtPurshaseBox.TabIndex = 7;
            // 
            // markBox
            // 
            this.markBox.FormattingEnabled = true;
            this.markBox.Location = new System.Drawing.Point(608, 312);
            this.markBox.Name = "markBox";
            this.markBox.Size = new System.Drawing.Size(121, 21);
            this.markBox.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(78, 352);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(651, 37);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "LASTNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "AGE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "DatePurshase";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "DateRelease";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(650, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mark";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(25, 182);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(259, 96);
            this.richTextBox2.TabIndex = 17;
            this.richTextBox2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.markBox);
            this.Controls.Add(this.dtPurshaseBox);
            this.Controls.Add(this.dtReleaseBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox dtReleaseBox;
        private System.Windows.Forms.TextBox dtPurshaseBox;
        private System.Windows.Forms.ComboBox markBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

