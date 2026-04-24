
namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 비트 연산자
            int A = 9, B = 10;
            Console.WriteLine($"a << 1 : {A << 1}");
            Console.WriteLine($"b >> 2 : {B >> 2}");
            Console.WriteLine($"a & b : {A & B}");  
            Console.WriteLine($"a | b : {A | B}");  
            Console.WriteLine($"a ^ b: {A ^ B}");   
            Console.WriteLine($"~a : {~A}");

            // 2. 시프트 연산자
            Console.WriteLine("-------------------");

            int a = 1, b = 255;
            Console.WriteLine("a  : {0:D5} (0x{0:X8})", a);
            Console.WriteLine("a  : {0:D5} (0x{0:X8})", a << 1);
            Console.WriteLine("a  : {0:D5} (0x{0:X8})", a << 3);

            Console.WriteLine("b : {0:D5} (0x{0:X8})", b);
            Console.WriteLine("b : {0:D5} (0x{0:X8})", b >> 1);

            int c = -255;       // Testing negative number >>...
            Console.WriteLine("c     : {0:D5} (0x{0:X8})", c);
            Console.WriteLine("c >> 1: {0:D5} (0x{0:X8})", c >> 1);
            Console.WriteLine("c >> 2: {0:D5} (0x{0:X8})", c >> 2);
            Console.WriteLine("c >> 5: {0:D5} (0x{0:X8})", c >> 5);
        }
    }
}