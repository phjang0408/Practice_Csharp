namespace MySpace
{
    public class MyClass
    {
        static void Main(string[] args)
        {
            using (BinaryWriter bw = new BinaryWriter(new
            FileStream("a.dat", FileMode.Create)))
            {   // 순서는 항상 기억! int-string-uing-string-double
                bw.Write(int.MaxValue);     // 4(bytes)
                bw.Write("Good Morning!");  // 영어는 한 글자에 1(bytes) => 1 + 13(bytes) = 14
                bw.Write(uint.MaxValue);    // 4(bytes)
                bw.Write("안녕하세요.");       // "한글"은 한 글자에 3(bytes) => 1 + (3*5) + 1(마침표)로 총 17
                bw.Write(double.MaxValue);  // 8(bytes)
                // 4 + 14 + 4 + 17 + 8 = 47(bytes)
            }

            using BinaryReader br = new BinaryReader(new
            FileStream("a.dat", FileMode.Open));
            Console.WriteLine($"File Size : {br.BaseStream.Length}"); // 오류 없음, 맛 감걍
            // 순서는 쓸 떄와 같이 적용
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadUInt32());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadDouble());
        }
    }
}
