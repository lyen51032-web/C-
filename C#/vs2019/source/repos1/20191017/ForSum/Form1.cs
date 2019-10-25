using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForSum
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

        private void button1_Click(object sender, EventArgs e)
        {
            int Total = 0;
            for (int i = System.Convert.ToInt16(textBox1.Text);
                i <= System.Convert.ToInt16(textBox2.Text); i++) {
                //測試Break
                //if (i % 2 == 0) break;
                Total = Total + i;


            }
            MessageBox.Show(textBox1.Text+"累加到"+textBox2.Text+"總合為"+Total.ToString());

        }
    }
}
