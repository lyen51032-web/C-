using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFibo
{
    class Program
    {
        static int n;
        static void Main(string[] args)
        {
            Console.Write("計算 fibo(n), 請輸入 n = ");
            n = int.Parse(Console.ReadLine());

            for (int i =1; i <= n; i++)
            {
                Console.WriteLine("fibo({0}) = " + Fibo(i), i);
            }                                  
            Console.Read();
        }

        static int Fibo(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            else
                return Fibo(n - 1) + Fibo(n-2);
        }
    }
}
