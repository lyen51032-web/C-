using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStru
{
    class Program
    {
        struct Product
        {
            public string no, name;
            public int price;
        }

        static void Main(string[] args)
        {
            Product game;
            game.no = "G01";
            game.name = "XBOX One";
            game.price = 10000;

            Product cookie;
            Console.Write("請輸入產品編號:");
            cookie.no = Console.ReadLine();
            Console.Write("請輸入產品名稱:");
            cookie.name = Console.ReadLine();
            Console.Write("請輸入產品單價:");
            cookie.price = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("========產品單價清單=========================");
            Console.WriteLine();
            Console.WriteLine(" game 產品編號 : {0}", game.no);
            Console.WriteLine(" game 產品名稱 : {0}", game.name);
            Console.WriteLine(" game 產品單價 : {0}", game.price);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(" cookie 產品編號 : {0}", cookie.no);
            Console.WriteLine(" cookie 產品名稱 : {0}", cookie.name);
            Console.WriteLine(" cookie 產品單價 : {0}", cookie.price);
            Console.Read();
        }
    }
}
