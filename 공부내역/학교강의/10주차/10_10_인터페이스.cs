namespace mySpace
{
    interface INamedValue
    {
        string Name { get; set; }
        string Value { get; set; }
    }
    class NamedValue : INamedValue
    {
        // 파생 클래스에서는, 상속받은 인터페이스의
        // 프로퍼티와 인덱서를 반드시 구현해야 함.
        public string Name { get; set; }
        public string Value { get; set; }
        static void Main(string[] args)
        {
            NamedValue name = new NamedValue()
            { Name = "이름", Value = "홍길동" };

            NamedValue height = new NamedValue()
            { Name = "키", Value = "175cm" };

            Console.WriteLine($"{name.Name} : {name.Value}");
            Console.WriteLine($"{height.Name} : {height.Value}");
        }
    }
}

    