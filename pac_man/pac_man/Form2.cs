using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pac_man
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 a=new Form1();
            if (textBox1.Text == "請輸入玩家名稱" || textBox1.Text == "")
            {
                MessageBox.Show("請輸入玩家名稱");
            }
            else
            {
                a.Text = textBox1.Text;
                a.Show();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form4 c = new Form4();
            c.Show();
        }

    }
}