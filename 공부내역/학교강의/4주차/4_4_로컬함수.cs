namespace DrawPaper
{
    class Program
    {
        static string ToLowerString(string input)   // 기본 private
        {
            var arr = input.ToCharArray();      // string -> char[]

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
            }

            char ToLowerChar(int i) // 로컬함수 선언
            {
                if (arr[i] < 65 || arr[i] > 90)
                    return arr[i];
                else
                    return (char)(arr[i] + 32); // 상위 ToLowerString의 지역변수 사용
            }

            return new string(arr); // 오버로딩 string(char[] arr)
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ToLowerString("Hello!"));
        }
    }
}
