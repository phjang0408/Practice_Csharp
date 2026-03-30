// 부호 여부에 따른 형 변환
namespace DrawingPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 500;
            uint b = (uint)a;
            Console.WriteLine(b);

            int x = -30;
            uint y = (uint)x;   // int.Maxvalue + 29 정도
            Console.WriteLine(y);
        }
    }
}