namespace MySpace
{
    public class MyClass
    {
        static void Main(string[] args)
        {
            // 1. StreamWriter 클래스
            StreamWriter sw = new StreamWriter(new FileStream("a.dat",FileMode.Create));
            
            // Write(), WriteLine() 둘 다 오버로딩. 데이터 형식도 다 가능
            sw.Write(32);
            sw.Write("Good Morning!");
            sw.Write(3.14);
            sw.Close();         // 하고 닫아줘야 함.

            // 2. StreamReader 클래스
            StreamReader sr = new StreamReader(new FileStream("a.dat",FileMode.Open));

            while(sr.EndOfStream == false)      //  EndOfStream 프로퍼티는 스트림의 끝에 도달하는지 나타냄
                Console.WriteLine(sr.ReadLine());
            sr.Close();         // 하고 닫아줘야 함.
        }
    }
}
