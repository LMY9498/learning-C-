using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032练习6和练习7
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int i=0;i<=100;i++)
            //{
            //    if((i%3==0)&&(i%5!=0))
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            for(int i=2;i<=1000;i++)
            {
                bool isZhiShu = true;
                for (int j=2;j<i-1;j++)
                {
                    if(i%j==0)
                    {
                        isZhiShu = false;
                        break;
                    }
                }
                if(isZhiShu)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
