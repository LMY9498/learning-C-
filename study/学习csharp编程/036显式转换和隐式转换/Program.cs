using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036显式转换和隐式转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //隐式转换
            byte myByte = 123;
            int myInt = myByte;//把一个小类型的数据赋值给大类型的变量的时候，编译器会自动进行类型的转换。
            //显式转换（强制类型转换）
            myByte=(byte)myInt;//当把一个大类型赋值给一个小类型的变量的时候，需要进行显式转换，就是加上括号，里面写需要转换的类型。
            //使用Convert命令进行显式转换
            string str = "123";//是int类型的字符串才可以转换为int,double类型//是小数类型的字符串就可以转化为doublele类型
            int num = Convert.ToInt32(str);
            //在一个int double float类型直接加上一个空的字符串，相当于把这个数字转化为一个字符串
            int myNum=1234;
            string str3 = myNum + "";
            //把一个int float double byte类型转换成字符串
            string str2 = Convert.ToString(myNum);
        }

    }
}
