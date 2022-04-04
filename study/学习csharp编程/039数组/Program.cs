using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _039数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一种数值的初始化方式：声明时赋值
            int[] scores = { 12, 23, 34, 45, 56, 67, 78, 89 };
            //第二种数值创建的方式方式
            int[] scores2 = new int[10];
            int[] scores3;
            scores3 = new int[10];
            //第三种方式
            int[] scores4 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            char[] charArray = new char[2] { 'a','b' };
            string[] names = new string[3] {"sdd","dfff","ddf"};
        }
    }
}
