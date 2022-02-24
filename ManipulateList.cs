using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class ManipulateList
    {
        public Node tail;
        Node temp;

        public void Insert(int input)
        {
            Node newNode = new Node();
            newNode.data = input;
            newNode.next = null;

            temp = newNode;
            temp.next = tail;
            tail = temp;
        }
        public void Display()
        {
            Console.WriteLine(temp.data);
            while (temp.next != null)
            {
                temp = temp.next;
                Console.WriteLine(temp.data);
            }
        }
    }
}

