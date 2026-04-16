using System.Globalization;

namespace DrawPaper
{
    class Program
    {
        class Foo
        {
            public int member;
        }
        static void Main(string[] args)
        {
            // 1. >, <, <=, >= 연산자 : 모든 수치형식, 열거형식에 가능

            // 2. ==, != 연산자 : 모든 데이터 형식 가능

            // 3. null 조건부 연산 [?]
            // 객체의 멤버에 접근하기 전, 해당 객체가 null인지 검사
            // null이 아닌 경우, 뒤의 지정된 멤버 반환.
            Foo foo = null;
            int? bar = null;
            Console.WriteLine(foo?.member);  // null 반환
            Console.WriteLine(bar?.ToString());  // null 반환



            // 4. null 병합 연산자 "??"
        }
    }
}