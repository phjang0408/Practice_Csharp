// ref와 out 매개변수
// ref : 호출 전에 초기화 필수, 메서드 안에서 값 변경 가능
// out : 호출 전 초기화 불필요, 메서드 안에서 반드시 값 할당해야 함
namespace DrawPaper
{
    class Program
    {
        // ref: 값을 읽고 쓸 수 있음
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // out: 여러 결과를 반환할 때 사용
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        static void Main(string[] args)
        {
            // 1. ref 사용 - 호출 전 초기화 필수
            int x = 10, y = 20;
            Console.WriteLine($"교환 전: x={x}, y={y}");
            Swap(ref x, ref y);
            Console.WriteLine($"교환 후: x={x}, y={y}");   // x=20, y=10

            // 2. out 사용 - 호출 전 초기화 불필요
            Divide(20, 3, out int q, out int r);
            Console.WriteLine($"20÷3 = 몫:{q}, 나머지:{r}");   // 몫:6, 나머지:2

            // 3. ref vs out 핵심 차이
            // ref: 메서드 안에서 값을 할당하지 않아도 됨 (읽기용으로도 사용)
            // out: 메서드 안에서 반드시 값을 할당해야 컴파일 통과
        }
    }
}
