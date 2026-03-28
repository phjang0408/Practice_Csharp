// 복합대입연산자 & 비트 연산자
namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            // ===== 1. 복합대입연산자 =====
            int a = 10;
            a += 5;     // a = a + 5  → 15
            a -= 3;     // a = a - 3  → 12
            a *= 2;     // a = a * 2  → 24
            a /= 4;     // a = a / 4  → 6
            a %= 4;     // a = a % 4  → 2
            Console.WriteLine(a);   // 2

            // ===== 2. 비트 연산자 =====
            int x = 0b1010;     // 10
            int y = 0b1100;     // 12

            // AND (&): 둘 다 1이면 1
            Console.WriteLine($"AND: {Convert.ToString(x & y, 2).PadLeft(4, '0')}");  // 1000

            // OR (|): 하나라도 1이면 1
            Console.WriteLine($"OR:  {Convert.ToString(x | y, 2).PadLeft(4, '0')}");  // 1110

            // XOR (^): 서로 다르면 1
            Console.WriteLine($"XOR: {Convert.ToString(x ^ y, 2).PadLeft(4, '0')}");  // 0110

            // NOT (~): 비트 반전
            byte b = 0b1010_0101;   // 165
            byte notB = (byte)~b;   // 0101_1010 → 90
            Console.WriteLine($"NOT: {Convert.ToString(notB, 2).PadLeft(8, '0')}");

            // ===== 3. 시프트 연산자 =====
            int val = 1;
            Console.WriteLine(val << 1);    // 2   (1을 왼쪽으로 1칸 = ×2)
            Console.WriteLine(val << 3);    // 8   (1을 왼쪽으로 3칸 = ×8)

            int big = 16;
            Console.WriteLine(big >> 1);    // 8   (16을 오른쪽으로 1칸 = ÷2)
            Console.WriteLine(big >> 2);    // 4   (16을 오른쪽으로 2칸 = ÷4)

            // ===== 4. 비트 복합대입 =====
            int z = 0b1111;
            z &= 0b1010;   // AND 대입 → 1010
            Console.WriteLine(Convert.ToString(z, 2));  // 1010

            z |= 0b0101;   // OR 대입  → 1111
            Console.WriteLine(Convert.ToString(z, 2));  // 1111

            z <<= 2;       // 왼쪽 시프트 대입
            Console.WriteLine(z);   // 60 (1111 → 111100)
        }
    }
}
