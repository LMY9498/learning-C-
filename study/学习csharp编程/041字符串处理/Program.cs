using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041字符串处理
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "   www.COM   ";
            string res = str.ToLower();//把字符串转化为小写并返回，对原字符没有影响
            string res2 = str.ToUpper();
            string res3 = str.Trim();//去掉字符串前面和后面的空格，对原字符串没有影响
            string res4 = str.TrimStart();
            string res5 = str.TrimEnd();
            string[] strArray = str.Split('.');//把原字符串按照指定的字符进行拆分，得到一个拆分后的字符串数组。
            for (int i=0;i<str.Length;i++)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(str);
            Console.WriteLine(res);
            Console.WriteLine(res2);
            Console.WriteLine(res3);
            Console.WriteLine(res4);
            Console.WriteLine(res5);
            foreach(string temp in strArray)
            {
                Console.WriteLine(temp);
            }
            Console.ReadKey();
        }
    }
}
