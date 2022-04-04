using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021三元运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInteger = 100;
            string resStr = (myInteger < 10) ? "less than 10" : "greater or equal to 10";
            Console.WriteLine(resStr);
            Console.ReadKey();
        }
    }
}
