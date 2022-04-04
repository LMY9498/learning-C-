using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022使用if_else_if语句做多条件判断
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("您考了多少分");
            int score = Convert.ToInt32(Console.ReadLine());
            if(score>=90)
            {
                Console.WriteLine("优秀");
            }
            else if(score>=80&&score<=89)
            {
                Console.WriteLine("良");
            }
            else if(score>=60&&score<=79)
            {
                Console.WriteLine("中");
            }
            else
            {
                Console.WriteLine("差，继续努力哦");
            }
            Console.ReadKey();
        }
    }
}
