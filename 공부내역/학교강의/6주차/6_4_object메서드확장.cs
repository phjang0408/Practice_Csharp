class Book
{
    decimal number;
    string title;
    string contents;
    public Book(decimal number, string title, string contents)
    {
        this.number = number;
        this.title = title;
        this.contents = contents;
    }
    // object 메서드를 확장 : 값 비교에서도, number만 비교해서 같으면 같다고 변경
    public override bool Equals(object obj)
    {
        if (obj == null) return false;

        Book book = obj as Book;
        if (book == null) return false;
        
        return this.number == book.number;
    }
    static void Main(string[] args)
    {
        Book book1 = new Book(1234, "book1", "...");
        Book book2 = new Book(1234, "book1", "...");
        Book book3 = new Book(5678, "book3", "...");
        Console.WriteLine("book1 == book2: " + book1.Equals(book2));
        Console.WriteLine("book1 == book3: " + book1.Equals(book3));
    }
}
