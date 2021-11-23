/*
 변수의 초기화와 default

 C#에서는 초기화되지 않은 변수를 사용할 수 없다 
 --> 특정한 값을 할당해주거나 해당 형식의 기본값(default)을 사용해서 변수 초기화 

 <형식에 따른 기본값>
 - 참조형식 : null
 - 숫자 값 형식 : 0
 - bool : false
 - char : '\0'
 - enum : 식 (E)0 값이며 여기서 E는 열거형 식별자
 - struct : 모든 값 형식 필드를 기본값으로 설정하고 모든 참조 형식 필드를 null로 설정하여 생성한 값
 - nullable : HasValue 속성은 false이고 Value 속성은 정의되지 않은 인스턴스 

 <default>
 - default 리터럴을 사용함으로 더 간단하게 형식의 기본값으로 초기화 가능
 - 제너릭 클래스와 메소드에서 유용함
 - 제너릭 사용으로 매개변수 형식 T에 기본값을 할당하는데 어떤 타입이라도 문제없이 초기화 가능
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2021
{
    class A037_Deafult
    {
        enum E                  //enum E 선언 : enum은 메소드 밖에 선언해야 함
        {
            Red, Green, Blue
        };

        static void Main(string[] args)
        {
            int a = default;            //int 변수 a를 디폴트로 할당
            string s = default;         //string 변수 s를 디폴트로 할당
            Console.WriteLine("a = " + a);  // a= 0
            Console.WriteLine("s = " + s);  // s= null

            Console.WriteLine("E = " + default(E));              //열거형 E의 default를 출력    //0에 해당하는 Red값 출력됨 
            Console.WriteLine("E = " + (E)0);                    //Red

            MyList<int> iList = new MyList<int>();              //연결리스트인 제네릭 클래스 MyList의 객체로 정수의 연결 리스트 iList를 생성
            Console.WriteLine("iList : " + iList.GetLast());    // iList.GetLast()메소드로 마지막 노드의 data값을 가져오는데 
                                                                //MyList가 비어있다면 data의 디폴트 값 0을 출력

            MyList<string> sList = new MyList<string>();        //연결리스트인 제너릭 클래스 MyList의 객체로 string의 연결 리스트 sList를 생성
            Console.WriteLine("sList : " + sList.GetLast());    //sList.GetLast()메소드로 마지막 노드의 data값을 가져오는데
                                                                //MyList가 비어있다면 data의 디폴트 값 null을 받아 출력
        }
    }

        public class MyList<T>                                  //MyList<T> 클래스 정의
        {
            private class Node                                  //Node 클래스 정의 : T data, Node next 멤버
            {
                public T data;                                  
                public Node next;
            }
            private Node head = default;                        //Node 객체 head를 default로 초기화 --> null (Node가 클래스이기 때문)

            public void AddNode(T t)                            //AddNode(T t)는 data를 t로 하는 노드를 만들어 맨 앞에 추가함
            {
                Node newNode = new Node();
                newNode.next = head;
                newNode.data = t;
                head = newNode;
            }

            public T GetLast()                                  //리스트의 마지막 data값을 리턴하는 메소드
            {
                T temp = default(T);                            //default(T)로 초기화
                                                                //T에 따라 디폴트 값이 달라지므로 default(T)를 사용해야함
                Node current = head;
                while (current != null)                     
                {
                    temp = current.data;
                    current = current.next;
                }
                return temp;                                    //리스트에 요소가 하나도 없다면 default(T)로 초기화된 temp를 리턴
            }
        }


    
}
