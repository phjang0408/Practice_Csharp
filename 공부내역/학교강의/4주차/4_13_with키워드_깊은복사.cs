namespace DrawPaper
{
    record RTranssaction
    {
        public string From { get; init; }
        public string TO { get; init; }
        public int Amount { get; init; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RTranssaction tr1 = new RTranssaction
            {
                From = "Alice",
                TO = "Bob",
                Amount = 100
            };
            // class는 깊은 복사를 할 때, 멤버 하나하나 복사해야 함.
            // record는 with문으로 간단히 복사 가능
            // 또한, 일부 필드 값 변경도 가능
            // (init인데도 with문으로는 변경 가능)
            RTranssaction tr2 = tr1 with { TO = "Charlie" };
            RTranssaction tr3 = tr1 with { From = "Charlie", Amount = 50 };

            Console.WriteLine($"{tr1.From,-10} -> {tr1.TO,-10} : {tr1.Amount,-10}");
            Console.WriteLine($"{tr2.From,-10} -> {tr2.TO,-10} : {tr2.Amount,-10}");
            Console.WriteLine($"{tr3.From,-10} -> {tr3.TO,-10} : {tr3.Amount,-10}");
        }
    }
}
