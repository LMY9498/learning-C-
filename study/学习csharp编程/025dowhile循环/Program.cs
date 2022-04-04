using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025dowhile循环
{
    class Program
    {
        static void Main(string[] args)
        {
            int var = 1;
            do
            {              
                Console.WriteLine(var);
                var++;

            }while(var< 10) ;
            Console.ReadKey();
        }
    }
}
