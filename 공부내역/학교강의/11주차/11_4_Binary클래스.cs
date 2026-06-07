namespace MySpace
{
    public class MyClass
    {
        // FileStream은 byte 단위로 처리 -> 불편
        // BinaryWriter, BinaryReader
        static void Main(string[] args)
        {
            // 1. BinaryWriter : Reader도 마찬가지로, "생성자 인자로, Stream객체를 받음"
            BinaryWriter bw = new BinaryWriter(new
            FileStream("a.dat", FileMode.Create));

            // Write()는 모든 기본데이터형식에 오버로딩
            bw.Write(32);              // 4바이트로 변환되어 저장
            bw.Write("Good Morning!"); // 문자열 길이정보 : 1바이트, 문자열데이터 : 13바이트 => 총 14바이트를 사용
            bw.Write(3.14);            // 8바이트로 저장되어 저장

            // 2. BinaryReader
            BinaryReader br = new BinaryReader(new
            FileStream("a.dat", FileMode.Open));

            // 읽을 데이터 형식별로, ReadInt32처럼, Read데이터형식()을 제공, 해당 형식을 반환
            // 데이터 형식별 메서드를, 'Write한 순서'대로, 사용해야 함.
            int a = br.ReadInt32();
            string b = br.ReadString();
            double c = br.ReadDouble();

            br.Close();
        }
    }
}
