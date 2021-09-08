/*
    <열거형 enum>
    - enum을 이용하여 커피 가격표를 출력하는 프로그램을 작성
    - 열거형 : 서로 관련 있는 상수들의 집합 
    - 숫자에 특정한 명칭을 붙여주어 의미를 쉽게 이해할 수 있게 하는 용도로 사용
 */

using System;

namespace Test2021
{
    class A032_Enum
    {
        enum Size { Short, Tall, Grand, Venti};
        static int[] price = { 3300, 3800, 4300, 4800 };
        enum Colors { Red = 1, Green = 2, Blue = 4, Yellow = 8 };
        enum Coffee { Short = 3300, Tall = 3800, Grande = 4300, Venti = 4800};

        static void Main(string[] args)
        {
            Console.WriteLine("커피 가격표");
            for (int i = 0; i < 4; i++)
            {
                if (i == (int)Size.Short)
                    Console.WriteLine("{0,10} : {1:C}", Size.Short, price[i]);
                else if (i == (int)Size.Tall)
                    Console.WriteLine("{0,10} : {1:C}", Size.Tall, price[i]);
                else if (i == (int)Size.Grand)
                    Console.WriteLine("{0,10} : {1:C}", Size.Grand, price[i]);
                else if (i == (int)Size.Venti)
                    Console.WriteLine("{0,10} : {1:C}", Size.Venti, price[i]);
            }

            Console.WriteLine("\n 커피 가격표 (Enum iteration)");
            foreach (var size in Enum.GetValues(typeof(Size)))
            {
                Console.WriteLine("{0,10}:{1:C}", size, price[(int)size]);
            }

            Console.WriteLine("\nColors Enum iteration");

        }
    }
}
