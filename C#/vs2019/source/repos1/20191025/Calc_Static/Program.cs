using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Static
{
    class Calc
    {
        public static void Show() {
            int A = Sum(5, 10);
            Console.WriteLine(A);

        }

        public static int Sum(int x, int y) {
            return x + y;
        }

        class Class1
        {

            public static void Main(string[] args)
            {
                Calc.Show();
                Console.Read();
            }
            
        }




    }
}
