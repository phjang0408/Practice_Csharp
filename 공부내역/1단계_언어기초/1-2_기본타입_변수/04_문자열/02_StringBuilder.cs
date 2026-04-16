// StringBuilder - 반복 문자열 연결 시 성능 최적화
// string은 불변(immutable)이라 + 연산마다 새 객체 생성 → 반복이 많을수록 느려짐
// StringBuilder는 내부 버퍼를 재사용 → 반복 연결에 적합
using System.Text;

namespace StringStudy
{
    class SbDemo
    {
        static void Main(string[] args)
        {
            // 1. 기본 사용
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.Append(", ");
            sb.Append("World");
            sb.AppendLine("!");          // 뒤에 \n 자동 추가
            sb.Append("C# is fun");
            Console.WriteLine(sb.ToString());

            // 2. 메서드 체이닝 - Append는 StringBuilder 자신을 반환하므로 연결 가능
            StringBuilder sb2 = new StringBuilder();
            sb2.Append("이름: ").Append("홍길동").AppendLine()
               .Append("나이: ").Append(25);
            Console.WriteLine(sb2.ToString());

            // 3. Insert / Remove / Replace
            StringBuilder sb3 = new StringBuilder("Hello World");
            sb3.Insert(5, ",");          // "Hello, World"
            sb3.Replace("World", "C#"); // "Hello, C#"
            Console.WriteLine(sb3.ToString());

            // 4. Length / Clear
            Console.WriteLine($"길이: {sb3.Length}");
            sb3.Clear();
            Console.WriteLine($"Clear 후 길이: {sb3.Length}");

            // 5. 성능 비교 예시 (백준에서 출력이 많을 때 자주 사용)
            // BAD  : string result = ""; for (...) result += i;  → 느림
            // GOOD : StringBuilder sb = new(); for (...) sb.Append(i); Console.Write(sb);
            StringBuilder output = new StringBuilder();
            for (int i = 1; i <= 5; i++)
            {
                output.Append(i);
                if (i < 5) output.Append(" ");
            }
            Console.WriteLine(output.ToString()); // 1 2 3 4 5
        }
    }
}
