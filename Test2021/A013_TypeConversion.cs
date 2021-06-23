/*
    <캐스팅과 자료형 변환>
    1) 암시적 형변환 
      - 작은 자료형->큰 자료형 변환 : 데이터 손실 X = 자동형변환 => 암시적 형변환
    2) 명시적 형변환
      - 큰 자료형->작은 자료형 : 데이터 손실 O = 강제로 형변환 => 명시적 형변환 = cast해주기
        Ex) double x; int a = (int)x;
 */
using System;
namespace Test2021
{
    class A013_TypeConversion
    {
        static void Main(string[] args)
        {
            int num = 2147483647;
            long bigNum = num;      //암시적 형변환 (작은값 -> 큰값)
            Console.WriteLine(bigNum);  //형변환 한 bigNum 출력

            double x = 1234.5;
            int a;

            a = (int)x;             //명시적 형변환 (큰값 -> 작은값)
            Console.WriteLine(a);   //(int)로 cast한 a 출력, 소수점 무시됨
        }
    }
}
