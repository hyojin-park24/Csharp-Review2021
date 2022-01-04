using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2021
{
    class A046_MinMaxAverage
    {
        /*평균, 최소, 최댓값 구하기*/

        static void Main(string[] args)
        {
            double max = double.MinValue;
            double min = double.MaxValue;
            double sum = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("키를 입력하세요(단위: cm) : ");
                double h = double.Parse(Console.ReadLine());
                if (h > max)
                {
                    max = h;
                }
                if (h < min)
                {
                    min = h;
                }
                sum += h;
            }

            Console.WriteLine("평균 : {0}, 최소 : {1}, 최대 : {2}", sum/5, min, max);
        }
    }
}
