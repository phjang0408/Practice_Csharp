
namespace DrawPaper
{
    class Cat
    {
        // 멤버 : 클래스 안에 선언된 모든 구성요소
        // ㄴ 필드 : 데이터 저장 변수
        // ㄴ 메소드 : 동작 함수
        // ㄴ 속성 : 필드 접근용(public, private)
        // ㄴ 생성자, 이벤트...

        public string name;     // 필드 1
        public string Color;    // 필드 2

        public Cat()
        {
            name = "KITT";
        }
        public Cat(string name)
        {
            this.name = name;
        }

        public void Meow()
        {
            Console.WriteLine($"{name} : 야옹~");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat("나비");
            Cat d = new Cat();
            c.Meow();
            d.Meow();
        }
    }
}