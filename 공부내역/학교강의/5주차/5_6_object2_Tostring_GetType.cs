class Item
{
    public string Name;
    public int Price;

    // 객체를 문자열로 표현 (기본은 클래스 이름만 출력)
    public override string ToString()
    {
        return $"[{Name}] 가격: {Price}원";
    }
}

class Program
{
    static void Main()
    {
        Item sword = new Item { Name = "검", Price = 1500 };

        Console.WriteLine(sword.GetType());   // MySpace.Item  (런타임 타입 반환)
        Console.WriteLine(sword.ToString());  // [검] 가격: 1500원

        // GetType 활용 예시
        object obj = sword;
        if (obj.GetType() == typeof(Item))
            Console.WriteLine("Item 타입 맞음");
    }
}