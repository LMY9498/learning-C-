using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029goto和return跳出循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //while(true)
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num == 0)
            //    {
            //        goto myLabel;
            //    }
            //}
            //myLabel:
            //Console.WriteLine("跳出循环了");
            while(true)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                {
                    return;
                }
                
            }
            Console.WriteLine("跳出循环了");
            Console.ReadKey();
        }
    }
}
