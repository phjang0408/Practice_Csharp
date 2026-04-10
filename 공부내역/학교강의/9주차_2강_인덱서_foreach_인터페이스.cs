using System;
using System.Collections;
using System.Collections.Generic;

namespace SchoolLecture
{
    class MyList : IEnumerable<int>
    {
        private int[] array = new int[3];

        public int Length => array.Length;

        public int this[int index]
        {
            get => array[index];
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize(ref array, index + 1);
                    Console.WriteLine("Array Resized : {0}", array.Length);
                }

                array[index] = value;
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    interface IMonitor
    {
        void TurnOn();
    }

    interface IKeyboard
    {
    }

    class Notebook : IMonitor, IKeyboard
    {
        public void TurnOn()
        {
            Console.WriteLine("Notebook TurnOn");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            for (int i = 0; i < 5; i++)
            {
                list[i] = i;
            }

            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }

            foreach (int value in list)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();

            Notebook notebook = new Notebook();
            IMonitor monitor = notebook;
            monitor.TurnOn();
        }
    }
}
