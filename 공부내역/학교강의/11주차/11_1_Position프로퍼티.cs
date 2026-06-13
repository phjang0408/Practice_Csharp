namespace MySpace
{
    public class MyClass
    {
        static void Main(string[] args)
        {
            // Stream.Position프로퍼티 : 읽고/쓰는 위치를 나타내는 포인터, 지금 사용하는 쪽
            // WriteByte() 또는 ReadByte() 메소드를 호출하면 자동으로 Position이 1씩 증가
            // Write() 또는 Read()는 쓰거나 읽은 바이트 수만큼 Position이 증가
            Stream outStream = new FileStream("a.dat", FileMode.Create);
            Pr(outStream.Position);

            outStream.WriteByte(0x01); // Write와 다르게, 한 바이트씩 씀. 바이트 배열이 아닌, 바이트 1개만 처리
            Pr(outStream.Position);

            outStream.WriteByte(0x02);
            Pr(outStream.Position);

            outStream.WriteByte(0x03);
            Pr(outStream.Position);
            // Seek(이동거리, 기준점) : 기준점으로부터, 이동거리만큼, 옮겨주는 함수
            outStream.Seek(5, SeekOrigin.Current); // 현재에서 5바이트만큼 Position을 이동
            Pr(outStream.Position);

            outStream.WriteByte(0x04);
            Pr(outStream.Position);

            outStream.Close();

            // SeekOrigin -> Begin, Current, End 3개 있음
        }
        void Pr(string str)
        { Console.WriteLine($"Position : {str}");}
    }
}
