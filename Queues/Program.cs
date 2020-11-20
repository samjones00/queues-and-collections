using System;
using System.Collections.Generic;
using System.Threading;

namespace Queues
{
    class Program
    {
        private static Queue<Item> queue = new Queue<Item>();

        static void Main(string[] args)
        {
            var size = 10;
            for (int i = 0; i < size; i++)
            {
                queue.Enqueue(new Item
                {
                    Message = $"Message added at {DateTime.Now}"
                });
                Thread.Sleep(500);
            }

            while (queue.TryDequeue(out var item))
            {
                Console.WriteLine($"{item.Message}");
                Console.WriteLine($"removing item, queue length: {queue.Count}");
            }
        }
    }

    class Item{
        public string Message { get; set; }
    }
}