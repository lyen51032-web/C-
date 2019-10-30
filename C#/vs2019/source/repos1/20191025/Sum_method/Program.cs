using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_method
{
    class Calc
    {

        public void Show() {

            int A = Sum(5, 10);
            Console.WriteLine(A);
        }

        public int Sum(int x, int y) {
            return x + y;
        }


}
    class class1 {
        static void Main(string[] args)
        {
            Calc obj = new Calc();
            obj.Show();
            Console.Read();
        }


    }

   

    
}
