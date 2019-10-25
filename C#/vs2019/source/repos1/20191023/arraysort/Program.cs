using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 80, 90, 40, 70, 50, 60 };
            //bubble
            //public static void Sort();
            Array.Sort(arr);
            foreach (int temp in arr) {
                Console.Write(temp + "  ");
            }
            Console.WriteLine("");



            //search
            Console.WriteLine("輸入搜尋值");
            int d =int.Parse(Console.ReadLine());
            Console.WriteLine("資料在索引:{0}", Array.BinarySearch(arr, d));

            //reverse
            Array.Reverse(arr);
            foreach (int temp in arr)
            {
                Console.Write(temp + "  ");
            }
            Console.WriteLine("");

            //copy
            int[] a = new int[4] { 1, 2, 3, 4, };
            int[] b = new int[6];
            Array.Copy(a, b, 3);
            foreach (int temp in b) {
                Console.Write(temp + " ");
            }
            Console.WriteLine("");

            //clear
            int[] a1 = new int[4] { 1, 2, 3, 4, };
   
            Array.Clear(a1,1,2);
            foreach (int temp in a1)
            {
                Console.Write(temp + " ");
            }
            Console.WriteLine("");


            Console.Read();
        }
        
    }
}
