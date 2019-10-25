using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string Answer;
            do {
                Console.WriteLine("請輸入快樂的英文");
                Answer = Console.ReadLine();
            }
            while (Answer!="happy");
            Console.WriteLine("答對了");
            Console.ReadLine();
        }
    }
}
