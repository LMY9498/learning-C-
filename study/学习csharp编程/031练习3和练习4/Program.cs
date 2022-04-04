using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031练习3和练习4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int count = 0;
            //int sum = 0;
            //for (int i=1;i<=1000;i++)
            //{
            //    if(i%7==0)
            //    {
            //        count++;
            //        sum = sum + i;
            //        Console.WriteLine(i);
            //        if(count==5)
            //        {
            //            Console.WriteLine(sum);
            //            count = 0;
            //            sum = 0;
            //        }
            //    }
            //}
            for(int i=1;i<=100;i++)
            {
                int pingfang = i * i;
                double gen = Math.Sqrt(i);
                Console.WriteLine("平方" + pingfang + "  " + "平方根" + gen);
            }
            Console.ReadKey();
        }
    }
}
