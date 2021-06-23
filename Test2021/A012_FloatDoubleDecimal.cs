/*
    <실수를 표현하는 float, double, decimal>
    구분 방법 
    - 정밀도(유효숫자) : float-7자리, double-15~16자리[금융 프로그램], decimal-28~29자리
    - 표현할 수 있는 범위 : float, double > decimal [과학적인 계산이 필요한 프로그램]
    - 저장 공간의 크기와 계산 속도 : float(4byte), double(8byte) > decimal(16byte)
    - 접미사 : double(d or 생략가능), float(f), decimal(m) 필요
 */
using System;

namespace Test2021
{
    class A012_FloatDoubleDecimal
    {
        static void Main(string[] args)
        {
            float flt = 1F / 3;         //float변수 flt를 선언하고 1F/3을 계산 후 저장 *1F = float 1을 의미
            double dbl = 1D / 3;        //double변수 dbl을 선언하고 1D/3을 계산 후 저장
            decimal dcm = 1M / 3;       //decimal변수 dcm을 선언하고 1M/3을 계산 후 저장 

            //정밀도 
            Console.WriteLine("float : {0}\ndouble : {1}\ndecimal : {2}", flt, dbl, dcm);
            //크기
            Console.WriteLine("float : {0} bytes\ndoulbe : {1} bytes\ndecimal : {2} bytes",
                              sizeof(float), sizeof(double), sizeof(decimal));
            //최소값, 최대값
            Console.WriteLine("float : {0}~{1}", float.MinValue, float.MaxValue);
            Console.WriteLine("double : {0}~{1}", double.MinValue, double.MaxValue);
            Console.WriteLine("decimal : {0}~{1}", decimal.MinValue, decimal.MaxValue);
        }
    }
}
