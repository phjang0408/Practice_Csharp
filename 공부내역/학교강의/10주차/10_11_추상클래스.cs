namespace MySpace
{
    abstract class AbstractBase
    {
        // 1. 일반 멤버(변수 등)도 포함 가능하다.
        public string className = "기본 추상 클래스";
        protected void PrivateMethod()
        {
            Console.WriteLine("AbstractBase.PrivateMethod()");
        }
        public void PublicMethod()
        {
            Console.WriteLine("AbstractBase.PublicMethod()");
        }
        public abstract void AbstractMethodA();    // 추상메서드
        // 2. 일반 클래스는 추상 메서드를 절대 가질 수 없음. 가지려면 추상 클래스가 되어야 함.
    }
    // abstract 클래스를 상속받은 일반 클래스는 부모의 미완성 '추상 메서드'를 반드시 구현해야 합니다.
    class Derived : AbstractBase
    {
        // 추상 메서드만 의무적으로 구현해주면 됩니다.
        public override void AbstractMethodA()
        {
            Console.WriteLine("Derived.AbstractMethod()");
            PrivateMethod();
        }
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethodA();
            obj.PublicMethod();
        }
    }
}