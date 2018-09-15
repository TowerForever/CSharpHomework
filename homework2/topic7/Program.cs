using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//编程求一个整数数组的最大值、最小值、平均值和所有数组元素的和
namespace topic7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("你想要输入多少个数字呢：");int length = 1;
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入你想要的一系列整数：");
            int[] ngroup=new int[length];
            for (int i = 0; i < length; i++)
            {
                ngroup[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max=0, min=ngroup[0], sum=0;double average=0;
            for (int i = 0; i < length; i++)
            {
                if (ngroup[i] > max) max = ngroup[i];
                if (ngroup[i] < min) min = ngroup[i];
                sum = sum + ngroup[i];
                average = sum / 10.0;
            }Console.WriteLine("最大值："+max+" "+"最小值："+min+" "
                +"总和："+sum+" "+"平均值："+average);
        }
    }
}
