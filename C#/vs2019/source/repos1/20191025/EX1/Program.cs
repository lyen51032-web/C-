using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
 撰寫一個可以傳回兩個參數中比較大之參數的方法，
 然後在Main() 方法中呼叫這個方法傳回 -5和 -3
 兩個參數中比較大之參數並顯示出來。
     */
namespace EX1
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
        static public void Main()
        {

            big obj = new big();
            
            Console.WriteLine("-5和-3誰比較大？"+ obj.change(-5, -3));
            Console.Read();
        }

    }
}
