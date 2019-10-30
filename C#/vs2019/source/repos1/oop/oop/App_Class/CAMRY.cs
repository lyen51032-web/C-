using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myUtility.Car
{
    public class CAMRY : TOYOTA, IRecorder, IDisposable//假設沒有定速功能
    {
        public bool FrontCarRecorder { get; set;}
        public bool BackCarRecorder { get; set; }
        public bool BackCarRadar { get; set; }


        /// <summary>
        /// Car 解構子
        /// </summary>
        /// 
        ~CAMRY()
        {
            //必須為false
            Dispose(false);
        }

        /// <summary>
        /// TOYATA CAMRY  廠牌建構子
        /// </summary>
        public CAMRY()
        {
            CarType = myEnum.TOYOTA_CarType.CAMRY;
            FuelType = myEnum.FuelType.Battery;
            Year = 2019;
            CC = 2000;
            Speed = 0;
            SpeedUp = 20;
            SpeedLimit = 350;
            EngineNumber = "9999-8888-7777";
            FrontCarRecorder = true;
            BackCarRecorder = true;
            BackCarRadar = false;
        }

        /// <summary>
        /// TOYATA CAMRY 廠牌建構子
        /// </summary>
        /// <param name="iYear">出廠年份</param>
        /// <param name="iCC">排氣量</param>
        /// <param name="enFuelType">燃油方式</param>
        /// <param name="sEngineNumber">引擎號碼</param>
        public CAMRY(int iYear, int iCC, myEnum.FuelType enFuelType, string sEngineNumber)
        {
            CarType = myEnum.TOYOTA_CarType.CAMRY;
            Year = iYear;
            CC = iCC;
            FuelType = enFuelType;
            EngineNumber = sEngineNumber;
            Speed = 0;
            SpeedUp = 20;
            SpeedLimit = 200;
        }

    }
}
