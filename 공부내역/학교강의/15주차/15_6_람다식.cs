namespace MySpace
{
    class MainApp
    {
        delegate int Calc(int a, int b);
        static void Main(string[] args)
        {
            var x = 3;
            // => 오른쪽에 "식(값으로 평가되는 것)" 하나만
            x => x * 2;
            x => x > 0;

            // 람다식 방식
            // Calculator 대리자의 선언코드로부터 해당 람다식의 매개변수의 형식을 유추
            Calc calc = (int a, int b) => a + b;
            Console.WriteLine($"3 + 4 : {calc(3, 4)}");

            // 익명 메서드 방식
            Calc calc2 = delegate (int a, int b) { return a + b; };
            Console.WriteLine($"3 + 4 : {calc2(3, 4)}");
        }
    }
}