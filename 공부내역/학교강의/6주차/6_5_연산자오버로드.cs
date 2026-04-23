public class Kilogram
{
    double mass;
    public Kilogram(double value)
    {
        this.mass = value;
    }
    // 사용 형식 : public static '타입' operator 연산자 (매개변수들)
    // 특히 ==은 !=도 같이 정의해야함.
    public static Kilogram operator +(Kilogram p1, Kilogram p2)
    {
        return new Kilogram(p1.mass + p2.mass);
    }

    static void Main(string[] args)
    {
        Kilogram kg1 = new Kilogram(5);
        Kilogram kg2 = new Kilogram(10);

        Kilogram kg3 = kg1 + kg2;   // 오버로딩된 연산자
        Console.WriteLine(kg3.mass);
    }
}