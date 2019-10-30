using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myUtility.Car
{
    /// <summary>
    /// 使用者自定義枚舉類型的類別
    /// </summary>
    public class myEnum
    {
        /// <summary>
        /// 車子顏色
        /// </summary>
        public enum Color
        {
            /// <summary>
            /// 黑色
            /// </summary>
            Black = 0,
            /// <summary>
            /// 藍色
            /// </summary>
            Blue = 1,
            /// <summary>
            /// 紅色
            /// </summary>
            Red = 2,
            /// <summary>
            /// 白色
            /// </summary>
            White = 3
        }
        /// <summary>
        /// 燃油種類
        /// </summary>
        public enum FuelType
        {
            /// <summary>
            /// 汽油
            /// </summary>
            Gasoline = 0,
            /// <summary>
            /// 柴油
            /// </summary>
            Diesel = 1,
            /// <summary>
            /// 電動
            /// </summary>
            Battery = 2
        }
        /// <summary>
        /// 車子廠牌
        /// </summary>
        public enum Brand
        {
            /// <summary>
            /// HONDA
            /// </summary>
            HONDA = 0,
            /// <summary>
            /// TOYOTA
            /// </summary>
            TOYOTA = 1
        }
        /// <summary>
        /// HONDA 廠牌車型
        /// </summary>
        public enum HONDA_CarType
        {
            ACCORD = 0,
            CIVIC  = 1,
            CRV = 2
        }
        /// <summary>
        /// TOYOTA 廠牌車型
        /// </summary>
        public enum TOYOTA_CarType
        {
            /// <summary>
            /// CAMRY
            /// </summary>
            CAMRY = 0,
            /// <summary>
            /// YARIS
            /// </summary>
            YARIS = 1,
            /// <summary>
            /// WISH
            /// </summary>
            WISH = 2
        }
        /// <summary>
        /// 保險類別
        /// </summary>
        public enum InsuranceType
        {
            /// <summary>
            /// 甲式保險
            /// </summary>
            InsuranceTypeA = 0,
            /// <summary>
            /// 乙式保險
            /// </summary>
            InsuranceTypeB = 1,
            /// <summary>
            /// 丙式保險
            /// </summary>
            InsuranceTypeC = 2
        }
    }
}
