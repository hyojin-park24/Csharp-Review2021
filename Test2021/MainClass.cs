using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2021
{
    public class Node
    {
        public int data;
        public Node next;

    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            var p = new MainClass();

            int i = 0;
            int count = 0;

            Node list = null;
            Node current = null;
            Node newNode = null;

            for (i = 0; i < 5; i++)
            {
                newNode = p.CreateNode(i);
                p.AppendNode(ref list, newNode);
            }

            newNode = p.CreateNode(0);
            p.InsertNewHead(ref list, newNode);

            newNode = p.CreateNode(1);
            p.InsertNewHead(ref list, newNode);


            count = p.GetNodeCount(list);
            for (i = 0; i < count; i++)
            {
                current = p.GetNodeAt(ref list, i);
                Console.WriteLine("list[{0}]: {1}", i, current.data);
            }
        }

        public Node CreateNode(int data)
        {
            var node = new Node();
            node.data = data;
            node.next = null;
            return node;
        }

        public void AppendNode(ref Node head, Node newNode)
        {
            if (head == null)
            {
                head = newNode;
                Console.WriteLine("head: {0}", head);
            }
            else
            {
                Node tail = head;
                while (tail.next != null)
                {
                    tail = tail.next;
                }
                tail.next = newNode;
            }
        }

        public Node GetNodeAt(ref Node head, int location)
        {
            Node current = head;

            while (current != null && --location >= 0)
            {
                current = current.next;
            }

            return current;
        }

        public void RemoveNode(ref Node head, Node remove)
        {
            if (head == remove)
            {
                head = remove.next;
            }
            else
            {
                Node current = head;
                while (current != null && current.next != remove)
                {
                    current = current.next;
                }

                if (current != null)
                {
                    current.next = remove.next;
                }
            }
        }

        public void InsertAfter(Node current, Node newNode)
        {
            newNode.next = current.next;
            current.next = newNode;
        }

        public void InsertNewHead(ref Node head, Node newHead)
        {
            if (head == null)
            {
                head = newHead;
            }
            else
            {
                newHead.next = head;
                head = newHead;
            }
        }

        public int GetNodeCount(Node head)
        {
            int cnt = 0;
            Node current = head;
            while (current != null)
            {
                current = current.next;
                cnt++;
            }
            return cnt;
        }
    }
}
