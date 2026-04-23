class Configuration
{
    private readonly int min;
    private readonly int max;

    public int How { get; init; }
    public Configuration(int v1, int v2)
    {
        min = v1;
        max = v2;
    }
    public void ChangeMax(int newMax)
    {
        // max = newMax;    // 컴파일에러
    }

    static void Main(string[] args)
    {
        // readonly는 선언 또는 생성자에서 초기화
        Configuration c = new Configuration(5, 7)  
        { How = 39 };                              
        // init은 객체 초기화(object initializer)에서 초기화
    }
}
