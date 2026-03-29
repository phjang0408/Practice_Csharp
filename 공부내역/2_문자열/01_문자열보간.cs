// 문자열 보간 기초
// {}사이에, 변수를 배치하여, 해당 텍스트를 변수로 바꾸는 지시
namespace myd
{
    public class sdsf
    {
        static void Main(string[] args)
        {
            // 1. 기본 문자열 보간
            string aFriend = "BILL";
            Console.WriteLine($"Hello {aFriend}");

            string bFriend = "Sage";
            Console.WriteLine($"My friends are {aFriend} and {bFriend}");

            // 2. length
            Console.WriteLine($"The Name {aFriend} has {aFriend.Length} letters");

            // 3. 공백제거 Trim 메서드
            // 일반 Trim과 앞 공백 제거 [TrimStart], 뒷 공백 제거 [TrimEnd]도 있다.
            string greeting = "       Hello World!       ";
            Console.WriteLine($"[{greeting}]");
            string trimmed_Greeting = greeting.Trim();  // 공백제거 Trim 메서드
            Console.WriteLine($"[{trimmed_Greeting}]");

            // 4. 문자열 교체 (replace)
            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            // 5. 대.소문자 변경
            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            // 6. 포함하는지 확인 - Contains
            string Lyrics = "You say goodbye, and I say hello";
            Console.WriteLine(Lyrics.Contains("goodbye"));

            // 7. Join 메서드 - 배열의 요소들을 모아, 하나의 문자열로 결합
            string[] shape = ["Circle", "Square", "Triangle"];
            Console.WriteLine(string.Join(",",shape));
        }
    }

}