using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callbyout
{
    class Program
    {
        static void Main(string[] args)
        {
            //int Num = 1;
            count(out int Num);
            Console.WriteLine("原參數執行完成" + Num);
            Console.Read();
        }
        private static void count(out int result)
        {

            result = 1;
            Console.WriteLine("原參數呼叫時" + result);
            result += 1;
            Console.WriteLine("原參數呼叫後" + result);

        }
    }
}

