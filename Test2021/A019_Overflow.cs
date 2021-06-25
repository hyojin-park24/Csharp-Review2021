/*OverflowException과 checked키워드*/

using System;

namespace Test2021
{
    class A019_Overflow
    {
        static void Main(string[] args)
        {
            Console.WriteLine("int.MaxValue = {0}", int.MaxValue);      //int.MaxValue 출력
            int x = int.MaxValue, y = 0;
            //y = x + 10;
            // int.MaxValue에 10을 더한 값을 y에 할당함
            // int의 최대값보다 더 큰 값이므로 오버플로우가 발생
            //Console.WriteLine("int.MaxValue + 10 = {0}", y);
            //하지만 오버프로우 메시지 없이 엉뚱한 값이 출력된다
            //따라서 오버플로 메시지를 표시하기 위해 checked키워드를 사용해야 한다

            checked         //오버플로우 예외를 발생시킴 
            {
                try
                {
                    y = x + 10;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("int.MaxValue + 10 = {0}", y);
        }
    }
}
