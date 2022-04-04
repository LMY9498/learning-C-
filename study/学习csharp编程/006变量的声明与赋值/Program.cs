using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _006变量的声明与赋值
{
    class program
    {
        //Main必须是大写，不然不识别程序入口
        static void Main(string[] args)
        {
            //int age;
            //age = 25;
            int age = 25;
            age = 45;
            int hp, mp=50, exp=69;
            hp = 100;
            Console.WriteLine("hp:{0} mp:{1} exp:{2}",hp,mp,exp);
            Console.ReadKey();
        }
    }
}
