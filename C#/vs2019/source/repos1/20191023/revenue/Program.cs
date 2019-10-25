using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revenue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] amt = new int[3][];

            amt[0] = new int[] { 1100, 2200, 3300 };
            amt[1] = new int[] { 1500,2500  };
            amt[2] = new int[] { 1000,2000,3000,4000 };
            /*double tc_total = new double();
            double cc_total = new double();
            double kc_total = new double();*/
            double[] sum = new double[] { 0.0, 0.0, 0.0 };
            string[] company = new string[] { "台北", "台中", "高雄" };
            double total = 0;
            Console.WriteLine("\t第一處\t第二處\t第三處\t第四處 (單位:千元)");
            Console.Write("     ");
            for (int i = 0; i < amt.Length; i++)
            {
                for (int j = 0; j < amt[i].Length; j++)
                {
                    Console.Write("\t{0}", amt[i][j]);	// 顯示各處的金額
                    sum[i] += amt[i][j];       		// 計算各公司的營業額
                }
                total += sum[i] * 1000;  		// 計算總營業額
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            for (int n = 0; n < 3; n++)
            {
                sum[n] *= 1000;
                Console.WriteLine("{0}分公司營業額：{1}元\t營業率：{2:p}",
                                    company[n], sum[n].ToString("c"), sum[n] / total);
            }
            Console.WriteLine("\n總營業額：{0}元", total.ToString("c"));
            Console.ReadLine();
            /*
            for (int i = 0; i <= amt.GetUpperBound(0); i++)
            {
                    Console.Write(amt[0][i]+"    ");
                tc_total += (amt[0][i])*1000;

            }
            Console.WriteLine("");
            Console.Write("     ");
            for (int i = 0; i < amt.GetUpperBound(0); i++)
            {
                Console.Write(amt[1][i] + "    ");
                cc_total += amt[1][i] * 1000;
            }

            Console.WriteLine("");
            Console.Write("     ");
            for (int i = 0; i < amt.GetUpperBound(0)+2; i++)
            {
                Console.Write(amt[2][i] + "    ");
                kc_total += amt[2][i] * 1000;
            }
            total = tc_total + cc_total + kc_total;
            Console.WriteLine("");
            




            Console.WriteLine("台北分公司營業額：NT$"+tc_total.ToString("c")+"元  營業率："+ (tc_total / total).ToString("P"));
            Console.WriteLine("台中分公司營業額：NT$" + cc_total.ToString("c")+"元  營業率：" + (cc_total / total).ToString("P"));
            Console.WriteLine("高雄分公司營業額：NT$" + kc_total.ToString("c")+"元  營業率：" + (kc_total / total).ToString("P"));
            Console.WriteLine("總營業額：NT$" + total.ToString("c"));
            */



        }
}
}
