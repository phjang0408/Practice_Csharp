namespace Myspace
{
    class MyClass
    {
        static void Main(string[] args)
        {
            Stream stream1 = new FileStream("a.dat", FileMode.Create); // 새 파일 생성
            Stream stream2 = new FileStream("b.dat", FileMode.Open); // 파일 열기
            Stream stream3 = new FileStream("c.dat", FileMode.OpenOrCreate); // 파일을 열거나
            // 파일이 없으면 생성
            Stream stream4 = new FileStream("d.dat", FileMode.Truncate); // 파일을 비워서 열기
            Stream stream5 = new FileStream("e.dat", FileMode.Append); // 덧붙이기 모드로 열기
        }
        public override void Write(
            byte[] array, // 쓸 데이터가 담겨 있는 byte 배열
            int offset, // byte 배열 내의 시작 오프셋
            int count // 기록할 데이터의 총 길이(단위는 바이트)
        );
        public override void WriteByte(byte value);
    }
}