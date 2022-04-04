using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _038结构体
{
    struct Position
    {
        public float x;
        public float y;
        public float z;
    }
    enum Diection
    {
        West,
        North,
        East,
        South
    }
    struct Path
    {
        public float distance;
        public Diection dir;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //当使用结构体声明变量的时候，相当于使用结构体中所有的变量去声明
            Position enenmy1Position;
            //通过.加上属性名来访问结构体中指定的变量
            enenmy1Position.x = 34;
            enenmy1Position.y = 1;
            enenmy1Position.z = 34;
            Path path1;
            path1.dir = Diection.East;
            path1.distance = 1000;
        }
    }
}
