
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.Label_SecondForm_AA = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Form2_Button_Ok = new System.Windows.Forms.Button();
            this.Form2_Button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_SecondForm_AA
            // 
            this.Label_SecondForm_AA.AutoSize = true;
            this.Label_SecondForm_AA.Location = new System.Drawing.Point(87, 65);
            this.Label_SecondForm_AA.Name = "Label_SecondForm_AA";
            this.Label_SecondForm_AA.Size = new System.Drawing.Size(192, 13);
            this.Label_SecondForm_AA.TabIndex = 0;
            this.Label_SecondForm_AA.Text = "Enter an int (row height/column weight)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Form2_Button_Ok
            // 
            this.Form2_Button_Ok.Location = new System.Drawing.Point(45, 176);
            this.Form2_Button_Ok.Name = "Form2_Button_Ok";
            this.Form2_Button_Ok.Size = new System.Drawing.Size(75, 23);
            this.Form2_Button_Ok.TabIndex = 2;
            this.Form2_Button_Ok.Text = "Ok";
            this.Form2_Button_Ok.UseVisualStyleBackColor = true;
            this.Form2_Button_Ok.Click += new System.EventHandler(this.Form2_Button_Ok_Click);
            // 
            // Form2_Button_Cancel
            // 
            this.Form2_Button_Cancel.Location = new System.Drawing.Point(232, 176);
            this.Form2_Button_Cancel.Name = "Form2_Button_Cancel";
            this.Form2_Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Form2_Button_Cancel.TabIndex = 3;
            this.Form2_Button_Cancel.Text = "Cancel";
            this.Form2_Button_Cancel.UseVisualStyleBackColor = true;
            this.Form2_Button_Cancel.Click += new System.EventHandler(this.Form2_Button_Cancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 236);
            this.ControlBox = false;
            this.Controls.Add(this.Form2_Button_Cancel);
            this.Controls.Add(this.Form2_Button_Ok);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Label_SecondForm_AA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Height table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_SecondForm_AA;
        private System.Windows.Forms.Button Form2_Button_Ok;
        private System.Windows.Forms.Button Form2_Button_Cancel;
        public System.Windows.Forms.TextBox textBox1;
    }
}