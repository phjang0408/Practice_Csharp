namespace MySpace
{
    delegate int MyDelegate(int a, int b);
    class Calculator
    {
        public int Plus(int a, int b) { return a + b; } // 인스턴스 메서드
        public static int Minus(int a, int b) { return a - b; } // 정적 메서드

        static void Main(string[] args)
        {
            Calculator Calc = new Calculator();
            MyDelegate Callback;

            // 인스턴스 메서드 참조
            Callback = new MyDelegate(Calc.Plus);   // 인스턴스메서드는 "객체.메서드" 로 참조
            Console.WriteLine(Callback(3, 4));

            // 정적 메서드 참조
            Callback = new MyDelegate(Calculator.Minus); // 정적 메서드는 "클래스.메서드"로, 객체없이 클래스 자체로 참조
            Console.WriteLine(Callback(7, 5));
        }
    }
}