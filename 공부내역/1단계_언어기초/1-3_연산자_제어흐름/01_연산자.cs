// 연산자: 산술, 비교, 논리, 삼항
namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 산술 연산자
            int a = 10, b = 3;
            Console.WriteLine(a + b);   // 13
            Console.WriteLine(a - b);   // 7
            Console.WriteLine(a * b);   // 30
            Console.WriteLine(a / b);   // 3  (정수 나눗셈 - 소수점 버림)
            Console.WriteLine(a % b);   // 1  (나머지)
            Console.WriteLine((double)a / b); // 3.333... (실수 나눗셈)

            // 2. 비교 연산자 - 결과는 항상 bool
            Console.WriteLine(a == b);  // False
            Console.WriteLine(a != b);  // True
            Console.WriteLine(a > b);   // True
            Console.WriteLine(a < b);   // False
            Console.WriteLine(a >= 10); // True
            Console.WriteLine(a <= 9);  // False

            // 3. 논리 연산자
            bool t = true, f = false;
            Console.WriteLine(t && f);  // False - 둘 다 true여야 true
            Console.WriteLine(t || f);  // True  - 하나라도 true면 true
            Console.WriteLine(!t);      // False - 반전

            // 단락 평가(Short-circuit): && 는 앞이 false면 뒤를 아예 안 봄
            // || 는 앞이 true면 뒤를 아예 안 봄
            int x = 0;
            bool result = (x != 0) && (10 / x > 1); // x=0이지만 예외 안 남 (앞이 false라 뒤 안 봄)
            Console.WriteLine(result);  // False

            // 4. 삼항 연산자: 조건 ? 참일때값 : 거짓일때값
            int score = 75;
            string grade = score >= 60 ? "합격" : "불합격";
            Console.WriteLine(grade);   // 합격

            // if-else와 동일하지만 한 줄로 표현 가능
            int max = a > b ? a : b;
            Console.WriteLine(max);     // 10
        }
    }
}
