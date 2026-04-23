namespace DrawPaper
{
    interface IDrawingObject { void Draw();   }
    class Line : IDrawingObject
    {
        // virtual, override : 사용하면 에러!!, 필요 없음
        // C# 컴파일러가 가상메서드로 간주
        public void Draw() { Console.WriteLine("Line"); }
    }
    class Rectangle : IDrawingObject 
    { 
        public void Draw() { Console.WriteLine("Rectangle"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IDrawingObject[] instances =
                new IDrawingObject[] { new Line(), new Rectangle() };

            foreach(IDrawingObject item in instances)
            {
                item.Draw();
            }
        }
    }
}
