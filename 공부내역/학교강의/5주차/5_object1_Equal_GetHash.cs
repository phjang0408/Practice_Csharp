class Person
{
    public string Name;
    public int Age;

    // 동등 비교 재정의 (기본은 참조 비교)
    public override bool Equals(object obj)
    {
        if (obj is Person other)
            return Name == other.Name && Age == other.Age;
        return false;
    }

    // Equals 재정의하면 GetHashCode도 같이 재정의 필수
    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Age); // 두 필드로 해시값 생성
    }
}

class Program
{
    static void Main()
    {
        Person p1 = new Person { Name = "지욱", Age = 20 };
        Person p2 = new Person { Name = "지욱", Age = 20 };

        Console.WriteLine(p1.Equals(p2));      // True  (값이 같으므로)
        Console.WriteLine(p1.GetHashCode() == p2.GetHashCode()); // True
    }
}