using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getset
{
    class Program
    {
        public class Student {
            private string StudentName;
            private int StudentScore;
        
            public string Name {
                set {
                    StudentName = value;
                }

                get {
                    return StudentName;
                }
            }

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


        static void Main(string[] args)
        {
            Student ST = new Student();
            ST.Name = "Lorcy";
            ST.Score = 50;
            Console.WriteLine(ST.Name+"的分數為"+ST.Score);
            Console.ReadLine();
        }
    }
}
