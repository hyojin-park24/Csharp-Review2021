/*
    <String과 StringBuilder의 차이점>
    - String객체의 값은 한 번 만들면 변경할 수 없는 불변(immutable)이다.
    - 객체가 변경될 때마다 새로운 string을 만들어서 변수명에 할당해주는데
    - 이럴때마다 값이 빈번하게 변경되는 경우에는 쓸데없이 ㅅ트링이 많아져 실행속도와 메모리 사용이 많아짐
    - 따라서, StringBuiler 클래스를 제공함
    [StringBuilder Class]
    - 가변(mutable)이다.
    - 문자열이 변경되면 자동으로 필요한 메모리를 동적으로 조정하고 내용을 바꿀 수 있음
    [StringBuilder Class Attribute & Methods]
    <Attribute>
    - Capacity : StringBuilder 객체에 할당된 메모리가 허용하는 최대 문자수를 가져오거나 설정함
    - Length : StringBuilder 객체의 길이를 가져오거나 설정함

    <Methods : 스트링 추가,제거,수정>
    - Append : StringBuilder 객체의 끝에 문자열 추가
    - Clear : StringBuilder 객체의 모든 문자들을 없애줌
    - Copy To : string의 일부분을 문자 배열로 복사함
    - EnsureCapacity : StringBuilder 객체의 용량을 최소한 지정된 값이 되도록 함
    - Equals : 이 객체가 다른 객체와 같은 지를 부울값으로 리턴함
    - Insert : 특정한 위치에 지정한 문자열을 삽입
    - Remove : 특정 위치에 있는 무자열을 삭제
    - Replace : StringBuilder 객체에서 문자 혹은 substring을 다른 문자 혹은 substring으로 대체
    - Tostring : StringBuilder 객체의 값을 String으로 변환
 */

using System;
using System.Diagnostics;       //Stopwatch사용을 위한 네임스페이스 추가
using System.Text;

namespace Test2021
{
    class A031_StringBuilder
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("This is StringBuilder Test.");
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Clear();
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Append("This is a new string.");
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Insert(5, "xyz", 2);     //5번째 위치에 "xyz"를 두번 삽입
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Remove(5, 4);            //5번째 위치에서 4개의 문자를 삭제
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);


            sb.Replace("xyz", "abc");   //"xyz"를 "abc"로 대치
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            /*String 시간*/
            Stopwatch time = new Stopwatch();   //객체 time생성하여 start~stop까지의 시간 측정
            string test = string.Empty;
            time.Start();
            for (int i = 0; i < 100000; i++)
            {
                test += i;                  //10만번 반복하면서 test에 숫자를 문자열로 추가함
            }
            time.Stop();
            Console.WriteLine("String: " + time.ElapsedMilliseconds + "ms");        //시간측정

            /*StringBuilder 시간*/
            StringBuilder test1 = new StringBuilder();
            time.Reset();
            time.Start();
            for (int i = 0; i < 100000; i++)
            {
                test1.Append(i);            //10만번 반복하면서 test에 숫자를 문자열로 추가함
            }
            time.Stop();
            Console.WriteLine("StringBuilder: " + time.ElapsedMilliseconds + "ms");
        }
    }
}
