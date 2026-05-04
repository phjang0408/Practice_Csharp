namespace mySpace
{
    abstract class Product
    {
        private static int serial = 0;
        public string SerialID
        {
            // 구현이 있는 프로퍼티
            get { return String.Format("{0:D5}", serial++); }
        }
        abstract public DateTime ProductDate
        {
            get;set;
        }
    }
    class MyProduct : Product
    {
        // 추상 메서드는, 반드시 override
        public override DateTime ProductDate { get; set; }

        static void Main(string[] args)
        {
            Product product_1 = new MyProduct()
            { ProductDate = new DateTime(2026, 5, 4) };

            Console.WriteLine("Product: {0}, Product Date: {1}",
                product_1.SerialID,
                product_1.ProductDate);

            Product product_2 = new MyProduct()
            { ProductDate = new DateTime(2026, 5, 8) };
            Console.WriteLine("Product: {0}, Product Date: {1}",
             product_2.SerialID,
             product_2.ProductDate);
        }
    }

}

    