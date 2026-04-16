
namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            while (i > 0)
            {
                Console.WriteLine($"a) i : {i--}");
            }

            do
            {
                Console.WriteLine($"b) i : {i--}");
            } while (i > 0);
        }
    }
}