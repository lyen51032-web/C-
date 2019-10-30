using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5_學習評量
{
    class big
    {

        public int change(int X, int Y)
        {
            return X > Y ? X : Y;
        }

    }

        class Ex1
    {
        static public void ex1()
        {

                big obj = new big();
                Console.WriteLine("-5和-3誰比較大？" + obj.change(-5, -3));
                Console.Read();
        }

    }
}
