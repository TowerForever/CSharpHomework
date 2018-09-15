using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//编写程序输出用户指定数据的所有素数因子
namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输出某数字素数因子，\n请输入你的数字：");
            ulong number = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("=");
            for (uint divisor = 2; (divisor <= number)&&(number!=1);)
            {
                if (number % divisor == 0) {
                    
                    Console.WriteLine(divisor);
                    number = number / divisor;
                } 
                else
                {
                    divisor++;
                    for (uint i = 2; i < divisor; i++)
                    {
                        while (divisor % i == 0) { divisor++; i = 2; }
                        
                    }
                }
            }

            
            
        }
    }
}
