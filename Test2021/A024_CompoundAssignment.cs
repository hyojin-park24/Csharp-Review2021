/*
  <증감연산자, 감소연산자와 대입연산자의 압축>
    - 변수값을 바꾸어 다시 그 변수에 할당하는 경우 합축하여 사용하는 방법
    ※ 주의사항 ※
    x += y * 3 => x = x + (y * 3)
    - 압축 표현은 모든 이항연산자에 적용됨 ----> '지정 연산자'
 */
using System;
namespace Test2021
{
    class A024_CompoundAssignment
    {
        static void Main(string[] args)
        {
            int x = 32;

            Console.WriteLine(x += 2);   //x에 32저장되어있는 값에서 2를 더하고 다시 x에 대입
            Console.WriteLine(x -= 8);   //x에 34저장되어있는 값에서 8을 빼고 다시 x에 대입
            Console.WriteLine(x *= 3);   //x에 26저장되어있는 값에서 3을 곱하고 다시 x에 대입
            Console.WriteLine(x /= 2);   //x에 78저장되어있는 값에서 2를 나누고 다시 x에 대입
            Console.WriteLine(x++);      //x에 39저장되어있는 값에서 x를 사용 후 증가
                                         //즉 x는 39 출력 후 40으로 저장됨
            Console.WriteLine(--x);      //x에 40저장되어있는 값에서 1을 감소시킨 후 x에 대입

        }
    }
}
