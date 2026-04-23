namespace MySpace
{
    interface ILogger
    {
        void WriteLog(string message);
        void WriteError(string error) // 기본구현 메소드
        {
            WriteLog(error);
        }
        // 구현해도 되고 안 해도 되는 선택적 메서드.
        // 안 하면 인터페이스의 기본 구현이 실행됨.
        // 이건 인터페이스 타입으로만 접근할 수 있고,
        // [상속받은 클래스는, 재정의 하지 않으면 못 씀!!]
    }
    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.WriteLog("System up");
            logger.WriteError("System Fail");

            ConsoleLogger clogger = new ConsoleLogger();
            clogger.WriteLog("System up");
            //clogger.WriteError("System Fail");  // 컴파일에러
        }
    }
}