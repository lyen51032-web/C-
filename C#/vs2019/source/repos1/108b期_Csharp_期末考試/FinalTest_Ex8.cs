using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _108b期_Csharp_期末考試
{
    interface IInfo {
        int Info();
    }


    

    class FinalTest_Ex8
    {



        class Traffic
        {
            protected static int _miles;

            public virtual void SpeedUP()
            {

            }

        }

        class Car : Traffic
        {
            public override void SpeedUP()
            {
                _miles += 2;
                Console.WriteLine("\n 駕駛車子, 加速中, 前進{0} 公里.", _miles);
                Console.WriteLine("-----------------------------------------------");
            }
        }

        class Airplane : Traffic
        {
            public override void SpeedUP()
            {
                _miles += 15;
                Console.WriteLine("\n 駕駛飛機, 加速中, 前進{0} 公里.", _miles);
                Console.WriteLine("-----------------------------------------------");
            }
        }
        
            public static void Ex8()
            {
                Traffic r;
                Car myCar = new Car();
                Airplane myAirplane = new Airplane();
                int input;
                while (true)
                {
                    Console.Write("請問要駕駛 (1)車子  (2)飛機 其他.離開");
                    input = int.Parse(Console.ReadLine());
                    if (input == 1)
                    {
                        r = myCar;

                    }
                    else if (input == 2)
                    {
                        r = myAirplane;
                    }
                    else
                    {
                        break;
                    }

                    r.SpeedUP();
                    Console.WriteLine();
                }

                Console.ReadLine();

            }
        
    }
}
