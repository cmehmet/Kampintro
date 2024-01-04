namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 25;
            product1.Description = "Amasya Elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 40;
            product2.Description = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("------------Methods--------------");
            //instance
            ChartManager chartManager = new ChartManager();
            chartManager.Add(product1);
            chartManager.Add(product2);
            
        }
    }
}

//Don't Repeat Yourself - DRY - Celan Code - Best Practice
