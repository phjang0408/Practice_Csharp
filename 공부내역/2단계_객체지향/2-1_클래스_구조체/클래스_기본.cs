// 클래스 기본 - 필드, 메서드, 생성자, this 키워드
namespace DrawPaper
{
    // 클래스 정의
    class Circle
    {
        // 필드
        double radius;

        // 생성자 - 객체 생성 시 자동 호출
        public Circle(double radius)
        {
            this.radius = radius;   // this: 현재 인스턴스를 가리킴
        }

        // 생성자 오버로딩
        public Circle() : this(1.0)  // 다른 생성자 호출 (생성자 체이닝)
        {
        }

        // 메서드
        public double GetArea()
        {
            return 3.14 * radius * radius;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"반지름: {radius}, 넓이: {GetArea():F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 객체 생성 (인스턴스화)
            Circle c1 = new Circle(5.0);
            c1.PrintInfo();     // 반지름: 5, 넓이: 78.50

            Circle c2 = new Circle();   // 기본 생성자
            c2.PrintInfo();     // 반지름: 1, 넓이: 3.14

            // 값 타입 vs 참조 타입 복사
            Circle c3 = c1;     // 같은 객체를 가리킴 (참조 복사)
        }
    }
}
