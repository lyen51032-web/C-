using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _108b期_Csharp_期末考試
{
    class FinalTest_Ex3
    {
        public static void Ex3()
        {

            int[,] A = new int[2, 9] { { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, { 1, 2, 3, 4, 5, 6, 7, 8, 9 } };   //2=0~1(乘數跟被乘數)  9(0~9參數 )

            for (int i = 0; i <= 8; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    Console.Write(A[0, i] + "*" + A[1, j] + "=" + A[0, i] * A[1, j] + '\t');
                }

                Console.WriteLine();    //等同Console.Write('\n');


            }



            Console.ReadLine();
        }
    }
}
