// break / continue
namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. break - 반복문을 즉시 탈출
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break;              // i가 5가 되면 루프 종료
                Console.WriteLine(i);  // 0, 1, 2, 3, 4
            }

            // 2. continue - 현재 반복만 건너뛰고 다음 반복으로
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    continue;           // 짝수면 건너뜀
                Console.WriteLine(i);   // 1, 3, 5, 7, 9
            }

            // 3. 중첩 반복문에서 break는 가장 안쪽 루프만 탈출
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 1)
                        break;          // 안쪽 루프만 탈출, 바깥 루프는 계속
                    Console.WriteLine($"i={i}, j={j}");
                }
            }
            // 출력: i=0,j=0 / i=1,j=0 / i=2,j=0
        }
    }
}
