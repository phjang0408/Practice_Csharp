namespace MySpace
{
    class MainClass
    {
        delegate int CalCulate(int a, int b);
        static void Main(string[] args)
        {
            CalCulate Calc;
            Calc = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine($"3 + 4 : {Calc(3, 4)}");
        }
    }
}