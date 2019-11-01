using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _108b期_Csharp_期末考試
{
    class FinalTest_Ex2
    {


        static void Triangle(char cx)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 2 * 10; j++)
                {
                    if (j >= (10 - i) && j <= (10 + i))
                    {
                        Console.Write(cx);
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public static void Ex2()
        {
            Console.WriteLine("請輸入要產生聖誕樹的字元符號：");
           
            char C = System.Convert.ToChar( Console.ReadLine());
            Triangle(C);

            Console.ReadLine();
        }
    }
}

