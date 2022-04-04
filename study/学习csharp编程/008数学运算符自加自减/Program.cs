using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008数学运算符自加自减
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 45;
            //++无论是在操作数的前还是后，都是让操作数加一
            num1++;
            num1++;
            num1++;
            ++num1;
            //当在表达式中时，++无论是在操作数的前还是后，有区别
            //++放在操作数前面会先进行自增，再进行其余的运算
            int res1 = ++num1;
            //++放在操作数后面，会先使用操作数进行运算，然后再自增
            int res2 = num1++;
            //--同上
            Console.WriteLine(num1);
            Console.ReadKey();

        }
    }
}
