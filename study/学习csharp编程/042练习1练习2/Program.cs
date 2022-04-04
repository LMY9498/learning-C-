using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042练习1练习2
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int i=100;i<1000;i++)
            //{
            //    int ge = i % 10;
            //    int shi = (i / 10) % 10;
            //    int bai = i / 100;
            //    int res = ge * ge * ge + shi * shi * shi + bai * bai * bai;
            //    if(res==i)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            int sum = 364;//表示可以喝多少可乐
            int numEmpty = sum;//喝完，表示现在有多少个空的瓶子
            while(numEmpty>=3)
            {             
                int newCount = numEmpty / 3;//表示可以兑换多少新的可乐
                sum += numEmpty / 3;//表示总共喝了多少可乐，原来的加上新兑换出来的
                int remainEmpty = numEmpty % 3;//表示剩余几个瓶子没有兑换
                numEmpty = newCount+remainEmpty;//表示兑换且喝了之后，还有多少空的瓶子
            }
            Console.WriteLine("我们一共喝了" + sum + "瓶可乐，剩余的空瓶子个数是" + numEmpty);
            Console.ReadKey();
        }
    }
}
