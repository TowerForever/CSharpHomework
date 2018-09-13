using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数字1：");
            double number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入数字2：");
            double number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("结果：" +"\n"+ number1 * number2);
        }
    }
}
