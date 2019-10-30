using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5_學習評量
{
    class Ex2
    {
        public static int GetMax(int x, int y)
        {
            int max;
            if (x > y)
            {
                return max = x;
            }
            else
            {
                return max = y;
            }


        }

        public static int GetMax(int x, int y, int z)
        {
            int max = z;
            if (x > z)
            {
                return max = x;
            }
            else if (y > z)
            {
                return max = y;
            }
            else
            {
                return z;
            }

        }


        public static int GetMax(params int[] big)
        {
            int max = big[0];
            for (int i = 0; i < big.Length; i++)
            {
                if (max < big[i])
                {
                    max = big[i];
                }
            }
            return max;
        }



        public static  void ex2()
        {
            Console.WriteLine("5和6之最大數為" + GetMax(5, 6));
            Console.WriteLine("58,9,6的最大數為" + GetMax(58, 9, 6));
            Console.WriteLine("n陣列(45,5,866,99,56)中最大數為" + GetMax(45, 5, 866, 99));

            Console.ReadLine();
        }

    }
}
