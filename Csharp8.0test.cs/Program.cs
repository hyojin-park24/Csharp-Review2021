/*2021년 9월 8일 (1sd - 1일차)
 * 
 * C# 기초 - 기본 자료형*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp8._0test.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*3.1.1 정수형 변수*/
            int n1 = 50;    //선언과 동시에 값을 부여할 수도 있고 
            int n2;         //선언만 하고
            n2 = 100;       //값은 나중에 부여하는 것도 가능

            long sum = n1 + n2; //더한 값을 sum 변수에 저장(대입)

            Console.WriteLine(sum); // 출력결과 : 150

            /*3.1.2 실수형
             - float과 double간의 조건은 정밀도의 차이
             - decimal : 반올림 오차 허용 X -> 회계 계산에 적합
             */
            float f = 5.2f;
            double d = 10.5;
            decimal money = 200.099m;

            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(money);

            /*3.1.3 문자형 
             - 정수를 담는 상황 : ushot
             - 문자를 담는 상황 : char
             - 문자열을 담는 상황 : string -> '+'연산지원*/

            char ch1 = '\t';    //들여쓰기 - 안먹힘 
            char ch2 = 'T';
            char ch3 = '\n';    //개행
            char ch4 = 'o';
            char ch = '\u2023'; //유니코드 문자의 번호를 16진수로 명시

            string text1 = "Hello, Word!";
            string text2 = "\"Hello, Word!\"";
            string text3 = @"\t Hello, \nWord!!";
            string text4 = "Hello";

            Console.WriteLine(ch1);
            Console.WriteLine(ch2);
            Console.WriteLine(ch3);
            Console.WriteLine(ch4);
            Console.WriteLine(ch);  //'?' : 윈도우의 해당 문자 폰트가 없음
            Console.WriteLine(text1);
            Console.WriteLine(text2);
            Console.WriteLine(text3);
            Console.WriteLine(text4 + " " + "Word!");

            /*3.1.4 불린(Boolen)형 기본 타입
             - 오직 true/false 값만 담음
             - System.Boolean
             - if문, while문 등에 평가식으로 사용되거나 
             - 사람의 성별과 같이 참/거짓에 해당하는 자료를 표현할 때 사용
             */

            bool isNumeric = false;
            Console.WriteLine(isNumeric);

        }
    }
}
