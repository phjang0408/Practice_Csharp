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
            // 1. >, <, <=, >= 연산자 : 모든 수치형식, 열거형식에 가능 -> bool,string,class,null,deligate 는 X
            // 2. ==, != 연산자 : 모든 데이터 형식 가능 -> 클래스도 가능하지만, 참조값 비교이므로, 같은 멤버값을 가진 객체라도 false 반환

            // 3. null 조건부 연산 [?.]
            // 객체의 멤버에 접근하기 전, 해당 객체가 null인지 [검사]
            // null이 아닌 경우, 뒤의 지정된 멤버 반환.
            Foo foo = null;
            int? bar = null;
            Console.WriteLine(foo?.member);  // null 반환
            Console.WriteLine(bar?.ToString());  // null 반환
            
            // ?[] 연산자 : 배열 요소에 접근하기 전, 해당 배열이 null인지 검사
            int[] arr = null;
            Console.WriteLine(arr?.[0]);  // null 반환

            // 4. null 병합 연산자 "??"
            // null이면 오른쪽, 아니면 왼쪽
            int? num = null;
            Console.WriteLine($" {num ?? 0} ");

            num = 99;
            Console.WriteLine($" {num ?? 00 }");
        }
    }
}