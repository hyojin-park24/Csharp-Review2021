using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*구구단 출력*/

namespace Test2021
{
    class A045_MultiplicationTable
    {
        static void Main(string[] args)
        {
            // 특정 숫자 지정 구구단 
            Console.WriteLine("구구단을 출력할 숫자를 입력하세요 : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", n,i, n*i);
            }

            //1~9 전체 구구단 
            Console.WriteLine("1~9의 구구단은,");
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                }
            }
        }
        
    }
}
