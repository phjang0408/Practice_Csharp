
namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. TryParse() : 문자열 -> 숫자로 변환
            // 반환값   => Parse : 반환 값     TryParse : bool
            // 결과값   => Parse : 직접 반환    TryParse : out 매개변수로 받음
            // 실패처리  => Parse : 에러 발생   TryParse : false반환, 예외 없음    
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
                // 2. when절 : switch문에서 조건 검사
                case float i when i >= 0:   
                    Console.WriteLine($"{i}는 float형식");
                    break;
                defalut:
                    Console.WriteLine($"{obj}는 무슨형식인지 모르겠네요");
                    break;
            }
        }
    }
}