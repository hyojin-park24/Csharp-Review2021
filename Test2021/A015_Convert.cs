/*
    <Convert클래스와 2진수, 8진수, 16진수 출력>
     - Console.ReadLine()으로 입력받은 데이터는 모두 string이다.
     - 입력받은 데이터를 숫자로 변환할 때 사용하는 Convert클래스
     - Parse()메소드와 동일하게 사용 가능하다
    [Convert 클래스]
     : ToInt32(), ToSingle(), ToDouble() 메소드 제공 - string을 숫자형으로 바꿈
       ToString(), ToByte(), ToBoolean(), ToChar(), ToDateTime() - 여러 자료형 사이의 변환도 지원함
    
    [진수변환]
    ToString() OR ToInt32() 메소드 사용
 */
using System;

namespace Test2021
{
    class A015_Convert
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("첫 번째 숫자를 입력하세요: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("두 번째 숫자를 입력하세요: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);

            // 2진수, 8진수, 10진수, 16진수로 출력하기
            short value = short.MaxValue;           //Int16.MaxValue
            Console.WriteLine("\n 2진수, 8진수, 10진수, 16진수로 출력하기");

            int baseNum = 2;        //baseNum = 진수를 의미함
            string s = Convert.ToString(value, baseNum);        //value값을 2진 문자열로 변환하여 s에 할당
            int i = Convert.ToInt32(s, baseNum);        //2진 문자열을 저장하고 있는 s의 값을 Int32형변환 후 baseNum파라미터가 문자열을 몇 진수로 해석할지 알려줌
            Console.WriteLine("i = {0}, {1,2}진수 = {2,16}", i, baseNum, s);
            //{0}은 첫번째 데이터인 i값 출력, {1,2}는 두번째 데이터인 baseNum을 2자리로,
            //{2,16}은 세번째 데이터 s를 16자리에 출력하라는 의미이다.

            baseNum = 8;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2}진수= {2,16}", i, baseNum, s);

            baseNum = 10;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2}진수= {2,16}", i, baseNum, s);

            baseNum = 16;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2}진수= {2,16}", i, baseNum, s);
        }
    }
}
