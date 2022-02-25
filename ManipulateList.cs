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

        public void SearchInsert(int search, int input)
        {
            Node newNode = new Node();
            newNode.data = input;

            Node temp = head;
            Node prev = head;
            while (temp.data != search)
            {
                prev = temp;
                temp = temp.next;
            }
            prev = temp;
            temp = temp.next;
            prev.next = newNode;
            prev.next.next = temp;
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
