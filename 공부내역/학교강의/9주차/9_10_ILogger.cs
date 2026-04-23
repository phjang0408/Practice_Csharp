using System;

namespace LoggingExample
{
    // 1. 인터페이스 정의: 로그를 남기는 표준 규격
    // "ILogger" 인터페이스는 WriteLog 메소드만을 포함, 구현부는 없음
    // "WriteLog"는 상속받는 쪽에서 반드시 구현해야 하는 '규격'
    interface ILogger
    {
        void WriteLog(string message); // 구현부 없음
    }

    // 2. 콘솔에 로그를 남기는 클래스
    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"[콘솔 로그] {DateTime.Now}: {message}");
        }
    }

    // 3. 파일(가상)에 로그를 남기는 클래스
    class FileLogger : ILogger
    {
        public void WriteLog(string message)
        {
            // 실제로는 파일 쓰기 로직이 들어감
            Console.WriteLine($"[파일 로그] {message} 정보를 로그 파일에 저장했습니다.");
        }
    }

    // 4. 인터페이스를 사용하는 클라이언트 클래스
    class ClimateMonitor
    {
        private ILogger logger;

        // 생성자를 통해 어떤 로거를 쓸지 인터페이스 참조로 받음 (의존성 주입)
        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }

        public void Start()
        {
            // 로거가 무엇인지 몰라도 규격(WriteLog)만 보고 사용 가능
            logger.WriteLog("온도 모니터링 시스템을 시작합니다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 인터페이스 참조를 통해 원하는 파생 클래스 주입
            ILogger consoleLogger = new ConsoleLogger();
            ClimateMonitor monitor1 = new ClimateMonitor(consoleLogger);
            monitor1.Start();

            ILogger fileLogger = new FileLogger();
            ClimateMonitor monitor2 = new ClimateMonitor(fileLogger);
            monitor2.Start();
        }
    }
}