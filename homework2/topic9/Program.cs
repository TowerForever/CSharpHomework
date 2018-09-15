using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//用“埃氏筛法”求2——100以内的素数。2——100以内的数，先去掉2的倍数，
//再去掉3的倍数，再去掉4的倍数，以此类推......最后剩下的数就是素数
namespace topic9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[99];
            for (int i = 2; i < 101; i++)
            {
                array[i - 2] = i;
            }for (int i = 0; i < 99; i++)
            {
                int j;
                for ( j=2; j < array[i]; j++)
                {
                    if (array[i] % j == 0) break;

                }
                if (array[i]==j) for (int k = i+1; k < 99; k++)
                    {
                        if (array[k] % array[i] == 0) array[k] = 0;
                    }
            }
            for (int k = 0; k < 99; k++)
                if (array[k] != 0) Console.WriteLine(array[k]);


        }

    }
}
