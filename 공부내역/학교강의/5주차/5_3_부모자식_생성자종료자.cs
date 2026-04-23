namespace MySpace
{
    class Base
    {
        public Base()
        {
            Console.WriteLine("Base()");
        }
        ~Base()
        {
            Console.WriteLine("~Base()");
        }
    }
    class Derived : Base
    {
        public Derived()
        {
            Console.WriteLine("Derived()");
        }
        ~Derived()
        {
            Console.WriteLine("~Derived()");
        }
    }
    class MainApp
    {
        public static void Test()
        {
            Derived derived = new Derived();
        }
        static void Main(string[] args)
        {
            Test();
            GC.Collect(); // GC 강제 실행
            GC.WaitForPendingFinalizers(); // 종료자 처리할 때 까지 Wait
        }
    }

}