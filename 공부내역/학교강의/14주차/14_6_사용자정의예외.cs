namespace MySpace
{
    // 사용자 정의 예외 클래스
    class InvalidArgumentException : Exception // 반드시 Exception 클래스를 상속해야 함.
    {
        public InvalidArgumentException() { }
        public object Argument { get; set; } // 문제가 된 값을 저장
        public string Range { get; set; }   // 허용 범위 저장
    }
    class MainClass
    {
        static uint MergeARGB(uint alpha, uint red, uint green, uint blue)
        {
            uint[] args = new uint[] { alpha, red, green, blue };
            foreach(uint arg in args)
            {
                if (arg > 255)
                    throw new InvalidArgumentException()
                    {
                        Argument = arg,
                        Range = "0~255"   };
            }
            return (alpha << 24 & 0xFF000000) |
            (red << 16 & 0xFF000000) |
            (green << 8 & 0xFF000000) |
            (blue & 0xFF000000);
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("0x{0:X}", MergeARGB(255, 111, 111, 111));
                Console.WriteLine("0x{0:X}", MergeARGB(1, 65, 192, 128));
                // 255를 넘어가는 예외로 던져보기
                Console.WriteLine("0x{0:X}", MergeARGB(0, 255, 255, 300));
            }
            catch (InvalidArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine($"Argument:{e.Argument}, Range:{e.Range}");
            }
        }
    }
}