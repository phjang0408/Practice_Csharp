// 명명된 인수 (Named Arguments) & 선택적 매개변수 (Optional Parameters)
namespace DrawPaper
{
    class Program
    {
        // 선택적 매개변수: 기본값을 지정하면 호출 시 생략 가능
        static void PrintInfo(string name, int age = 0, string city = "미정")
        {
            Console.WriteLine($"이름: {name}, 나이: {age}, 도시: {city}");
        }

        static void Main(string[] args)
        {
            // 1. 선택적 매개변수 - 뒤에서부터 생략 가능
            PrintInfo("홍길동", 25, "서울");    // 전부 지정
            PrintInfo("홍길동", 25);            // city 생략 → "미정"
            PrintInfo("홍길동");                // age, city 생략 → 0, "미정"

            // 2. 명명된 인수 - 이름을 지정해서 순서 무시 가능
            PrintInfo(name: "김철수", city: "부산", age: 30);
            PrintInfo("이영희", city: "대전");   // age 생략, city만 지정

            // 명명된 인수가 유용한 경우:
            // - 매개변수가 많아서 순서가 헷갈릴 때
            // - 중간 매개변수는 기본값 쓰고, 뒤의 매개변수만 지정할 때
        }
    }
}
