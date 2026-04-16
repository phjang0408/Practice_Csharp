
namespace DrawPaper
{
    class ReturnTest
    {
        public int Fibonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public void PrintProfile(string name, string phone)
        {
            if (name == "")
            {
                Console.WriteLine("이름을 입력하세요");
                return;
            }
            Console.WriteLine($"{name}과 {phone} 입니다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ReturnTest RT = new ReturnTest();

            // 1. 재귀호출 Fibonacci
            Console.WriteLine("10번째 수 : {0}", RT.Fibonacci(10));

            // 2. return으로 종결
            RT.PrintProfile("", "123-4567");
            RT.PrintProfile("박수", "123-4567");
        }
    }
}