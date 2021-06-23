/*
 <C#의 연산자와 식>
  - 연산자 : 식에서 수행할 연산을 지정하는 기호
  [연산의 종류]
    - 산술 연산자 : +,-,*,/,%
    - 논리 연산자 : !,~,&&,||
    - 비트 연산자 : &, |, ^, <<, >>
    - 증감 연산자 : ++, --
    - 관계 연산자 : ==, !=, <, >, <=, >=
    - 문자열 연결 연산자 : +
    - 대입 및 복합 연산자 : =, +=, -=, *=, /=, %/, <<=, >>=, &=, |=, ^=
    - 멤버 연산자 : .
    - 인덱싱 연산자 : []
    - 형변환 연산자 : ()
    - 조건 연산자 : ?:
    - 포인터 및 주소 연산자 : *, ->, &
    - Linq 연산자 : =>
 */
using System;

namespace Test2021
{
    class A016_Operators
    {
        static void Main(string[] args)
        {
            Console.WriteLine(3 + 4 * 5);
            Console.WriteLine((3 + 4) * 5);
            //연산 순서는 좌->우
            Console.WriteLine(3 * 4 / 5);
            Console.WriteLine(4 / 5 * 3);

            int a = 10, b = 20, c;
            Console.WriteLine(c = a + b);
        }
    }
}
