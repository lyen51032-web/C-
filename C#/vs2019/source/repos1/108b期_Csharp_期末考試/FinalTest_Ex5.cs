using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _108b期_Csharp_期末考試
{
    class FinalTest_Ex5
    {
        public static void Ex5()
        {

            Console.WriteLine("請輸入一個字串：");
           
            string str = Console.ReadLine();
            
            Dictionary<char, int> dic = new Dictionary<char, int>();
            
            foreach (char item in str)
            {
                
                if (char.IsLetter(item))
                {
                    
                    if (!dic.ContainsKey(item))
                    {
                        
                        dic.Add(item, 1);
                    }
                    else
                    {
                        
                        dic[item]++;
                    }
                }
            }
            // 遍歷字典
            foreach (KeyValuePair<Char, int> item in dic)
            {
               

                if (item.Key == 'a') { 
                    Console.WriteLine("出現"+item.Key + "的次數是 " + item.Value); 
                }
                if (item.Key == 'e')
                {
                    Console.WriteLine("出現" + item.Key + "的次數是 " + item.Value);
                }
                if (item.Key == 'i')
                {
                    Console.WriteLine("出現" + item.Key + "的次數是 " + item.Value);
                }
                if (item.Key == 'o')
                {
                    Console.WriteLine("出現" + item.Key + "的次數是 " + item.Value);
                }
                if (item.Key == 'u')
                {
                    Console.WriteLine("出現" + item.Key + "的次數是 " + item.Value);
                }



            }

            Console.Read();
        }
    }
}
