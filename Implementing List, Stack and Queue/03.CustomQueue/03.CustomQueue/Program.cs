﻿using System;

namespace _03.CustomQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomQueue<int> queue = new CustomQueue<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            queue.ForEach(Console.WriteLine);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            Console.WriteLine();

            Console.WriteLine(queue.Peek());
            Console.WriteLine();

            queue.Clear();

            queue.ForEach(Console.WriteLine);
        }
    }
}
