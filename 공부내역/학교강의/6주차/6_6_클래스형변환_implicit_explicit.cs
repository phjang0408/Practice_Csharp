public class Currency
{
    decimal money;
    public decimal Money { get { return money; } }
    public Currency(decimal money)
    {
        this.money = money;
    }
}
public class Won : Currency
{
    public Won(decimal money) : base(money) { }
    public override string ToString()
    {
        return Money + "Won";
    }
}
public class Yen : Currency
{
    public Yen(decimal money) : base(money) { }
    public override string ToString()
    {
        return Money + "Yen";
    }
    // implicit, explicit 키워드
    // 원본타입 클래스 안에서 구현
    // static public implicit operator [변환할 타입 클래스](원본 타입){
    //      return 변환될 타입형태
    // }
    // implicit은 explicit을 포함하지만, explicit은 implicit을 포함하지 않는다.
    static public implicit operator Won(Yen yen)
    {
        return new Won(yen.Money * 13m);
    }

    static void Main(string[] args)
    {
        Yen yen = new Yen(100);
        Won won1 = yen;     // 암시적(implicit) 형변환
        Won won2 = (Won)yen;// implicit은 explicit도 포함한다.
        Console.WriteLine(won1 + ", " + won2);  // ToString 자동 호출
    }
}