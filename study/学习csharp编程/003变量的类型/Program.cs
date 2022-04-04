using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003变量的类型
{
    class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 34;
            int score = 6000;
            long count =1000000000;
            Console.WriteLine("byte:{0} int:{1} long:{2}", myByte, score, count);

            //float myFloat = 12.5;//默认double类型
            float myFloat = 12.5f;
            double myDouble = 12.6;
            Console.WriteLine("float:{0}double:{1}", myFloat, myDouble);

            char myChhar = 'a';
            string myString = "a";
            bool myBool = true;
            Console.WriteLine("char:{0} string:{1} bool:{2}", myChhar, myString, myBool);
       
            Console.ReadKey();

        }
    }
}
