// 문자열 메서드 - 검색, 변환, 분리
namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, World! Hello, C#!";

            // 1. 검색
            Console.WriteLine(text.IndexOf("Hello"));       // 0  (처음 위치)
            Console.WriteLine(text.LastIndexOf("Hello"));   // 14 (마지막 위치)
            Console.WriteLine(text.Contains("World"));      // True
            Console.WriteLine(text.StartsWith("Hello"));    // True
            Console.WriteLine(text.EndsWith("C#!"));        // True

            // 2. 변환
            Console.WriteLine(text.ToUpper());              // HELLO, WORLD! HELLO, C#!
            Console.WriteLine(text.ToLower());              // hello, world! hello, c#!
            Console.WriteLine(text.Replace("Hello", "Hi")); // Hi, World! Hi, C#!

            // 3. 삽입/삭제
            Console.WriteLine(text.Insert(0, "[시작] "));   // [시작] Hello, World!...
            Console.WriteLine(text.Remove(13));              // Hello, World! (13번째부터 삭제)

            // 4. 공백 제거
            string padded = "   공백 제거   ";
            Console.WriteLine($"[{padded.Trim()}]");        // [공백 제거]
            Console.WriteLine($"[{padded.TrimStart()}]");   // [공백 제거   ]
            Console.WriteLine($"[{padded.TrimEnd()}]");     // [   공백 제거]

            // 5. 분리
            string csv = "사과,배,포도,딸기";
            string[] fruits = csv.Split(',');
            foreach (string fruit in fruits)
                Console.WriteLine(fruit);

            // 6. 부분 문자열
            string sub = text.Substring(7, 5);  // index 7부터 5글자
            Console.WriteLine(sub);             // World

            // 7. 길이
            Console.WriteLine(text.Length);      // 24
        }
    }
}
