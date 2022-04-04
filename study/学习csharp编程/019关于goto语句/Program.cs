using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019关于goto语句
{
    class Program
    {
        static void Main(string[] args)
        {
            int myinteger = 5;
            goto mylabel;
            myinteger++;
            mylabel: Console.WriteLine(myinteger);
            Console.ReadKey();
        }
    }
}
