namespace MySpace
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;

            //Numeric
            short sh = -32768;
            float f = 123.45f;

            // char/string
            char c = 'A';
            string s = "Hello";
            
            // DateTime
            DateTime dt = new DateTime(2026, 3, 19, 23, 10, 0);
            System.Console.WriteLine(dt);

        }
    }
}