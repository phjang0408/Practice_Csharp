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
            System.Console.Write(dt);

            // Nullable 타입
            int? i = null;  // ?를 붙여서, Nullable Type으로 사용하면, null값을 가진다.
            i = 101;

            bool? bb = null;

            // int?를 int로 할당
            Nullable<int> j = null;
            j = 10;
            int k = j.Value;
        }
    }
}