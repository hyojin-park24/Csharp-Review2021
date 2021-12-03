/*
 object 타입과 박싱, 언방식

 C#에서 모든 형식 : objcet로부터 상속된다
 Object ⊃ 기본형식, 사용자 형식, 값 형식, 참조 형식

 ∴ Object 타입 = 모든 데이터의 조상 , objcet 변수에 어떤 값이라도 할당 가능 
 ** Object == object
 
 [박싱 Boxing]
 - 값 형식의 변수 --> objcet타입으로 변환 

 [언박싱 Unboxing]
 - objcet 타입의 변수 --> 값 형식으로 변환
 - (int)와 같이 형식변환을 위한 캐스팅이 필요!  

 [Object Type]
 - 참조형식으로 힙에 데이터를 할당 
 != int나 double과 같은 값형식 : 스택에 데이터를 할당 

 ∴ 값 형식의 변수 <박싱> --> object로 포장해서 힙에 저장 
   objcet 형식의 변수 <언박싱> --> 값 형식을 꺼내옴 

 ∴ 원래 변수와 박싱된 object는 서로 다른 메모리 영역을 사용하기 때문에 다른 값을 저장할 수 있다 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2021
{
    class A039_Object
    {
        static void Main(string[] args)
        {
            int i = 123;        //int 변수 i를 선언하고 123의 값을 할당 --> 스택에 저장
            object o = i;       //i의 값을 박싱하여 'o'로 복사 --> 힙에 저장
            i = i + 10;         //i의 값을 바꿈 --> 'o'는 변하지 않음 ∵ 스택에 저장되어있기 때문
            int j = (int)o;     //'o'의 값을 언박싱하여 'j'로 복사 

            //i의 값이 변해도 'o'에 저장된 값은 영향을 받지 않는다.
            Console.WriteLine("The Value-Type value i = {0}", i);       //123
            Console.WriteLine("The Value-Type value o = {0}", o);       //123
            Console.WriteLine("The Value-Tpye value j = {0}", j);       //123

            object p = o;       //objcet p를 선언하고 o를 할당
            o = 100;            //o에 100을 박싱하여 할당
            Console.WriteLine("The Objcet-Type value o = {0}", o);      //100
            Console.WriteLine("The Object-Type value p = {0}", p);      //123
        }
    }
}
