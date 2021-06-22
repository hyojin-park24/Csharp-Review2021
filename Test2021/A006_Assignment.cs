/*
    <대입연산자와 대입문>
    - = is not mean SAME!!!! 
    = is mean 오른쪽값을 왼쪽 곳에 넣어라
    - lhs(left hand side) identifier = rhs(right hand side) value 
    ** rhs에는 변수, 값, 수식 등이 올 수 있음
    ** lhs는 [변수]만 올 수 있음
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2021
{
    class A006_Assignment
    {
        static void Main(string[] args)
        {
            int i;
            double x;

            i = 5;
            x = 3.141592;
            Console.WriteLine("i =" + i + ", x =" + x);

            x = i;          //암시적 형변환
            i = (int)x;     //캐스트가 필요함
            //*캐스타 : 강제 형변환

            Console.WriteLine("i = " + i + ", x = " + x);
        }
    }
}
