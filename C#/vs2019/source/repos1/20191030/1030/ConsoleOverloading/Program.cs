using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(10));
            Console.WriteLine(Add(10, 5));
            Console.Read();

        }

        private static int Add(int X)
    {
      return ++X;
    }

    private static int Add(int X, int Y)
    {
      return X + Y;
    }


    }
}
