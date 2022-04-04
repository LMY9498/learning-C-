using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015练习五六
{
    class Program
    {
        static void Main(string[] args)
        {
            //double shangdi = Convert.ToDouble(Console.ReadLine());
            //double xiadi = Convert.ToDouble(Console.ReadLine());
            //double gao = Convert.ToDouble(Console.ReadLine());
            //double area = (shangdi + xiadi) * gao / 2;
            //Console.WriteLine(area);
            //Console.ReadKey();

            double r = Convert.ToDouble(Console.ReadLine());
            double c = 2 * r * 3.1415926;
            double s = r * r * 3.1415926;
            Console.WriteLine("周长" + c);
            Console.WriteLine("面积" + s);
            Console.ReadKey();

        }
    }
}
