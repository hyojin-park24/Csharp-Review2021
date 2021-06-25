/*비트 연산자*/
using System;

namespace Test2021
{
    class A022_BitwiseOperators
    {
        static void Main(string[] args)
        {
            int x = 14, y = 11, result;

            result = x | y;
            Console.WriteLine("{0} | {1} = {2}", x, y, result);

            result = x & y;
            Console.WriteLine("{0} ^ {1} = {2}", x, y, result);

            result = x ^ y;
            Console.WriteLine("{0} ^ {1} = {2}", x, y, result);

            result = ~x;
            Console.WriteLine("~{0} = {1}", x, result);

            result = x << 2;        //2를 곱하는 효과가 있음
            Console.WriteLine("{0} << 2 = {1}", x, result);

            result = y >> 1;
            Console.WriteLine("{0} >> 1 = {1}", y, result);
        }
    }
}
