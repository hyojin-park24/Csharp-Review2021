using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2021
{
    class Dog
    {
        public string name;
        private string gender;
        public string ownernames;

        public void Bark()
        {
            Console.WriteLine("{0} : wark!wark!", name);
        }
    }
    class Access_Modifier
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();        //Dog클래스의 dog객체 생성
            //Dog 객체 접근하기 

            dog.name = "MARU";          //public : 모든 곳에서 접근 가능 
            dog.ownernames = "Edun";
            //dog.gender = "M";       //컴파일 error : 보호수준 때문에 접근할 수 없음 
            //∴ private는 클래스 내부에서만 접근 가능 

            dog.Bark();
        }
    }

}
