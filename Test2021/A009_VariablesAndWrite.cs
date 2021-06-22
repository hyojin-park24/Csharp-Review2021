/*
    <두 변수를 출력하는 방법>
    1) 두 개 변수의 값을 각각 문자열로 바꾸어 연결해서 하나의 문자열로 출력하는 방법
    2) 형식 정보를 사용하여 여러 개의 변수나 값을 출력하는 방법
    3) 형식문자열 앞에 '$'기호를 사용하는 문자열 보간(stirng interpolation)방법
 */
using System;

namespace Test2021
{
    class A009_VariablesAndWrite
    {
        static void Main(string[] args)
        {
            int v1 = 100;
            double v2 = 1.234;

            //Console.WriteLine(v1, v2)         //error
            Console.WriteLine(v1.ToString() + "," + v2.ToString());     //각각 문자열로 바꿔 연결
            Console.WriteLine("v1 = " + v1 + ", v2 = " + v2);           //문자열과 숫자를 +연산자로 연결하면 문자열이 된다 => 즉 하나의 문자열을 출력하는 셈이다.
            Console.WriteLine("v1 = {0}, v2 = {1}", v1, v2);            //형식(format)문자열 사용
            Console.WriteLine($"v1 = {v1}, v2 = {v2}");

        }
    }
}
