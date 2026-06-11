namespace MySpace
{
    class FilterableException : Exception
    {
        public int ErrorNo { get; set; }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number Between 0~10");
            string input = Console.ReadLine();
            try
            {
                int num = Int32.Parse(input);
                if (num < 0 || num > 10)
                    throw new FilterableException() { ErrorNo = num };
                else
                    Console.WriteLine($"Output : {num}");
            }
            // when 키워드로, 추가조건을 걸 수 있음.
            catch (FilterableException e) when (e.ErrorNo < 0) // when 키워드로 ErrorNo이 0보다 작은경우만
            {
                Console.WriteLine("Negative input is not allowed.");
            }
            catch (FilterableException e) when (e.ErrorNo > 10)
            {
                Console.WriteLine("Too big number is not allowed.");
            }
        }
    }
}