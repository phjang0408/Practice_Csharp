// enum class 형식
namespace DrawPaper
{
    public class Program{
        enum MD
        {
            YES,
            NO,
            CANCEL,
            CONFIRM
        }
        static void Main(string[] args)
        {
            Console.WriteLine((double)MD.YES);
            Console.WriteLine((int)MD.YES);
            Console.WriteLine(MD.YES);
        }
    }
    
}