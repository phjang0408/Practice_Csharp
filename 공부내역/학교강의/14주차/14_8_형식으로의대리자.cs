namespace MySpace
{
    class MainClass
    {
        delegate int Calc(int a, int b);


        static int Plus(int a, int b) { return a + b; }
        static int Minus(int a, int b) { return a - b; }
        static void Main(string[] args)
        {
            Calc C;
            C = new Calc(Plus); // new 연산자를 이용해 Callback 인스턴스 생성
            Console.WriteLine(C(3, 4)); // 7출력
            C = new Calc(Minus);
            Console.WriteLine(C(7, 5)); // 2출력
        }
    }
}