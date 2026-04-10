// var 과 object 타입
// var : 컴파일 타임에 결정, 선언과 초기화를 동시에 해야 함. 바로 사용 가능
// object : 런타임에 메모리 부하, 바로 사용 불가능('형변환'이 필요)
namespace MySpace
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. var: 암시적 타입 (Implicitly Typed)
            // 컴파일러가 타입을 추론함.

            // var a; -> 에러! 초기화 없이 선언 불가
            var vInt = 101;      // 컴파일러가 int로 확정
            var vString = "Hi";  // 컴파일러가 string으로 확정
            // vInt = "Hello"; // 에러! 이미 int로 결정되었기 때문에 다른 타입 대입 불가

            // 2. object: 모든 객체의 조상 (Root Type)
            // 어떤 타입이든 담을 수 있지만, 꺼낼 때 '형변환'이 필요함.
            object objInt = 101;
            object objString = "Hello";

            // 3. 주요 차이점: 데이터 접근
            int sum1 = vInt + 10; // 바로 연산 가능
            
            // int sum2 = objInt + 10; // 에러! object는 숫자 타입이 아니므로 형변환 필수
            int sum2 = (int)objInt + 10; // (int)로 캐스팅해야 사용 가능

            // 4. Boxing & Unboxing (object의 특징)
            // 값 형식(int 등)을 object에 넣으면 메모리 부하가 발생함.
            object boxed = 123;         // Boxing
            int unboxed = (int)boxed;   // Unboxing

            // 출력 확인
            System.Console.WriteLine($"var 타입: {vInt}, {vString}");
            System.Console.WriteLine($"object 타입: {objInt}, {objString}");
        }
    }
}