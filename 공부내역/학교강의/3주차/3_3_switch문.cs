
namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. TryParse함수 : 데이터_형식.TryParse()
            object obj = null;
            string s = Console.ReadLine();

            if (int.TryParse(s, out int out_i))
                obj = out_i;
            else if (float.TryParse(s, out float out_f))
                obj = out_f;
            else
                obj = s;

            switch (obj)
            {
                case int i:
                    Console.WriteLine($"{i}는 int형식");
                    break;
                case float i when i >= 0:   // 2. when절 : switch문에서 조건 검사
                    Console.WriteLine($"{i}는 float형식");
                    break;
                defalut:
                    Console.WriteLine($"{obj}는 무슨형식인지 모르겠네요");
                    break;
            }
        }
    }
}