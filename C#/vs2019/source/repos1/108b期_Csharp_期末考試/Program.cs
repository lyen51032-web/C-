using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _108b期_Csharp_期末考試
{
    class Program
    {
        static public int len, textLen, b, sLen;
        static public string[] arr;
        
        static void Main(string[] args)
        {

            //len = args.Length;
            //arr = new string[len];
            //arr = args;
            bool flag = true;

            while (flag)
            {
                string input = "";
                Console.WriteLine(" 1.設計f(x)=3x+2x-1,試寫一函數 double f(double x）,用來傳回 f(x)的值，並於主程式裡分別計算 f(-3.2), f(-2.1), f(0), f(2.1)");
                Console.WriteLine(" 2.請設計可產生任意輸入符號的聖誕樹");
                Console.WriteLine(" 3.撰寫一個二維陣列九九乘法表。");
                Console.WriteLine(" 4.試設陣列A的維度為4×2×3，請在程式碼裡宣告此一陣列，並在宣告同時設定初值(1~24)，然後計算陣列A內所有元素的總和");
                Console.WriteLine(" 5.請試撰寫一程式，由鍵盤輸入一字串後，分別計算該字串出現a、e、i、o、u的次數。");
                Console.WriteLine(" 6.請撰寫int mod(int x, int y) 函數，計算x / y的餘數。並利用此函數來計算mod(17, 5)，即計算的餘數");
                Console.WriteLine(" 7.建立一個Student類別，此類別屬性有下列成員:\n" +
                                  "   (1)id  學號屬性，Sname 姓名屬性\n" +
                                  "   (2)chi 國文成績屬性: 存取範圍 1-100\n" +
                                  "   (3)eng 英文成績屬性: 存取範圍 1-100\n" +
                                  "   (4)bcc 計概成績屬性: 存取範圍 1-100\n" +
                                  "   (5)GetAvg() 方法,可以取得 chi+eng+bcc 之平均分數\n" +
                                  "   (6)Num 靜態成員: 用來計算共建立多少位學生\n" +
                                  "   (7)GetStudentNum() 方法：用來取得目前共建立多少位學生\n");
                Console.WriteLine(" 8.將ConsolePolymorphism3.sln 多型範例，改用介面來完成");
                Console.WriteLine(" 9.宣告Shape為抽象類別後，再宣告Ｃircle 子類別繼承抽象類別，並且實作圓面積的 Area() 抽象方法。");
                Console.WriteLine("10.定義一個GetMax()方法,該方法傳回陣列中的最大值，當主程式呼叫GetMax() 方法時，將整個陣列以參考呼叫(Call By Reference)" +
                                  "   方式傳遞給此方法，結果會傳回陣列中的最大值並顯示出來。\n");
                Console.WriteLine("   ----------------------------------------------------------------------------------------------------------------");
                Console.Write("請輸入要執行的範例 ? ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        flag = false;
                        break;
                    case "1":
                        FinalTest_Ex1.Ex1();
                        break;
                    case "2":
                        FinalTest_Ex2.Ex2();
                        break;
                    case "3":
                        FinalTest_Ex3.Ex3();
                        break;
                    case "4":
                        FinalTest_Ex4.Ex4();
                        break;
                    case "5":
                        FinalTest_Ex5.Ex5();
                        break;
                    case "6":
                        FinalTest_Ex6.Ex6();
                        break;
                    case "7":
                        FinalTest_Ex7.Ex7();
                        break;
                    case "8":
                        FinalTest_Ex8.Ex8();
                        break;
                    case "9":
                        FinalTest_Ex9.Ex9();
                        break;
                    case "10":
                        FinalTest_Ex10.Ex10();
                        break;
                    default:
                        break;
                }
                Console.Clear();
            }
        }
    }
}
