/*
 if~else 조건문

 [if~else]
 - 조건식에 따라 프로그램의 흐름을 결정하기 위해 사용되는 조건문
 - true / fasle로 계산
 - else if문을 원하는 만큼 추가하여 확장 가능
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 입력한 년도가 윤년 / 평년인지 판단하여 출력하는 프로그램
// 윤년 : 4로 나누어지고 100으로 나누어지지 않거나 400으로 나누어지는 연도 
namespace Test2021
{
    class A040_LeapYear
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());   //콘솔에서 값을 입력받아 정수로 변환하여 int형 변수 year에 할당

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)    //4로 나누어지고 100으로 나누어지지 않거나 400으로 나누어지는
                Console.WriteLine("{0}는 윤년", year);                 // true : 윤년
            else
                Console.WriteLine("{0}는 평년", year);                 // false : 평년

            if (DateTime.IsLeapYear(year))              // DataTime구조체에서 제공되는 IsLeapYear()메소드 사용
                Console.WriteLine("{0}는 윤년", year);  // true : 윤년
            else
                Console.WriteLine("{0}는 평년", year);  // false : 평년
        }
    }
}
