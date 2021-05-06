using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//（1）只爬取某个指定网站上的网页 
// （2）只有当爬取的是html / html / aspx / jsp等网页时，才解析并爬取下一级URL。
// （3）相对地址(test / page.html, ./ test / page.html, .. / test2 / page2.html, / test3 / page.html)转成完整地址进行爬取。
// （4） 尝试使用Winform来配置初始URL，启动爬虫，显示已经爬取的URL和错误的URL信息。

namespace Homework9
{
    public partial class Form1 : Form
    {
       
        private SimpleCrawler crawler = new SimpleCrawler();

        public static   List<ClassUrl> listtrue = new List<ClassUrl>();
      public static  List<ClassUrl> listfalse = new List<ClassUrl>();
        public Form1()
        {
            InitializeComponent();
        }

      
  


   
    private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string startUrl = textBox1.Text.ToString();
            //arg？？？
          
            crawler.Enter(startUrl);

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
           
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            bindingSourcetrue.DataSource = listtrue;
         
            bindingSourcefalse.DataSource = listfalse;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingSourcetrue.ResetBindings(false);
            bindingSourcefalse.ResetBindings(false);

        }
    }
}
