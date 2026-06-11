namespace MySpace
{
    class FriendList
    {
        // list 필드 하나를 가지는, FriendList 클래스 선언
        private List<string> list = new List<string>();

        // 식 본문 멤버 : 본문을 식으로만 표현하는 방식\
        // { return ...; } 대신 => 하나로 본문을 표현하는 문법. 코드가 짧아진다.
        public void Add(string name) => list.Add(name);
        public void Remove(string name) => list.Remove(name);
        public void PrintAll()
        {
            foreach (var s in list)
                Console.WriteLine(s);
        }

        // 생성자, 종료자도 식으로 구현 가능
        public FriendList() => Console.WriteLine("FriendList()"); // 생성자
        ~FriendList() => Console.WriteLine("~FriendList()");

        // 프로퍼티도 구현 가능
        //public int Capacity => list.Capacity; // 읽기전용
        public int Capacity
        {
            get => list.Capacity;
            set => list.Capacity = value;
        }
        // 인덱서도 구현 가능
        //public string this[int index] => list[index]; // 읽기전용
        public string this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            FriendList obj = new FriendList();
            obj.Add("Jane");
            obj.Add("John");
            obj.Add("David");
            obj.Remove("Jane");
            obj.PrintAll();

            // Capacity는 Count와 달리, 2배로 할당, Remove해도 변하지않음 
            Console.WriteLine($"{obj.Capacity}");   
            obj.Capacity = 10;
            Console.WriteLine($"{obj.Capacity}");

            Console.WriteLine($"{obj[0]}");
            obj[0] = "Vincent";
            obj.PrintAll();
        }
    }
}