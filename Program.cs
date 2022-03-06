using System;

namespace CSharpStacksQueues {

    class Program {

        static void Main(string[] args) {

            Stack<string> sportStack = new Stack<string>();
            sportStack.Push("Rugby");
            sportStack.Push("Soccer");
            sportStack.Push("Football");
            sportStack.Push("Hocky");
            sportStack.Push("Netball");
            sportStack.Push("Cricket");

            Console.WriteLine("There are {0} items on the stack", sportStack.Count);
            Console.WriteLine("The top item in the stack is {0}", sportStack.Peek());
            sportStack.Pop();
            sportStack.Pop();
            Console.WriteLine("Does the stack contain the sport 'Netball' = {0}", sportStack.Contains("Netball"));

            Queue<string> sportQueue = new Queue<string>();
            sportQueue.Enqueue("Rugby");
            sportQueue.Enqueue("Soccer");
            sportQueue.Enqueue("Football");
            sportQueue.Enqueue("Hockey");
            sportQueue.Enqueue("Netball");
            sportQueue.Enqueue("Cricket");

            Console.WriteLine("There are {0} items in the queue", sportQueue.Count);
            Console.WriteLine("The top item in the queue is {0}", sportQueue.Peek());
            sportQueue.Dequeue();
            sportQueue.Dequeue();
            Console.WriteLine("Does the queue contain the sport 'Netball' = {0}", sportQueue.Contains("Netball"));

            Console.WriteLine("\nPress Enter to Continue...\n");
            Console.ReadLine();
        }
    }
}