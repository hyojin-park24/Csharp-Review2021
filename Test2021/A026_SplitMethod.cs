/*
    <String.Split()메소드를 사용한 문자열 구문 분석>
    - 문자열에서 숫자들을 추출해서 더해줄때 사용할 메소드 Split
    - 
 */

using System;

namespace Test2021
{
    class A026_SplitMethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine("더하고자 하는 숫자들을 입력하세요: ");
            string s = Console.ReadLine();
            Console.WriteLine(s);

            int sum = 0;
            string[] v = s.Split();
            foreach (var i in v)
            {
                sum += int.Parse(i);
                //배열의 각 요소i를 정수로 변환하여 변수sum에 더하고 결과를 출력
            }
            Console.WriteLine("결과는 {0}", sum);
            {

            }
        }
    }
}
