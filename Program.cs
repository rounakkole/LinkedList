// See https://aka.ms/new-console-template for more information
using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure");
            ManipulateList manipulateList = new ManipulateList();
            manipulateList.Insert();
            manipulateList.Display();
        }
    }
}
