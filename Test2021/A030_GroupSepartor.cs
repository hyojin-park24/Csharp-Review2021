/*
    <그룹 분리자를 넣는 방법>
    - 큰 수를 표시할 때 사용하는 그룹 구분자(,)를 넣는 프로그램 만들기
    - 콤마 : 그룹 분리자(Group Separator)
    - 표준 형식지정자 중 N이 그룹 분리자를 표시해줌
    - N 형식지정자는 디폴트로 소수점 아래 두자리를 표시함
    - 소수점 아래 자릿수를 지정할 때는 N 뒤에 숫자로 표시
    - 출력 : 반올림 표시
    ------------------------------------>윈도우 표준 계산기에서 사용됨 */
using System;

namespace Test2021
{
    class A030_GroupSepartor
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("표시할 숫자를 입력하세요(종료:-1): ");        //안내문 출력
                string s = Console.ReadLine();                               // 입력한 숫자를 
                double v = double.Parse(s);                                  //숫자로 바꾸어 v에 할당
                if (v == -1)                                                 //-1이면 while문 빠져나옴
                    break;
                Console.WriteLine(NumberWithGroupSeparator(s));             //NumberWithGroupSeparator(s)호출하여 리턴받은 문자열 출력
            }
        }

        private static string NumberWithGroupSeparator(string s)
        {
            int pos = 0;                                                    //pos : 소수점 아래 자릴수 의미하는 변수 0으로 초기화
            double v = Double.Parse(s);                                     // s를 double로바꿔 v에 할당

            if(s.Contains("."))                                             //Contain메소드로 소수점 있는지 검사해서 있으면
            {
                pos = s.Length - s.IndexOf('.');                            //문자열 길이에서 소수점이 있는 인덱스 값을 뺀 다음 pos에 할당 ---> pos는 소수점 자릴수 보다 1이 큰 수가 된다
                string formatStr = "{0:N" + (pos - 1) + "}";                //따라서 pos-1이 소수점 아래 자릿수가 되므로 포맷 문자열을 {0:N" + (pos - 1) + "}로 만듦
                s = string.Format(formatStr, v);
            }
            else
                s = string.Format("{0:N0}", v);                             //소수점이없으녀 {0:N0}을 출력
            return s;                                                       //s를 리턴
        }
    }
}
