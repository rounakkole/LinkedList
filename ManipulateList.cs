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

        public void Insert(int input)
        {
            Node newNode = new Node();

            newNode.data = input;
            newNode.next = null;

            if (head != null)
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            else
            {
                head = newNode;
            }
        }

        public void SearchDelete(int search)
        {
            Node temp = head;
            while (temp.next.data != search)
            {
                temp = temp.next;
            }
            temp.next = temp.next.next;
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
