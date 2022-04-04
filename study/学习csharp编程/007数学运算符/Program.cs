using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007数学运算符
{
    class Program
    {
        static void Main(string[] args)
        {
        //    int num1 = 45;
        //    int num2 = 15;
        //    int res1 = num1 + num2;
        //    int res2 = num1 - num2;
        //    int res3 = num1 * num2;
        //    int res4 = num1 / num2;
        //    int res5 = num1 % num2;
        //    //当两边的操作数类型不一致的时候，返回的结果跟类型大的操作数保持一致
        //    double res = 123.4 % 2;
        //    int num3 = 45;
        //    double num4 = 3.1;
        //    double res6 = num3 + num4;
        //    //加减乘除两边的操作数都是整数的话结果还是整数，如果不能被整除的话则自动略去小数部分
        //    Console.WriteLine("加法的结果：{0}\n减法的结果：{1}\n乘法的结果：{2}\n除法的结果：{3}\n求余的结果：{4}",res1, res2, res3, res4,res5);
        //    Console.WriteLine(res);
        //    Console.WriteLine(res6);

            //字符串相加，用来连接两个字符串 返回一个字符串
            string str1 = "123abc";
            string str2 = "qwer";
            string str = str1 + str2;
            Console.WriteLine(str);
            //字符串与数字相加，先把数字转变为字符串，然后连接起来 结果是字符串
            //数字+空字符串，把数字转变为数字的字符串
            string str3 = "123";
            int num = 456;
            string strr = str3 + num;
            Console.WriteLine(strr);
            Console.ReadKey();
        }
    }
}
