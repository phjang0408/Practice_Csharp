namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. string.Format(string 문자열 틀, 틀에 들어갈 데이터들...)
            // 문자열 틀의 {0},{1}...을 [서식항목]이라고 함.
            string result = string.Format("오늘: {0}, 내일 : {1}, ", "목", "금");
            Console.WriteLine(result);

            // 서식 항목의 추가옵션 => {첨자, 맞춤 : 서식문자열}
            // 2. 맞춤 = '값' -> '칸의 개수 생성', '부호' -> '방향'

            // {0,-9} : 9칸 생성, 왼쪽 정렬(-)
            Console.WriteLine("{0,-9}DEF", "ABC");

            // {0,8} : 8칸 생성, 오른쪽 정렬(+)
            Console.WriteLine("{0,8}DEF", "ABC");

            string fmt = "{0,-20}{1,-15}{2,30}";    // 총 65칸, 각각 왼쪽-왼쪽-오른쪽 맞춤
            Console.WriteLine(fmt, "Publisher", "Author", "Title");
            Console.WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");

            // 3. 서식문자열
            // ':' 뒤에 서식과 자릿수를 저장할 수 있다.
            // ex) D5 : Decimal, 5자리
            // D = 10진수, X = 16진수, N = 콤마(1000마다), F = float, E = 지수
            Console.WriteLine("서식지정자 : {0:D5}", 123);

            // 4. 서식문자열 예제

            // D : 10진수
            Console.WriteLine("10진수: {0:D}", 123);                    // 10진수: 123
            Console.WriteLine(string.Format("10진수: {0:D}", 123));     
            Console.WriteLine("10진수: {0:D5}", 123);                   // 10진수: 00123
            // X : 16진수
            Console.WriteLine("16진수: 0x{0:X}", 0xFF1234);             // 16진수: 0xFF1234
            Console.WriteLine("16진수: 0x{0:X8}", 0xFF1234);            // 16진수: 0x00FF1234
            // N : 콤마 구분
            Console.WriteLine("콤마: {0:N}", 123456789);                 // 콤마: 123,456,789.00
            Console.WriteLine("콤마: {0:N0}", 123456789);                // 콤마: 123,456,789 => 소수점 제거
            // F : 고정소수점
            Console.WriteLine("고정: {0:F}", 123.45);                    // 고정: 123.45
            Console.WriteLine("고정: {0:F5}", 123.456);                  // 고정: 123.45600 => 소수점 5자리까지 표시
            // E : 지수 표기
            Console.WriteLine("지수: {0:E}", 123.456789);               // 지수: 1.234568E+002 =>
        }
    }
}