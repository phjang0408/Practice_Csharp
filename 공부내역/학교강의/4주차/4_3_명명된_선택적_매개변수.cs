// 명명된 인수 (Named Arguments) & 선택적 매개변수 (Optional Parameters)
namespace DrawPaper
{
    class Program
    {
        static void PrintInfo(string name, int age = 0, string city = "미정")
        {
            Console.WriteLine($"이름: {name}, 나이: {age}, 도시: {city}");
        }

        static void Main(string[] args)
        {
            // 1. 선택적 매개변수
            // [매개변수가 기본값을 가지면], 인자를 생략해도 된다.
            PrintInfo("홍길동", 25, "서울");    // 전부 지정
            PrintInfo("홍길동", 25);            // city 생략 → "미정"
            PrintInfo("홍길동");                // age, city 생략 → 0, "미정"
            // 오버로딩과 합쳐지면, 혼란 야기!


            // 2. 명명된 인수
            // 이름으로 '지정'해서 인자 전달 => [순서 무시 가능]
            PrintInfo(city: "부산", name: "김철수", age: 30);
            PrintInfo("이영희", city: "대전");   // age 생략, city만 지정

            // 명명된 인수가 유용한 경우:
            // - 매개변수가 많아서 순서가 헷갈릴 때
            // - 중간 매개변수는 기본값 쓰고, 뒤의 매개변수만 지정할 때
        }
    }
}
