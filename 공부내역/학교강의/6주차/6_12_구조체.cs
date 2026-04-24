using System.Drawing;

namespace myspace
{
    struct ThreeD{  // 상속 불가능!
        public int X;
        public int Y;
        public int Z;
        // 생성자는 매개변수가 필수
        public ThreeD(int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
        public override string ToString()
        {
            return string.Format($"{X}, {Y}, {Z}");
        }
        public static bool operator ==(ThreeD p1, ThreeD p2)
        {
            return p1.X == p2.X;
        }
        public static bool operator !=(ThreeD p1, ThreeD p2)
        {
            return !(p1 == p2); // 위에서 만든 ==를 재활용
        }
        // Main은 struct안에서도 작동
        static void Main(string[] args)
        {
            ThreeD p1;  // 값으로 선언(new필요없음)
            p1.X = 10; p1.Y = 20;p1.Z = 40;
            Console.WriteLine(p1);

            ThreeD p2 = new ThreeD(100, 200, 300);
            ThreeD p3 = p2; // 구조체는 값 타입이라, 값이 복사됨(깊은복사)
            p3.Z = 400;
            Console.WriteLine(p2.ToString()); // p3를 바꿔도 원본은 유지됨 : 다른객체
            Console.WriteLine(p3.ToString());
        }
    }
}
