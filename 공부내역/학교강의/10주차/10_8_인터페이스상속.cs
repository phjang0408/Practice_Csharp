namespace MySpace
{
    interface Ilogger { // 부모 인터페이스
        void WriteLog(string Message);
    }
    interface IFormattableLogger : Ilogger  // 파생 인터페이스(부모의 메소드 다 받음)
    {
        void WriteLog(string format, params Object[] args);
    }
    class ConsoleLogger2 : IFormattableLogger
    {   // 상속받는 클래스는, 두 개의 인터페이스의 메서드를 다 구현해야 함.
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}",
                DateTime.Now.ToLocalTime(), message);
        }
        public void WriteLog(string format, params Object[] args)
        {
            string message = String.Format(format, args);
            Console.WriteLine("{0} {1}",
                DateTime.Now.ToLocalTime(), message);
        }

        static void Main(string[] args)
        {
            IFormattableLogger logger = new ConsoleLogger2();
            logger.WriteLog("C# Programming");
            logger.WriteLog("{0} + {1} = {2}", 1, 1, 2);
        }
    }
}