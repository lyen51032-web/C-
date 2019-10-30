using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
 撰寫一個方法擁有搜尋陣列中資料的功能，呼叫方法時傳入一個陣列以及欲搜尋的資料。搜尋結果即會印出相關訊息，
 告知你該陣列中是否有你要搜尋的資料，若有找到則印出欲搜尋的資料是在陣列的第幾個位置；若找不到則印出”無此資料!!”的訊息。*/
namespace EX3
{
    class Program
    {
        //static void 



        static void Main(string[] args)
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
            for (int i = 0; i < stu[0].Length;i++)
            {

                Console.Write("第{0}位學生{1}的成績為:{2}\n", (i + 1), stu[0][i],stu[1][i]);
            }
            Console.WriteLine("請輸入欲查詢的學生：");
            string student = Console.ReadLine();

            for (int i = 0; i < stu[0].Length; i++) {
                if (student == stu[0][i])
                {
                    Console.WriteLine("找到了!\r{0}的分數是{1}在陣列的第{2}個位置", stu[0][i], stu[1][i], i);
                    break;
                }
                else if(i == stu[0].Length-1)
                {
                    Console.WriteLine("無此資料!!");
                    break;
                }
            }
        }
        
    }
}
