using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car.oop
{   /// <summary>
    ///車子的類別
    /// </summary>
    public class Car
    {
        /// <summary>
        /// 廠牌名稱
        /// </summary>
        public MyEnum.CarBrandName BrandName { get; set; }
        /// <summary>
        /// 車名
        /// </summary>
        public string CardName { get; set; }
        /// <summary>
        /// 排氣量
        /// </summary>
        public int CC { get; set; }
        
        /// <summary>
        /// 顏色
        /// </summary>
        public MyEnum.CarColor Color { get; set; }

        /// <summary>
        /// 車門數
        /// </summary>
        public int Door { get; set; }

        public int SpeedLimit { get; set; }

        private int _Speed = 0;

        public int Speed
        {
            get
            {
                return _Speed;
            }
            set
            {
                if (value < 0)
                    _Speed = 0;
                else if (value > SpeedLimit)
                    _Speed = SpeedLimit;
                else
                    _Speed = value;
            }
        }

        public void Accelerate()
        {
            if (Speed + 10 < SpeedLimit)
                Speed += 10;
        }

        public void Decelerate()
        {
            if (Speed - 10 < 0)
                Speed -= 10;
        }

    }
}
