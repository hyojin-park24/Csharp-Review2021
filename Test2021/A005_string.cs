/*
    <문자와 문자열>
    - 문자를 표시 하는 방법 : ''
    - 문자 : ''
    - 문자열 : ""
    - 문자를 저장하기 위해서 string 형식의 변수를 사용한다. 
    [string의 특징]
    1) string의 개별 문자에 대한 읽기 전용 액세스를 위해 []연산자 사용 가능
        Ex) string str = "test"
            char x = str[2];    // x = 's';
    2) 이스케이프 시퀀스 사용 가능 
        Ex) \n(줄바꿈), '\"(따옴표), \t(탭)
    3) "앞에 @를 쓰면 이스케이프 시퀀스는 무시
        Ex) Console.WritLine(@"abc\nabc);       //"abc\nabc"출력
    4) 연산자 3가지 
       - == : 같다
       - != : 같지 않다
       - +  : 연결하다
 */

using System;

namespace Test2021
{
    class A005_string
    {
        static void Main(string[] args)
        {
            string a = "Hello";             //string a변수에 hello저장
            string b = "h";                 //string b변수에 h 저장

            b = b + "ello";                 //b에 ello연결
            Console.WriteLine(a == b);      //a와 b를 비교 후 같으면 true 출력 후 줄바꿈
            Console.WriteLine("b = " +b);   // b=을 b앞에 연결 후 b출력하고 줄바꿈

            int x = 10;                     //int형 변수 x에 10 대입
            string c = b + '!' + " " + x;   //string c변수에 b에 저장된 문자열 출력 후 !연결 빈칸 후 x연결 출력
            Console.WriteLine("c = " + c);  //c=를 c앞에 연결 후 c출력하고 줄바꿈

        }
    }
}
