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
    /// HONDA CIVIC 車型
    /// </summary>
    public class CIVIC : HONDA , IFixdSpeed , IRecorder , IDisposable
    {
        /// <summary>
        /// Car 解構子
        /// </summary>
        /// 
        ~CIVIC()
        {
            //必須為false
            Dispose(false);
        }

        /// <summary>
        /// HONDA CIVIC 廠牌建構子
        /// </summary>
        public CIVIC()
        {
            CarType = myEnum.HONDA_CarType.CIVIC;
            FuelType = myEnum.FuelType.Gasoline;
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
        /// HONDA CIVIC 廠牌建構子
        /// </summary>
        /// <param name="iYear">出廠年份</param>
        /// <param name="iCC">排氣量</param>
        /// <param name="enFuelType">燃油方式</param>
        /// <param name="sEngineNumber">引擎號碼</param>
        public CIVIC(int iYear, int iCC, myEnum.FuelType enFuelType, string sEngineNumber)
        {
            CarType = myEnum.HONDA_CarType.CIVIC;
            Year = iYear;
            CC = iCC;
            FuelType = enFuelType;
            EngineNumber = sEngineNumber;
            Speed = 0;
            SpeedUp = 20;
            SpeedLimit = 200;
        }

        public bool FixedSpeed { get; set; }
        public bool FrontCarRecorder { get; set; }
        public bool BackCarRecorder { get; set; }
        public bool BackCarRadar { get; set; }

        public void PushFixedSpeedButton()
        {
            FixedSpeed = !FixedSpeed;
        }

        public override void Decelerate()
        {
            base.Decelerate();//父親執行一次
            FixedSpeed = false;//兒子執行一次
        }
    }
}
