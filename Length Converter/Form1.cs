using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Length_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Double Measure,outcome;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            errLabel.Text = "";
            measurement.Text = "";

            //Check if input is empty or invalid
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errLabel.Text = "Enter a size to convert!.";
                return;
            }
            else {
                Measure = Convert.ToDouble(textBox1.Text);

                if (cB1.Checked)
                {
                    if (rB4.Checked)
                    {
                        outcome = Measure;
                    }

                    else if (rB5.Checked)
                    {
                        outcome = Measure / 100;
                    }
                    else if (rB6.Checked)
                    {
                        outcome = Measure / 100000;
                        outcome = Math.Round(outcome, 2);
                    }

                    else
                    {
                        errLabel.Text = "Select the Unit that you wanted to convert!.";
                        return;
                    }
                }

                else if (cB2.Checked)
                {

                    if (rB4.Checked)
                    {
                        outcome = Measure * 100;
                    }

                    else if (rB5.Checked)
                    {
                        outcome = Measure;
                    }
                    else if (rB6.Checked)
                    {
                        outcome = Measure / 1000;
                        outcome = Math.Round(outcome, 2);
                    }

                    else
                    {
                        errLabel.Text = "Select the Unit that you wanted to convert.!";
                        return;
                    }

                }

                else if (cB3.Checked)
                {
                    if (rB4.Checked)
                    {
                        outcome = Measure * 100000;
                    }

                    else if (rB5.Checked)
                    {
                        outcome = Measure * 100;
                    }
                    else if (rB6.Checked)
                    {
                        outcome = Measure;

                    }

                    else
                    {
                        errLabel.Text = "Select the Unit that you wanted to convert!.";
                        return;
                    }

                }
                else
                {
                    errLabel.Text = "Select the unit of your measurement";
                    return;
                }
            }
            measurement.Text = outcome.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cB1_CheckedChanged(object sender, EventArgs e)
        {
            if (cB1.Checked)
            {
                cB2.Checked = false;
                cB3.Checked = false;
            }
        }

        private void cB2_CheckedChanged(object sender, EventArgs e)
        {
            if (cB2.Checked)
            {
                cB1.Checked = false;
                cB3.Checked = false;
            }
        }

        private void cB3_CheckedChanged(object sender, EventArgs e)
        {
            if (cB3.Checked)
            {
                cB1.Checked = false;
                cB2.Checked = false;
            }

        }

        private void measurement_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
