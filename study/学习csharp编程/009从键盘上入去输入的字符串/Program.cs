using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009从键盘上入去输入的字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            string str=Console.ReadLine();//接收键盘输入，返回字符串
            Console.WriteLine(str);
            string str1 = Console.ReadLine();//输入整数字符串
            int num = Convert.ToInt32(str1);//将整数字符串转换为整数，只能是整数字符串
            string str2 = Console.ReadLine();//输入小数字符串
            double num1 = Convert.ToDouble(str2);//将小数字符串转换为double浮点类型
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
