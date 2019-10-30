using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 遮蔽效應範例
{
    class Program
    {

        static int i = 1;
        static void Main(string[] args)
        {
            int i = 100;
            Console.WriteLine(i);
            Console.Read();
        }
    }
}
