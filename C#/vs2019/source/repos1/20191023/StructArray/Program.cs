using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructArray
{
    class Program
    {
        struct Student {
            public string No, Name;
            public int Score;
        }
        static void Main(string[] args)
        {
            Student[] nns = new Student[3];
            nns[0].No = "01"; nns[0].Name="A"; nns[0].Score = 100;
            nns[1].No = "01"; nns[1].Name = "B"; nns[1].Score = 70;
            nns[2].No = "01"; nns[2].Name = "C"; nns[2].Score = 90;

            Student[] nns1 = new Student[] {
            new Student() { No="101",Name="Z" , Score=50},
            new Student() { No="102",Name="Y" , Score=20},
            new Student() { No = "103", Name = "X", Score = 10}

            };
        }

    }
}
