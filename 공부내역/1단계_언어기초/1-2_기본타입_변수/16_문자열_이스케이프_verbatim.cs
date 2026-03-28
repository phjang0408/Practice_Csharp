// 이스케이프 문자 & verbatim string
namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 이스케이프 문자
            Console.WriteLine("줄바꿈:\n두 번째 줄");
            Console.WriteLine("탭:\t탭 이후");
            Console.WriteLine("따옴표: \"Hello\"");
            Console.WriteLine("백슬래시: C:\\Users\\dnln");

            // 2. verbatim string (@"...") - 이스케이프 문자를 무시하고 그대로 출력
            Console.WriteLine(@"백슬래시 그대로: C:\Users\dnln");
            Console.WriteLine(@"줄바꿈도 그대로: \n은 줄바꿈 아님");

            // 여러 줄 문자열에 유용
            string path = @"C:\Program Files\Unity\Editor";
            Console.WriteLine(path);

            // 3. 문자열 보간 + verbatim 조합 ($@"...")
            string name = "dnln";
            Console.WriteLine($@"이름: {name}, 경로: C:\Users\{name}");
        }
    }
}
