using car.oop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Program
    {

        static void Main(string[] args)
        {
            Prog1();

        }
        static void Prog1()
        {
            Mazda cx3 = new Mazda();
            cx3.MazdaType = MyEnum.MazdaType.CX3;
            cx3.Color = MyEnum.CarColor.Red;
            cx3.Door = 5;
            cx3.SpeedLimit = 250;

            cx3.Speed = 80;
            cx3.Accelerate();
            Console.WriteLine("Now Speed = {0}", cx3.Speed);
            cx3.Accelerate();
            Console.WriteLine("Now Speed = {0}", cx3.Speed);
            cx3.Speed = 250;
            cx3.Accelerate();
            Console.WriteLine("Now Speed = {0}", cx3.Speed);
            Console.Read();
        }
    }
}
