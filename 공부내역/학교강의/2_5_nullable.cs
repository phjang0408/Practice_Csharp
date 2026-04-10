namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            Console.WriteLine(a.HasValue);  // 1. HasValue 속성
            Console.WriteLine(a != null);
            // Console.WriteLine(a.Value);     // 2. Value속성 런타임 에러 발생!

            Console.WriteLine("---------------");
            a = 3;
            Console.WriteLine(a.HasValue);  // 1. HasValue 속성
            Console.WriteLine(a != null);
            Console.WriteLine(a.Value);     // 2. Value속성 런타임 에러 발생!
        }
    }
}