using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014练习三四
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int num3 = Convert.ToInt32(Console.ReadLine());
            //int num4 = Convert.ToInt32(Console.ReadLine());
            //int res = num1 * num2 * num3 * num4;
            //Console.WriteLine(res);
            //Console.ReadKey();
            int num = Convert.ToInt32(Console.ReadLine());
            int ge = num % 10;
            int shi = (num / 10 )% 10;
            int bai = num / 100;
            int res = ge * 100 + shi * 10 + bai;
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}
