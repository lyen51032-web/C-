using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1025_作業繳交
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;

            while (flag)
            {
                string input = "";
                Console.WriteLine("1.撰寫一個可以傳回兩個參數中比較大之參數的方法，然後在Main() 方法中呼叫這個方法傳回 -5和 -3兩個參數中比較大之參數並顯示出來。");
                Console.WriteLine("2.建立三個 GetMax() 多載方法，可用來傳回兩數最大數、傳回三個整數中的最大值、傳回陣列的最大數。");
                Console.WriteLine("3.撰寫一個方法擁有搜尋陣列中資料的功能，呼叫方法時傳入一個陣列以及育搜尋的資料。搜尋結果即會印出相關訊息，告知你該陣列中是否有你要搜尋的資料，若有找到則印出欲搜尋的資料是在陣列的第幾個位置；若找不到則印出”無此資料!!”的訊息。");
                Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                Console.Write("請輸入要執行的題目編號? ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                         flag = false;
                        break;
                    case "1":
                        Ex1.ex1();
                        break;
                    case "2":
                        Ex2.ex2();
                        break;
                    case "3":
                        Ex3.ex3();
                        break;

                    default:
                        break;
                }
                Console.Clear();
            }

        }
    }
}
