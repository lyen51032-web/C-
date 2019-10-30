using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5_學習評量
{
    class Ex3
    {
        static public void ex3()
        {
            string[][] stud_value = {
                    new string [] { "小明", "小呆","小華","小龜","小白"},
                    new string [] {"90", "80","70","50","77" }
            };
            value(stud_value);


            Console.Read();
        }
        static void value(string[][] stu)
        {
            for (int i = 0; i < stu[0].Length; i++)
            {

                Console.Write("第{0}位學生{1}的成績為:{2}\n", (i + 1), stu[0][i], stu[1][i]);
            }
            Console.WriteLine("請輸入欲查詢的學生：");
            string student = Console.ReadLine();

            for (int i = 0; i < stu[0].Length; i++)
            {
                if (student == stu[0][i])
                {
                    Console.WriteLine("找到了!\r{0}的分數是{1}在陣列的第{2}個位置", stu[0][i], stu[1][i], i);
                    break;
                }
                else if (i == stu[0].Length - 1)
                {
                    Console.WriteLine("無此資料!!");
                    break;
                }
            }
        }

    }
}
