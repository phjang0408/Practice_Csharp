// switch expression (C# 8.0+) - 값을 반환하는 switch
// 기존 switch 문(statement)과 달리, case/break 없이 간결하게 사용
namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 기본 switch expression
            int score = 85;
            string grade = score switch
            {
                >= 90 => "A",
                >= 80 => "B",
                >= 70 => "C",
                >= 60 => "D",
                _ => "F"            // _ 는 default와 같음
            };
            Console.WriteLine(grade);   // B

            // 2. 값 매칭
            string day = "월";
            string type = day switch
            {
                "토" or "일" => "주말",
                _ => "평일"
            };
            Console.WriteLine(type);    // 평일

            // 3. 타입 패턴 매칭
            object obj = 3.14;
            string typeName = obj switch
            {
                int => "정수",
                double => "실수",
                string => "문자열",
                _ => "알 수 없음"
            };
            Console.WriteLine(typeName);    // 실수

            // 4. when 조건 추가
            int num = -5;
            string desc = num switch
            {
                > 0 => "양수",
                0 => "영",
                < 0 when num > -10 => "작은 음수",
                _ => "큰 음수"
            };
            Console.WriteLine(desc);    // 작은 음수
        }
    }
}
