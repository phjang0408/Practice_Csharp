
namespace DrawPaper
{
    class Program
    {
        // 값 전달 : 복사로 받음
        public static void Swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        // 참조에 의한 전달 : a,b가 같아도 오버로드임
        public static void Swap(ref int a, ref int b)   // ref키워드
        {
            int temp = b;
            b = a;
            a = temp;
        }
        static void Main(string[] args)
        {
            int x = 3, y = 10;
            Console.WriteLine($"x : {x}, y : {y}");

            Swap(x, y);
            Console.WriteLine($"x : {x}, y : {y}");

            Swap(ref x, ref y);     // ref키워드
            Console.WriteLine($"x : {x}, y : {y}");
        }
    }
}