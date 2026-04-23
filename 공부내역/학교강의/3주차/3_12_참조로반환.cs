
namespace DrawPaper
{
    class Product
    {
        private int price = 100;

        public ref int GetPrice()
        {
            return ref price;
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
            ref int ref_price = ref carrot.GetPrice();
            // ref로 선언해도, 값으로 받을 수 있음
            int normal_price = carrot.GetPrice();   

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