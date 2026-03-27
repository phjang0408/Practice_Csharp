// 메서드 하이딩 (Hiding) vs 오버라이딩 (Overriding)
// 하이딩:     new 키워드, 부모 타입으로 호출하면 부모 메서드 실행
// 오버라이딩: override 키워드, 부모 타입으로 호출해도 자식 메서드 실행
namespace DrawPaper
{
    // === 하이딩 ===
    class ParentH
    {
        public void Method()
        {
            Console.WriteLine("부모의 메서드");
        }
    }

    class ChildH : ParentH
    {
        public new void Method()    // new: 부모 메서드를 숨김
        {
            Console.WriteLine("자식의 메서드 (hiding)");
        }
    }

    // === 오버라이딩 ===
    class ParentO
    {
        public virtual void Method()
        {
            Console.WriteLine("부모의 메서드");
        }
    }

    class ChildO : ParentO
    {
        public override void Method()   // override: 부모 메서드를 재정의
        {
            Console.WriteLine("자식의 메서드 (override)");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 하이딩: 변수 타입에 따라 호출되는 메서드가 달라짐
            ChildH childH = new ChildH();
            childH.Method();                    // 자식의 메서드 (hiding)
            ((ParentH)childH).Method();         // 부모의 메서드  ← 부모 타입이면 부모 메서드!

            Console.WriteLine("---");

            // 오버라이딩: 변수 타입과 관계없이 실제 객체의 메서드가 호출됨
            ChildO childO = new ChildO();
            childO.Method();                    // 자식의 메서드 (override)
            ((ParentO)childO).Method();         // 자식의 메서드 (override)  ← 부모 타입이어도 자식 메서드!
        }
    }
}
