/*
    <문자열 검색>
    (1) Contains() 메소드
        - 스트링에 특정 문자열이 포함되어 있는지를 체크함
        - bool(true, false)리턴
    (2) IndexOf() 메소드
        - 문자열에서 특정 문자 또는 문자열이 나타나는 인덱스를 리턴
        - 인덱스는 0부터 시작, 문자열이 없을 때는 -1을 리턴 
    (3) 대소문자를 구분하지 않는 비교
        - Contains() : 대소문자 구분
        - StringComparison열거형 : 대소문자 구분없이 비교, 언어, 정렬순서, 대소문자 구분 여부 등을 표현
    (4) String.StartsWith()와 String.EndsWith() 메소드 
        - StartWith() : 문자열이 특정 문자열로 시작되는지를 알려줌
        - EndWith() : 특정 문자열로 끝나는지를 알려줌 
 */

using System;

namespace Test2021
{
    class A028_StringContains
    {
        static void Main(string[] args)
        {
            string s1 = "mouse, cow, tiger, rabbit, dragon";
            string s2 = "Cow";      // s2 = "cow"           //s1에 Cow가 없어서 false값 출력됨
            bool b = s1.Contains(s2);
            Console.WriteLine(" '{0}' is in the string '{1}' : {2}", s2, s1, b);

            if(b)
            {
                int index = s1.IndexOf(s2);
                if (index >= 0)
                    Console.WriteLine("'{0} begins at index {1}", s2, index);
            }

            if(s1.IndexOf(s2, StringComparison.CurrentCultureIgnoreCase) >= 0)
            {
                Console.WriteLine("'{0}' is in the string '{1}'", s2, s1);
            }
        }
    }
}
