namespace ClassMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.FirstName = "Ahmet";
            customer1.LastName = "Ak";
            customer1.Age = 30;
            customer1.City = "Ankara";
            customer1.Region = "İçAnadolu";
            customer1.PostalCode = "06000";
            customer1.Country = "Türkiye";
            customer1.Phone = "05554443322";

            Customer customer2 = new Customer();
            customer2.FirstName = "Ali";
            customer2.LastName = "Ak";
            customer2.Age = 28;
            customer2.City = "Adana";
            customer2.Region = "Akdeniz";
            customer2.PostalCode = "01000";
            customer2.Country = "Türkiye";
            customer2.Phone = "05553339911";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            Console.WriteLine("-------------------");

            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
            Console.WriteLine("-------------------");

            customerManager.Update(customer1);
            customerManager.Update(customer2);
            Console.WriteLine("-------------------");

            customerManager.List(customer1);
            customerManager.List(customer2);
            
        }
    }
}
