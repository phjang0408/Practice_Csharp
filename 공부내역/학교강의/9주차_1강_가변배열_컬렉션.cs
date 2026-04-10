using System;
using System.Collections;

namespace SchoolLecture
{
    class Program
    {
        static void PrintElement(int[][] jagged)
        {
            foreach (int[] arr in jagged)
            {
                Console.Write($"Length : {arr.Length}, ");
                foreach (int value in arr)
                {
                    Console.Write($"{value} ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[] { 1, 2, 3, 4, 5 };
            jagged[1] = new int[] { 10, 20, 30 };
            jagged[2] = new int[] { 100, 200 };
            PrintElement(jagged);

            ArrayList list = new ArrayList { 1, "two", 3.0 };
            Queue queue = new Queue();
            queue.Enqueue("first");
            queue.Enqueue("second");

            Stack stack = new Stack();
            stack.Push("A");
            stack.Push("B");

            Hashtable table = new Hashtable
            {
                ["one"] = 1,
                ["two"] = 2
            };

            Console.WriteLine(list.Count);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(table["one"]);
        }
    }
}
