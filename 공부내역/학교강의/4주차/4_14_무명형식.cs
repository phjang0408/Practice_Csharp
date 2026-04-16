namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            // 무명 형식 : 클래스 선언 없이 즉석에서 객체 생성
            // var로만 받을 수 있음 (타입 이름이 없으므로)
            // 프로퍼티는 자동으로 읽기 전용(init)으로 생성됨
            var a = new { Name = "홍길동", Age = 123 };
            Console.WriteLine($"Name: {a.Name}, Age: {a.Age}");

            // 무명 형식 안에 배열도 포함 가능
            var b = new { Subject = "수학", Scores = new int[] { 90, 80, 70, 60 } };
            Console.Write($"Subject: {b.Subject}, Scores: ");

            // Scores 배열 순회, score의 타입도 var로 추론 (int)
            foreach (var score in b.Scores)
                Console.Write($"{score} ");
            Console.WriteLine();
        }
    }
}