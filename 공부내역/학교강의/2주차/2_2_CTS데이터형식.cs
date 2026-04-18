namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            // CTS 데이터 형식 (모든 .NET호환언어들이 따르는 데이터형식표준)
            // CTS에서 정의하는 데이터형식을 모두 구현 할 필요는 없음

            // C#의 데이터 형식체계가 CTS 표준을 따름
            // => CTS의 데이터형식은 코드에서 그대로 사용가능
            System.Int32 a = 123;
            int b = 456;
            Console.WriteLine("a type : {0}, value : {1}", a.GetType(), a);
            Console.WriteLine("b type : {0}, value : {1}", b.GetType(), b);

            System.String c = "HELLO";
            string d = "HELLO";
            Console.WriteLine("c type : {0}, value : {1}", c.GetType(), c);
            Console.WriteLine("d type : {0}, value : {1}", d.GetType(), d);
            Console.WriteLine($"{c.GetType()} is format size");

            System.Single f = 3.14f;
            System.Double g = 123.45;
        }
    }
}