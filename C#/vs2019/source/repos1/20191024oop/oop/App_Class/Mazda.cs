using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car.oop
{

    public class Mazda : Car
    {
        public MyEnum.MazdaType MazdaType { get; set; }

        public Mazda()
        {
            BrandName = MyEnum.CarBrandName.MAZDA;
            MazdaType = MyEnum.MazdaType.M3;
            CC = 200;
            Door = 4;
            SpeedLimit = 300;
            Color = MyEnum.CarColor.Black;
        }
    }
}


