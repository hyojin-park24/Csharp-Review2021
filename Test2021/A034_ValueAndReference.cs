/*
 값 형식과 참조 형식, ref 키워드

 C#자료형의 두 가지 타입 : 값 형식(value type), 참조 형식(reference type)

 값형식 
 - 변수가 실제 데이터 값을 저장하는 형식 
 - int, double, char, bool의 기본형식, enum, strcut

 참조형식
 - 변수가 값이 저장되어 있는 곳의 위치를 저장하는 형식 (Like C Pointer)
 - object, string, dynamic, class, interface, delegate
 * string이나 배열은 참조 형식이다. 
 * 문자열이나 배열의 데이터는 힙 영역에 저장하고 스택에는 참조만 저장한다. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2021
{
    class A034_ValueAndReference
    {
        static void Main(string[] args)
        {
            string s = "before passing";        // s에 "before passing"을 할당
            Console.WriteLine(s);               // s 출력

            Test(s);                            //Test(s) 메소드를 호출함, Test메소드 생성 필요
            Console.WriteLine(s);               //메소드 안에서 s가 변하지만 이는 로컬변수 s의 내용이 바뀐 것이므로 Main의 출력값에 지장이 없음

            Test(ref s);                        //Test(ref s)를 호출하면 Test(ref string s) 메소드가 호출되고  
            Console.WriteLine(s);               //ref 키워드에 의해 s의 값이 변하면 Main에서도 바뀌게 된다.
        }

        public static void Test(string s)       //Test 메소드가 매개변수만 다르고 이름이 같음 ==> 메소드 중복
        {
            s = "after passing";
        }

        public static void Test(ref string s)   //매개변수의 개수나 형에 따라 그에 맞는 메소드를 호출하게 됨
        {
            s = "after passing";
        }
    }
}
