// checked / unchecked 블록
// 기본적으로 C#은 overflow가 발생해도 예외를 던지지 않고 그냥 넘어감 (unchecked 상태)
// checked 블록 안에서는 overflow 발생 시 OverflowException을 던짐
namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MaxValue; // 2147483647

            // unchecked (기본값): overflow 발생해도 예외 없이 wrap-around
            int result1 = unchecked(max + 1);
            Console.WriteLine(result1);         // -2147483648 (wrap-around)

            // checked: overflow 발생 시 OverflowException 예외 발생
            try
            {
                int result2 = checked(max + 1);
                Console.WriteLine(result2);
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"오버플로우 발생: {e.Message}");
            }

            // checked 블록 형태로도 사용 가능
            checked
            {
                byte b = 200;
                try
                {
                    b = (byte)(b + 100); // 300은 byte 범위(0~255) 초과
                }
                catch (OverflowException)
                {
                    Console.WriteLine("byte overflow!");
                }
            }
        }
    }
}
