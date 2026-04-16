
namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] i = new int[5] { 0, 1, 2, 3, 4, };
            foreach(int x in i)
            {
                Console.WriteLine(x);
                if (x == 3)
                    goto PP;    // 세미콜론
            }

            PP: // : 따옴표
            Console.WriteLine("4에서 나왔습니다.");

        }
    }
}