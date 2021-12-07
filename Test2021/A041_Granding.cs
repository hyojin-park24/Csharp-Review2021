/*
 switch 문 
 - 조건에 따른 분기가 여러 개일 경우 편리하게 사용할 수 있는 문장 
 - if~else문장을 다르게 표현한 것 
 - case문에 쓰이는 값 : int, bool, string, char OR long과 같은 정수, enum값
 - case문은 break로 끝나고 어떤 조건도 맞지 않으면 default로 처리됨
 [if~else문 vs switch문]

 "if문을 사용하여 c값이 랜덤하게 Color값 중 하나를 갖게 되는 경우에 어떤 색인지 출력하는 프로그램"

 public enum Color {Red, Green, Blue};

 public static void Main(string[] args)
 {
    Color c = (Color) (new Random()).Next(0,3);
    if (c == Color.Red)
        Console.WriteLine("The Color is Red");
    else if (c == Color.Green)
        Console.WriteLine("The Color is Green"):
    else if (c == Conlor.Blue)
        Console.WriteLine("The Color is Blue");
    else
        Console.WriteLine("The Color is unkown.");
 }

 "switch문을 사용하여 c값이 랜덤하게 Color값 중 하나를 갖게 되는 경우에 어떤 색인지 출력하는 프로그램:

 public static void Main()
 {
    Color c = (Color) (new Random().Next(0,3);
    switch(c)
    {
        case Color.Red:
            Console.WriteLine("The Color is Red");
            break;
        case Color.Geen:
            Console.WriteLine("The Color is Green"):
            break;
        case Color.Blue:
            Console.WriteLine("The Color is Blue");
            break;
        default:
            Console.WriteLine("The Color is unkown.");
            break;
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
    /*
        점수를 입력받아 학점을 출력하는 프로그램 (if문 && switch문)
        
        입력 : 100~90점 이상, 80~89점, 70~79점, 60~69점, 그 외
        출력 : A, B, C, D, F 
    */
    class A041_Granding
    {
        static void Main(string[] args)
        {
            Console.WriteLine("점수를 입력하세요 : ");
            int score = int.Parse(Console.ReadLine());

            string grade = null;

            if (score >= 90)
                grade = "A";
            else if (score >= 80)
                grade = "B";
            else if (score >= 70)
                grade = "C";
            else if (score >= 60)
                grade = "D";
            else
                grade = "F";

            Console.WriteLine("학점은 {0} 입니다.", grade);

            switch (score / 10)             //100점~0점을 10으로 나누면 10~0의 정수로 떨어지는 것을 이용
            {
                case 10:
                case 9:
                    grade = "A";
                    break;
                case 8:
                    grade = "B";
                    break;
                case 7:
                    grade = "C";
                    break;
                case 6:
                    grade = "D";
                    break;
                default:
                    grade = "F";
                    break;
            }
            Console.WriteLine("학점은 {0} 입니다.", grade);
        }
    }
}
