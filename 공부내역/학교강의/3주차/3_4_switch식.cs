
namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            // switch문은 작업에 분기를 사용할 때, switch 식은 결과값을 내 놓을 때.
            // 조건식을 switch 키워드 앞으로 위치
            // "case: :" 대신에 “=>”
            // “break;” 대신에 콤마(,)
            // default 키워드 대신에 “_”
            // 세미콜론 “;”으로 종료

            Console.Write("성적을 정수로 입력 : ");
            string input = Console.ReadLine();
            int.TryParse(input, out int score);

            bool repeated = true;
            string grade = score switch
            {
                90 => "A",
                80 when repeated == true => "B+",
                80 => "B",
                70 => "C",
                _ => "F"
            };
            Console.WriteLine($"성적은 : {grade}");
        }
    }
}