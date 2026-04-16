using System.Globalization;

namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. ToLower, ToUpper
            Console.WriteLine("ToLower() : {0}", "ABC".ToLower());
            Console.WriteLine("ToUpper() : {0}", "abc".ToUpper());

            // 2. Insert
            // Length를 벗어나는 Index는 오류!!
            // 들어갈 index, 들어갈 문자열
            Console.WriteLine("Insert() : {0}", "Happy".Insert(5, "Birthday"));

            // 3. Remove
            // 인자 하나 : 삭제 시작 index -> 문자열 끝까지 삭제
            // 인자 둘   : (삭제 시작 index, 삭제할 개수) -> 뒤에 남으면 붙여줌
            Console.WriteLine("Remove() : {0}", "dolphin".Remove(5));
            Console.WriteLine("Remove() : {0}", "ChainSaw Man".Remove(5, 3));

            // 4. Trim, TrimStart, TrimEnd
            Console.WriteLine("Trim() : {0}", "     SPACE      ".Trim());
            Console.WriteLine("TrimStart() : {0}", "     SPACE      ".TrimStart());
            Console.WriteLine("TrimEnd() : {0}", "     SPACE      ".TrimEnd());
        }
    }
}