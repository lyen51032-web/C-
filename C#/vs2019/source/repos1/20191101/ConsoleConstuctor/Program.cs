using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleConstuctor
{
    class Student {
        private int _Height, _Weight;

        public Student() { 
            _Height=160;
            _Weight=50;
}
        public Student(int w)
        {
            _Height = 160;
            _Weight = w;
        }
        public Student(int w,int h)
        {
            _Height = h;
            _Weight = w;
        }

        public void GetShow() {

            Console.WriteLine("身高是：{0}", _Height);
            Console.WriteLine("體重是：{0}", _Weight);

        }


    }

    class Program
    {
        static void Main(string[] args)
        {

            Student Peter = new Student();
            Console.WriteLine("Peter的資料是-->使用建構式Student()");
            Peter.GetShow();

            Student Allen = new Student(56);
            Console.WriteLine("Allen的資料是-->使用建構式Student(56)");
            Allen.GetShow();

            Student Lynn = new Student(54,160);
            Console.WriteLine("Lynn的資料是-->使用建構式Student()");
            Lynn.GetShow();


            Console.ReadLine();

        }
    }
}
