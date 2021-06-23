/*
    <문자열과 숫자의 변환>
    Ex) Console.ReadLine()으로 입력받은 값은 string인데 계산을 하려면 이를 숫자로 바꾸어야 함.
    - 문자열을 숫자로 바꾸거나 반대로 숫자를 문자열로 바꾸어야 할 경우가 많다.

    1) 숫자형식(int, float, double등)에 있는 Parse() OR TryParse() 메소드 사용
       - 문자열의 앞뒤에 있는 공백은 무시
       - 문자열 중간에 공백이 있으면 에러 발생 
       - 문자열이 숫자를 나타내지 않는 경우 : Parse()-ERROR, TryParse()-False를 리턴함

    2) Convert클래스의 메소드 사용 
 */
using System;

namespace Test2021
{
    class A014_StringToNumber
    {
        static void Main(string[] args)
        {
            string input;
            int value;

            /*입력 함수*/
            Console.WriteLine("1. int로 변환할 문자열을 입력하세요: ");      //문자열 출력
            input = Console.ReadLine();                                      //문자열 입력받아 string input에 저장
            bool result = Int32.TryParse(input, out value);                  //Int32.TryParse()메소드로 input을 정수 value로 변환

            /*입력 결과 출력 조건문 및 출력 함수*/
            if (!result)
                Console.WriteLine("'{0}'는 int로 변환될 수 없습니다.\n", input);
            else
                Console.WriteLine("int '{0}'으로 변환되었습니다.\n", value);

            /*입력함수*/
            Console.Write("2. double로 변환할 문자열을 입력하세요: ");
            input = Console.ReadLine();

            /*예외처리*/
            try
            {
                //Parse()는 바로 에러시 종료이기 때문에 예외처리로 함수 처리
                double m = Double.Parse(input);                             
                //double m = Convert.ToDouble(input);     //동일한 결과 출력
                //Convert클래스 메소드들은 Parse()와 똑같이 동작함
                Console.WriteLine("double '{0}'으로 변환되었습니다.\n", m);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);       //e.Message : 컴파일 자동 오류 메시지 출력
            }
        }
    }
}
