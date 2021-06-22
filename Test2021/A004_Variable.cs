/*
    <변수 선언 및 자료형(Type)>
    - 변수 : 값(데이터)을 저장하는 곳
    - 컴퓨터에서 모든 데이터는 메모리의 특정 위치에 저장되기 때문에 변수가 필요함 
    [C#의 자료형 종류]
    - bool, byte, sbyte, char, decimal, double, float, int, unit, long, ulong, short, ushort, string
    -                      8bit                  16bit                 32bit               64bit
    - 부호 있는 정수       sbyte                short                  int                 long
    - 부호 없는 정수       byte                 ushort                 uint:               ulong
    - 부동 소수점                                                      float               double
    - Decimal              128bit-decimal
    ※ var형
     - 메소드 범위에서 선언된 변수에 암시적 "형식" var을 사용 가능
     - var형식은 지역변수로만 사용할 수 있음
     - 암시적 형식 지역 변수는 형식을 직접 선언한 것 처럼 강력한 형식이지만 컴파일러가 형식을 결정함 
     Ex) var i = 10;    //암시적 형식
         int i = 10;    //명시적 형식
 */
using System;

namespace Test2021
{
    class A004_Variable
    {
        static void Main(string[] args)
        {
            Console.Write("이름을 입력하세요: ");           //문자열 출력하고 줄바굼 안함
            string name = Console.ReadLine();               //string변수 name을 선언하고 입력받은 문자열을
                                                            //name 변수에 할당한 후 ReadLine으로 콘솔에 입력되는
                                                            //값을 무조건 string으로 반환
            Console.Write("나이를 입력하세요: ");           //문자열 출력하고 줄바꿈 안함
            int age = int.Parse(Console.ReadLine());        //int형 변수 age를 선언하고 입력받은 문자열을 정수로 바꿔 할당
            Console.Write("키를 입력하세요(cm): ");         //문자열 출력하고 줄바꿈 안함
            float height = float.Parse(Console.ReadLine()); //float 변수 height를 선언하고 입력받은 문자열을 float로 바꿔 할당

            Console.Write("안녕하세요, ");                   //문자열 출력하고 줄바꿈 안함
            Console.Write(name);                             //저장된 변수 name을 출력하고 줄바꿈 안함
            Console.WriteLine("님!");                        //문자열 출력하고 줄바꿈 함

            Console.Write("나이는 ");                        //문자열 출력하고 줄바꿈 안함
            Console.Write(age);                              //저장된 변수age를 출력하고 줄바꿈 안함
            Console.Write("세, 키는 ");                      //문자열 출력하고 줄바꿈 안함
            Console.Write(height);                           //저장된 변수height를 출력하고 줄바꿈 안함
            Console.WriteLine("cm 이군요!");                 //문자열 출력하고 줄바꿈 함 
        }
    }
}
