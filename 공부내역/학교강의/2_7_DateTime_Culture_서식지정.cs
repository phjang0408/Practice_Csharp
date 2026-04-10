using System.Globalization;

namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. DateTime
            DateTime dt = new DateTime(2026, 4, 11, 0, 54, 18);
            Console.WriteLine(dt);

            // DateTime 변수를 서식 지정할 수 있다.
            Console.WriteLine("{0:yy-MM-dd tt hh:mm:ss (ddd)}", dt);
            // y : 년도 (뒤 2자리), 
            // M : 월, (대문자임)
            // d : 일, 
            // tt : 오전/오후,

            // h : 12시간, 
            // m : 분, (소문자임)
            // s : 초, 
            // ddd : 요일(짧게-토), dddd(길게-토요일)

            // 2. CultureInfo 클래스
            // 국가별 정렬 방식을 클래스 객체가 담고있다.
            CultureInfo ciKo = new CultureInfo("ko-KR");
            Console.WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)"), ciKo);
            Console.WriteLine(dt.ToString(ciKo));
        }
    }
}