using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c = System.Convert.ToInt32(textBox1.Text);
            MessageBox.Show("攝氏"+textBox1.Text+"度可以轉換成華氏"+temp(c)+"度");
            label2.Text = "攝氏" + textBox1.Text + "度可以轉換成華氏" + temp(c).ToString()+"度";
        }

        private double temp(double C) {
            double F;
            return F = C * 9 / 5 + 32;
        }
    }
}
