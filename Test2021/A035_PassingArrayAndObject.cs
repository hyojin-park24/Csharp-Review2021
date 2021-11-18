/*
 배열과 객체를 메소드 매개변수로 전달

 배열 : 참조형식
 배열의 이름 : 그 배열이 저장된 곳의 참조

 메소드 호출 --> 배열의 이름을 매개변수로 전달하면 배열의 참조가 전달
 이때, 배열의 내용을 바꾸면 호출한 곳에서도 배열이 바뀌게 된다. 

 클래스의 객체 : 참조형식

 메소드 호출 --> 호추로딘 메소드 안에서 내용을 바꾸면 호출한 곳에서도 바뀌게 된다.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2021
{
    class A035_PassingArrayAndObject
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30 };     //정수 배열 arr을 선언하고 초기화 하기
            Console.WriteLine("Main() before: arr[0] = {0}", arr[0]);   // arr[0]을 출력

            Change(arr);                    //배열의 이름을 매개변수로 Change 메소드 호출
                                            //배열의 이름은 참조형이므로 Change 메소드에서 변경한 값은 Main에도 반영이 됨.
            Console.WriteLine("Main() after: arr[0] = {0}", arr[0]);

            Student s1 = new Student();     //Student 클래스의 객체 s1을 생성하고
            s1.name = "Alpha";              //s1의 name을 "Alpha"로 설정하고 
            Console.WriteLine("Main() before: " + s1.name); //출력해준다

            Change(s1);                     //객체 s1을 매개변수로 Change(s1)을 호출한다.
            Console.WriteLine("Main() after: " + s1.name);
        }

        private static void Change(Student s1)
        {   
            s1.name = "Beta";               //객체 s1은 참조형이므로 메소드에서 변경된 값이 Main에서도 반영된다.
        }   

        private static void Change(int[] arr)
        {
            arr[0] = -10;
        }

        class Student
        {
            public string name;
        }
    }
}
