using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018条件布尔运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            bool var1 = true;
            bool var2 = false;
            bool res = !var1;
            bool res1 = var1 & var2;
            bool res2 = var1 | var2;
            bool res3 = var1 ^ var2;
            bool res4 = var1 && var2;
            bool res5 = var1 || var2;


        }
    }
}
