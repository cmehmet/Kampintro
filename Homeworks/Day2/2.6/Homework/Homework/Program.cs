using System.Diagnostics.Metrics;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Asus Bilgisayar";
            product1.Price = 10000;
            product1.Description = "Rog Strix";
            product1.Amount = 100;

            Product product2 = new Product();
            product2.Name = "Arzum Ütü";
            product2.Price = 2500;
            product2.Description = "3000 W";
            product2.Amount = 54;

            Product product3 = new Product();
            product3.Name = "LG Monitör";
            product3.Price = 8000;
            product3.Description = "144 Hz";
            product3.Amount = 9;

            Product product4 = new Product();
            product4.Name = "Steel Series Mouse";
            product4.Price = 1200;
            product4.Description = "16000 Dpi";
            product4.Amount = 300;

            Product[] products = new Product[] { product1, product2, product3, product4 };

            Console.WriteLine("-----For Döngüsü-----");
            for(int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Ürün Adı : " + products[i].Name + " - "  + products[i].Price + " TL");
            }

            Console.WriteLine("-----Foreach Döngüsü-----");
            foreach ( Product product in products)
            {
                Console.WriteLine("Ürün Adı : " + product.Name + " - " + product.Price + " TL"); ;
            }

            Console.WriteLine("-----While Döngüsü-----");
            int counter = 0;
            while (counter < products.Length)
            {
                Console.WriteLine("Ürün Adı : " + products[counter].Name + " - " + products[counter].Price + " TL");
                counter++;
            }


        }
    }
}
