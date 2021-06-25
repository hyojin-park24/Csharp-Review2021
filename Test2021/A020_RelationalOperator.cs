/*관계연산자*/
using System;

namespace Test2021
{
    class A020_RelationalOperator
    {
        static void Main(string[] args)
        {
            bool result;                //bool형 변수 result정의 true, false
            int first = 10, second = 20;

            result = (first == second);
            Console.WriteLine("{0} == {1} : {2}", first, second, result);

            result = (first > second);
            Console.WriteLine("{0} > {1} : {2}", first, second, result);

            result = (first < second);
            Console.WriteLine("{0} < {1} : {2}", first, second, result);

            result = (first >= second);
            Console.WriteLine("{0} >= {1} : {2}", first, second, result);

            result = (first <= second);
            Console.WriteLine("{0} <= {1} : {2}", first, second, result);

            result = (first != second);
            Console.WriteLine("{0} != {1} : {2}", first, second, result);
        }
    }
}
