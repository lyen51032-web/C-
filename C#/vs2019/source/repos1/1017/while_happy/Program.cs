using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_happy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入「快樂」的英文"); 
            string Answer = Console.ReadLine(); 
            while (Answer.ToUpper() != "HAPPY") {
                Console.WriteLine("請輸入「快樂」的英文"); 
                //停住看打了什麼
                Answer = Console.ReadLine(); 
            }
            Console.WriteLine("答對了！");
            Console.ReadLine();

        }
    }
}
