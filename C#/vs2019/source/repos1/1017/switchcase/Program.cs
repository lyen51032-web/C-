using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入成績");
            int num = System.Convert.ToInt32
                (Console.ReadLine());

            int level = num / 10;
            switch (level){
                case 10:
                case 9:
                    Console.WriteLine("優等");
                    break;
                case 8:
                    Console.WriteLine("甲等");
                    break;
                case 7:
                    Console.WriteLine("乙等");
                    break;
                case 6:
                    Console.WriteLine("丙等");
                    break;
            }
            Console.ReadLine();  
        }
    }
}
