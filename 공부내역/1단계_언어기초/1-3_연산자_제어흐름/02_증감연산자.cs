// 증감 연산자 (++, --) - 전위(prefix) vs 후위(postfix) 차이
namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 전위 증감: 먼저 증가/감소 후 값 사용
            int a = 5;
            int b = ++a;            // a를 먼저 6으로 만든 후 b에 대입
            Console.WriteLine($"a={a}, b={b}");  // a=6, b=6

            // 2. 후위 증감: 값을 먼저 사용 후 증가/감소
            int c = 5;
            int d = c++;            // c의 현재값(5)을 d에 대입한 후 c를 6으로
            Console.WriteLine($"c={c}, d={d}");  // c=6, d=5

            // 3. 전위 감소
            int e = 10;
            int f = --e;
            Console.WriteLine($"e={e}, f={f}");  // e=9, f=9

            // 4. 후위 감소
            int g = 10;
            int h = g--;
            Console.WriteLine($"g={g}, h={h}");  // g=9, h=10

            // 5. 단독 사용 시에는 차이 없음
            int x = 0;
            x++;    // x = 1
            ++x;    // x = 2
            Console.WriteLine(x);   // 2
        }
    }
}
