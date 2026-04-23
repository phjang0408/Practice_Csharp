using System.Collections;   // 컬렉션을 담는 네임스페이스
namespace mySpace
{
    class myClass
    {

        static void Main(string[] args)
        {
            // 1. Hashtable : 키와 값으로 이루어진 데이터 저장, 키는 중복 불가능
            // 키는 []로 접근, 값은 =으로 저장
            // 키는 object 타입이므로 다양한 객체 사용 가능
            // 키로 값을 저장하는 방식이므로, 검색이 빠름
            Hashtable ht = new Hashtable();
            ht["하나"] = "one";
            ht["둘"] = "two";
            ht["셋"] = "three";
            ht["넷"] = "four";
            ht["다섯"] = "five";
            Console.WriteLine(ht["하나"]);
            Console.WriteLine(ht["둘"]);
            Console.WriteLine(ht["셋"]);
            Console.WriteLine(ht["넷"]);
            Console.WriteLine(ht["다섯"]);
        }
    }
}