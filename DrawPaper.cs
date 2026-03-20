namespace DrawingPaper
{
    class CSVar
    {
        int globalVar;
        const int MAX = 1024;
        public void Method1()
        {
            int localVar;
            localVar = 100;
            System.Console.WriteLine(localVar);
            System.Console.WriteLine(globalVar);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CSVar obj = new CSVar();
            obj.Method1();
        }
    }
}