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

        public void Insert()
        {
            Node newNode = new Node();
         

            newNode.data = 56;
            Node temp = newNode;
            newNode.data = 30;
           temp.next = newNode;
            temp = temp.next;
            newNode.data = 70;
            temp.next = newNode;
            Console.WriteLine(temp.data);

        }

    }
}
