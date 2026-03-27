// 문자열 포매팅 - Format(), 보간($""), 정렬, 숫자/날짜 포맷
namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. string.Format()
            string name = "홍길동";
            int age = 25;
            string msg1 = string.Format("이름: {0}, 나이: {1}", name, age);
            Console.WriteLine(msg1);

            // 2. 문자열 보간 ($) - C# 6.0+, 더 간결함
            string msg2 = $"이름: {name}, 나이: {age}";
            Console.WriteLine(msg2);

            // 3. 정렬 - {index, width} (양수=오른쪽 정렬, 음수=왼쪽 정렬)
            Console.WriteLine($"{"이름",-10}{"점수",5}");   // 왼쪽10, 오른쪽5
            Console.WriteLine($"{"홍길동",-10}{95,5}");
            Console.WriteLine($"{"김철수",-10}{87,5}");

            // 4. 숫자 포맷
            int num = 123456;
            Console.WriteLine($"D8: {num:D8}");     // 00123456 (10진수, 8자리)
            Console.WriteLine($"X:  {num:X}");      // 1E240    (16진수)
            Console.WriteLine($"N:  {num:N0}");     // 123,456  (천단위 콤마)

            double pi = 3.141592;
            Console.WriteLine($"F2: {pi:F2}");      // 3.14     (소수점 2자리)
            Console.WriteLine($"E:  {pi:E}");       // 3.141592E+000 (과학표기법)

            // 5. 날짜/시간 포맷
            DateTime now = DateTime.Now;
            Console.WriteLine($"yyyy-MM-dd: {now:yyyy-MM-dd}");
            Console.WriteLine($"HH:mm:ss:   {now:HH:mm:ss}");
            Console.WriteLine($"ddd:        {now:ddd}");         // 요일 (짧게)
            Console.WriteLine($"tt:         {now:tt hh:mm}");    // AM/PM
        }
    }
}
