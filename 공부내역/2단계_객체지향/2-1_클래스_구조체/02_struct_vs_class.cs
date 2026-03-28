// struct vs class
// struct: 값 타입 (Stack), 상속 불가, 작은 데이터에 적합
// class:  참조 타입 (Heap), 상속 가능, 복잡한 객체에 적합
namespace DrawPaper
{
    // struct (값 타입)
    struct PointStruct
    {
        public int X;
        public int Y;
        public PointStruct(int x, int y) { X = x; Y = y; }
    }

    // class (참조 타입)
    class PointClass
    {
        public int X;
        public int Y;
        public PointClass(int x, int y) { X = x; Y = y; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. struct - 값 복사 (독립적)
            PointStruct s1 = new PointStruct(1, 2);
            PointStruct s2 = s1;        // 값 복사
            s2.X = 999;
            Console.WriteLine($"s1.X={s1.X}");  // 1  (s2 변경이 s1에 영향 없음)
            Console.WriteLine($"s2.X={s2.X}");  // 999

            // 2. class - 참조 복사 (같은 객체)
            PointClass c1 = new PointClass(1, 2);
            PointClass c2 = c1;         // 참조 복사 (같은 객체를 가리킴)
            c2.X = 999;
            Console.WriteLine($"c1.X={c1.X}");  // 999 (c2 변경이 c1에도 영향!)
            Console.WriteLine($"c2.X={c2.X}");  // 999

            // Unity에서는 Vector3가 struct → 값 복사가 일어남
        }
    }
}
