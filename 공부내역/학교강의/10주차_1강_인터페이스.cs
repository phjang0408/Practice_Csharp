using System;

namespace SchoolLecture
{
    class Computer { }

    interface IMonitor
    {
        void TurnOn();
    }

    interface IKeyboard
    {
    }

    class Notebook : Computer, IMonitor, IKeyboard
    {
        public void TurnOn()
        {
            Console.WriteLine("Notebook TurnOn");
        }
    }

    class Monitor : IMonitor
    {
        void IMonitor.TurnOn()
        {
            Console.WriteLine("Explicit TurnOn");
        }
    }

    interface ILogger
    {
        void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    class ConsoleLogger : ILogger
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            notebook.TurnOn();

            IMonitor monitor = new Monitor();
            monitor.TurnOn();

            ILogger logger = new ConsoleLogger();
            logger.Log("callback and default interface method");
        }
    }
}
