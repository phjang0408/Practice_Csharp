
namespace DrawPaper
{
    class MyClass
    {
        public static int a;

        // 클래스에 소속된다는 것은, 프로그램 전체에 유일한 필드
        // -> 같은 클래스의 인스턴스가 몇 개든 static은 그 클래스에 1개
        // 클래스가 아닌 다른곳이면, 객체마다 각각의 필드가 존재한다는 것
        // -> 같은 네임스페이스에, 동명의 static 가능
        public static int count = 0;
    }
    class CA
    {
        public CA()
        {
            MyClass.count++;
        }
    }
    class CB
    {
        public CB()
        {
            MyClass.count++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 개념
            MyClass.a = 1;
            Console.WriteLine(MyClass.a);   // 객체 생성 없이 접근

            MyClass refer = new MyClass();
            // Console.WriteLine(refer.a);  -> 객체로 접근하면 오류!

            // 2. 프로그램 전체가 공유
            Console.WriteLine($"Global Count : {MyClass.count}");
            new CA();
            new CB();
            Console.WriteLine($"Global Count : {MyClass.count}");
        }
    }
}