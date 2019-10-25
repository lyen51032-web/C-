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

        private void button1_Click(object sender, EventArgs e)
        {
            if (System.Convert.ToInt16(textBox1.Text) >= 60)
                MessageBox.Show("及格！");
            else
                MessageBox.Show("不及格！");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (System.Convert.ToInt16(textBox1.Text) >= 90)
                MessageBox.Show("優等！"); 
            else if (System.Convert.ToInt16(textBox1.Text) < 90 && System.Convert.ToInt16(textBox1.Text) >= 80) 
                MessageBox.Show("甲等！");
            else if (System.Convert.ToInt16(textBox1.Text) < 80 && System.Convert.ToInt16(textBox1.Text) >= 70) 
                MessageBox.Show("乙等！"); 
            else if (System.Convert.ToInt16(textBox1.Text) < 70 && System.Convert.ToInt16(textBox1.Text) >= 60) 
                MessageBox.Show("丙等！"); 
            else 
                MessageBox.Show("不及格！");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
