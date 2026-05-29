namespace MySpace
{
    abstract class Product
    {
        private static int serial = 0;
        public string SerialID
        {   // 구현이 있는 프로퍼티 - 일반 프로퍼티
            get{ return String.Format("{0:D5}",serial++);}
        }
        abstract public DateTime ProductDate
        {   // 구현이 없는 추상 프로퍼티 - 규격 없이, get; set; 두 개만 사용하여 선언 가능함.
            get; set;
        }
    }
    class MyProduct : Product
    {
        // 부모 abstract는, 자식이 반드시 override로 구현 - {}로 상세 구현해도 됨.
        public override DateTime ProductDate
        {
            get; set;
        }

        static void Main(string[] args)
        {
            Product product_1 = new MyProduct()
            {
                ProductDate = new DateTime(2018,1,10)
            };

            Console.WriteLine("Product : {0}, Product Date : {1}",
            product_1.SerialID, product_1.ProductDate);

            Product product_2 = new MyProduct()
            {
                ProductDate = new DateTime(2018,2,3)
            };

            Console.WriteLine("Product : {0}, Product Date : {1}",
            product_2.SerialID, product_2.ProductDate);
        }
    }
}