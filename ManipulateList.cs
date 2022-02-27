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
            Node start = null;
            Node node1 = new Node();
            node1.data = 56;
            start = node1;

            Node node2 = new Node();
            node2.data = 30;
            node2.next = node1;
            start = node2;

            Node node3 = new Node();
            node3.data = 70;
            node3.next = node2;
            start = node3;
            head = start;
        }
    }
}
