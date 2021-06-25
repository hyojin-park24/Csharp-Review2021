/*논리 연산자*
 * AND : 피연산자 모두 true
 * OR  : 피연산자 중 하나만 true면 true
 * XOR : 두 값이 같으면 false, 다르면 true
 * NOT : 단항 연산자, 피연산자의 논리 값을 바꾸어준다
 * * 논리연산자는 주로 판단과 반복문에 사용
 */
using System;

namespace Test2021
{
    class A021_LogicalOperators
    {
        static void Main(string[] args)
        {
            bool result;
            int first = 10, second = 20;

            result = (first == second) || (first > 5);
            Console.WriteLine("{0} || {1} : {2}", first == second, first > 5, result);

            result = (first == second) && (first > 5);
            Console.WriteLine("{0} && {1} : {2}", first == second, first > 5, result);

            result = true ^ false;
            Console.WriteLine("{0} ^ {1} : {2}", true, false, result);

            result = !(first > second);
            Console.WriteLine("!{0} : {1}", first > second, result);
        }

    }
}
