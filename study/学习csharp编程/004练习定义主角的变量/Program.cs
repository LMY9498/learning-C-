using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004练习定义主角的变量
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "siki";
            int hp = 100;
            int lever = 34;
            float exp = 345.3f;
            Console.WriteLine("主角的名字是:{0}\n血量:{1}\n等级:{2}\n经验值:{3}", name, hp, lever, exp);
            Console.ReadKey();
        }
    }
}
