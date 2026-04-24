
namespace DrawPaper
{
    class Product
    {
        private int price = 100;

        public ref int GetPrice()   // 1. ref키워드로 선언
        {
            return ref price;  // 2. 반환하는 변수 앞에도 ref 선언
        }
        public void PrintPrice()
        {
            Console.WriteLine($"Price : {price}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product carrot = new Product();
            ref int ref_price = ref carrot.GetPrice();  // 3. 결과를 ref로 받을 수 있음.
            int normal_price = carrot.GetPrice();   // 4.[ref로 선언되어도, 값으로 반환받을 수 있음.]

            carrot.PrintPrice();
            Console.WriteLine($"Ref Price : {ref_price}");
            Console.WriteLine($"Normal Price : {normal_price}");

            Console.WriteLine("\n[CHANGE PRICE]");
            // ref값은 변경
            ref_price = 200;
            
            carrot.PrintPrice();
            Console.WriteLine($"Ref Price : {ref_price}");
            Console.WriteLine($"Normal Price : {normal_price}");
        }
    }
}