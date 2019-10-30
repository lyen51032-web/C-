using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace round_area
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
            double R = System.Convert.ToDouble(textBox1.Text);
            MessageBox.Show("圓面積為" + Round_Area(R).ToString());
        }
        private double Round_Area(double r)
        {


            double PI = 3.1415926;//聲明雙精度常量π
            return r * r * PI;
        }







        /*


        double r, area, circle;//聲明雙精度變數r\area\circle

        r = System.Convert.ToInt32(textBox1.Text);
        area = r * r * PI; //計算圓的面積

        MessageBox.Show(area.ToString());
        */

    }
}

