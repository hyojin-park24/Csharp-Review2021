using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2021
{
    class A047_Power
    {
        /*x의 y승 구하기, 제곱근 루트값 구하기*/

        static void Main(string[] args)
        {
            Console.WriteLine("x의 y승을 계산합니다.");
            Console.Write("x를 입력하세요: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y를 입력하세요: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("제곱근 z를 입력하세요: ");
            int z = int.Parse(Console.ReadLine());
            int pow = 1;        //숫자를 곱해가므로 0이 아닌 1로 초기화

            for (int i = 0; i < y; i++)
            {
                pow *= x;
            }

            double root = Math.Sqrt(z);
            Console.WriteLine("{0}의 {1}승은 {2}입니다.", x, y, pow);
            Console.WriteLine("{0}의 제곱근 루트는 {1}입니다.", z, root);
            
        }
    }
}
