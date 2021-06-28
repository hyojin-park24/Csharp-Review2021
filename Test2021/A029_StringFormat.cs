/*
    <Stirng.Format의 날짜와 시간 형식 지정>
    - 지정된 형식에 따라 객체, 변수, 수식의 값을 문자열로 변화하여 다른 문자열에 삽입
    - 포맷 문자열에 인덱스를 사용하여 표현하고자 하는 객체, 변수, 수식(포맷아이템)을 나타냄
    - 포맷 문자열 뒤에 나오는 파라미터는 0부터 순서대로 번호가 부여됨
    - {0:C}와 같이 인덱스 뒤에 콜론과 함께 형식지정자가 나올 수 있음
    - 통화 : C, 날짜 : d, 시간 : t ----> 국가마다 표현이다르기 때문에 컴퓨터에 설정된 국가에 따라 다르게 표시됨
 */

using System;

namespace Test2021
{
    class A029_StringFormat
    {
        static void Main(string[] args)
        {
            string max = String.Format("0x{0:X} {0:E} {0:N}", Int64.MaxValue);  
            //Int64.Maxvalue를 각각 16진수형, 지수형, 구분자(,)가 있는 숫자형으로 변환하여 string max에 할당 후 출력
            //인덱스 모두 {0}이며 형식지정자만 다르다
            Console.WriteLine(max);

            Decimal exchangeRate = 1129.20m;    //decimal형의 변수 exchangeRate 선언하고 값 할당

            /*변수값 출력*/
            string s = String.Format("현재 원달러 환율은 {0}입니다.", exchangeRate);
            Console.WriteLine(s);

            /*통화형식 출력*/
            s = String.Format("현재 원달러 환율은 {0:C2}입니다.", exchangeRate);
            //C는 통화형식으로 화폐 단위인 원ㅇ르 표시하는 \기호와 3자리마다 콤마를 넣어준다.
            Console.WriteLine(s);

            /*현재 날짜와 시간 출력*/
            s = String.Format("오늘 날짜는 {0:d}, 시간은 {0:t} 입니다.", DateTime.Now);
            //DateTime.Now : 현재 날짜와 시간을 가져옴
            Console.WriteLine(s);

            /*TimeSpan 구조체 포맷 출력*/
            TimeSpan duration = new TimeSpan(1, 12, 23, 62);
            //구조체 변수 duration선언 후 초기값 (new)을 1일 12시간 23분 26초로 세팅
            string output = String.Format("소요 시간 : {0:c}", duration);
            // {0:c}로 포맷 후 출력
            Console.WriteLine(output);
        }
    }
}
