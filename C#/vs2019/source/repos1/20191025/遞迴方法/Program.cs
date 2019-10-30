using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 遞迴方法
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int result = 1;
             int r = Convert.ToInt32(Console.ReadLine());
             result = r;
             Console.WriteLine(result + "! =" + result);
             for (int i = 1; i <= result; i++)
             {
                 result *= i;

             }

             Console.WriteLine(r+"! =" + result);*/

            int Result = 1;
            for (
            int i = 1; i <= 5; i++) { Result *= i; }
            
            Console.WriteLine("5! =" + Result); 

                                     Console.Read();
        }
    }
}
