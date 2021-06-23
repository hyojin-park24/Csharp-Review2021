/*
    <형식지정자를 사용하는 String.Format()과 ToString()>
    * 형식 지정자
      - 표준 형식지정자
        1) 숫자 : N(Number), D(Decimal), C(Currency), F(Fixed Poin), E(Scientific)
            => 수로 정밀도 표현 가능
        2) Console.WritLine(), String.Format(), ToString() 에서 사용

      - 커스텀 형식 지정자
        : 기호를 이용하여 쉽게 포맷 지정 가능  {"#.##"}, {"#,#.##"}
        # : Digit placeholder(0이 앞에 붙지 않음)
        0 : Zero placeholder (0이 앞에 붙음)
        . : 소수점(Decimal point)
        , : 천 자리(Thousands operator)
        ; : 섹션 구분 기호(Section separator)
            -> 섹션 구분 기호는 독특한 기능 존재 : ;으로 양,음,0의 값을 구분할 수 있다.
               Ex) -123 = (123)으로 표시 => "{#,##0; (#,##0);zero}" => 음수는 괄호안 숫자로, 0은 zero로 출력함
 */
using System;

namespace Test2021
{
    class A011_FormatSpecifier
    {
        static void Main(string[] args)
        {
            /*형식 지정자 - Console.WriteLine*/
            Console.WriteLine("{0:N2}", 1234.5678);     //1,234.57
            Console.WriteLine("{0:D8}", 1234);          //00001234
            Console.WriteLine("{0:F3}", 1234.56);       //1234.560
            Console.WriteLine("{0,8}", 1234);           //____1234
            Console.WriteLine("{0,-8}", 1234);          //1234____

            /*String.Format()*/
            string s;
            s = string.Format("{0:N2}", 1234.5678);
            Console.WriteLine(s);

            s = string.Format("{0:D8}", 1234);
            Console.WriteLine(s);

            s = string.Format("{0:F3}", 1234.56);
            Console.WriteLine(s);

            /*ToString()*/
            Console.WriteLine(1234.5678.ToString("N2"));
            Console.WriteLine(1234.ToString("D8"));
            Console.WriteLine(1234.56.ToString("F3"));
            //ToString 메서드 : 모든 변수에는 해당 내용을 문자열로 반환할 수 있도록 하는 메서드

            /*커스텀 형식 지정자*/
            Console.WriteLine("{0:#.##}", 1234.5678);
            Console.WriteLine("{0:0,0.00}", 1234.5678);
            Console.WriteLine("{0:#,#.##}", 1234, 5678);
            Console.WriteLine("{0.000000.00}", 1234.5678);

            /*섹션 구분 기호*/
            Console.WriteLine("{0:#,#.##;(#,#.##);zero}", 1234.567);
            Console.WriteLine("{0:#,#.##;(#,#.##);zero}", -1234.567);
            Console.WriteLine("{0:#,#.##;(#,#.##);zero}", 0);
        }
    }
}
