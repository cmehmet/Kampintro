namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { ProductId = 1, CategoryId = 1, ProductName = "MSI PC", QuantityPerUnit = "32 GB Ram", UnitPrice = 12000, UnitsInStock = 7  },
                new Product { ProductId = 2, CategoryId = 1, ProductName = "Asus PC", QuantityPerUnit = "16 GB Ram", UnitPrice = 10000, UnitsInStock = 12  },
                new Product { ProductId = 3, CategoryId = 1, ProductName = "Hp PC", QuantityPerUnit = "8 GB Ram", UnitPrice = 8500, UnitsInStock = 10  },
                new Product { ProductId = 4, CategoryId = 2, ProductName = "Samsung Telefon", QuantityPerUnit = "4 GB Ram", UnitPrice = 7000, UnitsInStock = 15  },
                new Product { ProductId = 5, CategoryId = 2, ProductName = "Apple Telefon", QuantityPerUnit = "4 GB Ram", UnitPrice = 9000, UnitsInStock = 2  }
            };

            List<Category> categories = new List<Category>
            {
                new Category { CategoryId = 1, CategoryName = "Bilgisayar"},
                new Category { CategoryId = 2, CategoryName = "Telefon"}
            };

            foreach (var category in categories)
            {
                Console.WriteLine("Kategori Adı : " + category.CategoryName);
            }

            Console.WriteLine("Standart-------------------");

            foreach (Product product in products)
            {
                if (product.UnitPrice > 9000 && product.UnitsInStock > 8)
                {
                    Console.WriteLine("Ürün Adı : " + product.ProductName);
                }
                
            }

            Console.WriteLine("Standart_With_Method-------------------");

            foreach (Product product in GetFilteredProducts(products))
            {
                Console.WriteLine("Ürün Adı : " + product.ProductName);
            }

            Console.WriteLine("Linq---------------------");

            List<Product> products1 = products.Where(p => p.UnitPrice > 9000 && p.UnitsInStock > 8).ToList();
            foreach (Product product in products1)
            {
                Console.WriteLine("Ürün Adı : " + product.ProductName);
            }

            Console.WriteLine("Linq_With_Method---------------------");

            foreach (Product product in GetFilteredProductsByLinq(products))
            {
                Console.WriteLine("Ürün Adı : " + product.ProductName);
            }


        }

        static List<Product> GetFilteredProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (Product product in products)
            {
                if (product.UnitPrice > 9000 && product.UnitsInStock > 8)
                {
                    filteredProducts.Add(product);
                }

            }
            return filteredProducts;
        }

        static List<Product> GetFilteredProductsByLinq (List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 9000 && p.UnitsInStock >8).ToList(); 
             
        }
    }
}
