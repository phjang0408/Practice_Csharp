<<<<<<< HEAD
namespace mySpace
{
    // 추상 클래스
    // 인스턴스를 가질 수 없음(객체 생성 불가)
    // 접근 제한자를 명시하지 않으면, private로 선언
    abstract class AbstractBase 
    {
        protected void PrivateMethod()
        {
            Console.WriteLine("AbstractBase.Private Method");
        }
        public void PublicMethodA()
        {
            Console.WriteLine("AbstractBase.Public Method");
        }
        // 추상 메서드
        // 파생 클래스에서 override 키워드를 사용하여, 반드시 구현해야 함.
        // public, protected, internal, protected internal 4개만 가능
        public abstract void AbstractMethod();  
    }
    
    class Derived : AbstractBase
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Derived.AbstractMethodA()");
            PrivateMethod();
        }

        static void Main(string[] args)
        {
            AbstractBase obj = new Derived(); // 추상 클래스는 인스턴스화 불가해서, 업캐스팅
            obj.AbstractMethod();
            obj.PublicMethodA();
        }
    }

}

    
=======
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
>>>>>>> 1f5103595ac232657413e57d5f85e2ecc38e22d6
