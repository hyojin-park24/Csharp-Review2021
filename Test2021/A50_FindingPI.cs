using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2021
{
    class A50_FindingPI
    {
        /*라이프니츠의 원주율 공식 계산*/

        static void Main(string[] args)
        {
            bool sign = false;  //한번은 빼기, 한번은 더하기 위해 bool타입 sign변수에 false대입
            double pi = 0;

            for (int i = 0; i <= 10000; i += 2) //i는 1~10000까지 2씩 증가하면서 반복
            {
                if (sign == false)  //sign이 false이면 덧셈
                {
                    pi += 1.0 / i;  
                    sign = true;
                }
                else
                {
                    pi -= 1.0 / i;  //sign이 true면 뺄셈
                    sign = false;
                }
                Console.WriteLine("i = {0}, PI = {1}", i, 4*pi);
            }
        }
    }
}
