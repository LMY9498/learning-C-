using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _037枚举类型
{
    enum GameState//默认存储类型为int
    //enum GameState:byte//修改该枚举类型的存储类型为byte
    {
        Pause,//0//=10
        Failed,//1//11
        Success,//2//12
        Start//3//13
    }
    class Program
    {
        static void Main(string[] args)
        {
            GameState state = GameState.Start;
            Console.WriteLine(state);
            if(state==GameState.Start)
            {
                Console.WriteLine("游戏开始了");
            }
            int num = (int)GameState.Start;
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
