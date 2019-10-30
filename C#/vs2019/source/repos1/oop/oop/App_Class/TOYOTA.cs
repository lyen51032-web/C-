using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myUtility.Car
{
    public class TOYOTA : Car, IInsurance, IDisposable
    {
        public myEnum.InsuranceType InsuranceType { get ; set ; }

        /// <summary>
        /// Car 解構子
        /// </summary>
        ~TOYOTA()
        {
            //必須為false
            Dispose(false);
        }

        /// <summary>
        /// TOYOTA 車型
        /// </summary>
        public myEnum.TOYOTA_CarType CarType { get; set; }

        /// <summary>
        /// TOYOTA 廠牌建構子
        /// </summary>
        public TOYOTA()
        {
            Brand = myEnum.Brand.TOYOTA;
            FuelType = myEnum.FuelType.Gasoline;
            Year = DateTime.Today.Year;
            CC = 1800;
            Speed = 0;
            SpeedUp = 1;
            SpeedLimit = 200;
            EngineNumber = "0000-0000-0000";
            InsuranceType = myEnum.InsuranceType.InsuranceTypeB;
        }



    }


}
