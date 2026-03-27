// goto - 레이블로 점프
// 가독성이 떨어져 일반적으로 권장하지 않지만, 중첩 반복문 탈출에 유용
namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 기본 goto
            Console.WriteLine("1번");
            goto SKIP;
            Console.WriteLine("2번");  // 실행 안 됨
            SKIP:
            Console.WriteLine("3번");  // 여기로 점프

            // 2. 중첩 반복문 탈출 (goto의 유일한 실용적 사용처)
            // break는 가장 안쪽 루프만 탈출하지만, goto는 한번에 전체 탈출 가능
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == 2 && j == 3)
                        goto FOUND;
                    Console.Write($"({i},{j}) ");
                }
                Console.WriteLine();
            }
            FOUND:
            Console.WriteLine("\n(2,3)에서 탈출!");
        }
    }
}
