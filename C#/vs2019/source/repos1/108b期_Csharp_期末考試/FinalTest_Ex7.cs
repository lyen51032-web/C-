using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _108b期_Csharp_期末考試
{

    class FinalTest_Ex7
    {
        class Id {

        }

        class Sname
        {

        }

        class Chi
        {

        }
        class Eng
        {

        }
        class Bcc
        {

        }

        static int GetAvg(int c, int e, int b) {
            return (c + e + b) / 3;
        }


        static int GetStudentNum(int num)
        {
            return num += 1;
        }


        public static void Ex7()

        {
            int num = 0;
            int chi=89, eng=78, bcc=100;
            
            int avg = GetAvg(chi, eng, bcc);
           
            bool flag = true;
            string sname ="彼得", id = "a01";


            while (flag == true)
            {
                
                Console.WriteLine("目前建立{0}位學生" , num);

                Console.WriteLine("建立{0}學生，學號{1} ,國文{2} , 英文{3} , 計概{4} ,平均{5}的資料",sname,id,chi, eng, bcc,avg);

                 num += 1;
                GetStudentNum(num);
                Console.WriteLine("目前建立{0}位學生", num);
                flag = false;
            }

            Console.ReadLine();
        }
    }
}
