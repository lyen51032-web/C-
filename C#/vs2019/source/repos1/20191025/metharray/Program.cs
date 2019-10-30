using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metharray
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int[] RetuernArray;
            RetuernArray = ExpValue(10);
            foreach (int Item in RetuernArray) {
                Console.WriteLine(Item);
            }
            Console.Read();

        }

        private static int[] ExpValue(int A) {
            int[] X = new int[3];
            X[0] = A;
            X[1] = A*A;
            X[2] = A * A *A;
            return X;
        }
    }
}
