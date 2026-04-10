using System;

namespace SchoolLecture
{
    class Computer
    {
        protected bool powerOn;

        public void Boot()
        {
            powerOn = true;
        }

        public void Shutdown()
        {
            powerOn = false;
        }
    }

    class Notebook : Computer
    {
        private bool fingerScan;

        public bool HasFingerScanDevice()
        {
            return fingerScan;
        }

        public void CloseLid()
        {
            if (powerOn)
            {
                Shutdown();
            }
        }
    }

    class Desktop : Computer { }
    class Netbook : Computer { }

    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            notebook.Boot();
            notebook.CloseLid();

            Desktop desktop = new Desktop();
            desktop.Boot();
            desktop.Shutdown();
        }
    }
}
