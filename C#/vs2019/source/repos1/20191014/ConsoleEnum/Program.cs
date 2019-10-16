using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEnum
{

    class Program
    {
        enum WeekDays : int
        {
            Monday = 1,
            Tuesday = 2, 
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }


        static void Main(string[] args)
        {
            WeekDays day;
            Console.WriteLine("星期三的列舉常數值:{0}",(int) WeekDays.Wednesday);
            Console.WriteLine("星期五的列舉常數值:{0}", (int)WeekDays.Friday);
            Console.Read();
        }
    }
}
