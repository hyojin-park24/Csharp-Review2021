/*
 반복문(1~100까지 더하기, 홀수의 합, 역수의 합)
 반복문(loop)은 프로그램 중 가장 자주 나오고 중요한 부분이다.
 프로그램을 잘 하는지 여부가 반복문을 얼마나 자유롭게 잘 사용할 수 있는지에 달려있다고해도 과언이 아니다!

 [C#의 반복문 - 문법]

  <while vs do while>
  - while : 조건식이 true인 동안 실행 
        
        while (조건식)
        {
            //참이면 반복 동작
        }
            //거짓이면 빠져나옴

  - do while : 블럭이 참/거짓 상관없이 무조건한번 실행한 후 조건식을 타게됨 

        static void Main(string[] args)
        {
            int i = 1;
            
            do
            {
                Console.WriteLine(i);
                i++;
            }while (i<10);
        }

  <for vs foreach>
  - for : 일정 범위 동안 for 루프 안의 블럭을 실행

        for(시작값; 조건; 증감)
        {
            //반복 동작
        }

  - foreach : 배열이나 컬렉션에 주로 사용, 컬렉션의 각 요소를 하나씩 꺼내와서 foreach 루프문 실행 

        static void Main(string[] args)
        {
            string[] array = new string[] {"AB","CD","EF"};
            foreach (string s in array) 
            {
                Console.WriteLine(s);       //AB \ BC \ EF
            }
        }

  - for vs foreach
    * for와 foreach를 비교하는 것은 흔히 성능적인 측면과 코드 가독성 측면을 고려함
    * 성능 : for가 경우의 따라 약간 빠를 수 있지만 대부분의 경우 성능적 차이는 크지 않음
    * 가독성 : foreach는 for보다 훨씬 간결한 코들르 제공하는 장점이 있음 
    * loop에서 가장 많이 사용되는 C# 배열(array)의 경우, foreach가 내부적인 최적화를 거쳐 for루프와 동일한 성능임
    * for loop : 배열의 차수만큼 여러번 루프를 돌려야 함
    * foreach loop : 단순히 loop한 문장으로 처리 가능 함
        
        static void Main(string[] args)
        {
            string[,,] arr = new string[,,]
            {
                {{"1","2"},{"11","22"}},
                {{"3","4"},{"33","44"}}
            };

            //for loop : need to 3rd loop
            for (int i = 0; i <arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Debug.WriteLine(arr[i, j, k]);
                    }
                }
            }

            //foreach loop : 3rd arrangement at once.
            foreach (var s in arr)
            {
                Console.WriteLine(s);
            }
        }


 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2021
{
    class A043_Loop
    {
        static void Main(string[] args)
        {
            // 1) 1~100까지 더하는 프로그램
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine("1부터 100까지 숫자의 합은 {0}", sum);

            // 2) 1에서 100까지 홀수의 합을 구하는 프로그램
            int sum2 = 0;
            for (int x= 1; x <= 100; x++)
            {
                if (x % 2 != 0)
                {
                    sum2 += x;
                }
            }
            Console.WriteLine("1에서 100까지 홀수의 합은 {0}", sum2);

            // 3) 1+1 / 2+1/ 3+1 / 3 + ... + 1 / 100 을 구하는 프로그램
            double sum3 = 0;
            for (int x = 1; x <= 100; x++)
            {
                sum3 += 1.0 / x;
            }
            Console.WriteLine("1에서 100까지 역수의 합은 {0}", sum3);
        }
    }
}
