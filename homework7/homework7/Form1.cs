using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
      

        private Graphics graphics;

        double th1;
        double th2;
        double per1;
        double per2;
        double leng;
        int n;
        Color color;
        private Pen pen;
        private   double x0 = 1;

        private  double y0 = 1;

        private double th = 0.6;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = panel3.CreateGraphics();
          
            DrawCayleyTree(n, x0, y0, leng, th);
        }
        public void DrawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            DrawLine(x0, y0, x1, y1);
            DrawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            DrawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        public void DrawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
      

        private void button2_Click(object sender, EventArgs e)
        {

            colorDialog1.ShowDialog();
         
                Color color = colorDialog1.Color;
                pen = new Pen(color);

            


        }
        

    

    private void textBox1_TextChanged(object sender, EventArgs e)
        {
            n = Convert.ToInt32(textBox1.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            leng = Convert.ToDouble(textBox3.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            per1 = Convert.ToDouble(textBox2.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            per2 = Convert.ToDouble(textBox6.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            th1 = Convert.ToDouble(textBox4.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            th2 = Convert.ToDouble(textBox5.Text);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
