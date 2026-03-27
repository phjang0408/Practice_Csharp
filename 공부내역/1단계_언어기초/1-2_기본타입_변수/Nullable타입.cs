namespace MySpace
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Nullable 타입과 두 가지 속성타입
            int? i = null;                  // ?를 붙여서, Nullable Type으로 사용하면, null값을 가진다.
            Console.WriteLine(i.HasValue);  // 1-1. HasValue - 속성 타입, 값을 가지고 있는지 확인
            Console.WriteLine(i != null);

            i = 101;
            Console.WriteLine(i.HasValue);
            Console.WriteLine(i.Value);     // 1-2. Value - 속성타입, 값을 반환

            // 2. Nullable 타입은 [반드시 초기화] 후 사용해야 한다.
            bool? bb;
            //Console.WriteLine(bb.HasValue);   -> 초기화 하지 않아서, 오류가 발생

            // 3. Nullable를 int로 할당
            Nullable<int> j = null;
            j = 10;
            int k = j.Value;
        }
    }
}