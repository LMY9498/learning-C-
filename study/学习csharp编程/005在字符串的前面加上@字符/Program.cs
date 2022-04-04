using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005在字符串的前面加上_字符
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "I'm a good man.\n you are a bad girl";
            Console.WriteLine(str1);
            //当在字符串前面加上一个@字符的时候，我们就可以把一个字符串定义在多行（原样输出）
            //编译器不会再去识别字符串中的转义字符
            //如果需要在一个字符串中表示一个双引号的话，需要使用两个双引号
            string str2 = @"I'm a good man.\n ""you are a bad girl";//使用两个引号表示一个引号
            string path1 = "c:\\xxx\\xxx\\xxx.doc";
            string path2 = @"c:\xxx\xxx\xxx.doc";
            Console.WriteLine(str2);
            Console.WriteLine(path1);
            Console.WriteLine(path2);
            Console.ReadKey();
        }
    }
}
