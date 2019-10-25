using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproj4_1
{
    class Program
    {
        private static void ShowArray(int a1) {
            Console.WriteLine(a1);
        }
        static void Main(string[] args)
        {
            int[] Score = new int[] { 90, 86, 99, 54 };
            foreach (int temp in Score) {
                Console.WriteLine(temp);
            }
            

            Console.WriteLine("----------------");

            for (int i = 0; i < Score.Length; i++) {
                Console.WriteLine("{0}{1}",Score[i],Score[2]);
            }

            Console.WriteLine("----------------");
            Console.WriteLine("{0}", Score.GetUpperBound(0));
            for(int i=0; i<=Score.GetUpperBound(0);i++)
             {
                Console.WriteLine("{0}",Score[i]);
            }
            Console.WriteLine("----------------");

            //委派
            Action<int> myAction = new Action<int>(ShowArray);
            Array.ForEach(Score, myAction);

            Console.WriteLine("///////////////////二維陣列///////////////////");
            int[,] score = new int[4, 5];
            score[0,0] =0 ; score[0,1] = 1; score[0,2] =2 ; score[0,3] = 2; score[0,4] =4 ;
            score[1,0] =5 ; score[1,1] = 6; score[1,2] = 7; score[1,3] = 7; score[1,4] = 9;
            score[2,0] =10 ; score[2,1] = 11; score[2,2] =12 ; score[2,3] =12 ; score[2,4] = 14;
            score[3,0] =15 ; score[3,1] = 16; score[3,2] = 17; score[3,3] = 17; score[3,4] = 19;
            Console.WriteLine("透過forEach拜訪");
                 foreach (int temp in score)
            {
                Console.WriteLine(temp);
            }
            Console.WriteLine("----------------");
            Console.WriteLine(score.GetUpperBound(1));
            for (int i = 0; i <= score.GetUpperBound(0); i++)
            {
                for(int j=0; j<= score.GetUpperBound(1);j++)
                Console.WriteLine("score["+i+"]["+j+"]="+score[i,j]);
            }
            Console.WriteLine("///////////////////不規則陣列///////////////////");
            int[][] arr = new int[3][];
            arr[0] = new int[3];
            arr[1] = new int[2];
            arr[2] = new int[4];
            Console.WriteLine(arr[0].Length);




            Console.ReadLine();
        }
    }
}
