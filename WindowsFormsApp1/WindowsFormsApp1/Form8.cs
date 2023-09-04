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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            if(serialPort1.IsOpen)
            {
              if(comboBox1.Text=="左后主推"&&comboBox2.Text=="高速")
                {
                    serialPort1.Write("MT1H");
                }
               else  if (comboBox1.Text == "右后主推" && comboBox2.Text == "高速")
                {
                    serialPort1.Write("MT2H");
                }
               else  if (comboBox1.Text == "左前垂推" && comboBox2.Text == "高速")
                {
                    serialPort1.Write("MT3H");
                }
                else if (comboBox1.Text == "右前垂推" && comboBox2.Text == "高速")
                {
                    serialPort1.Write("MT4H");
                }
               else  if (comboBox1.Text == "后垂推" && comboBox2.Text == "高速")
                {
                    serialPort1.Write("MT4H");
                }
                else if (comboBox1.Text == "左后主推" && comboBox2.Text == "中速")
                {
                    serialPort1.Write("MT1M");
                    
                }
                else if (comboBox1.Text == "右后主推" && comboBox2.Text == "中速")
                {
                    serialPort1.Write("MT2M");
                }
                else if (comboBox1.Text == "左前垂推" && comboBox2.Text == "中速")
                {
                    serialPort1.Write("MT3M");
                }
                else if (comboBox1.Text == "右前垂推" && comboBox2.Text == "中速")
                {
                    serialPort1.Write("MT4M");
                }
                else if (comboBox1.Text == "后垂推" && comboBox2.Text == "中速")
                {
                    serialPort1.Write("MT5H");
                }
                else if (comboBox1.Text == "左后主推" && comboBox2.Text == "低速")
                {
                    serialPort1.Write("MT1L");
                }
                else if (comboBox1.Text == "右后垂推" && comboBox2.Text == "低速")
                {
                    serialPort1.Write("MT2L");
                }
                else if (comboBox1.Text == "左前垂推" && comboBox2.Text == "低速")
                {
                    serialPort1.Write("MT3L");
                }
                else if (comboBox1.Text == "右前垂推" && comboBox2.Text == "低速")
                {
                    serialPort1.Write("MT4L");
                }
                else if (comboBox1.Text == "后垂推" && comboBox2.Text == "低速")
                {
                    serialPort1.Write("MT5L");
                }
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }

        private void serialPort1_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                
                serialPort1.Open();
                MessageBox.Show("打开成功", "成功");

            }
            catch
            {
                MessageBox.Show("端口错误，请检查串口", "错误");
            }
        }
    }
}

