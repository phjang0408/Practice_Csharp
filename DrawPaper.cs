namespace Drawing
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 128;   // 1000_0000
            sbyte b = (sbyte)a;
            System.Console.WriteLine(a);
            System.Console.WriteLine(b);

            byte c = 255;
            sbyte d = (sbyte)c;
            System.Console.WriteLine(c);
            System.Console.WriteLine(d);

            uint e = uint.MaxValue; // uint형 최대값 4294967295
            Console.WriteLine(e);
            e = e + 1;              // 0000 0000 … … 0000
            Console.WriteLine(e);
            
            int f = int.MaxValue;   // int형 최대값 2147483647
            Console.WriteLine(f);
            f = f + 1;              // 1000 0000 … 0000
            Console.WriteLine(f);
        }
    }
}