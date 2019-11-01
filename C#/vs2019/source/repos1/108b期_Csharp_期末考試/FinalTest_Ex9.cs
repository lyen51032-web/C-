using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _108b期_Csharp_期末考試
{





    class FinalTest_Ex9
    {

        abstract class radius
        {
            public double r;

            abstract public void Run();


        }

        class circle : radius
        {

            public override void Run()
            {
                r = r * r * 3.14;
            }

        }


        public static void Ex9()
        {
            double r = 20;
            circle rad = new circle();
            rad.r = r;
            rad.Run();
            Console.WriteLine("圓心(X,Y):(15,25)");
            Console.WriteLine("圓半徑:"+r);
            Console.WriteLine("圓面積:"+rad.r);

            Console.ReadLine();
        }
    }
}
