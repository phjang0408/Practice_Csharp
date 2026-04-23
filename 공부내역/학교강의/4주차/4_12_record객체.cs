namespace DrawPaper
{
    // 불변 데이터를 표현하기 위한 클래스의 특수한 형태
    // init을 쓰는게 의미상 명확함.
    // class : 일반 객체 <--> record : 불변 객체    
    // class : 참조 비교 <--> record : 값 비교
    // class : 변경 가능 <--> record : init으로 제한

    // => class는 두 객체의 내용이 같아도 주소가 다르면 다름
    // => record는 값 비교라서, 내용만 같으면 같음.
    record RTranssaction
    {
        // init : 생성 시점에만 초기화 가능, 이후 변경 불가
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
            RTranssaction tr2 = new RTranssaction { From = "Bob", TO = "Charlie", Amount = 50 };

            // 출력에서 -10은 10칸 생성 후, 왼쪽 정렬
            Console.WriteLine($"{tr1.From,-10} -> {tr1.TO,-10} : {tr1.Amount,-10}");
            Console.WriteLine($"{tr2.From,-10} -> {tr2.TO,-10} : {tr2.Amount,-10}");

            // record의 비교를 위해  : "Equals()", "==" 모두 값비교
            // 특히 Equals는 자동으로 구현됨.
            Console.WriteLine(tr1.Equals(tr2));   // 물론 false긴함.
            RTranssaction tr3 = new RTranssaction
            {
                From = "Alice",
                TO = "Bob",
                Amount = 100
            };
            Console.WriteLine(tr1.Equals(tr3));   // 값이 같은 tr3로 비교해보면 true

        }
    }
}
