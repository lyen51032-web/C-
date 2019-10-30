using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 費氏遞迴
{
    class Program

    {

        static int n;
        static void Main(string[] args)
        {
            Console.WriteLine("請輸出費氏數列n=");
            n = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= n; i++) {
                Console.Write("fib({0})+", i);
            }
            Console.WriteLine("="+Fib(n));

            Console.ReadLine();
        }

        static int Fib(int n) {
            if (n <= 2)
            {
                return 1;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }
        

    }
}
