namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bireysel Müşteri
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.FirstName = "Mehmet";
            customer1.LastName = "Atay";
            customer1.IdendityNumber = "111111111111";
            customer1.CustomerNumber = "222222222222";

            // Tüzel Müşteri
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 1;
            customer2.CustomerNumber = "333333333333";
            customer2.CompanyName = "Trendyol";
            customer2.TaxNumber = "1234567890";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}
