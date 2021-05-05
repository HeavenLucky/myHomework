using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            if (comboBox1.Text == "+")
            {
                c = a + b;
                textBox3.Text = c.ToString();
            }
            else if (comboBox1.Text == "-")
            {
                c = a - b;
                textBox3.Text = c.ToString();
            }
            else if (comboBox1.Text == "*")
            {
                c = a * b;
                textBox3.Text = c.ToString();

            }
            else
            {  if (b == 0)
                    textBox3.Text = "被除数不能为零！";
                else
                {
                    c = a / b;
                    textBox3.Text = c.ToString();
                }
                    
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


        

       
    

