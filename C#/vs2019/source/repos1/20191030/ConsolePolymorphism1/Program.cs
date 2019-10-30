using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePolymorphism1
{
    //定義 Employee 員工當作父類別
    class Employee
    {  // _salary 宣告為保護層級，只讓子類別中使用
       protected int _salary;        //父類別的欄位
          public virtual int Salary  //父類別的屬性
        {
            get {
                return _salary;
            }
            set {
                //薪資< 20000, 以 20000 計算; 薪資 > 40000 以 40000 計算
                if (value < 20000)
                    _salary = 20000;
                else if (value > 40000)
                {
                    _salary = 40000;
                }
                else
                    _salary = value;
            }
        } 
    }

    class Manager : Employee
    {
        public int Bonus { get; set; }

        public override int Salary //覆寫
        {
            get
            {
                return _salary;
            }
            set
            {
                //薪資< 30000, 以 30000 計算; 薪資 > 60000 以 60000 計算
                if (value < 30000)
                    _salary = 30000;
                else if (value > 60000)
                {
                    _salary = 60000;
                }
                else
                    _salary = value;
            }
        }

        public void ShowTotal()
        {
            Console.WriteLine("\n實領的薪資: {0}元", (Bonus + Salary).ToString("0,0"));
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            Console.WriteLine("請輸入bonus多少?");
            manager.Bonus = System.Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("請輸入Salary多少?");
            manager.Salary = int.Parse(Console.ReadLine());
            manager.ShowTotal();

            Console.Read();
        }
    }
}
