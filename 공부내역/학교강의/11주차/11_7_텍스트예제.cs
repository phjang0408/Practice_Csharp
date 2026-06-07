namespace MySpace
{
    public class MyClass
    {
        static void Main(string[] args)
        {
            using(StreamWriter sw = new StreamWriter(new FileStream("a.txt", FileMode.Create)))
            {
                // int, double 같은 기본형 데이터는 텍스트로 저장할 때, '문자열'로 변환됨 => 하나당 [1바이트]
                // [줄 바꿈]은 하나에 [2바이트](\r\n)
                // [한글]은 한 글자에 [3바이트], [영어]는 한 글자에 [1바이트]
                // [특수문자](.,!,? 등)은 한 글자에 [1바이트]
                sw.WriteLine(int.MaxValue);         // 2147483647 + 줄바꿈문자 => 10 + 2 (bytes)                => 12 bytes
                sw.WriteLine("Good Morning!");      // 13(영어는 1바이트) + 2 (bytes)                           => 15 bytes
                sw.WriteLine(uint.MaxValue);        // 4294967295 + 줄바꿈문자 => 10 + 2 (bytes)                => 12 bytes
                sw.WriteLine("안녕하세요.");         // 5 * 3(한글은 3바이트) + 1(마침표) + 2 (bytes)            => 18 bytes
                sw.WriteLine(double.MaxValue);      // 1.7976931348623157E+308 + 줄바꿈문자 => 23 + 2 (bytes)   => 25 bytes
            }   // 특히 소수는, '.', '+', '-', 'E' 등의 특수문자도 포함되어 있어, 이것들도 전부 1바이트로 저장됨.

            using(StreamReader sr = new StreamReader(new FileStream("a.txt", FileMode.Open)))
            {   // 12+ 15 + 12 + 18 + 25 = 82 bytes
                Console.WriteLine($"File Size : {sr.BaseStream.Length} bytes");
                while(sr.EndOfStream == false)
                    Console.WriteLine(sr.ReadLine());
            }
        }
    }
}
