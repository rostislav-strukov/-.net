using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChooseOperation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //textBox3.Text = Convert.ToString(Reminder(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private static double Reminder(double devidend, double devisor)
        {
            return devidend % devisor;
        }

        private static double Pow(double value, double power)
        {
            return Math.Pow(value, power);
        }

        private static string Concatenation(string line1, string line2)
        {
            return line1 + line2;
        }

        private static double Division(double devidend, double devisor)
        {
            return devidend / devisor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox3.Text = Convert.ToString(Reminder(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
            }
        }
    }
}
