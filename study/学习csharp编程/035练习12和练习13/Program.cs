using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035练习12和练习13
{
    class Program
    {
        static void Main(string[] args)
        {
        //    while (true)
        //    {
        //        Console.WriteLine("请输入一个整数");
        //        int n = Convert.ToInt32(Console.ReadLine());
        //        if (n > 0)
        //        {
        //            for (int i = 0; i < n; i++)
        //            {
        //                Console.Write(i + " ");
        //            }
        //            Console.WriteLine();
        //        }
        //        else if(n<0)
        //        {
        //            return;
        //        }
        //    }
            for(int i=0;i<100;i++)
            {
                string str = "1";
                int sum = 1;
                for(int j=2;j<i;j++)
                {
                    if(i%j==0)
                    {
                        str += "+" + j;
                        sum = sum + j;
                    }
                }
                if(sum==i)
                {
                    Console.WriteLine(i + "是完数"+str);
                }
            }
            Console.ReadKey();
        }
    }
}
