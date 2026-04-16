namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            // 암시-명시 형 변환
            sbyte a = 127;
            Console.WriteLine(a);

            int b = a;
            Console.WriteLine(b);

            int x = 128;
            Console.WriteLine(x);

            sbyte y = (sbyte)x;     // overFlow발생(기본이 unchecked라 안 뜨는거임)
            Console.WriteLine(y);
        }
    }
}