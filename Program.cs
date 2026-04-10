namespace DrawPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bb = {3,4,5,7,2,1};
            foreach(int x in bb){
                Console.Write(x);
            }
            Array.Sort(bb);
            Console.WriteLine(String.Join(", ",bb));
            foreach(int x in bb){
                Console.Write(x);
            }
            Console.WriteLine();
        }
    }
}