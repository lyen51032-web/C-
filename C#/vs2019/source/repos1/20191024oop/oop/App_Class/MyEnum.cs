using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car.oop
{
    /// <summary>
    /// 使用者自定義枚舉類型的類別
    /// </summary>
    public class MyEnum
    {
        public enum CarColor
        { 
            /// <summary>
            /// 黑
            /// </summary>
            Black = 0,
            /// <summary>
            /// 藍
            /// </summary>
            Blue=1,
            /// <summary>
            /// 紅
            /// </summary>
            Red=2,
            /// <summary>
            /// 白
            /// </summary>
            White=3
        

        }

        public enum CarBrandName { 
        
            BENZ = 0,
            MAZDA=1
        }

        public enum MazdaType { 
            M3=0,
            CX3=1
        
        }





    }
}
