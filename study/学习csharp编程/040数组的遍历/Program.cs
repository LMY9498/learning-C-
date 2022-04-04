using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040数组的遍历
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 23, 23, 45, 67, 88, 99 };
            for(int i=0;i<scores.Length;i++)
            {
                Console.WriteLine(scores[i]);
            }
            int j = 0;
            while(j<scores.Length)
            {
                Console.WriteLine(scores[j]);
                j++;
            }
            foreach(int temp in scores)//foreach会一次取到数组中的值，然后赋值给temp,然后执行循环体。
            {
                Console.WriteLine(temp);
            }
            Console.ReadKey();
        }
    }
}
