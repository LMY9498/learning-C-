using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033练习8和练习9
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int i=1;i<=9;i++)
            //{
            //    for (int j = i; j <= 9; j++)
            //    {
            //        Console.Write(i + "*" + j + "=" + (i * j)+"   ");
            //    }
            //    Console.WriteLine();
            //}
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;
            Random random = new Random();
            for (int i=1;i<=100;i++)
            {              
                int num=random.Next(1, 7);//1~6
                switch(num)
                {
                    case 1:
                        num1++;
                        break;
                    case 2:
                        num2++;
                        break;
                    case 3:
                        num3++;
                        break;
                    case 4:
                        num4++;
                        break;
                    case 5:
                        num5++;
                        break;
                    case 6:
                        num6++;
                        break;
                }             
            }
            Console.WriteLine("num1   " + num1);
            Console.WriteLine("num2   " + num2);
            Console.WriteLine("num3   " + num3);
            Console.WriteLine("num4   " + num4);
            Console.WriteLine("num5   " + num5);
            Console.WriteLine("num6   " + num6);
            Console.ReadKey(); 
        }
    }
}
