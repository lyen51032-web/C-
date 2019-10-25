using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //bubble sort
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
                }
                /*onsole.WriteLine("---結果---");
                for (int k = 0; k < arr.Length; k++)
                {
                    Console.Write(arr[k] + "  ");
                }

                Console.Read();*/

                
            }
            for (int k = 0; k < arr.Length; k++)
            {
                Console.Write(arr[k] + "  ");
            }
            Console.WriteLine("");

            //binary search
            int left, right, mid = 0, input_num, bingo;

            Console.WriteLine("請輸入欲搜尋數字");
            input_num = int.Parse(Console.ReadLine());
            left = 0;
            right = n - 1;
            bingo = 0;



            while (left <= right)
            {
                mid = (left + right) / 2;
                if (input_num == arr[mid])
                {
                    bingo = 1;
                    break;
                }
                if (input_num < arr[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            if (bingo == 1)
            {
                Console.WriteLine("在arr[{0}]找到{1} \n", mid, input_num);
            }
            else
            {
                Console.WriteLine("查無此搜尋資料");
            }

            Console.Read();

        }
    }
    }

