using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020if语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool var = true;
            //if (var)
            //    Console.WriteLine("------");
            //Console.WriteLine("####3");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 50)
            {
                Console.WriteLine("您输入的分数大于50");
            }
            else
            {
                Console.WriteLine("您输入的分数小于等于50");
            }
            Console.ReadKey();
        }
    }
}
