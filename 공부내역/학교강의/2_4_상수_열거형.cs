namespace DrawPaper
{
    class Program
    {
        enum COLOR
        {
            RED,
            BLUE,
            GREEN = 60,
            BLACK
        }
        static void Main(string[] args)
        {
            const int a = 10;   // 상수임

            Console.WriteLine(COLOR.BLACK);
            Console.WriteLine((int)COLOR.BLACK);

            // 열거형 변수 만들기
            COLOR myColor = COLOR.BLUE;
            Console.WriteLine(myColor == COLOR.BLACK);
        }
    }
}