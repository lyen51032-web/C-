using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            string[] Names = new string[] { "張大名","孫小美","小丸子"};
            foreach (string Str in Names) {
                s += Str;
                s += "\n";


            }
            MessageBox.Show(s);
            namelb1.Text = Names[0];
            namelb2.Text = Names[1];
            namelb3.Text = Names[2];
        }
    }
}
