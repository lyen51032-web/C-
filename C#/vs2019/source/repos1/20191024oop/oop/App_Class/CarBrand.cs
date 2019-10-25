using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car.oop
{
    /// <summary>
    /// 車子廠牌的類別
    /// </summary>
    public class CarBrand : Car
    {
        /// <summary>
        /// 建構子
        /// </summary>
        public CarBrand()
        {
            CardName = "None";
            CC = 2000;
            Color = MyEnum.CarColor.Black;
            Door = 4;
        }
    }
}
