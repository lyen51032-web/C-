using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _108b期_Csharp_期末考試
{
    class FinalTest_Ex4
    {

        public static void Ex4()
        {
            int total = 0;
            int[,,] num =new int[4,2,3]
            { 
                { { 1, 2 ,3}, { 4, 5,6 } },
                { { 7, 8 ,9}, { 10, 11,12 } },
                { { 13, 14 ,15}, { 16, 17,18 } },
                { { 19, 20 ,21}, { 22, 23,24 } },

            };

            for (int i = 1; i <= num.Length; i++)
            {
                total += i;

            }


        

            Console.WriteLine("sum=" + total);
            Console.Read();
        }
    }
}
