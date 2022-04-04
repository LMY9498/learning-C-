using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013练习一二
{
    class Program
    {
        static void Main(string[] args)
        {
            //int hp;
            //float x, y, z;
            //float speed;
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("num1:{0} num2:{1}", num1, num2);
            Console.ReadKey();

        }
    }
}
