using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
          





            int[] arr = new int[] { 80, 90, 40, 70, 50, 60 };
            int n = arr.Length;
            int i, j, t;
            for (i = 0; i < n - 1; i++)
            {
                for (j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }
                    for (int k = 0; k < arr.Length; k++)
                    {
                        Console.Write(i + ":" + arr[k] + "  ");
                    }
                    Console.WriteLine("");
                }

            }

            Console.WriteLine("---結果---");
            for (int k = 0; k < arr.Length; k++)
            {
                Console.Write(arr[k] + "  ");
            }

            Console.Read();
        }
    }
}
