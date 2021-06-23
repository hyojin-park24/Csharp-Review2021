/*
    <산술 연산자>
     :4칙연산 (+,-, *, /, %)
    - 중요한것 "자료형"
      : 피연산자의 자료형에 따라 계산 결과값의 자료형도 결정됨.
 */
using System;

namespace Test2021
{
    class A017_ArithmeticOperators
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수의 계산");
            Console.WriteLine(123 + 45);
            Console.WriteLine(123 - 45);
            Console.WriteLine(123 * 45);
            Console.WriteLine(123 / 45);
            Console.WriteLine(123 % 45);

            Console.WriteLine("\n실수의 계산");
            Console.WriteLine(123.45 + 67.89);
            Console.WriteLine(123.45 - 67.89);
            Console.WriteLine(123.45 * 67.89);
            Console.WriteLine(123.45 / 67.89);
            Console.WriteLine(123.45 % 67.89);      //C와 C++과 달리 실수도 %연산이 가능함~!
        }
    }
}
