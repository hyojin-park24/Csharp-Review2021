/*여러 개의 변수나 값을 한 문장으로 출력*/
// 문법 : Console.WriteLine(string format, object arg0, object arg1, ...)
// format : 데이터들을 어떤 형태로 출력할지를 지정
// String.Format()사용시, 콘솔에 출력하는 것과 똑같이 문자열에 저장할 수도 있다.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2021
{
    class A008_ConsoleWritLineMulti
    {
        static void Main(string[] args)
        {
            //콘솔 출력
            Console.WriteLine("10이하의 소수: {0}, {1}, {2}, {3}", 2, 3, 5, 7);


            //String.Format 출력 - 문자열에 출력 저장 가능
            string primes;
            primes = String.Format("10이하의 소수 : {0}, {1}, {2}, {3}", 2, 3, 5, 7);
            Console.WriteLine(primes);
        }
    }
}
