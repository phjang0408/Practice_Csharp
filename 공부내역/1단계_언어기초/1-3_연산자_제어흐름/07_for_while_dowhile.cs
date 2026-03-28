// for / while / do-while
namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. for - 횟수가 정해진 반복, 인덱스가 필요할 때
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"for: {i}");
            }

            // 역순 반복
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine($"역순: {i}");
            }

            // 2. while - 조건이 참인 동안 반복 (횟수 불확실할 때)
            int count = 0;
            while (count < 3)
            {
                Console.WriteLine($"while: {count}");
                count++;
            }

            // 3. do-while - 조건과 관계없이 최소 1번은 실행
            int x = 10;
            do
            {
                Console.WriteLine($"do-while: {x}");  // 조건이 false여도 한 번은 실행됨
                x++;
            } while (x < 5); // x=10이므로 false지만 위 코드는 실행됨

            // for vs foreach 비교
            int[] arr = { 1, 2, 3, 4, 5 };

            // for: 인덱스 접근 가능, 역순 가능
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"for [{i}]: {arr[i]}");
            }

            // foreach: 인덱스 없음, 읽기 전용, 코드가 간결
            foreach (int val in arr)
            {
                Console.WriteLine($"foreach: {val}");
            }
        }
    }
}
