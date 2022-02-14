using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue
{
    public class Queue
    {
        public Node head;

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }


        public void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            if (head.next == null)
            {
                head = null;
            }
            else
            {
                Node temp = head;

                while (temp.next.next != null)
                { temp = temp.next; }
                temp.next = null;
            }
        }

        public int Count()
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }

        public void DisplayAll()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    Console.Write("->");
                    temp = temp.next;
                }
            }
            Console.Write("NULL");
        }
    }

}
