namespace DrawPaper
{
    interface IObjectToString { } // 빈 인터페이스
    // 기능 제공이 아닌, '표식'용 함수, 
    class Computer { }
    // Computer는 인터페이스 안 받음
    class Person : IObjectToString
    {
        string name;
        public Person(string name)
        {
            this.name = name;
        }
        // 추가로 ToString을 재정의한거임
        public override string ToString()
        {
            return "Person: " + this.name;
        }
        // 인터페이스를 가졌는지, 표식 있는지 체크용 함수
        private static void DisplayObject(object obj)
        {
            if (obj is IObjectToString)
            {
                Console.WriteLine(obj.ToString());
            }
        }

        static void Main(string[] args)
        {
            DisplayObject(new Computer());
            DisplayObject(new Person("홍길동"));
        }
    }
}
