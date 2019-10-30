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
            Console.Write("計算 n!, 請輸入 n = ");
            n=int.Parse(Console.ReadLine());
            Console.WriteLine("n! = " + F(n));
            Console.Read();
        }

        static int F(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else if (n > 0)
                return n * F(n - 1);
            else
                return -1;
        }
    }
}
