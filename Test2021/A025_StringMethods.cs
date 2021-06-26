/*
    <String 클래스>
    - 문자열(string)은 프로그램에서 가장 많이 쓰이는 자료형 
    - 문자열 : " ", 문자(char) ' '
    - int가 Int32의 별명인 것 처럼 string도 String의 별명이다
      * 대소문자 상관없이 사용 가능
    - C#의 string은 '불변(Immutable)'이다
    - 한 번 문자열이 설정되면 다시 변경할 수 없다.
    [String Class의 속성 Length]
    : String객체의 길이, 특정 위치에 있는 문자를 가져올 수 있다 
       (배열처럼 인덱스로 string 사용 가능)
     ** s.Length, s[8]과 같이 사용 가능, 값을 가져올 수만 있고 설정할 수는 없음
     ** int i = s.Length (O) / s.Length = 5 (X)
    [String Class의 필드 Empty]
    - 이 필드는 static readonly이다.
      * readonly (읽기 전용)
      * 한번 값이 정해지면 값을 수정할 수 없다
      * 생성자에서 값을 초기화 할 수 있다
      * 지역변수에서는 readonly를 사용할 수 없다.
    - NULL과 다르다.
      * NULL은 선언되고 할당되지 않은 스트링 
      * Empty("")는 빈 문자열 

    [String Class Method]
    - Insert : string안의 특정 위치에 string을 삽입합니다.
    - Contains : 특정 문자 또는 문자열을 포함하는지 true/false로 리턴
    - Compare To : string을 비교해서 작으면 -값, 같으면 0, 크면 +값을 리턴
    - IndexOf : string에서 특정 문자 또는 문자열이 처음으로 나오는 index를 리턴
    - LastIndexOf : string에서 특정 문자 또는 문자열이 마지막으로 나오는 index를 리턴
    - PadLeft : string 앞에 특정 문자를 삽입하여 글자 수를 맞춤
    - Remove : stirng에서 substring을 삭제
    - ToLower : string의 문자를 소문자로 변환
    - ToUpper : string의 문자를 대문자로 변환
    - Trim : string에서 앞뒤의 공백문자 또는 특정 문자를 제거
    - TrimEnd : string의 뒤의 공백문자 또는 특정 문자를 제거
    - TrimStart : string의 앞의 공백문자 혹은 특정 문자를 제거
    - Split : string에서 substring을 추출하여 새로운 string배열을 리턴
    - Copy To : string의 일부분을 문자 배열로 복사
    - Substring : string에서 특정 문자에서 끝까지의 substring을 추출

    [String Class Static(정적) Method]
    - 클래스 이름 string뒤에 .연산자와 함께 사용
    - Concat : 한 개 이상의 substring을 합쳐서 새로운 string을 만듦
    - Compare : 두 개의 string을 비교해서 상대적인 위치를 리턴
    - Copy : 현재 string을 복사하여 새로운 string을 만듦
    - Format : 문자열을 포맷에 맞추어 변경 (형식표현)
    - Join : 배열이나 컬렉션의 멤버들을 모아서 새로운 string을 만듦, 이때 멤버 사이에 구분자를 삽입
    
 */
using System;

namespace Test2021
{
    class A025_StringMethods
    {
        static void Main(string[] args)
        {
            string s = " Hello, World! ";
            string t;

            Console.WriteLine(s.Length);
            Console.WriteLine(s[8]);
            Console.WriteLine(s.Insert(8, "C# "));
            Console.WriteLine(s.PadLeft(20, '.'));
            Console.WriteLine(s.PadRight(20, '.'));
            Console.WriteLine(s.Remove(6));
            Console.WriteLine(s.Remove(6, 7));
            Console.WriteLine(s.Replace('l', 'm'));
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.ToUpper());
            Console.WriteLine('/' + s.Trim() + '/');
            Console.WriteLine('/' + s.TrimStart() + '/');
            Console.WriteLine('/' + s.TrimEnd() + '/');

            string[] a = s.Split(',');
            foreach (var i in a)
                Console.WriteLine('/' + i + '/');

            char[] destination = new char[10];
            s.CopyTo(8, destination, 0, 6);
            Console.WriteLine(destination);

            Console.WriteLine('/' + s.Substring(8) + '/');
            Console.WriteLine('/' + s.Substring(8, 5) + '/');

            Console.WriteLine(s.Contains("11"));
            Console.WriteLine(s.IndexOf('o'));
            Console.WriteLine(s.LastIndexOf('o'));
            Console.WriteLine(s.CompareTo("abc"));

            Console.WriteLine(String.Concat("Hi~", s));
            Console.WriteLine(String.Compare("abc", s));
            Console.WriteLine(t = String.Copy(s));

            String[] val = { "apple", "orange", "grape", "pear" };
            String result = String.Join(",", val);
            Console.WriteLine(result);
            {

            }
        }
    }
}
