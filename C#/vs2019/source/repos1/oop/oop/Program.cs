using myUtility.Car;
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
            /*
            CIVIC civic = new CIVIC();
            CIVIC civic1 = new CIVIC(1901, 1600, myEnum.FuelType.Gasoline, "999999");
            GC.Collect();//回收記憶體
            */
            Prog1();
        }

        static void Prog1()
        {
            //using 跟解構子綁在一起，沒有就要用這個
            /*
             CAMRY camry = new CAMRY();
             GC.collection();
             */
            using (CAMRY camry = new CAMRY()) {



            }




            using (CIVIC civic = new CIVIC())
            {
                civic.InsuranceType = myEnum.InsuranceType.InsuranceTypeB;
                civic.EngineNumber = "8888-0000-2222";
                civic.FuelType = myEnum.FuelType.Gasoline;
                civic.Year = 2018;
                civic.CC = 1600;
                civic.Speed = 50;
                Console.WriteLine("現在速度為:{0}", civic.Speed);
                civic.Accelerate();
                Console.WriteLine("加速一次,速度為:{0}", civic.Speed);
                civic.Accelerate();
                Console.WriteLine("再加速一次,速度為:{0}", civic.Speed);
                Console.Read();
            }
        }
    }
}
