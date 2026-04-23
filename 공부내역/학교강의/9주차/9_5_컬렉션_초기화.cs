using System.Collections;   // 컬렉션을 담는 네임스페이스
namespace mySpace
{
    class myClass
    {
        
        static void Main(string[] args)
        {
            // 1. 배열로 컬렉션 초기화
            int arr = {123,456,789};
            ArrayList list = new ArrayList(arr);  // 배열로 ArrayList 생성
            Stack stack = new Stack(arr);  // 배열로 Stack 생성
            Queue que = new Queue(arr);  // 배열로 Queue 생성
            
            // 2. 컬렉션 초기자로 초기화
            ArrayList list2 = new ArrayList(){11,22,33};

            // 3. HastTable초기화를 위한 Dictionary Initializer
            Hashtable ht = new Hashtable()
            {
                ["하나"] = "one",
                ["둘"] = "two",
                ["셋"] = "three",
                ["넷"] = "four",
                ["다섯"] = "five"
            };
        }
    }
}