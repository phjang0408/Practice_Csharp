using System.Collections;   // 컬렉션을 담는 네임스페이스
namespace mySpace
{
    class myClass
    {
        static void Print(ArrayList tempList)
        {
            foreach(object x in tempList)   // 다양한 객체라 object로
            {
                Console.Write($"{x} ");

            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < 5; i++)
                list.Add(i);    // Add : 뒤에 삽입
            Print(list);

            list.RemoveAt(2);   // 2에 해당하는 index의 값 삭제
            list.Insert(2, 10);  // 2 뒤에 '10'을 삽입
            Print(list);

            // 다양한 객체 가능
            list.Add("abc");
            list.Add("def");
            Print(list);
        }
    }
}