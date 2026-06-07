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
            // 3. null 조건부 연산 "?." 과 "?[]"
            // 객체의 멤버에 접근하기 전, 해당 객체가 null인지 검사
            // null이 아닌 경우, 뒤의 지정된 멤버 반환.
            Foo foo = null;
            int? bar = null;
            Console.WriteLine(foo?.member);  // null 반환
            Console.WriteLine(bar?.ToString());  // null 반환

            // ?[] 연산자 : 배열 요소에 접근하기 전, 해당 배열이 null인지 검사
            int[] arr = null;
            Console.WriteLine(arr?.[0]);  // null 반환
        }
    }
}