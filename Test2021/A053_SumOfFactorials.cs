using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2021
{
    class A053_SumOfFactorials
    {
        /*1!~n!까지를 출력하고 그 합을 계산하는 프로그램*/
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요 : ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                int fact = 1;
                for (int j = 2; j <= i; j++)
                {
                    fact *= j;
                }
                sum += fact;
                Console.WriteLine("{0,2}! = {1,10:##}",i,fact);
            }
            Console.WriteLine("1! + 2! + *** + {0}! = {1:N0}\n", n, sum);
        }
    }
}
