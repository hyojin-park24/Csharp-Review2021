/*
 <Nullable형>

 기존 c#에서는 값 형식의 변수에 null값을 할당할 수 없음 --> 개선 : Nullable 
 Nullable 선언 : Nullable<T> // T : 데이터 형 

 int i = null;           // Error
 Nullable<int>  i = null // Pass

 [Nullable 구조체]
 public struct Nullable<T> where T : struct 
 {
    public bool HasValue { get; }           // 값이 할당 : true, 값이 없거나 null이면 false 리턴 
    publci T Value { get; }
 }

 Nullable<int> = "보통의 int에 그 변수가 값을 가지고 있는지 아닌지를 표현하는 플래그를 가짐"; //null인지, 아닌지 알 수 있음

 [?연산자]
 Nullable<T> == '?'

 Nullable<int> == int?
 Nullable<double> == double?

 [?? 연산자]
 Nullable 타입이 non-nullable타입일 때, '??'연산자 // null : 0 할당

 [Nullable형의 트성]
 - Nullalbe<T> 형은 값 형에 null을 할당할 수 있게 한다.
 - ? 연산자는 Nullalble형을 간단히 표현할 수 있게 한다.
 - Value 속성은 null 이면 InvaildOperationException을 발생하고, 아니면 값을 리턴한다.
 - HasValue 속성은 변수가 값을 가지면 true, null이면 false를 리턴한다.
 - Nullable형에서는 ==과 != 연산만 사용할 수 있다. 다른 비교는 Nullable 클래스의 Compare()메소드를 사용한다.

 ** Nullalbe형은 데이터베이스 프로그램에서 자주 사용 

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2021
{
    class A038_Nullable
    {
        static void Main(string[] args)
        {
            Nullable<int> i = null;     //Nullable<int> 변수 i를 선언하고 null값을 할당 
            Console.WriteLine(i.GetValueOrDefault());   //출력시 GetValueOrDefault()메소드를 사용하여 출력 
                                                        // i가 null일 때 default인 0을 출력    // 0

            if (i.HasValue)                     //Null
                Console.WriteLine(i.Value);     //or Console.WriteLine(i)  
            else
                Console.WriteLine("Null");

            int? x = null;
            int j = x ?? 0;                                 // x가 null이 아니면 x, null이면 0 할당 
            Console.WriteLine("x = {0}, j = {1}", x, j);    // x = , j = 0

            Console.WriteLine("x >= 10 ? {0}", x >= 10);    //x >= 10 ? False //숫자나 non-Nullable과 비교할 수 없으므로 false
            Console.WriteLine("x < 10 ? {0}", x < 10);      //x < 10 ? False  //숫자나 non-Nullable과 비교할 수 없으므로 false

            if (Nullable.Compare<int>(i, j) < 0)            // i < j    //비교시 Compare()메소드 사용 //null은 모든 숫자보다 작다 
                Console.WriteLine("i < j");                 
            else if (Nullable.Compare<int>(i, j) > 0)
                Console.WriteLine("i > j");
            else
                Console.WriteLine("i = j");
        }
    }
}
