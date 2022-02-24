using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class ManipulateList
    {

        public Node head;
        public Node tail = null;
        public void Insert(int input)
        {
            Node newNode = new Node();
            newNode.data = input;
            newNode.next = null;

            if (head != null && newNode.data != 70)
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                temp.next.next = tail;
            }
            else if (newNode.data == 70)
            {
                tail = newNode;
            }
            else
            {
                head = newNode;
            }

        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("list is empty");
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
                Console.WriteLine(temp.data);
            }
        }

    }
}
