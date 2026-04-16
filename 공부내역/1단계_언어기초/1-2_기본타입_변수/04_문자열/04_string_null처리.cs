// 문자열 null/빈값 처리 - IsNullOrEmpty, IsNullOrWhiteSpace, null 병합
namespace StringStudy
{
    class StringNullDemo
    {
        static void Main(string[] args)
        {
            string? a = null;
            string b = "";
            string c = "   ";       // 공백만 있는 문자열
            string d = "hello";

            // 1. IsNullOrEmpty - null 이거나 빈 문자열("")이면 true
            Console.WriteLine(string.IsNullOrEmpty(a));  // True  (null)
            Console.WriteLine(string.IsNullOrEmpty(b));  // True  ("")
            Console.WriteLine(string.IsNullOrEmpty(c));  // False (공백은 빈값 아님)
            Console.WriteLine(string.IsNullOrEmpty(d));  // False

            // 2. IsNullOrWhiteSpace - null, 빈값, 공백만 있는 경우 모두 true
            Console.WriteLine(string.IsNullOrWhiteSpace(a));  // True
            Console.WriteLine(string.IsNullOrWhiteSpace(b));  // True
            Console.WriteLine(string.IsNullOrWhiteSpace(c));  // True  ← 공백도 잡힘
            Console.WriteLine(string.IsNullOrWhiteSpace(d));  // False

            // 3. null 병합 연산자(??) - null이면 오른쪽 값 사용
            string? input = null;
            string result = input ?? "기본값";
            Console.WriteLine(result);  // 기본값

            // 4. null 조건 + 병합 조합 — 백준 입력처리에서 자주 씀
            string? line = Console.ReadLine();          // null일 수 있음
            string safe = line?.Trim() ?? "";           // null이면 빈 문자열로 대체
            Console.WriteLine($"입력: [{safe}]");

            // 5. null 병합 대입(??=) - null일 때만 대입
            string? name = null;
            name ??= "홍길동";
            Console.WriteLine(name);    // 홍길동
        }
    }
}
