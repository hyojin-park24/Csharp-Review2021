/*
 상수, const와 readonly

 - 상수 : 변하지 않는 값
   * 선언될 때 값이 할당
   * 컴파일 시에 값이 결정
   * Classname.VariableName으로 사용
 - readonly : 변수를 선언하는 시점과 생성자 메소드에서만 값을 변경할 수 있다
   * 실행될 때 또는 객체가 생성자에 의해 초기화될 때 값이 할당
   * 런타임 시에 값이 결정
   * InstanceName.VariableName으로 사용
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2021
{
    class A033_const_readonly
    {
        class ConstEx
        {
            public const int number = 3;    //const int number선언 후 3을 할당
                                            //상수이므로 값을 변경할 수 없음
        }

        class ReadonlyEx
        {
            public readonly int number = 10;    //readonly int number선언 후 10을 할당
            public ReadonlyEx()                 //매게변수가 없는 ReadonlyEx()생성자는
            {
                number = 20;                    //number에 20으로 값을 할당
            }

            public ReadonlyEx(int n)            //매게변수(int n)가 있는 ReadonlyEx()생성자는
            {
                number = n;                     //number에 n으로 값을 할당
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine(ConstEx.number);      //const 사용
                                                        //const를 사용한 number값 출력 "ConstEx.number(클래스 이름.변수명)"을 사용

                ReadonlyEx inst1 = new ReadonlyEx();    //readonly 사용 / ReadonlyEx의 인스턴스 inst1을 생성
                Console.WriteLine(inst1.number);        //new ReadonlyEx()를 사용하므로 매개변수 없는 ReadonlyEx() 생성자가 실행
                                                        //number값은 20으로 할당됨 / inst1.number를 출력하면 20
                                                        // readonly변수는 "인스턴스명.변수명"을 사용

                ReadonlyEx inst2 = new ReadonlyEx(100); //readonly 사용 / ReadonlyEx의 인스턴스 inst2를 생성
                Console.WriteLine(inst2.number);        //new ReadonlyEx(100)을 사용하므로 매개변수로 int를 갖는 ReadonlyEx(int n) 생성자가 실행
                                                        //number값는 100으로 할당됨 // 100
            }
        }
    }
}
