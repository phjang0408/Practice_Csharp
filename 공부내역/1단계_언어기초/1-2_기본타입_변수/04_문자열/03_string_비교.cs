// 문자열 비교 - ==, Equals, CompareTo, StringComparer
namespace StringStudy
{
    class StringCompareDemo
    {
        static void Main(string[] args)
        {
            string a = "hello";
            string b = "Hello";
            string c = "hello";

            // 1. == 연산자 - 대소문자 구분 (기본)
            Console.WriteLine(a == c);          // True
            Console.WriteLine(a == b);          // False

            // 2. Equals - == 와 동일하지만 메서드 형태
            Console.WriteLine(a.Equals(c));     // True
            Console.WriteLine(a.Equals(b));     // False

            // 3. 대소문자 무시 비교
            Console.WriteLine(a.Equals(b, StringComparison.OrdinalIgnoreCase));  // True
            Console.WriteLine(string.Equals(a, b, StringComparison.OrdinalIgnoreCase)); // True

            // 4. CompareTo - 사전순 비교 (정렬에 활용)
            // 반환값: 0 = 같음, 양수 = 현재가 더 뒤, 음수 = 현재가 더 앞
            Console.WriteLine("apple".CompareTo("banana")); // 음수 (apple이 앞)
            Console.WriteLine("banana".CompareTo("apple")); // 양수
            Console.WriteLine("apple".CompareTo("apple"));  // 0

            // 5. StringComparer - IComparer<string> 구현체, Sort/Dictionary에 넣을 때 유용
            string[] words = { "Banana", "apple", "Cherry" };
            Array.Sort(words, StringComparer.OrdinalIgnoreCase); // 대소문자 무시 정렬
            Console.WriteLine(string.Join(", ", words)); // apple, Banana, Cherry

            // 6. Dictionary에 대소문자 무시 키 사용
            var dict = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            dict["Key"] = 1;
            Console.WriteLine(dict.ContainsKey("key")); // True — 대소문자 무시
        }
    }
}
