using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStudent
{
    public class Student
    {
        private string StudentName;
        private int StudentScore;
        public string Name { set; get; }

        //public string Name
        //{
        //    set {
        //        StudentName = value;
        //    }
        //    get {
        //        return StudentName;
        //    }
        //}

        public int Score
        {
            set
            {

                if (value < 60) StudentScore = 60;
                else StudentScore = value;

            }
            get
            {
                return StudentScore;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student ST = new Student();
            ST.Name = "Mary";
            ST.Score = 40;
            Console.WriteLine(ST.Name + "的分數為" + ST.Score);
            Console.Read();
        }
    }
}
