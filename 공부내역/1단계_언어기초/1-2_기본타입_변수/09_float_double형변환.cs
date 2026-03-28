// float <-> double 형 변환
// 2진수 -> 10진수 -> 2진수로 변환하기에, 정밀도 손상 발생
namespace DrawingPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            float c = 0.1f;
            Console.WriteLine(c);
            double d = (double)c;
            Console.WriteLine(d);
        }
    }
}