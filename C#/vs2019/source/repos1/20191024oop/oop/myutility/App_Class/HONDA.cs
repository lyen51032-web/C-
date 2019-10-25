using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace myUtility.Car
{
    /// <summary>
    /// HONDA 廠牌
    /// </summary>
    public class HONDA : Car, IInsurance, IDisposable
    {
        /// <summary>
        /// Car 解構子
        /// </summary>
        ~HONDA()
        {
            //必須為false
            Dispose(false);
        }

        /// <summary>
        /// HONDA 車型
        /// </summary>
        public myEnum.HONDA_CarType CarType { get; set; }

        /// <summary>
        /// 汽車保險
        /// </summary>
        public myEnum.InsuranceType InsuranceType { get; set; }

        /// <summary>
        /// HONDA 廠牌建構子
        /// </summary>
        public HONDA()
        {
            Brand = myEnum.Brand.HONDA;
            FuelType = myEnum.FuelType.Gasoline;
            Year = DateTime.Today.Year;
            CC = 1800;
            Speed = 0;
            SpeedUp = 1;
            SpeedLimit = 200;
            EngineNumber = "0000-0000-0000";
            InsuranceType = myEnum.InsuranceType.InsuranceTypeA;
        }
    }
}
