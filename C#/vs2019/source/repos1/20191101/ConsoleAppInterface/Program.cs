using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterface
{
    interface IInfo
    {
        string Info();
    }

    interface IArea
    {
        double Area();
    }

    class Rectangle :IArea,IInfo {

        public int Height;
        public int Width;


        public Rectangle(int h, int w) {

            Height = h;
            Width = w;

        }

        public double Area() {

            return (Height * Width);
        }
        public string Info() {

            return "長方形的長" + Height + "\r\n" + "長方形的寬" + Width;
        }



    }





    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 20);
            Console.WriteLine(r.Info());

            Console.WriteLine("\n長方形面積"+r.Area());

            Console.ReadLine();
        }
    }
}
