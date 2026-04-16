namespace DrawPaper
{
    record RTransaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }
        // record는 Equals가 기본 탑재
    }
    class CTransaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        // class : 참조 비교가 기본, 값 비교를 원하면 Equals를 직접 오버라이딩해야 함
        // object의 Equals를 오버라이딩해서 값 비교로 재정의
        public override bool Equals(object obj)
        {
            CTransaction target = (CTransaction)obj; // object를 CTransaction으로 형변환
            if (this.From == target.From && this.To == target.To && this.Amount == target.Amount)
                return true;
            else
                return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // class : Equals 오버라이딩으로 값 비교 -> true
            CTransaction trA = new CTransaction { From = "Alice", To = "Bob", Amount = 100 };
            CTransaction trB = new CTransaction { From = "Alice", To = "Bob", Amount = 100 };
            Console.WriteLine(trA.Equals(trB));

            // record : 값 비교가 기본 제공 -> true
            RTransaction tr1 = new RTransaction { From = "Alice", To = "Bob", Amount = 100 };
            RTransaction tr2 = new RTransaction { From = "Alice", To = "Bob", Amount = 100 };
            Console.WriteLine(tr1.Equals(tr2));
        }
    }
}
