// 문자열 백준 자주 쓰는 패턴 모음
// 입력 처리, char 단위 조작, 뒤집기, 팰린드롬, 문자 빈도수
using System.Text;

namespace StringStudy
{
    class BaekjunPatterns
    {
        static void Main(string[] args)
        {
            // ─────────────────────────────────────────────
            // 1. 입력 한 줄 읽기 + 안전하게 처리
            // ─────────────────────────────────────────────
            // string line = Console.ReadLine()!;           // ! : null 아님을 단언
            // string line = Console.ReadLine()?.Trim() ?? ""; // 더 안전한 방법

            // ─────────────────────────────────────────────
            // 2. 공백으로 구분된 정수 파싱 (가장 자주 쓰임)
            // 예: "1 2 3 4 5" → int 배열
            // ─────────────────────────────────────────────
            string input = "1 2 3 4 5";
            int[] nums = input.Split(' ')
                              .Select(int.Parse)
                              .ToArray();
            Console.WriteLine(string.Join(", ", nums)); // 1, 2, 3, 4, 5

            // StringSplitOptions.RemoveEmptyEntries — 연속 공백 있을 때 안전
            string input2 = "10  20  30";
            int[] nums2 = input2.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();
            Console.WriteLine(string.Join(", ", nums2)); // 10, 20, 30

            // ─────────────────────────────────────────────
            // 3. char 배열로 변환 후 개별 처리
            // ─────────────────────────────────────────────
            string word = "hello";
            char[] chars = word.ToCharArray();

            // 문자 → 숫자 변환 (알파벳 순서 등)
            foreach (char ch in chars)
                Console.Write((int)ch + " ");  // 104 101 108 108 111
            Console.WriteLine();

            // ─────────────────────────────────────────────
            // 4. 문자열 뒤집기
            // ─────────────────────────────────────────────
            string original = "abcde";

            // 방법 1: Array.Reverse
            char[] arr = original.ToCharArray();
            Array.Reverse(arr);
            string reversed = new string(arr);
            Console.WriteLine(reversed); // edcba

            // 방법 2: string.Concat + Reverse LINQ
            string reversed2 = new string(original.Reverse().ToArray());
            Console.WriteLine(reversed2); // edcba

            // ─────────────────────────────────────────────
            // 5. 팰린드롬 확인 (앞뒤로 같은 문자열)
            // ─────────────────────────────────────────────
            string CheckPalindrome(string s)
            {
                string rev = new string(s.Reverse().ToArray());
                return s == rev ? "팰린드롬" : "아님";
            }
            Console.WriteLine(CheckPalindrome("racecar")); // 팰린드롬
            Console.WriteLine(CheckPalindrome("hello"));   // 아님

            // ─────────────────────────────────────────────
            // 6. 문자 빈도수 카운팅 (알파벳 26개 등)
            // ─────────────────────────────────────────────
            string sentence = "abracadabra";
            int[] freq = new int[26]; // a=0, b=1, ...

            foreach (char ch in sentence)
                freq[ch - 'a']++;

            for (int i = 0; i < 26; i++)
                if (freq[i] > 0)
                    Console.Write($"{(char)('a' + i)}:{freq[i]} "); // a:5 b:2 c:1 d:1 r:2
            Console.WriteLine();

            // Dictionary로도 가능 (문자 제한 없을 때)
            var dict = new Dictionary<char, int>();
            foreach (char ch in sentence)
                dict[ch] = dict.GetValueOrDefault(ch) + 1;

            foreach (var kv in dict)
                Console.Write($"{kv.Key}:{kv.Value} ");
            Console.WriteLine();

            // ─────────────────────────────────────────────
            // 7. 출력이 많을 때 StringBuilder 사용 (TLE 방지)
            // ─────────────────────────────────────────────
            // BAD:  for (...) Console.WriteLine(i);       ← 느림
            // GOOD: StringBuilder sb = new(); for (...) sb.AppendLine(i.ToString());
            //       Console.Write(sb);
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 5; i++)
                sb.AppendLine(i.ToString());
            Console.Write(sb);
        }
    }
}
