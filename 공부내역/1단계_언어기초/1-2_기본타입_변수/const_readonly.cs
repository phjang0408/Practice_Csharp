// const vs readonly
// const   : 컴파일 타임에 값 확정, 선언과 동시에 초기화 필수, 메서드 안에서도 선언 가능
// readonly: 런타임에 값 확정, 생성자에서 한 번만 할당 가능, 필드에서만 선언 가능
namespace DrawPaper
{
    class Program
    {
        const double PI = 3.14159;          // 변하지 않는 고정값 (컴파일 타임)
        readonly int instanceId;            // 객체마다 다를 수 있는 값 (런타임)

        Program(int id)
        {
            instanceId = id;                // 생성자에서 한 번만 할당 가능
            // instanceId = 999;            // 두 번 할당하면 에러
        }

        static void Main(string[] args)
        {
            // const: 메서드 안에서도 선언 가능
            const int MAX_COUNT = 100;
            Console.WriteLine(PI);          // 3.14159
            Console.WriteLine(MAX_COUNT);   // 100

            // const vs readonly 핵심 차이:
            // const는 항상 동일한 값 (바꿀 수 없음)
            // readonly는 인스턴스마다 다를 수 있음 (생성자에서 결정)
            Program p1 = new Program(1);
            Program p2 = new Program(2);
            Console.WriteLine(p1.instanceId);   // 1
            Console.WriteLine(p2.instanceId);   // 2
        }
    }
}
