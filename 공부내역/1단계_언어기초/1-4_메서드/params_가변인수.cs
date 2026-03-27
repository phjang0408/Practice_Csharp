// params - 가변 개수의 인수
// 매개변수 개수가 유동적일 때 배열 대신 params 사용
namespace DrawPaper
{
    class Program
    {
        // params: 인수 개수를 자유롭게 전달
        static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        // params는 마지막 매개변수여야 함
        static void PrintAll(string label, params object[] items)
        {
            Console.Write($"{label}: ");
            foreach (var item in items)
                Console.Write($"{item} ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // 인수 개수를 자유롭게 전달
            Console.WriteLine(Sum(1, 2));               // 3
            Console.WriteLine(Sum(1, 2, 3));            // 6
            Console.WriteLine(Sum(1, 2, 3, 4, 5));     // 15

            // 배열을 직접 전달해도 됨
            int[] arr = { 10, 20, 30 };
            Console.WriteLine(Sum(arr));                // 60

            PrintAll("과일", "사과", "배", "포도");
            PrintAll("혼합", 1, "hello", 3.14, true);
        }
    }
}
