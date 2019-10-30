using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5_學習評量
{
    class Program
    {
        static public int len, textLen, b, sLen;
        static public string[] arr;

        static void disMenu(string s)
        {
            b = s.Length;//整句話長度
            if (textLen > b)
                textLen = b;  

            for (int i = 0; i < s.Length; i = i + textLen)
            {
                b = b - textLen;
                if (b <= textLen)
                {
                    sLen = b;
                    Console.WriteLine(s.Substring(i, textLen));//第一行
                    Console.WriteLine("    "+s.Substring(i + textLen, b));//第二行
                    break;
                }
                else
                {
                    sLen = textLen;
                }
                Console.WriteLine(s.Substring(i, sLen));
            }
            Console.WriteLine();
        }
               
        static void Main(string[] args)
        {
            textLen =49;//每一行幾個字
            len = args.Length;
            arr = new string[len];
            arr = args;
            bool flag = true;           

            while (flag)
            {
                string input = "";
                disMenu("１．撰寫一個可以傳回兩個參數中比較大之參數的方法，然後在ＭＡＩＮ（） 方法中呼叫這個方法傳回－５和－３兩個參數中比較大之參數並顯示出來。");
                disMenu("２．建立三個 ＧｅｔＭａｘ（）多載方法，可用來傳回兩數最大數、傳回三個整數中的最大值、傳回陣列的最大數。");
                disMenu("３．撰寫一個方法擁有搜尋陣列中資料的功能，呼叫方法時傳入一個陣列以及育搜尋的資料。搜尋結果即會印出相關訊息，告知你該陣列中是否有你要搜尋的資料，若有找到則印出欲搜尋的資料是在陣列的第幾個位置；若找不到則印出”無此資料!!”的訊息。");
                Console.WriteLine("   ----------------------------------------------------------------------------------------------------------------");
                Console.Write("請輸入要執行的範例 ? ");
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
                    /*case "4":
                        Ex4.ex4();
                        break;
                    case "5":
                        Ex5.ex5();
                        break;*/
                    default:
                        break;
                }
                Console.Clear();
            }
        }
    }
}
