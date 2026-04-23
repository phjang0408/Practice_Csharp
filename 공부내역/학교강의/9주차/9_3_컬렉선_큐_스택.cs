using System.Collections;   // 컬렉션을 담는 네임스페이스
namespace mySpace
{
    class myClass
    {

        static void Main(string[] args)
        {
            Queue que = new Queue();
            // Enqueue : 뒤에 추가
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);

            while (que.Count > 0)
                // Dequeue : 앞부터 반환 및 삭제
                Console.WriteLine(que.Dequeue());

            Console.WriteLine(que.Peek());  // 제일 앞에 값, 비어서 오류남

            Stack stack = new Stack();
            stack.Peek();  // 비어서 오류남
            stack.Push(1);  // Push : 뒤에 추가
            stack.Push(2);  
            stack.Push(3);
            stack.Push(4); 
            stack.Push(5); 
            while (stack.Count > 0)
            // Pop : 최상위 데이터 반환 및 삭제
                Console.WriteLine(stack.Pop());
        }
    }
}