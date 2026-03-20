// 숫자 - 문자 형 변환
namespace DrawPaper
{
    public class Program{
        static void Main(string[] args)
        {
            int a = 123;
            string b = a.ToString();
            Console.WriteLine(b);

            string c = "12345";
            int d = int.Parse(c);
            Console.WriteLine(d);
        }
    }
    
}