namespace MySpace
{
    public class MyClass
    {
        static void Main(string[] args)
        {
            using(StreamWriter sw = new StreamWriter(new FileStream("a.txt", FileMode.Create)))
            {
                sw.WriteLine(int.MaxValue);
                sw.WriteLine("Good Morning!");
                sw.WriteLine(uint.MaxValue);
                sw.WriteLine("안녕하세요.");
                sw.WriteLine(double.MaxValue);
            }   // 왜 총 82바이트이지?

            using(StreamReader sr = new StreamReader(new FileStream("a.txt", FileMode.Open)))
            {
                Console.WriteLine($"File Size : {sr.BaseStream.Length} bytes");
                while(sr.EndOfStream == false)
                    Console.WriteLine(sr.ReadLine());
            }
        }
    }
}
