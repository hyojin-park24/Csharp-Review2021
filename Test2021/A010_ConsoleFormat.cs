/*
    <형식지정자를 사용한 Console.WriteLine 메소드>
    - 출력할 때 형식지정자를 사용 할 수 있다.
    + 표준 숫자 형식 지정자 이미지 필요
    - 현재 시간 오전 12시16분 오늘은 21년 6월23일 수요일이다.
    - 필사를 마치고 운동하고 복습중이다.
    - 미치도록 하기싫지만 그래도 한다. 근데 또 하면 재밌다.
    - 오늘은 양력으로 아버지 생신이신데 어떻게해드리면 좋을까
    - 오늘도 많은 지혜가 필요한 날이다.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2021
{
    class A010_ConsoleFormat
    {
        static void Main(string[] args)
        {
            Console.Clear();            //콘솔창의 모든 글자 지우기

            Console.WriteLine("Standard Numeric Format Specifiers");
            Console.WriteLine(
                "(C) Currency                  {0:c}\n" +
                "(D) Decimal                   {0:D}\n" +
                "(E) Scientific                {1:E}\n" +
                "(F) Fixed point               {1:F}\n" +
                "(G) General                   {0:G}\n" +
                "(N) Number                    {0:N}\n" +
                "(P) Percent                   {1:P}\n" +
                "(R) Round-trip                {1:R}\n" +
                "(X) Hexadecimal               {0:X}\n",
                -12345678, -1234.5678f);

            // 9가지 형식지정자를 사용하여 -12345678{0}과 -1234.5678f{1}을 출력하게함
            // Ex) {0:C2}는 C형식지정자 소수점 아래 두자리로 출력한다.
            // Ex) {0,20:C2}는 전체 20자리 중 소수점 두자리까지 출력한다. 사용되지 않은 부분은 빈칸으로 출력됨.
        }
    }
}
