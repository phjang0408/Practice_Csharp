namespace MySpace
{
    class MainClass
    {
        static void Main(string[] args)
        {
            // 1. List
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
                list.Add(i);
            foreach (int element in list)
                Console.Write($"{element} ");
            Console.WriteLine();

            list.RemoveAt(2);
            foreach (int element in list)
                Console.Write($"{element} ");
            Console.WriteLine();

            list.Insert(2, 2); // index 2에 2 값을입력
            foreach (int element in list)
                Console.Write($"{element} ");
            Console.WriteLine();

            // 2. Queue
            Queue<int> queue = new Queue<int>(); // int형 데이터를 관리하도록 정의
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            while (queue.Count > 0) // Queue는 Count로 잔여개수확인.
                Console.WriteLine(queue.Dequeue()); // Dequeue로 제거 및 반환

            // 3. Stack
            Stack<int> stack = new Stack<int>(); // int형 데이터를 관리
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            while (stack.Count > 0) // Stack은 Count로 잔여개수 확인
                Console.WriteLine(stack.Pop()); // Pop으로 제거 및 반환
        }
    }
}