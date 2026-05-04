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

    