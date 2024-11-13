namespace Length_Converter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rB4 = new System.Windows.Forms.RadioButton();
            this.rB5 = new System.Windows.Forms.RadioButton();
            this.rB6 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.measurement = new System.Windows.Forms.TextBox();
            this.errLabel = new System.Windows.Forms.Label();
            this.cB1 = new System.Windows.Forms.CheckBox();
            this.cB2 = new System.Windows.Forms.CheckBox();
            this.cB3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(43, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "LENGTH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(31, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 69);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONVERTER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter the Length: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 279);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(44, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(494, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Convert to :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rB4
            // 
            this.rB4.AutoSize = true;
            this.rB4.Location = new System.Drawing.Point(557, 106);
            this.rB4.Name = "rB4";
            this.rB4.Size = new System.Drawing.Size(46, 20);
            this.rB4.TabIndex = 8;
            this.rB4.TabStop = true;
            this.rB4.Text = "cm";
            this.rB4.UseVisualStyleBackColor = true;
            this.rB4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rB5
            // 
            this.rB5.AutoSize = true;
            this.rB5.Location = new System.Drawing.Point(559, 151);
            this.rB5.Name = "rB5";
            this.rB5.Size = new System.Drawing.Size(39, 20);
            this.rB5.TabIndex = 9;
            this.rB5.TabStop = true;
            this.rB5.Text = "m";
            this.rB5.UseVisualStyleBackColor = true;
            // 
            // rB6
            // 
            this.rB6.AutoSize = true;
            this.rB6.Location = new System.Drawing.Point(559, 196);
            this.rB6.Name = "rB6";
            this.rB6.Size = new System.Drawing.Size(50, 20);
            this.rB6.TabIndex = 10;
            this.rB6.TabStop = true;
            this.rB6.Text = " Km";
            this.rB6.UseVisualStyleBackColor = true;
            this.rB6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Chocolate;
            this.button1.Location = new System.Drawing.Point(523, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = " CONVERTR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "m";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(504, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Messurement : ";
            // 
            // measurement
            // 
            this.measurement.Location = new System.Drawing.Point(658, 370);
            this.measurement.Name = "measurement";
            this.measurement.Size = new System.Drawing.Size(43, 22);
            this.measurement.TabIndex = 14;
            this.measurement.TextChanged += new System.EventHandler(this.measurement_TextChanged);
            // 
            // errLabel
            // 
            this.errLabel.AutoSize = true;
            this.errLabel.ForeColor = System.Drawing.Color.Red;
            this.errLabel.Location = new System.Drawing.Point(59, 225);
            this.errLabel.Name = "errLabel";
            this.errLabel.Size = new System.Drawing.Size(0, 16);
            this.errLabel.TabIndex = 15;
            // 
            // cB1
            // 
            this.cB1.AutoSize = true;
            this.cB1.Location = new System.Drawing.Point(207, 332);
            this.cB1.Name = "cB1";
            this.cB1.Size = new System.Drawing.Size(47, 20);
            this.cB1.TabIndex = 16;
            this.cB1.Text = "cm";
            this.cB1.UseVisualStyleBackColor = true;
            this.cB1.CheckedChanged += new System.EventHandler(this.cB1_CheckedChanged);
            // 
            // cB2
            // 
            this.cB2.AutoSize = true;
            this.cB2.Location = new System.Drawing.Point(207, 377);
            this.cB2.Name = "cB2";
            this.cB2.Size = new System.Drawing.Size(40, 20);
            this.cB2.TabIndex = 17;
            this.cB2.Text = "m";
            this.cB2.UseVisualStyleBackColor = true;
            this.cB2.CheckedChanged += new System.EventHandler(this.cB2_CheckedChanged);
            // 
            // cB3
            // 
            this.cB3.AutoSize = true;
            this.cB3.Location = new System.Drawing.Point(207, 418);
            this.cB3.Name = "cB3";
            this.cB3.Size = new System.Drawing.Size(48, 20);
            this.cB3.TabIndex = 18;
            this.cB3.Text = "Km";
            this.cB3.UseVisualStyleBackColor = true;
            this.cB3.CheckedChanged += new System.EventHandler(this.cB3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cB3);
            this.Controls.Add(this.cB2);
            this.Controls.Add(this.cB1);
            this.Controls.Add(this.errLabel);
            this.Controls.Add(this.measurement);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rB6);
            this.Controls.Add(this.rB5);
            this.Controls.Add(this.rB4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rB4;
        private System.Windows.Forms.RadioButton rB5;
        private System.Windows.Forms.RadioButton rB6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox measurement;
        private System.Windows.Forms.Label errLabel;
        private System.Windows.Forms.CheckBox cB1;
        private System.Windows.Forms.CheckBox cB2;
        private System.Windows.Forms.CheckBox cB3;
    }
}

