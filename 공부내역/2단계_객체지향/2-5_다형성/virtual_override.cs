// 다형성 (Polymorphism) - virtual / override
// 부모 클래스의 메서드를 자식 클래스에서 재정의
// 부모 타입 변수로 호출해도 자식의 재정의된 메서드가 실행됨
namespace DrawPaper
{
    class Animal
    {
        public int Age { get; set; }

        // virtual: 자식 클래스에서 재정의 가능하다는 표시
        public virtual void Cry()
        {
            Console.WriteLine("소리 내어 웁니다.");
        }
    }

    class Dog : Animal
    {
        // override: 부모의 virtual 메서드를 재정의
        public override void Cry()
        {
            Console.WriteLine("멍멍!");
        }
    }

    class Cat : Animal
    {
        public override void Cry()
        {
            // base: 부모 클래스의 원래 메서드 호출
            base.Cry();
            Console.WriteLine("야옹!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 다형성: 부모 타입 배열에 자식 객체를 담을 수 있음
            Animal[] animals = { new Dog(), new Cat(), new Dog(), new Animal() };

            foreach (Animal a in animals)
            {
                a.Cry();    // 각 객체의 실제 타입에 맞는 메서드가 호출됨
            }
            // 출력:
            // 멍멍!
            // 소리 내어 웁니다.  (base.Cry())
            // 야옹!
            // 멍멍!
            // 소리 내어 웁니다.

            // is 연산자로 타입 확인
            Animal a1 = new Dog();
            Console.WriteLine(a1 is Dog);       // True
            Console.WriteLine(a1 is Animal);    // True
            Console.WriteLine(a1 is Cat);       // False
        }
    }
}
