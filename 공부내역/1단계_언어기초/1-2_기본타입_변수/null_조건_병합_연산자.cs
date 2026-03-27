// null 조건 연산자 (?.) / null 병합 연산자 (??, ??=)
namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. null 조건 연산자 (?.)
            // 객체가 null이면 뒤쪽을 실행하지 않고 null 반환
            string? name = null;
            int? length = name?.Length;      // name이 null이므로 length도 null
            Console.WriteLine(length);       // (빈 줄)

            name = "Hello";
            length = name?.Length;           // name이 null이 아니므로 5
            Console.WriteLine(length);       // 5

            // 배열에서도 사용 가능 (?[])
            int[]? arr = null;
            int? first = arr?[0];           // arr이 null이므로 null
            Console.WriteLine(first);        // (빈 줄)

            // 2. null 병합 연산자 (??)
            // 왼쪽이 null이면 오른쪽 값 사용, null이 아니면 왼쪽 값 사용
            string? input = null;
            string result = input ?? "기본값";
            Console.WriteLine(result);       // 기본값

            input = "입력값";
            result = input ?? "기본값";
            Console.WriteLine(result);       // 입력값

            // 3. null 병합 할당 연산자 (??=)
            // 왼쪽이 null일 때만 오른쪽 값을 할당
            string? msg = null;
            msg ??= "기본 메시지";
            Console.WriteLine(msg);          // 기본 메시지

            msg ??= "새 메시지";             // msg가 이미 값이 있으므로 무시
            Console.WriteLine(msg);          // 기본 메시지

            // 4. 조합 사용 예시
            string? userName = null;
            string display = userName?.ToUpper() ?? "이름 없음";
            Console.WriteLine(display);      // 이름 없음
        }
    }
}
