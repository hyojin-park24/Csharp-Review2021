using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    class MyLinkedList<T>
    {
        public int Length { get { return Count(); }}
        private Node head;


        public void InsertNodeAtFirst(T data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }

        public void InsertNodeAtLast(T data)
        {
            if (head == null)
            {
                InsertNodeAtFirst(data);
                return;
            }
            Node firstNode = head;
            Node newNode = new Node(data);
            while(head != null)
            {
                if(head.next == null)
                {
                    break;
                }
                head = head.next;
            }

            head.next = newNode;
            head = firstNode;
        }

        public void Remove()
        {

        }

        public void PrintNodes()
        {
            Node firstNode = head;
            while(head != null)
            {
                Console.WriteLine(head.data);
                head = head.next;
            }

            head = firstNode;
        }

        private int Count()
        {
            int count = 0;
            Node firstNode = head;

            while (head != null)
            {
                count++;
                head = head.next;
            }

            head = firstNode;
            return count;
        }

        public Node FindLastNode()
        {
            Node lastNode = null;

            return lastNode;
        }

        /*Remove*/

        /*Cycle*/
    }

    class Node
    {
        public dynamic data;
        public Node next;

        public Node(object data)
        {
            this.data = data;
        }
    }
}
