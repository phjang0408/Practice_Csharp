namespace Myspace
{
    class MyClass
    {
        // Stream 클래스 - FileStream, NetworkStream, BufferStream
        static void Main(string[] args)
        {
            // 1. FileStream 인스턴스 생성 , 생성자인자 : (파일 제목, FileMode)
            Stream stream1 = new FileStream("a.dat", FileMode.Create); // 새 파일 생성
            Stream stream2 = new FileStream("b.dat", FileMode.Open); // 파일 열기
            Stream stream3 = new FileStream("c.dat", FileMode.OpenOrCreate); // 파일을 열거나
            // 파일이 없으면 생성
            Stream stream4 = new FileStream("d.dat", FileMode.Truncate); // 파일을 비워서 열기
            Stream stream5 = new FileStream("e.dat", FileMode.Append); // 덧붙이기 모드로 열기
        }
        // 2. Stream 클래스로 부터 물려받은 메소드
        // 매개변수로 byte 또는 byte 배열만 입력 받음
        public override void Write(
            byte[] array, // 쓸 데이터가 담겨 있는 byte 배열
            int offset, // byte 배열 내의 시작 오프셋
            int count // 기록할 데이터의 총 길이(단위는 바이트)
        );
        public override void WriteByte(byte value);
        public override int Read(
            byte[] array, // 읽을 데이터가 담겨 있는 byte 배열
            int offset, // byte 배열 내의 시작 오프셋
            int count // 읽을 데이터의 최대 바이트 수
        );
        public override int ReadByte();

        // 3. BitConverter 클래스
        // byte 배열 <-> 임의의 형식으로 변환 (예: long, int, double 등 <-> byte[] 변환)
        // [왜?] FileStream은 항상 byte 배열만 다루므로, 다른 형식의 데이터는, BitConverter를 거쳐야함.

        // [예제 1] long 형식 데이터를 파일에 기록하기
        void WriteLongToFile()
        {
            long someValue = 0x123456789ABCDEF0;

            // 1) 파일 스트림 생성
            Stream outStream = new FileStream("a.dat", FileMode.Create);

            // 2) GetBytes메서드임 : someValue(long 형식) -> byte 배열로 변환
            byte[] wBytes = BitConverter.GetBytes(someValue);

            // 3) 변환한 byte 배열 -> 파일 스트림을 통해 파일에 기록 
            outStream.Write(wBytes, 0, wBytes.Length);

            // 4) 파일 스트림 닫기
            outStream.Close();

            // long value = 12345;                               
            // stream.Write(value);  // 에러!, 
        }

        // [예제 2] 파일에서 long 형식 데이터 읽기 - 내가 추가한거
        // 읽기도 마찬가지로, BitConverter를 거친 데이터만 읽을 수 있다.
        void ReadLongFromFile()
        {
            byte[] rBytes = new byte[8];

            // 1) 파일 스트림 생성
            Stream inStream = new FileStream("a.dat", FileMode.Open);

            // 2) rBytes의 길이만큼(8바이트) 데이터를 읽어 rBytes에 저장
            inStream.Read(rBytes, 0, rBytes.Length);

            // 3) BitConverter : rBytes안의 값 -> long 형식으로 변환
            long readValue = BitConverter.ToInt64(rBytes, 0);

            // 4) 파일 스트림 닫기
            inStream.Close();
        }
    }
}