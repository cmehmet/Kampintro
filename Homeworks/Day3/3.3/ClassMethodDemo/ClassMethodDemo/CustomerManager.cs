using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class CustomerManager
    {   
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri veritabanına eklendi. " + customer.FirstName + " " + customer.LastName);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Müşteri güncellendi. " + customer.FirstName + " " + customer.LastName);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri silindi. " + customer.FirstName + " " + customer.LastName);
        }

        public void List(Customer customer) 
        {
            Console.WriteLine("Müşteri listelendi. " + customer.FirstName + " " + customer.LastName);
        }
    }
}
