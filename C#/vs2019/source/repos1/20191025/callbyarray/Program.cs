using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callbyarray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] score = new string[] { "90", "80", "缺席", "70" };
            studentscore("人", score);
            Console.Read();
        }

        static void studentscore(string Name, params string[] Score)
        {
            Console.WriteLine(Name + "的分數如下:");
            for (int i = 0; i <= Score.GetUpperBound(0); i++) {
                Console.WriteLine(Score[i]);
            }
        }
        
    }
}
