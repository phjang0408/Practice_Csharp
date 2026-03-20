// for each문 : 범위기반 for형
namespace DrawPaper
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[]{1,2,3,4,5};
            foreach(int x in ar)
            {
                System.Console.WriteLine(x);
            }
        }
    }

}