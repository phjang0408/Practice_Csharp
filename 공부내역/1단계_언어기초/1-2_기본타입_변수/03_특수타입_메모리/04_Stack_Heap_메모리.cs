// Stack과 Heap 메모리 구조
// 값 타입(int, float, bool, struct)  → Stack에 저장
// 참조 타입(string, object, class, 배열) → Heap에 저장, Stack에는 주소만 저장
namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 값 타입 - Stack에 직접 저장
            // 복사하면 독립적인 값이 됨
            int a = 10;
            int b = a;      // 값 복사
            b = 20;
            Console.WriteLine(a);   // 10 (b를 바꿔도 a는 안 변함)
            Console.WriteLine(b);   // 20

            // 2. 참조 타입 - Heap에 데이터, Stack에 주소
            // 복사하면 같은 데이터를 가리킴
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = arr1;      // 주소 복사 (같은 배열을 가리킴)
            arr2[0] = 999;
            Console.WriteLine(arr1[0]); // 999 (arr2를 바꾸면 arr1도 변함!)

            // 3. string은 참조 타입이지만 불변(immutable)
            string s1 = "Hello";
            string s2 = s1;
            s2 = "World";           // 새 문자열 생성 (s1과 별개)
            Console.WriteLine(s1);  // Hello
            Console.WriteLine(s2);  // World

            // Stack: 코드 블록 끝나면 자동 정리 (LIFO)
            // Heap : CLR의 가비지 컬렉터(GC)가 정리
        }
    }
}
