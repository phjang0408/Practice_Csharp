namespace MySpace
{
    interface INamedValue
    {
        string Name{get; set;}
        string Value{get; set;}
    }
    // 파생 클래스에서 프로퍼티와 인덱서를 반드시 구현해야 함
    // 인터페이스의 프로퍼티 선언은 클래스의 자동구현 프로퍼티 선언과 동일
    class NamedValue : INamedValue{
        // INamedValue 인터페이스 프로퍼티 구현
        // 위해 자동구현 프로퍼티 이용 가능
        string Name{get; set;}
        string Value{get; set;}

        // 여기서는 프로퍼티만 구현했음. [인덱서는 어떻게 하는 지 알아봐야할 듯]
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
