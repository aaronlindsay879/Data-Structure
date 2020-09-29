using System;
using Queue.Queue;
using Queue.Stack;

namespace Queue
{
    class Program
    {
        /// <summary>
        /// Tests the queue class
        /// </summary>
        private static void TestQueue()
        {

            IQueue<int> queue = new CircularQueue<int>(5);

            Console.WriteLine(queue.IsEmpty());

            queue.EnQueue(5);
            queue.EnQueue(10);
            queue.EnQueue(20);
            queue.EnQueue(15);
            queue.EnQueue(4);
            queue.EnQueue(4); //will not add to queue as is full

            Console.WriteLine(queue.DeQueue()); //shold be 5
            Console.WriteLine(queue.DeQueue()); //should be 10
            Console.WriteLine(queue.DeQueue()); //should be 20
        }

        /// <summary>
        /// Tests the stack class
        /// </summary>
        private static void TestStack()
        {
            Stack<int> stack = new Stack<int>(5);

            stack.Push(5);
            stack.Push(10);
            stack.Push(15);

            Console.WriteLine(stack.Pop()); //should be 15
            Console.WriteLine(stack.Pop()); //should  be 10
        }

        /// <summary>
        /// Tests the priority queue class
        /// </summary>
        private static void TestPriorityQueue()
        {
            PriorityQueue<int> queue = new PriorityQueue<int>();

            queue.EnQueue(5, 3);
            queue.EnQueue(10, 3);
            queue.EnQueue(1, 1);
            queue.EnQueue(20, 2);

            Console.WriteLine(queue.DeQueue()); //should be 1
            Console.WriteLine(queue.DeQueue()); //should be 20
            Console.WriteLine(queue.DeQueue()); //should be 5
        }

        static void Main(string[] args)
        {
            TestPriorityQueue();
        }
    }
}
