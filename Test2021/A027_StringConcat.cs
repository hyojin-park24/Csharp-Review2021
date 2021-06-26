/*
    <문자열을 연결하는 네 가지 방법>
    (1) '+' 연산자 사용 
    (2) 문자열 보간(string interpolation)
        - $문자를 사용하여 문자열 변수의 값을 표현 할 수 있다.
    (3) String.Format
    (4) String.Concat()과 String.Join()
        - Concat()메소드 : 문자열을 연결한 새로운 문자열을 리턴
 */

using System;

namespace Test2021
{
    class A027_StringConcat
    {
        static void Main(string[] args)
        {
            string userName = "bikang";     //bikang으로 userName초기화
            string date = DateTime.Today.ToShortDateString();   //오늘날짜로 초기화 ToShortDateString: 짧은 날짜 문자열 표현


            string strPlus = "Hello" + userName + ". Today is " + date + ".";
            Console.WriteLine(strPlus);

            string strFormat = String.Format("Hello {0}. Today is {1}.",
                                userName, date);
            Console.WriteLine(strFormat);

            string strInterpolation = $"Hello {userName}. Today is {date}.";
            Console.WriteLine(strInterpolation);

            string strConcat = String.Concat("Hello", userName, ". Today is ", date, ".");
            Console.WriteLine(strConcat);

            string[] animals = { "mouse", "cow", "tiger", "rabbit", "dragon" };
            string s = String.Concat(animals);
            Console.WriteLine(s);
            s = String.Join(",", animals);      //요소마다 ","로 구분해주는 메소드
            Console.WriteLine(s);
        }
    }
}
