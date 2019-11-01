using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDeConstructor
{
    class Car {



        private int _speend = 0;

        public Car() {

            _speend = 0;
            Console.WriteLine("初始化車速={0}", _speend);
        }

        public Car(int vSpeed) {


            _speend = vSpeed;
            Console.WriteLine("初始化車速={0}", _speend);
        }

        ~Car() {

            Console.WriteLine("車子物件被消滅");
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("進入程序，宣告BMW物件");
            Car BMW = new Car(10);
            Console.WriteLine("宣告BMW完成，準備離開方法");
            Console.WriteLine("宣告Benz物件");
            Car Benz = new Car();
            Console.WriteLine("宣告Benz完成-----------------------------");

            Benz = null;
            GC.Collect();

            Benz = null;//證明單純空值，也不會釋放記憶體
            GC.Collect();//清除一次同個空值
            Console.WriteLine("Benz=null執行完成*********************");

            Benz = null;
            GC.Collect();
            Console.ReadLine();
        }
    }
}
