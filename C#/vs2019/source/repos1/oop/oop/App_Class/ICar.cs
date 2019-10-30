using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 介面功能提取，如果要有介面有的東西，就一模一樣複製過去!!!
/// </summary>
namespace myUtility.Car
{
    /// <summary>
    /// 定速功能介面
    /// </summary>
    public interface IFixdSpeed
    {
        /// <summary>
        /// 是否在定速狀態
        /// </summary>
        bool FixedSpeed{ get; set; }
        /// <summary>
        /// 按下定速鍵
        /// </summary>
        void PushFixedSpeedButton();
    }

    /// <summary>
    /// 錄影功能介面
    /// </summary>
    public interface IRecorder
    { 
        /// <summary>
        /// 前車錄影
        /// </summary>
        bool FrontCarRecorder { get; set; }
        /// <summary>
        /// 後車錄影
        /// </summary>
        bool BackCarRecorder { get; set; }
        /// <summary>
        /// 倒車雷達
        /// </summary>
        bool BackCarRadar { get; set; }
    }
    /// <summary>
    /// 汽車保險介面
    /// </summary>
    public interface IInsurance
    {
        /// <summary>
        /// 保險方式
        /// </summary>
        myEnum.InsuranceType InsuranceType { get; set; }
    }
}
