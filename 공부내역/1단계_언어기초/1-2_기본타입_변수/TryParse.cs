// int.Parse() vs int.TryParse()
// Parse()   : 변환 실패 시 예외(FormatException) 발생 → 프로그램 죽음
// TryParse(): 변환 실패 시 false 반환 → 프로그램 안 죽음
namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Parse() - 실패하면 예외 발생
            // int bad = int.Parse("abc"); // FormatException 발생!

            // 2. TryParse() - bool 반환 + out 매개변수로 결과를 받음
            string input1 = "123";
            bool success1 = int.TryParse(input1, out int result1);
            Console.WriteLine(success1);    // True
            Console.WriteLine(result1);     // 123

            string input2 = "abc";
            bool success2 = int.TryParse(input2, out int result2);
            Console.WriteLine(success2);    // False
            Console.WriteLine(result2);     // 0 (변환 실패 시 기본값)

            // 3. 실제 사용 패턴
            Console.Write("숫자를 입력하세요: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                Console.WriteLine($"입력한 숫자: {number}");
            }
            else
            {
                Console.WriteLine("숫자가 아닙니다.");
            }
        }
    }
}
