using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_我们的第一个Csharp程序
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("helloworld");
            Console.Write("aaa");
            //没有using System时
            //System.Console.Write("bbb");
            Console.Write("\n");
            Console.WriteLine("两个数相加{0}+{1}={2}", 3, 34, 34);
            Console.WriteLine("three integers are {0} {1}and {1}", 2, 5);
            Console.ReadKey();
        }
    }
}
