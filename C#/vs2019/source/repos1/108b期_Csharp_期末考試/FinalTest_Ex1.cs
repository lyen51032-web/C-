using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _108b期_Csharp_期末考試
{
    public class FinalTest_Ex1
    {

        static double fnum(double x) {
  
            if (x == 0)
            {
                return x =-1;
            }

            else { 
            
            return x = 3*x+2*x-1;
            }
        }


        public static void Ex1()
        {

   

            Console.WriteLine("f(-3.2)="+ System.Convert.ToDouble( fnum(-3.2)));
            Console.WriteLine("f(-2.1)="+ fnum(-2.1));
            Console.WriteLine("f(0)="+ fnum(0));
            Console.Read();
        }
    }
}
