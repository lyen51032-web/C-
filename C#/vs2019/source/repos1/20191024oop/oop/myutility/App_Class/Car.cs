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
    /// 車子的類別
    /// </summary>
    public abstract class Car : IDisposable
    {
        private bool disposed = false;
        private SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        /// <summary>
        /// 解構子,實現IDisposable中的Dispose方法
        /// </summary>
        public void Dispose()
        {
            //必須為true
            Dispose(true);
            //通知垃圾回收機制不再調用終端子（析構器）
            GC.SuppressFinalize(this);
        }
        /// <summary>
        /// Car解構子
        /// </summary>
        /// <param name="disposing">disposing</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            //解構時要執行的其它程式
            if (disposing)
            {
                handle.Dispose();
            }
            //讓類別知道自己已經被釋放
            disposed = true;
        }
        /// <summary>
        /// Car 解構子
        /// </summary>
        ~Car()
        {
            //必須為false
            Dispose(false);
        }

        /// <summary>
        /// 排氣量
        /// </summary>
        public int CC { get; set; }
        /// <summary>
        /// 出廠年份
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// 引擎號碼
        /// </summary>
        public string EngineNumber { get; set; }
        /// <summary>
        /// 燃油方式
        /// </summary>
        public myEnum.FuelType FuelType { get; set; }
        /// <summary>
        /// 廠牌
        /// </summary>
        public myEnum.Brand Brand { get; set; }
        /// <summary>
        /// 目前車速
        /// </summary>
        public int Speed { get; set; }
        /// <summary>
        /// 車子極速
        /// </summary>
        public int SpeedLimit { get; set; }
        /// <summary>
        /// 車子每加速增加速度
        /// </summary>
        public int SpeedUp { get; set; }
        /// <summary>
        /// 車子的建構子
        /// </summary>
        public Car()
        {
            Brand = myEnum.Brand.HONDA;
            FuelType = myEnum.FuelType.Gasoline;
            Year = DateTime.Today.Year;
            CC = 1800;
            Speed = 0;
            SpeedUp = 1;
            SpeedLimit = 200;
            EngineNumber = "0000-0000-0000";
        }
        /// <summary>
        /// 車子的建構子
        /// </summary>
        /// <param name="enBrand">廠牌</param>
        /// <param name="iYear">出廠年份</param>
        /// <param name="iCC">排氣量</param>
        /// <param name="enFuelType">燃油方式</param>
        /// <param name="sEngineNumber">引擎號碼</param>
        public Car(myEnum.Brand enBrand, int iYear, int iCC, myEnum.FuelType enFuelType, string sEngineNumber)
        {
            Brand = enBrand;
            Year = iYear;
            CC = iCC;
            FuelType = enFuelType;
            EngineNumber = sEngineNumber;
        }
        /// <summary>
        /// 車子加速
        /// </summary>
        public void Accelerate()
        {
            AccelerateSpeed();
        }
        /// <summary>
        /// 車子減速
        /// </summary>
        public virtual void Decelerate()
        {
            DecelerateSpeed();
        }
        /// <summary>
        /// 加速
        /// </summary>
        private void AccelerateSpeed()
        {
            if (Speed + SpeedUp < SpeedLimit) Speed += SpeedUp;
        }
        /// <summary>
        /// 減速
        /// </summary>
        private void DecelerateSpeed()
        {
            if (Speed - SpeedUp > 0) Speed -= SpeedUp;
        }
    }
}
