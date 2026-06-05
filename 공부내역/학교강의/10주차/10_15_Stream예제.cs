namespace Myspace
{
    class MyClass
    {
        static void Main(string[] args)
        {
            // 1. Write예제
            long someValue = 0x123456789ABCDEF0;
            // X16에서 X는 수를 16진수로 표현하고 뒤의 숫자 16은 열여섯 자리 수로 표현
            Console.WriteLine("{0,-13} : 0x{1:X16}", "Original Data", someValue);

            Stream outStream = new FileStream("a.dat". FileMode.Create);
            byte[] wBytes = BitConverter.GetBytes(someValue); 
            // 'someValue'(long) --BitConverter.GetBytes--> 'wBytes'(byte[])
            Console.Write("{0,-13} : ","Byte Array");

            foreach(byte b in wBytes)
            {
                Console.Write("{0:X2} ", b);
            }
            Console.WriteLine();
    
            outStream.Write(wBytes, 0, wBytes.Length); // wBytes를, 0부터, wBytes.Length만큼, outStream에 Write
            outStream.Close();

            // 2. Read 예제
            byte[] rBytes = new byte[8]; // 8바이트 저장공간
            Stream inStream = new FileStream("a.dat",Filemode.Open);
            inStream.Read(rBytes, 0, rBytes.Length); // 파일에서 8바이트만큼 읽어, rBytes에 저장

            long readValue = BitConverter.Toint64(rBytes,0); // rBytes를 long으로 변환
            Console.WriteLine("{0,-13} : 0x{1:X16}", "Read Data", readValue);
            inStream.Close();
            //Original Data : 0x123456789ABCDEF0
            //Byte array : F0 DE BC 9A 78 56 34 12  (원본 : 0x123456789ABCDEF0 / C#은 데이터가 내림차순으로 출력되는, 리틀 앤디안방식)
            //Read Data : 0x123456789ABCDEF0

            /* 요약
               // [쓰기]
               Stream outStream = new FileStream("a.dat", FileMode.Create);
               byte[] wBytes = BitConverter.GetBytes(someValue);  // long → byte[]
               outStream.Write(wBytes, 0, wBytes.Length);         // (배열, offset, 개수)

               // [읽기]
               byte[] rBytes = new byte[8];
               Stream inStream = new FileStream("a.dat", FileMode.Open);
               inStream.Read(rBytes, 0, rBytes.Length);           // (배열, offset, 개수)
               long readValue = BitConverter.ToInt64(rBytes, 0);  // byte[] → long

               // [닫기]
               outStream.Close();
               inStream.Close();
               ================================================================ */
        }
    }
}