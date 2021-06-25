/*DivideByZeroException과 try~catch문
 *산술연산에서 나오는 예외처리
 * 0으로 나눔 예외 (DivideByZeroException)
 * 오버플로우 예외 (OverflowException)
 */

using System;

namespace Test2021
{
    class A018_DivideByZero
    {
        static void Main(string[] args)
        {
            int x = 10, y = 0;
            //Console.WriteLine(10.0 / y);    //실수를 0으로 나누기 때문에 예외가 아니고 무한대 출력

            //예외처리를 위한 try~catch문 사용
            try
            {
                Console.WriteLine(x / y);       //y값이 0이기 때문에 0으로 나눔 예외 발생 

            }
            catch (Exception ex)                //예외가 발생하면 실행
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
