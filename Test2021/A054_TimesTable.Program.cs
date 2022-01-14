using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2021
{
    class A054_TimesTable
    {
        /*이중루프로 구구단 출력*/
        static void Main(string[] args)
        {
            Console.WriteLine("구구단을 할 숫자를 입력하세요 : ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}의 구구단은", n);
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine("{0} * {1} = {2}",n ,i, i * n);
            }
            Console.WriteLine("입니다.");

            Console.WriteLine("1~9까지의 구구단은");
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine("{0} X {1} = {2}", i,j, i*j);
                }
            }
            Console.WriteLine("입니다.");

            //C# 예제문 
            for (int y = 1; y <= 9; y++)
            {
                for (int x = 2; x <= 9; x++)
                    Console.Write("{0}X{1} = {2,2}   ", x,y,x*y);
               Console.WriteLine();
                
            }

        }
    }
}
