// 리터럴 (Literal) - 고정된 값 표현
// 2진수(0b), 16진수(0x), 밑줄 구분자(_) 사용 가능
namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 10진수 (기본)
            int dec = 255;

            // 2. 16진수 (0x 접두사)
            int hex = 0xFF;             // 255
            Console.WriteLine(hex);

            // 3. 2진수 (0b 접두사, C# 7.0+)
            int bin = 0b1111_1111;      // 255
            Console.WriteLine(bin);

            // 4. 밑줄 구분자 (_) - 가독성을 위한 구분, 값에는 영향 없음
            int million = 1_000_000;
            int bitmask = 0b1010_0101;
            long bigNum = 999_999_999_999L;

            Console.WriteLine(million);     // 1000000
            Console.WriteLine(bitmask);     // 165
            Console.WriteLine(bigNum);      // 999999999999

            // 5. 실수 리터럴
            float f = 3.14f;        // f 접미사 필수
            double d = 3.14;        // 기본값
            decimal m = 3.14m;      // m 접미사 필수

            // 6. 세 가지 모두 같은 값
            Console.WriteLine(dec == hex && hex == bin);  // True
        }
    }
}
