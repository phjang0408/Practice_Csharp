namespace MySpace
{
    public class MyClass
    {
        // using 키워드 : 네임스페이스 import로 써왔지만,
        // 블럭이 끝나면 자동 리소스 해제의 역할도 함.
        static void Main(string[] args)
        {
            // 1. 파일 스트림 생성
            // 기존 : Stream outStream = new FileStream("a.dat", FileMode.Create);
            using Stream outStream = new FileStream("a.dat", FileMode.Create);
            // [추가] 기존 using은 {}로 using 뒤로 (사용 객체){코드블럭}이지만, 8.0이상은 {}가 없어도 된다.}

            // 2. someValue(long 형식)를 byte 배열 형식으로 변환
            byte[] wBytes = BitConverter.GetBytes(someValue);
            
            // 3. 변환한 byte 배열 -> 파일 스트림을 통해 기록
            outStream.Write(wBytes, 0, wBytes.Length);

            // using 선언을 통해 코드 블록이 끝나면서 outStream.Dispose() 자동 호출
            // 기존 : outStream.Close();
            
        }// 블럭이 끝나면, 자동으로 outStream.Dispose(); 호출!
    }
}
