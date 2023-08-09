using System;
using System.Collections;



namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue aqueue = new Queue();
            
            // Adding element to the queue
            aqueue.Enqueue(1);
            aqueue.Enqueue(2);

            // Return top elemnt without removing - First in first out principle
            Console.WriteLine(aqueue.Peek());

            // Remove and return top element in the queue
            aqueue.Dequeue();

            foreach (var item in aqueue)
            {
                Console.WriteLine(item);   
            }
        }

    }



}