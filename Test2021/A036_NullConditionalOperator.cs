/*
 Null 조건 연산자(?)

 null = "어떤 객체도 참조하지 않는 참조형 변수";
 null은 참조형 변수의 디폴트 값 
 ** 값형은 null일 수 없다
 
 참조형 변수의 속성을 사용하려면 그 변수는 null이 아니어야 한다
 null인 참조형에서 속성에 접근할 경우 'NullReferenceException'이 발생!!
 그래서 null을 항상 체크해야 함 --> null 조건 연산자 '?'
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2021
{
    class A036_NullConditionalOperator
    {
        //4글자 이상인 동물의 이름만 출력
        static void Main(string[] args)
        {
            string animal = null;           //string 변수 animal을 null로 초기화 

            Console.WriteLine("4글자 이상인 동물의 이름만 출력합니다.");    //안내문 출력
            do
            {
                LongNameAnimal(animal);         //do~while반복문으로 LongNameAnimal()메소드 호출
                Console.Write("동물이름 : ");
            } while ((animal = Console.ReadLine()) != "");
        }

        private static void LongNameAnimal(string animal)   //맨 처음 호출 시
        {   
              if (animal?.Length >= 4)                      //animal == null이기 때문에 ? null조건 연산자가 없으면 예외발생 
                Console.WriteLine(animal + " : " + animal.Length);
        }
    }
}
