using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012运算符的优先级
{
    class Program
    {
        static void Main(string[] args)
        {
            //在程序中的表达式中，运算符是有优先级的，先运行优先级高的运算的运算，
            //我们可以通过括号来改变运算符的优先级，括号内的运算总是最先运行。
            int num = 12 + 90;
            int num1 = 12 + 90 * 2;
            int num2 = (12 + 90) * 2;
            Console.WriteLine(num);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.ReadKey();

        }
    }
}
