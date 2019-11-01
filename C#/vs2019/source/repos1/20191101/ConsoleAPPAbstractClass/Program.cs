using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPPAbstractClass
{

    abstract class Pass
    {
        public int Speed;
        public string Result;

        abstract public void Run();
    
    
    }

    class Highway : Pass
    {

        public override void Run()
        {
            Result = "沒超速";
            if (Speed >= 120)
            {
                Result = "超速";
            }
        }

    }

    class Cityway : Pass
    {

        public override void Run()
        {
            Result = "沒超速";
            if (Speed >= 60)
            {
                Result = "超速";
            }
        }

    }



    class Program
    {
        static void Main(string[] args)
        {

                int s = 90;
                Highway Hw = new Highway();
                Hw.Speed = s;
                Hw.Run();
                Console.WriteLine("在高速公路"+Hw.Speed+"是"+Hw.Result);


                Cityway Cw = new Cityway();
                Cw.Speed = s;
                Cw.Run();
                Console.WriteLine("在市區道路" + Cw.Speed + "是" + Cw.Result);


                Console.ReadLine();

            }
    }
}
