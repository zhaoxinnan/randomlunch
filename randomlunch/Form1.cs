using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace randomlunch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        System.Collections.ArrayList arr = new System.Collections.ArrayList();
        //        arr.Add("a");
        //arr.Add("b");
        object[] obj;
        private void button1_Click(object sender, EventArgs e)
        {
            Random ro = new Random();
            int iResult = ro.Next(0, obj.Length);
            string msg = obj[iResult].ToString();
            MessageBox.Show(msg, "提示");
            //switch(iResult)
            //{
            //    case 1:
            //        MessageBox.Show("西部马华", "提示");
            //}
            //if(iResult==1)
            //{
            //    MessageBox.Show("西部马华", "提示");
            //}
            //else if (iResult == 2)
            //{
            //    MessageBox.Show("巫山烤鱼", "提示");
            //}
            //else if (iResult == 3)
            //{
            //    MessageBox.Show("三秦", "提示");
            //}
            //else if (iResult == 4)
            //{
            //    MessageBox.Show("八方", "提示");
            //}
            //else if (iResult == 5)
            //{
            //    MessageBox.Show("金香", "提示");
            //}
            //else if (iResult == 6)
            //{
            //    MessageBox.Show("大盘鸡", "提示");
            //}
            //else if (iResult == 7)
            //{
            //    MessageBox.Show("庆丰", "提示");
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string txt1 = textBox1.Text;
            arr.Add(txt1);
            obj=arr.ToArray();
            string a="";
            for(int i = 0; i < obj.Length; i++)
            {
                if (i != 0)
                {
                a += "，";
                }
                a += obj[i];
            }
            label1.Text = a;
        }
    }
}
