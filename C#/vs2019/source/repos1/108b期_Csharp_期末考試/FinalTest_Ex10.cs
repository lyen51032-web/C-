using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _108b期_Csharp_期末考試
{

    class FinalTest_Ex10
    {
        public static int Max(int[] array)
          {

             int value = 0;
             bool hasValue = false;
             foreach (int x in array)
             {
                 if (hasValue)
                {
                     if (x > value)
                         value = x;
                }
                 else
                 {
                     value = x;
                     hasValue = true;
                 }
             }
             if (hasValue) return value;
             throw new Exception("沒找到");
         }





        public static void Ex10()
        {

            int[] array = new int[] { 12, 15, 38, 21, 25 };


            Console.WriteLine("==陣列元素如下==");
            Console.WriteLine("12\t15\t38\t21\t25");
            Console.WriteLine("陣列最大值:"+ array.Max());
            Console.Read();
        }
    }
}
