using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017布尔运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 34;
            int num2 = 67;
            bool res1 = num1 == num2;
            bool res2 = num1 != num2;
            bool res3 = num1 < num2;
            bool res4 = num1 > num2;
            bool res5 = num1 <= num2;
            bool res6 = num1 >= num2;
            Console.WriteLine("{0}{1}{2}{3}{4}{5}",res1, res2, res3, res4, res5, res6);
            Console.ReadKey();

        }
    }
}
