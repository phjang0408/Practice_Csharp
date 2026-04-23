namespace DrawPaper
{
    class Program
    {
        // static int Sum(int a, int b, int c, ... int i, int j, ...)
        // 인수가 가변길이일 경우 -> "params"키워드 사용!
        // 1. 무조건 마지막 매개변수여야 함
        // 2. 한 메서드에 하나만
        // 3. 배열 직접 넘기는 것도 가능
        static int Sum(params int[] numbers)
        {
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1, 2, 3));
            Console.WriteLine(Sum(1, 2, 3, 4, 5));
            Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
        }
    }
}