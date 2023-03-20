
using System.Runtime.CompilerServices;

namespace calcilator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bPow = new calcilator.RoundedButton();
            this.bSqrt = new calcilator.RoundedButton();
            this.button17 = new calcilator.RoundedButton();
            this.button16 = new calcilator.RoundedButton();
            this.button15 = new calcilator.RoundedButton();
            this.button14 = new calcilator.RoundedButton();
            this.button13 = new calcilator.RoundedButton();
            this.button12 = new calcilator.RoundedButton();
            this.button11 = new calcilator.RoundedButton();
            this.button10 = new calcilator.RoundedButton();
            this.button9 = new calcilator.RoundedButton();
            this.button8 = new calcilator.RoundedButton();
            this.button7 = new calcilator.RoundedButton();
            this.button6 = new calcilator.RoundedButton();
            this.button5 = new calcilator.RoundedButton();
            this.button4 = new calcilator.RoundedButton();
            this.button3 = new calcilator.RoundedButton();
            this.button2 = new calcilator.RoundedButton();
            this.button1 = new calcilator.RoundedButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(16, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(385, 114);
            this.textBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 18;
            // 
            // bPow
            // 
            this.bPow.BorderColor = System.Drawing.SystemColors.Control;
            this.bPow.BorderWidth = 6F;
            this.bPow.Font = new System.Drawing.Font("Lucida Console", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bPow.Location = new System.Drawing.Point(330, 284);
            this.bPow.Margin = new System.Windows.Forms.Padding(4);
            this.bPow.Name = "bPow";
            this.bPow.Size = new System.Drawing.Size(70, 66);
            this.bPow.TabIndex = 20;
            this.bPow.Text = "^2";
            this.bPow.UseVisualStyleBackColor = true;
            this.bPow.Click += new System.EventHandler(this.bPow_Click);
            // 
            // bSqrt
            // 
            this.bSqrt.BorderColor = System.Drawing.SystemColors.Control;
            this.bSqrt.BorderWidth = 6F;
            this.bSqrt.Font = new System.Drawing.Font("Lucida Console", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSqrt.Location = new System.Drawing.Point(331, 354);
            this.bSqrt.Margin = new System.Windows.Forms.Padding(4);
            this.bSqrt.Name = "bSqrt";
            this.bSqrt.Size = new System.Drawing.Size(70, 66);
            this.bSqrt.TabIndex = 19;
            this.bSqrt.Text = "√";
            this.bSqrt.UseVisualStyleBackColor = true;
            this.bSqrt.Click += new System.EventHandler(this.bSqrt_Click);
            // 
            // button17
            // 
            this.button17.BorderColor = System.Drawing.SystemColors.Control;
            this.button17.BorderWidth = 6F;
            this.button17.Font = new System.Drawing.Font("Lucida Console", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button17.Location = new System.Drawing.Point(173, 359);
            this.button17.Margin = new System.Windows.Forms.Padding(4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(71, 66);
            this.button17.TabIndex = 17;
            this.button17.Text = ",";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button16
            // 
            this.button16.BorderColor = System.Drawing.SystemColors.Control;
            this.button16.BorderWidth = 6F;
            this.button16.Font = new System.Drawing.Font("Lucida Console", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button16.Location = new System.Drawing.Point(330, 211);
            this.button16.Margin = new System.Windows.Forms.Padding(4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(71, 66);
            this.button16.TabIndex = 16;
            this.button16.Text = "С";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.BorderColor = System.Drawing.SystemColors.Control;
            this.button15.BorderWidth = 6F;
            this.button15.Font = new System.Drawing.Font("Lucida Console", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button15.Location = new System.Drawing.Point(93, 137);
            this.button15.Margin = new System.Windows.Forms.Padding(4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(72, 66);
            this.button15.TabIndex = 14;
            this.button15.Text = "8";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BorderColor = System.Drawing.SystemColors.Control;
            this.button14.BorderWidth = 6F;
            this.button14.Font = new System.Drawing.Font("Lucida Console", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.Location = new System.Drawing.Point(16, 210);
            this.button14.Margin = new System.Windows.Forms.Padding(4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(69, 66);
            this.button14.TabIndex = 13;
            this.button14.Text = "4";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button13_Click);
            // 
            // button13
            // 
            this.button13.BorderColor = System.Drawing.SystemColors.Control;
            this.button13.BorderWidth = 6F;
            this.button13.Font = new System.Drawing.Font("Lucida Console", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.Location = new System.Drawing.Point(16, 284);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(69, 66);
            this.button13.TabIndex = 12;
            this.button13.Text = "1";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.BorderColor = System.Drawing.SystemColors.Control;
            this.button12.BorderWidth = 6F;
            this.button12.Font = new System.Drawing.Font("Lucida Console", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(93, 285);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(72, 66);
            this.button12.TabIndex = 11;
            this.button12.Text = "2";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button13_Click);
            // 
            // button11
            // 
            this.button11.BorderColor = System.Drawing.SystemColors.Control;
            this.button11.BorderWidth = 6F;
            this.button11.Font = new System.Drawing.Font("Lucida Console", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.Location = new System.Drawing.Point(252, 137);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(70, 66);
            this.button11.TabIndex = 10;
            this.button11.Text = "/";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.BorderColor = System.Drawing.SystemColors.Control;
            this.button10.BorderWidth = 6F;
            this.button10.Font = new System.Drawing.Font("Lucida Console", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(330, 137);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(71, 66);
            this.button10.TabIndex = 9;
            this.button10.Text = "=";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BorderColor = System.Drawing.SystemColors.Control;
            this.button9.BorderWidth = 6F;
            this.button9.Font = new System.Drawing.Font("Lucida Console", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(252, 359);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 66);
            this.button9.TabIndex = 8;
            this.button9.Text = "+";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button11_Click);
            // 
            // button8
            // 
            this.button8.BorderColor = System.Drawing.SystemColors.Control;
            this.button8.BorderWidth = 6F;
            this.button8.Font = new System.Drawing.Font("Lucida Console", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(252, 285);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 66);
            this.button8.TabIndex = 7;
            this.button8.Text = "-";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button11_Click);
            // 
            // button7
            // 
            this.button7.BorderColor = System.Drawing.SystemColors.Control;
            this.button7.BorderWidth = 6F;
            this.button7.Font = new System.Drawing.Font("Lucida Console", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(252, 210);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 66);
            this.button7.TabIndex = 6;
            this.button7.Text = "*";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button11_Click);
            // 
            // button6
            // 
            this.button6.BorderColor = System.Drawing.SystemColors.Control;
            this.button6.BorderWidth = 6F;
            this.button6.Font = new System.Drawing.Font("Lucida Console", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(93, 359);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 66);
            this.button6.TabIndex = 5;
            this.button6.Text = "0";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button13_Click);
            // 
            // button5
            // 
            this.button5.BorderColor = System.Drawing.SystemColors.Control;
            this.button5.BorderWidth = 6F;
            this.button5.Font = new System.Drawing.Font("Lucida Console", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(173, 211);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 66);
            this.button5.TabIndex = 4;
            this.button5.Text = "6";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button13_Click);
            // 
            // button4
            // 
            this.button4.BorderColor = System.Drawing.SystemColors.Control;
            this.button4.BorderWidth = 6F;
            this.button4.Font = new System.Drawing.Font("Lucida Console", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(173, 285);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 66);
            this.button4.TabIndex = 3;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button13_Click);
            // 
            // button3
            // 
            this.button3.BorderColor = System.Drawing.SystemColors.Control;
            this.button3.BorderWidth = 6F;
            this.button3.Font = new System.Drawing.Font("Lucida Console", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(173, 137);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 66);
            this.button3.TabIndex = 2;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button13_Click);
            // 
            // button2
            // 
            this.button2.BorderColor = System.Drawing.SystemColors.Control;
            this.button2.BorderWidth = 6F;
            this.button2.Font = new System.Drawing.Font("Lucida Console", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(93, 211);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "5";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button13_Click);
            // 
            // button1
            // 
            this.button1.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.BorderWidth = 6F;
            this.button1.Font = new System.Drawing.Font("Lucida Console", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(16, 137);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button13_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(408, 433);
            this.Controls.Add(this.bPow);
            this.Controls.Add(this.bSqrt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private calcilator.RoundedButton button1;
        private calcilator.RoundedButton button2;
        private calcilator.RoundedButton button3;
        private calcilator.RoundedButton button4;
        private calcilator.RoundedButton button5;
        private calcilator.RoundedButton button6;
        private calcilator.RoundedButton button7;
        private calcilator.RoundedButton button8;
        private calcilator.RoundedButton button9;
        private calcilator.RoundedButton button10;
        private calcilator.RoundedButton button11;
        private calcilator.RoundedButton button12;
        private calcilator.RoundedButton button13;
        private calcilator.RoundedButton button14;
        private calcilator.RoundedButton button15;
        private System.Windows.Forms.TextBox textBox1;
        private calcilator.RoundedButton button16;
        private calcilator.RoundedButton button17;
        private System.Windows.Forms.Label label1;
        private RoundedButton bSqrt;
        private RoundedButton bPow;
    }
}

