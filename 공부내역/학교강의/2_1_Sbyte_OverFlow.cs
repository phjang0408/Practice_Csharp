namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            // sbyte형의 음수 표현
            byte b_a = 255;       // 비트표현: 1111 1111 
            sbyte b_b = (sbyte)b_a;

            byte b_c = 128;       // 비트표현: 1000 0000 
            sbyte b_d = (sbyte)b_c; // sbyte의범위-128 ~ 127

            Console.WriteLine(b_a);
            Console.WriteLine(b_b);
            Console.WriteLine(b_c);
            Console.WriteLine(b_d);

            // OverFlow
            uint i_a = uint.MaxValue; // uint형최대값4294967295
            Console.WriteLine(i_a);
            i_a = i_a + 1;              // 0000 0000 … … 0000
            Console.WriteLine(i_a);
            int i_b = int.MaxValue;   // int형최대값2147483647
            Console.WriteLine(i_b);
            i_b = i_b + 1;              // 1000 0000 … … 0000
            Console.WriteLine(i_b);
        }
    }
}