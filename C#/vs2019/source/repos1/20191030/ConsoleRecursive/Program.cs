using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRecursive
{
    class Program
    {
        static int n;
        static void Main(string[] args)
        {
            Console.WriteLine("計算n!，請輸入n=");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("n!=" + F(n));
            Console.ReadLine();
        }


        static int F(int n) {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else if (n > 0)
            {
                return n * F(n - 1);
            }
            else { return -1; }
        }
    }
}
