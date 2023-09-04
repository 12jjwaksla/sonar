using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();//首先将另一个窗口Form2实例化

            f2.Visible = false;//将当前窗口设置为不可视；如果不这样处理则系统报错。

            f2.ShowDialog();//打开窗口
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();//首先将另一个窗口Form2实例化

            f2.Visible = false;//将当前窗口设置为不可视；如果不这样处理则系统报错。

            f2.ShowDialog();//打开窗口

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f2 = new Form4();//首先将另一个窗口Form2实例化

            f2.Visible = false;//将当前窗口设置为不可视；如果不这样处理则系统报错。

            f2.ShowDialog();//打开窗口
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f2 = new Form5();//首先将另一个窗口Form2实例化

            f2.Visible = false;//将当前窗口设置为不可视；如果不这样处理则系统报错。

            f2.ShowDialog();//打开窗口
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 f2 = new Form6();//首先将另一个窗口Form2实例化

            f2.Visible = false;//将当前窗口设置为不可视；如果不这样处理则系统报错。

            f2.ShowDialog();//打开窗口
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 f2 = new Form7();//首先将另一个窗口Form2实例化

            f2.Visible = false;//将当前窗口设置为不可视；如果不这样处理则系统报错。

            f2.ShowDialog();//打开窗口
        }
    }
}
