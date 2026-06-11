namespace MySpace
{
    class MainApp
    {
        static void Main(string[] args)
        {   
            // Func : 반환값이 있는 버전, 마지막이 반환 타입
            // 1. 매개변수가 없는 버전
            Func<int> func1 = () => 10; 
            Console.WriteLine($"func1() : {func1()}");  // 함수처럼 사용

            // 2. 매개변수가 하나인 버전
            Func<int, int> func2 = (x) => x * 2;
            Console.WriteLine($"func2(4) : {func2(4)}");

            // 2. 매개변수가 둘 인 버전
            Func<double, double, double> func3 = (x, y) => x / y;
            Console.WriteLine($"func3(22, 7) : {func3(24, 7)}");

            // Action : 반환값이 없음. 
            // 1. 매개변수 없는 벚전
            Action act1 = () => Console.WriteLine("Action()");
            act1();

            // 2. 매개변수 하나 인 버전
            int result = 0;
            Action<int> act2 = (x) => result = x * x;
            act2(3);
            Console.WriteLine($"result : {result}");

            // 3. 매개변수가 둘 인 버전
            Action<double, double> act3 = (x, y) =>
            {
                double pi = x / y;
                Console.WriteLine($"Action<T1,T2>({x}, {y}) : {pi}");
            };
            act3(22.0, 7.0);
        }
    }
}