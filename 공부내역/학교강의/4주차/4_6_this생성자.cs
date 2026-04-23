namespace DrawPaper
{
    class For_This
    {
        int a, b, c;
        public For_This()
        {
            this.a = 5425;
        }
        public For_This(int b) : this() // this는 자기자신의 생성자, ()가 매개변수
        {
            // this.a = 5425;  // this(b)덕에 생략가능
            this.b = b;
        }
        public For_This(int b, int c) : this(b) // For_This(int b)를 불러옴
        {
            // this.a = 5425;  // this()덕에 생략가능
            // this.b = b;     // this(b)덕에 생략가능
            this.c = c;
        }
        public void printField()
        {
            Console.WriteLine($"a = {a}, b = {b}, c = {c}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            For_This a = new For_This();
            a.printField();

            For_This b = new For_This(22);
            b.printField();

            For_This c = new For_This(22, 5959);
            c.printField();
        }
    }
}
