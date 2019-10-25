using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace switchcase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            int row = System.Convert.ToInt32(rowtext.Text);
            int column = System.Convert.ToInt32(columntext.Text);
            string result = "";
            //MessageBox.Show(row.ToString());
            //多到少
            for (int i = 0; i <column; i++) {
                
                for (int j=row; j > i; j--) {
                    resulttest.Text += "*";
                }
                resulttest.Text += "\n";

            }
            /*
            //少到多
            for (int i = column; i > 0; i--)
            {

                for (int j = row; j > i; j--)
                {
                    result += "*";
                }
                result+= "\n";

            }
            MessageBox.Show(result);
            */


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
