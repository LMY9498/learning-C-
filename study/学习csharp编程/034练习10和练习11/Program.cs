using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034练习10和练习11
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int i=1;i<6;i++)
            //{
            //    Console.WriteLine(i*i);
            //}
            //int index = 1;
            //while(index<6)
            //{
            //    Console.WriteLine(index * index);
            //    index++;
            //}
            //int num = 1;
            //do
            //{
            //    Console.WriteLine(num * num);
            //    num++;
            //} while (num < 6);
            while(true)
            {
                string str = Console.ReadLine();
                bool isAllUpperChar = true;
                for (int i = 0; i < 5; i++)
                {
                    if (str[i] >= 'A' && str[i] <= 'Z')
                    {

                    }
                    else
                    {
                        isAllUpperChar = false;
                        break;
                    }
                }
                if (isAllUpperChar == false)
                {
                    Console.WriteLine("请从新输入");
                }
                else
                {
                    break;
                }
            }         
            Console.ReadKey();
        }
    }
}
