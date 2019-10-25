using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            try
            {
                Console.WriteLine("請輸入被除數");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("請輸入除數");
                b = int.Parse(Console.ReadLine());
                c = a / b;
                Console.WriteLine("結果是 {0}", c);
            }


            /*catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ToString());
            }*/

            catch (DivideByZeroException e)
            {
              Console.WriteLine("除數為0");
             }
            catch (FormatException e)
            {
                Console.WriteLine("引數格式不合");
            }
            finally
            {
                Console.WriteLine("程式結束");
            }
            Console.ReadLine();
            
        }
        
    }
}
