using System.IO;
using FS = System.IO.FileStream;
namespace MySpace
{
    public class MyClass
    {
        static void Main(string[] args)
        {   
            long someValue = 0x123456789ABCDEF0;
            Console.WriteLine("{0,-13} : 0x{1:X16}","Original Data", someValue);

            using (Stream outStream = new FileStream("a.dat", FileMode.Create))
            {
                byte[] wBytes = BitConverter.GetBytes(someValue); 
                Console.Write("{0,-13} : ", "Byte Array");// [F0, DE, BC, 9A, 78, 56, 34, 12]
                foreach(byte b in wBytes)
                {
                    Console.Write("{0:X2} ", b);
                }
                Console.WriteLine();

                outStream.Write(wBytes,0,wBytes.Length);
            }// 여기서 oustStream 자동 Dispose()
            // using 선언문 아래에, 코드블럭 만드는 방법, {}사용버전(statement)

            using Stream inStream = new FS("a.dat",FileMode.Open);
            byte[] rbytes = new byte[8];

            int i = 0;
            while (inStream.Position < inStream.Length)
            {
                rbytes[i++] = (byte)inStream.ReadByte(); // ReadByte는, byte -> int로 반환
            }
            long readValue = BitConverter.ToInt64(rbytes, 0); // 인덱스 0부터, Int64=long이랑 같음.
            Console.WriteLine("{0,-13} : 0x{1:X16} ", "Read Data", readValue);
        }// inStream은 여기서 자동 Dispose()
    }
}