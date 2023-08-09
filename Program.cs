using System;
using System.Collections;



namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack astack = new Stack();


            Stack<int> bstack = new Stack<int>();
            // Inner elements can be predefined, in this case we cannot push string or float to bstack

            // Adding elements
            astack.Push(1);
            astack.Push(2);
            astack.Push(3.0);
            astack.Push("Hello");

            //Droping the element on top of box
            //astack.Pop();

            foreach (var data in astack)
            {
                Console.WriteLine(data);
                // Output is in sequence of Hello, 3, 2, 1 => Last in First Out
                // Like dropping marbels in a square box
            }

            //Return the top element of stack without dropping it  
            astack.Peek();



        }

    }



}