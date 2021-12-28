using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            MyLinkedList<int> list = new MyLinkedList<int>();
            list.InsertNodeAtLast(3);
            list.PrintNodes();
            Console.WriteLine(list.Length);
            return;
            list.InsertNodeAtFirst(2);
            list.InsertNodeAtFirst(1);

            list.PrintNodes();

            list.InsertNodeAtLast(4);
            list.PrintNodes();
        }
    }
}
