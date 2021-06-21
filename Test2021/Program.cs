/* 2021.06.21 첫 C#복습
   <콘솔에서 읽고 쓰기>
    - 콘솔 : 입력은 키보드로, 출력은 모니터에서 하는 것
    - 컴퓨터에 연결되어 시스템의 상황을 모니터 하는데 사용되는 터미널을 의미 
    - 모니터 + 키보드의 조합 장치 

    [콘솔 입출력 메소드 및 동작]
    - int Console.Read() : 콘솔에서 한 글자를 읽는다.
    - string Console.ReadLine() : 콘솔에서 한 줄을 읽는다.
    - void Console.Write(string) : 콘솔에 문자열(스트링)을 출력한다.
    - void Console.WriteLine(string) : 콘솔에 문자열(스트링)을 출력하고 줄을 바꾼다.
 */

using System;

namespace Test2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello ");                    //콘솔창에 줄바꿈 하지않고 Hello출력
            Console.WriteLine("World!");                //콘솔창에 World!출력 후 줄바꿈
            Console.Write("이름을 입력하세요:  ");      //콘솔창에 문자열 출력 후 줄바꿈하지 않음

            /*이름 입력 받기*/
            string name = Console.ReadLine();       // 이름 입력받기
                                                    // 입력받은 문자열을 name변수에 저장
            Console.Write("안녕하세요, ");          // 콘솔창에 문자열 출력 후 줄바꾸지 않음
            Console.Write(name);                    // 콘솔창에 문자열 저장한 name변수 출력 후 줄바꾸지 않음
            Console.WriteLine("님!");               // 콘솔창에 문자열 출력 후 줄바꿈
        }
    }
}
