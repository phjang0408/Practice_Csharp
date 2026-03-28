// 접근 제한자 & 프로퍼티 (Property)
// public    : 어디서든 접근 가능
// private   : 클래스 내부에서만 접근 (기본값)
// protected : 클래스 내부 + 자식 클래스에서 접근
// internal  : 같은 프로젝트(어셈블리) 내에서 접근
namespace DrawPaper
{
    class Person
    {
        // private 필드 (외부 접근 불가)
        private string name;
        private int age;

        // 프로퍼티 - 필드에 대한 안전한 접근 통로
        public string Name
        {
            get { return name; }
            set { name = value; }   // value: 설정되는 값 (암묵적 매개변수)
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 150)
                {
                    Console.WriteLine("잘못된 나이");
                    return;
                }
                age = value;
            }
        }

        // 읽기 전용 프로퍼티
        public bool IsAdult
        {
            get { return age >= 18; }
        }
    }

    // 자동구현 프로퍼티 (C# 3.0+)
    class NameCard
    {
        public string Name { get; set; } = "Unknown";       // 초기값 지정 가능
        public string Phone { get; set; } = "000-0000";
        public int Id { get; private set; }                  // 외부에서 읽기만 가능

        public NameCard(int id)
        {
            Id = id;    // 내부에서만 설정 가능
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 프로퍼티 사용
            Person p = new Person();
            p.Name = "홍길동";      // set 호출
            p.Age = 25;
            Console.WriteLine($"{p.Name}, {p.Age}세, 성인: {p.IsAdult}");

            p.Age = -5;             // "잘못된 나이" 출력

            // 자동구현 프로퍼티
            NameCard card = new NameCard(1);
            card.Name = "김철수";
            // card.Id = 2;         // 에러! private set
            Console.WriteLine($"{card.Name}, ID: {card.Id}");
        }
    }
}
